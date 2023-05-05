Option Explicit On
Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions
Imports System.Windows.Media.TextFormatting

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
    Function Pick_param_old(param As String) ' TODO
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
            Case "A" : Return newTool.CorChamfer
            Case "r" : Return newTool.CorRadius
            Case Else
                MsgBox("param < " + param + " > not found, check outil name mask config")
        End Select
    End Function
    Public Function Set_Name_auto(newTool As Tool) As String

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
                Return formated
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
    End Function

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
            Main.localtools.Tool.add(newtool)

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
        Dim tool As New Tool

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
            Case "string"
                PasteString()
            Case "stringList"
                PasteStringList()
            Case "topsolid"
                OpenV6File()
            Case "language"
                ChangeLanguage(sender.ToString)
            Case "OtherFunction"
                ' Call other function here
            Case Else
                Dim len As Integer = sender.Name.ToString.Length()

                If sender.Name.ToString.Substring(1, len - 1).ToUpper() = "DRILL" Then
                    Dim checkMat As String = sender.Name.ToString.Substring(0, 1)

                    tool.SetType(checkMat)
                Else
                    tool.SetType(sender.Name)

                End If

                ' Handle unknown function here
        End Select
    End Sub

    Private Sub PasteStringList()
        Dim userInput As String
        Dim inputForm As New Form()
        inputForm.Text = "Input"
        inputForm.FormBorderStyle = FormBorderStyle.FixedDialog
        inputForm.MaximizeBox = False
        inputForm.MinimizeBox = False
        ' Set width to two-thirds of screen width
        inputForm.Width = CInt(Screen.PrimaryScreen.Bounds.Width * 2 / 3)
        inputForm.StartPosition = FormStartPosition.CenterScreen
        Dim inputBox As New TextBox()
        inputBox.Multiline = True
        inputBox.Dock = DockStyle.Fill
        Dim okButton As New Button()
        okButton.Text = "OK"
        okButton.DialogResult = DialogResult.OK
        okButton.Dock = DockStyle.Bottom
        Dim cancelButton As New Button()
        cancelButton.Text = "Cancel"
        cancelButton.DialogResult = DialogResult.Cancel
        cancelButton.Dock = DockStyle.Bottom
        inputForm.Controls.Add(inputBox)
        inputForm.Controls.Add(okButton)
        inputForm.Controls.Add(cancelButton)
        Dim result As DialogResult = inputForm.ShowDialog()
        If result = DialogResult.OK Then
            userInput = inputBox.Text
            For Each line As String In userInput.Split(vbCrLf)
                GetDataFromStringLine(line)
            Next
        End If

    End Sub


    Function ExtractNumbers(line As String) As List(Of Double)

        Dim numbers As New List(Of Double)
        Dim currentNumber As String = ""
        For Each c As Char In line
            If Char.IsDigit(c) OrElse c = "."c Then
                currentNumber &= c
            ElseIf currentNumber.Length > 0 Then
                numbers.Add(Double.Parse(currentNumber))
                currentNumber = ""
            End If
        Next
        If currentNumber.Length > 0 Then
            numbers.Add(Double.Parse(currentNumber))
        End If
        Return numbers
    End Function


    Private Sub PasteString()
        Dim input As String =
            InputBox("Line input", "tab", "Micro-drill	Solid carbide	Without	Without	0.16	
            FOC501	FOC501-000.160	VHM MICRO-DRILL DIN1899A Ø0.16 Z2 L30x1 D1 	 23.43 € 	0.0020	82075050	14	FALCON TOOLS
            ")

        GetDataFromStringLine(input)
    End Sub
    Private Function GetDataFromStringLine(input As String)

        'input = input.Replace("& vbCrLf", "").Replace("  ", "").Replace(" & vbCrLf", "").Replace(vbCrLf, "").Replace(vbLf, "")

        Dim output As String = Regex.Replace(input, "[^a-zA-Z0-9\t\D\d]+", "")
        Console.WriteLine(output)
        input = output
        Dim toolFields As List(Of String) = input.Split(vbTab).ToList()

        If toolFields.Count <= 1 And toolFields(0) <> "" Then

            Dim filter As String = InputBox("Nao foi possivel dividir a string, pls enter the caracter do divide", "ex: ;", ":")
            toolFields = input.Split(filter).ToList()
        End If
        Dim toolFieldsTmp As New List(Of String)
        For Each tF As String In toolFields
            Dim tmp() As String = tF.Split(" ")
            For Each t As String In tmp
                If toolFields.Contains(t) = False Then
                    toolFieldsTmp.Add(t)
                End If
            Next
        Next
        toolFields.AddRange(toolFieldsTmp)

        Dim splitLine() As String = My.Resources.ToolParamsSins.Split(New String() {Environment.NewLine}, StringSplitOptions.None).ToArray

        Dim paramDict As New Dictionary(Of String, String)


        Dim numbersList As New List(Of Double)

        For Each p As String In toolFields
            Dim tmp As List(Of Double) = ExtractNumbers(p)
            If tmp.Count > 0 Then
                For t As Integer = 0 To tmp.Count - 1
                    numbersList.Add(tmp(t))
                Next
            End If
            Dim foundMatch As Boolean = False
            For Each line As String In splitLine
                Dim synonyms As String() = line.Split(";")
                If p <> "" Then
                    If synonyms.Contains(p) Then
                        Try
                            paramDict.Add(synonyms(0), p)
                        Catch ex As Exception
                        End Try
                        ' Encontrou uma correspondência
                        ' O primeiro campo da string de entrada corresponde a um dos sinônimos
                        ' Você pode armazenar a correspondência e continuar a verificar os outros campos
                        Exit For
                    End If
                End If
            Next
        Next

        Dim types() As String
        types = {"endMill", "radiusMill", "drill", "reamer"}
        Dim type As String = ""

        Dim tool As New Tool

        For Each t As String In types
            'Gets Types
            If paramDict.ContainsKey(t) Then tool.Type = t
        Next

        'Gets tool material
        If paramDict.ContainsKey("material") Then tool.ToolMaterial = paramDict("material")

        Dim regexPatternD1 As String = "Ø([\d.]+)"
        Dim rmD1 As Match = Regex.Match(input, regexPatternD1)
        If rmD1.Success Then tool.D1 = Double.Parse(rmD1.Groups(1).Value)


        Dim regexPatternD3 As String = "D([\d.]+)"
        Dim rmD3 As Match = Regex.Match(input, regexPatternD3)
        If rmD3.Success Then tool.D3 = Double.Parse(rmD3.Groups(1).Value)

        Dim regexPatternZ As String = "Z([\d]+)"
        Dim rmZ As Match = Regex.Match(input, regexPatternZ)
        If rmZ.Success Then tool.NoTT = Double.Parse(rmZ.Groups(1).Value)

        'Gets L3 and L1 * TODO
        Dim regexPattern As String = "L(\d+)x(\d+)x(\d+)" ' "L(\d+)x(\d+)"
        Dim regexMatch As Match = Regex.Match(input, regexPattern)
        If regexMatch.Success Then
            tool.L3 = Double.Parse(regexMatch.Groups(1).Value)
            tool.L2 = Double.Parse(regexMatch.Groups(3).Value)
            tool.L1 = Double.Parse(regexMatch.Groups(2).Value)
        Else
            Dim regexPattern2 As String = "L(\d+)x(\d+)"
            Dim regexMatch2 As Match = Regex.Match(input, regexPattern2)
            If regexMatch2.Success Then
                tool.L3 = Double.Parse(regexMatch2.Groups(1).Value)
                tool.L1 = Double.Parse(regexMatch2.Groups(2).Value)
            End If
        End If

        'Get ManufRef
        Dim regexRefPattern As String = "\bFOC\d{3}-\d{3}\.\d{3}[A-Za-z]?\d?\b"
        Dim refRegexMatch As Match = Regex.Match(input, regexRefPattern)
        If refRegexMatch.Success Then
            tool.ManufRef = refRegexMatch.Value
        End If
        'Get ManufRef2
        Dim regexRefPattern2 As String = "\bALB\d{3}-\d{3}\.\d{3}[A-Za-z]?\d?\b"
        Dim refRegexMatch2 As Match = Regex.Match(input, regexRefPattern2)
        If refRegexMatch2.Success Then
            tool.ManufRef = refRegexMatch2.Value
        End If

        'Get Lub
        Dim regexPatternLub As String = "\bINTERNAL LUB\b"
        Dim regexMatchLub As Match = Regex.Match(input, regexPatternLub)
        If regexMatchLub.Success Then
            tool.ArrCentre = 1
        End If



        Dim brand As String = ""

        Dim brands() As String
        brands = {"FALCON TOOLS", "SECO", "SANDVIK", "KENNAMETAL", "WALTER", "ISCAR", "GUHRING", "KOMET", "TUNGALOY", "DORMER", "OSG", "TITEX", "VARGUS", "MAFORD", "KYOCERA", "MITSUBISHI", "KORLOY", "CERATIZIT", "TAEGUTEC", "SUMITOMO", "YG1", "GARR TOOL", "CRALEY", "INGERSOLL", "GUEHRING", "HORN", "MAPAL", "MICRO 100", "NACHI", "NTK", "WIDIA", "EUROMAC", "HOFFMAN", "GARANT", "SPEED TOOLS"}

        For Each b As String In brands
            If input.ToUpper.Contains(b) Then
                brand = b
                Exit For
            End If
        Next

        tool.Manuf = brand

        If tool.D2 = 0 Then
            tool.D2 = If(tool.D1 - 0.2 > 0, tool.D1 - 0.2, tool.D1)
        End If
        If tool.D3 = 0 Then tool.D3 = tool.D1
        If tool.L2 = 0 Then tool.L2 = tool.L1

        tool.AddTool()
        Create_outil(tool)

    End Function

    Private Sub ImportOrderTools()
        'Throw New NotImplementedException()
        ClearFilters()
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
