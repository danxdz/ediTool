Option Explicit On
Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions

Module Init
    ' Returns the index of the specified language
    Private Function GetLanguageIndex(language As String, file As String) As Integer
        ' Read the first line of the CSV file to get the list of available languages
        Dim firstLine As String = file.Split(Environment.NewLine)(0)

        Dim languages As String() = firstLine.Split(";").ToArray()

        ' Check if the specified language is in the list of languages
        Dim languageIndex As Integer = Array.IndexOf(languages, language)
        If languageIndex < 0 Then
            ' Language not found in the list, use the default language
            languageIndex = 0
        End If

        Return languageIndex
    End Function

    ' Updates the text of UI controls based on the specified language
    Public Sub FillUI(language As String)
        Dim languageIndex As Integer = GetLanguageIndex(language, My.Resources.textUI)

        ' Iterate over each line in the CSV file and update the text of the appropriate control
        For Each line As String In My.Resources.textUI.Split(Environment.NewLine).Skip(1)
            Dim words() As String = line.Split(";")
            Dim key As String = words(1)
            Dim control As Control = Main.Controls.Find(key, True).FirstOrDefault()
            If control IsNot Nothing Then
                control.Text = words(languageIndex)
            End If
        Next
    End Sub

    Public Sub FillMainMenu(language As String)

        Main.MenuStrip1.Items.Clear()
        Dim splitLine() As String = My.Resources.textMainMenu.Split(New String() {Environment.NewLine}, StringSplitOptions.None).Skip(1).ToArray

        Dim currentMenu As ToolStripMenuItem = Nothing
        Dim currentSubMenu As ToolStripMenuItem = Nothing

        Dim languageIndex As Integer = GetLanguageIndex(language, My.Resources.textMainMenu)

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
            If data(0) = "" Then
                Exit For
            End If
            Dim index As Integer = Integer.Parse(data(0))
            Dim name As String = data(1)
            Dim parent As Integer = Integer.Parse(data(2))
            Dim lang As String = data(languageIndex)

            ' Check for parameters in curly braces {}
            Dim paramName As String = ""
            Dim regex As New Regex("\{(.*?)\}")
            Dim matches As MatchCollection = regex.Matches(lang)

            For Each match As Match In matches
                ' Get the parameter name without the curly braces
                paramName = match.Value.Replace("{", "").Replace("}", "")

                ' Get the value of the parameter from the My.Settings
                Dim paramValue As String = My.Settings(paramName)

                ' Replace the parameter with its value in the menu text
                lang = lang.Replace(match.Value, paramValue)
            Next
            If parent = index And lang <> "" Then
                currentMenu = New ToolStripMenuItem(lang)
                currentMenu.Name = name

                dictMenus.Add(index, currentMenu)
                Main.MenuStrip1.Items.Add(currentMenu)
            ElseIf parent <> index And lang <> "" Then
                currentSubMenu = New ToolStripMenuItem(lang)
                currentSubMenu.Name = name
                If isCheck And lang <> "" Then
                    currentSubMenu.CheckOnClick = False
                    Dim parentName As String = dictMenus(parent).Name

                    If paramName <> "" Then
                        currentSubMenu.Checked = True
                    Else
                        Dim v = My.Settings.sourceLibrary

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
                ElseIf isFunction And lang <> "" Then
                    currentSubMenu.Name = name
                    AddHandler currentSubMenu.Click, AddressOf MenuItemFunction
                End If
                dictMenus(parent).DropDownItems.Add(currentSubMenu)
                dictMenus.Add(index, currentSubMenu)
            End If
        Next
    End Sub

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
            Return Main.L1textBox.Text
        Else
            Return value
        End If
        If param = "CTS_AD" And value = 0 Then
            Return Main.D1textBox.Text
        Else
            Return value
        End If
    End Function
    Function Pick_param_old(param As String)
        Select Case param
            Case "D" : Return Main.D1textBox.Text
            Case "L" : Return Main.L1textBox.Text
            Case "OL" : Return Main.L3textBox.Text
            Case "SD" : Return Main.D3textBox.Text
            Case "CTS_AL" : Return Check_zero(param, Main.L2textBox.Text)
            Case "CTS_EL" : Return Check_zero(param, Main.L2textBox.Text) ' TODO
            Case "NoTT" : Return Main.NoTT.Text
            Case "A" : Return Main.A_TextBox.Text
            Case "r" : Return Main.Chf_textbox.Text
            Case Else
                MsgBox("param < " + param + " > not found, check outil name mask config")
        End Select
    End Function
    Function Pick_param(param As String, newTool As Tool)
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
    Public Sub Set_Name_auto(newTool As Tool)

        If Main.forceName.Checked = False Then
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

            Dim newtool As Tool = FileImports.Fill_newTool(line(1), line(3), line(2), line(5), line(6), line(4), line(8), "FR2T", "0", "0", "0", "0", "0", "0", "0", "FRAISA", line(0), "0", "0", "0")
            Main.fullToolsList.Tool.add(newtool)

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

    Private Sub MenuItemFunction(sender As Object, e As EventArgs)
        Console.WriteLine(sender)
        Console.WriteLine(e)

        Dim tmp As String = sender.Name
        If (tmp.Length = 2) Then
            ChangeLanguage(tmp)
            Exit Sub
        End If

        Select Case sender.Name
            Case "exit"
                Main.Close()
            Case "xml"
                OpenXmlFile()
            Case "FRAISA"
                ImportFraisa()
            Case "ORDERTOOLS"
                ImportOrderTools()
            Case "text"
                ImportPaste.Show()
            Case "topsolid"
                OpenV6File()
            Case "language"
                ChangeLanguage(sender.ToString)
            Case "OtherFunction"
                ' Call other function here
            Case Else
                ' Handle unknown function here
        End Select
    End Sub

    Private Sub ImportOrderTools()
        Throw New NotImplementedException()
    End Sub

    Private Sub ChangeLanguage(toString As String)

        My.Settings.PrefLang = toString
        My.Settings.Save()

        FillMainMenu(toString)
        FillUI(toString)
    End Sub

    Private Sub ImportFraisa()
        ImportFSA.Show()
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

End Module
