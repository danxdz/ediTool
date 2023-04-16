Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Xml
Imports EdiTool.My

Module Init

    Dim DataTable_buffer As DataTable
    Public Sub Set_filter()
        'Dim dv As New DataView(DataTable_buffer)
        'Dim str_tmp As String
        'If Main.Diam_filter_TextBox.Text = "" Then
        '    str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%'"
        'ElseIf Main.Ref_filter_TextBox.Text = "" Then
        '    str_tmp = "D LIKE '%" + Main.Diam_filter_TextBox.Text + "%'"
        'Else
        '    str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%' AND D like '%" + Main.Diam_filter_TextBox.Text + "%'"
        'End If
        'DataTable_buffer.DefaultView.RowFilter = str_tmp
    End Sub
    Function Check_zero(param As String, value As String)
        ''Dim tmp_string As String = value
        ''tmp_string = Replace(tmp_string, ".", ",") ' replace , -> .
        ''Dim result As Double = tmp_string
        If param = "CTS_AL" And value = 0 Then
            Return Main.L_textbox.Text
        Else
            Return value
        End If
        If param = "CTS_AD" And value = 0 Then
            Return Main.D_textbox.Text
        Else
            Return value
        End If
    End Function
    Function Pick_param_old(param As String)
        Select Case param
            Case "D" : Return Main.D_textbox.Text
            Case "L" : Return Main.L_textbox.Text
            Case "OL" : Return Main.OL_textbox.Text
            Case "SD" : Return Main.SD_textbox.Text
            Case "CTS_AL" : Return Check_zero(param, Main.CTS_AL_textbox.Text)
            Case "CTS_EL" : Return Check_zero(param, Main.CTS_AL_textbox.Text) ' TODO
            Case "CTS_AD" : Return Check_zero(param, Main.CTS_AD_textbox.Text)
            Case "NoTT" : Return Main.NoTT.Text
            Case "A" : Return Main.A_TextBox.Text
            Case "r" : Return Main.Chf_textbox.Text
            Case Else
                MsgBox("param < " + param + " > not found, check outil name mask config")
        End Select
    End Function
    Function Pick_param(param As String, newTool As NewTool)
        Select Case param
            Case "D" : Return newTool.D1
            Case "L" : Return newTool.L1
            Case "OL" : Return newTool.L3
            Case "SD" : Return newTool.D3
            Case "CTS_AL" : Return Check_zero(param, newTool.L2)
            Case "CTS_EL" : Return Check_zero(param, newTool.L2) ' TODO
            Case "CTS_AD" : Return Check_zero(param, newTool.D2)
            Case "NoTT" : Return newTool.NoTT
            Case "A" : Return newTool.Chanfrein
            Case "r" : Return newTool.RayonBout
            Case Else
                MsgBox("param < " + param + " > not found, check outil name mask config")
        End Select
    End Function
    Public Sub Set_Name_auto(newTool As NewTool)

        If Main.ForceName_checkBox.Checked = False Then
            Try
                Dim Namemask As String = ToolName_config.Namemask_textbox.Text

                Dim temp As String = Namemask
                Dim formated As String = ""
                Dim tempL, res, code_temp As String

                For i As Integer = 0 To Namemask.Length
                    tempL = Left(temp, 1)
                    If tempL = "[" Then
                        If formated = "" Then
                            formated = Left(Namemask, i)
                        End If
                        code_temp = temp
                        For j As Integer = 0 To temp.Length

                            If Left(code_temp, 1) = "]" Then
                                Dim parameter_temp As String = Left(temp, j)
                                res = Right(parameter_temp, parameter_temp.Length - 1)
                                formated += Pick_param(res, newTool).ToString
                                j = temp.Length
                            End If
                            code_temp = Right(code_temp, code_temp.Length - 1)

                        Next
                        temp = Right(code_temp, code_temp.Length)
                    Else
                        formated += tempL
                        If temp.Length > 0 Then
                            temp = Right(temp, temp.Length - 1)
                        Else
                            i = Namemask.Length

                        End If
                    End If
                Next
                'If L2.Text = "" Or L2.Text = "0" Then
                ''Main.Name_textbox.Text = "FR Ø" + Main.D_textbox.Text + " " + Main.NoTT.Text + "z" ' nome =  FR Ø + diamètre de coupe + numero d dents
                Main.Name_textbox.Text = formated
                ''If Main.L_textbox.Text <> "" And Main.L_textbox.Text <> "0" Then
                ''Main.Name_textbox.Text += " Lc" + Main.L_textbox.Text ' nome += Longueur de coupe
                ''End If
                ''If Main.CTS_AL_textbox.Text <> "" And Main.CTS_AL_textbox.Text <> "0" Then
                ''Main.Name_textbox.Text += " Lu" + Main.CTS_AL_textbox.Text ' nome += Longueur util
                ''
                'ToolPreview()
            Catch ex As Exception
                MsgBox("Name Mask Error - " + ex.ToString)
            End Try
        End If
    End Sub

    Public Function SetDataGridColumnsTitle(columns() As String, dt As DataTable)
        For Each col As String In columns
            dt.Columns.Add(col, GetType(String))
        Next
        'dt.Columns.Add("index", GetType(String))            ' --------> option to add index to DataGridView1
        Return dt
    End Function

    Private Sub ToolTypeButton_Click(sender As Object, e As EventArgs)
        Console.Write(sender)
        Console.Write(e.ToString)
    End Sub

    Public Sub Get_prefs(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        Dim pref_lang As String = Right(splitLine(0), 2)
    End Sub
    Public Sub FillUI(language As String)
        Dim labels() As Label = {
        Main.dg, Main.menu_2, Main.menu_3, Main.menu_4,
        Main.menu_D1, Main.menu_D2, Main.menu_D3, Main.menu_L1,
        Main.menu_L2, Main.menu_L3}

        Try
            Dim lines() As String = My.Resources.textUI.Split(Environment.NewLine)
            Dim languageIndex As Integer = Array.IndexOf(lines(0).Split(";"), language)

            If languageIndex = -1 Then
                MessageBox.Show("Language not found in UI_text.csv")
            Else
                For i As Integer = 1 To labels.Length
                    Dim splitLine2() As String = lines(i).Split(";")
                    labels(i - 1).Text = splitLine2(languageIndex)
                Next
                Main.ForceName_checkBox.Text = lines(labels.Length + 1).Split(";")(languageIndex)
                Main.AutoOpen_checkBox.Text = lines(labels.Length + 2).Split(";")(languageIndex)
                Main.ValidateBt.Text = lines(labels.Length + 3).Split(";")(languageIndex)
                Main.DefineName_Bt.Text = lines(labels.Length + 4).Split(";")(languageIndex)
                Main.toolRef_checkBox.Text = lines(labels.Length + 5).Split(";")(languageIndex)
                Main.toolDiam_checkBox.Text = lines(5).Split(";")(languageIndex)
                Main.AutoCheckIn_checkBox.Text = lines(17).Split(";")(languageIndex)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading UI_text.csv: " + ex.Message)
        End Try
    End Sub

    Function AddFiltersCombobox(tmp As Decimal, filter As List(Of Decimal))
        If filter.Count > 0 Then
            If filter.Contains(tmp) = False Then
                filter.Add(tmp)
            End If
        Else
            filter.Add(0)
            filter.Add(tmp)
        End If
        Return filter
    End Function

    Function AddFiltersStringCombobox(str As String, filter As List(Of String))
        If str <> "" Then
            If filter.Count > 0 Then
                If filter.Contains(str) = False Then
                    filter.Add(str)
                End If
            Else
                filter.Add("")
                filter.Add(str)
            End If
        End If
        Return filter
    End Function

    Public Sub GetDefaultTools(data As String, filter As String)
        Dim full_file() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim single_line As String
        Dim line() As String
        '                           0      1    2       3       4     5     6       7     8     9
        Dim objList() As String = {"ref", "D", "SD", "CTS_AD", "OL", "L", "CTS_AL", "a", "z", "chf"}

        DataTable_buffer = New DataTable
        DataTable_buffer = SetDataGridColumnsTitle(objList, DataTable_buffer)

        Dim filterD1 As New List(Of Decimal)
        Dim filterL1 As New List(Of Decimal)

        For i As Integer = 0 To 4000 'full_file.Length - 1
            single_line = full_file(i)
            line = Split(single_line, ";")

            DataTable_buffer.Rows.Add(line)
            Dim tmp_line() As String = line.ToArray

            Dim newtool As NewTool = FileImports.Fill_newTool(line(1), line(3), line(2), line(5), line(6), line(4), line(8), "FR2T", "0", "0", "0", "0", "0", "0", "0", "FRAISA", line(0), "0", "0", "0")
            Main.toolsList.Tool.add(newtool)

            filterD1 = AddFiltersCombobox(line(1), filterD1)
            filterL1 = AddFiltersCombobox(line(5), filterL1)

        Next
        PopulateFilters(filterD1, Main.filterD1_Combobox)
        PopulateFilters(filterL1, Main.filterL1_ComboBox)

        'if we want to filter/order data
        'DataTable_buffer.DefaultView.Sort = "d ASC"
        'Main.NewToolDataGridView.DataSource = DataTable_buffer.DefaultView.ToTable
        'Main.NewToolDataGridView.DataSource = DataTable_buffer
    End Sub
    Public Sub PopulateFilters(ByVal filterList As List(Of Decimal), ByVal comboBox As ComboBox)
        filterList = filterList.OrderBy(Function(x) x).ToList()
        With comboBox
            .DataSource = filterList
        End With
    End Sub

    Public Sub FillMainMenu(language As String)

        Main.MenuStrip1.Items.Clear()
        Dim splitLine() As String = My.Resources.textMainMenu.Split(New String() {Environment.NewLine}, StringSplitOptions.None).Skip(1).ToArray

        Dim currentMenu As ToolStripMenuItem = Nothing
        Dim currentSubMenu As ToolStripMenuItem = Nothing

        Dim langIndex As Integer

        Select Case language 'TODO read avaliable languages from txt file
            Case "en" : langIndex = 3
            Case "fr" : langIndex = 4
            Case "pt" : langIndex = 5
        End Select

        Dim dictMenus As New Dictionary(Of Integer, ToolStripMenuItem)

        Dim CheckableItemsList As New List(Of String)

        For Each line As String In splitLine
            Dim isCheck As Boolean = False
            Dim isFunction As Boolean = False

            If line.EndsWith("#") Then
                line = line.TrimEnd("#"c)
                isCheck = True
            End If
            If line.EndsWith("@") Then
                line = line.TrimEnd("@"c)
                isFunction = True
            End If

            Dim data() As String = line.Split(";")
            Dim index As Integer = Integer.Parse(data(0))
            Dim name As String = data(1)
            Dim parent As Integer = Integer.Parse(data(2))
            Dim text As String = data(langIndex)

            ' Check for parameters in curly braces {}
            Dim paramName As String = ""
            Dim regex As New Regex("\{(.*?)\}")
            Dim matches As MatchCollection = regex.Matches(text)

            For Each match As Match In matches
                ' Get the parameter name without the curly braces
                paramName = match.Value.Replace("{", "").Replace("}", "")

                ' Get the value of the parameter from the My.Settings
                Dim paramValue As String = My.Settings(paramName)

                ' Replace the parameter with its value in the menu text
                text = text.Replace(match.Value, paramValue)
            Next
            If parent = index And text <> "" Then
                currentMenu = New ToolStripMenuItem(text)
                currentMenu.Name = name

                dictMenus.Add(index, currentMenu)
                Main.MenuStrip1.Items.Add(currentMenu)
            ElseIf parent <> index And text <> "" Then
                currentSubMenu = New ToolStripMenuItem(text)
                currentSubMenu.Name = name
                If isCheck And text <> "" Then
                    currentSubMenu.CheckOnClick = False
                    Dim parentName As String = dictMenus(parent).Name

                    If paramName <> "" Then
                        currentSubMenu.Checked = True
                    Else
                        Dim savedDefaultLib = My.Settings(parentName)
                        If savedDefaultLib = "" Then
                            savedDefaultLib = "Default"
                            My.Settings(parentName) = savedDefaultLib
                            My.Settings.Save()
                        End If
                        If currentSubMenu.Name = savedDefaultLib Then
                            currentSubMenu.Checked = True
                        End If
                    End If
                    AddHandler currentSubMenu.Click, Sub(sender, e) MenuItemCheckedItem(parentName, sender, e)
                ElseIf isFunction And text <> "" Then
                    currentSubMenu.Name = name
                    AddHandler currentSubMenu.Click, AddressOf MenuItemFunction
                End If
                dictMenus(parent).DropDownItems.Add(currentSubMenu)
                dictMenus.Add(index, currentSubMenu)
            End If
        Next
    End Sub

    Private Sub MenuItemFunction(sender As Object, e As EventArgs)
        Console.WriteLine(sender)
        Console.WriteLine(e)
        Select Case sender.Name
            Case "exit"
                Main.Close()
            Case "xml"
                OpenXmlFile()
            Case "FRAISA"
                ImportFraisa()
                ' Call other function here
            Case "OtherFunction"
                ' Call other function here
            Case Else
                ' Handle unknown function here
        End Select
    End Sub

    Private Sub ImportFraisa()
        ImportTool.Show()

        'AddFraisaTool("15520501")
    End Sub

    Private Sub MenuItemCheckedItem(name As String, sender As Object, e As EventArgs)
        Dim clickedItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Console.WriteLine(clickedItem.Text, " - ", clickedItem.Name)
        ' Uncheck all other items in the same sub-menu
        If TypeOf clickedItem.OwnerItem Is ToolStripMenuItem Then
            For Each item As ToolStripMenuItem In CType(clickedItem.OwnerItem, ToolStripMenuItem).DropDownItems
                If item IsNot clickedItem AndAlso item.Checked Then
                    item.Checked = False
                End If
            Next
        End If
        ' Check the clicked item
        clickedItem.Checked = True
        My.Settings(name) = clickedItem.Name
        My.Settings.Save()
    End Sub

    Public Sub Preload()
        ' Show splash screen
        Dim splashForm As New Preload()
        splashForm.output.Visible = True
        ' Add event handler for click on splash screen
        AddHandler splashForm.Click, Sub(sender, e)
                                         ' Close splash screen and show main form
                                         splashForm.Close()
                                         Main.Show()
                                     End Sub
        ' Show splash screen
        splashForm.ShowDialog()
        splashForm.Close()
    End Sub
End Module
