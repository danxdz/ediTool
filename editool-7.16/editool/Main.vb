
Option Explicit On
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports EdiTool.My
Imports Newtonsoft.Json

Public Class Main

    Public ReadOnly debugMode As Boolean = False 'True to pick local files

    Public localtools = New List(Of Tool)

    Public filteredTools = New List(Of Tool)

    Private ReadOnly newTool As Tool

    Public started As Boolean = False

    ReadOnly color = Drawing.Color.Transparent
    ReadOnly color_green = Drawing.Color.SpringGreen



    ReadOnly api As New TopSolidAPI()


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Debug **************************************************************
        'Clean settings - change to 'false' to persistent settings or true to clear user settings
        If My.Settings.userSettings = False Then
            My.Settings.destinationLibrary = ""
            My.Settings.PrefLang = ""
            My.Settings.ToolType = ""
            My.Settings.userSettings = True
            My.Settings.Save()

        End If

        localtools = Tool.GetAllToolsByType()

        Preload.Preload(localtools.Count)

        'First time load - check tool lib to save new tools
        Dim customToolLib As String = My.Settings.destinationLibrary
        'if not defined as for ne one
        If customToolLib = "" Then

            Dim libName As String = InputBox("custom lib name", "Custom Tools", "Tool Lib")
            My.Settings.destinationLibrary = libName
            My.Settings.Save()

        End If

        'Set lang settings and label text
        Dim language As String = My.Settings.PrefLang

        If language = "" Then
            Dim culture As CultureInfo = CultureInfo.CurrentCulture
            language = culture.TwoLetterISOLanguageName
            My.Settings.PrefLang = language
            My.Settings.Save()
        End If

        FillMainMenu(language)
        FillUI(language)


        'Dim service = New FirestoreService()
        ' If service.db IsNot Nothing Then ' TODO
        ' Dim remoteTools = service.GetTools("endMill") ' TODO FIRESTORE



        'Dim type As String = My.Settings.ToolType

        'FileImports.GetOrderTools()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR

        'My.Settings.DefManuf = "FRAISA"

        Try
            'GetDefaultTools(My.Resources.outils, "")
            'Set_Name_auto()
        Catch ex As Exception
            MsgBox("no db file    -->" & ex.ToString)
            Close()
            End
        End Try


    End Sub



    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles D1textBox.KeyPress, D3textBox.KeyPress, D2textBox.KeyPress, L3textBox.KeyPress, L1textBox.KeyPress, L2textBox.KeyPress
        Dim digitsOnly As New Regex("[^\d]")
        sender.Text = digitsOnly.Replace(sender.Text, "")
        ' Refresh_outil(toolsList(NewToolDataGridView.CurrentRow().Index))
    End Sub

    Private Sub ForceName_checkBox_CheckedChanged(sender As Object, e As EventArgs) Handles forceName.CheckedChanged
        If forceName.Checked = True Then
            Name_textbox.Enabled = True
        Else
            Name_textbox.Enabled = False
            ''Set_Name_auto()
        End If
    End Sub
    Private Sub ValidateBt_Click_1(sender As Object, e As EventArgs) Handles createBt.Click
        If NewToolDataGridView.CurrentRow Is Nothing Then

        Else
            Dim i As Integer = NewToolDataGridView.CurrentRow().Index

            Dim newTool As Tool
            If filteredTools IsNot Nothing Then

                If filteredTools.count > 0 Then
                    newTool = filteredTools(i)
                Else
                    newTool = localtools(i)
                End If

                Create_outil(newTool)

            End If
        End If



        'REG CREATED TOOLS
        'Dim file_reader As IO.StreamReader
        'file_reader = Open_data_file("reg.txt")
        'Outil_exists(file_reader, Name_textbox.Text)
    End Sub

    Private Sub DefineName_Bt_Click(sender As Object, e As EventArgs) Handles config.Click
        ToolName_config.Show()
    End Sub

    Public Sub HandleToolTypeButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim toolType As String = button.Tag
        Dim toolName As String = ""

        ' Set all buttons to default color
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = color.DefaultBackColor
            End If
        Next

        ' Set the clicked button to green
        button.BackColor = color.Green

        ' Update the tool name based on the selected tool type
        Select Case toolType
            Case "FR2T"
                toolName = My.Settings.MaskTT_FR
            Case "FOP9"
                toolName = My.Settings.MaskTT_FOP9
            Case "FRHE"
                toolName = My.Settings.MaskTT_FB
            Case "FRTO"
                toolName = My.Settings.MaskTT_FT
            Case "FOCA"
                toolName = My.Settings.MaskTT_FOCA
            Case "ALFI"
                toolName = My.Settings.MaskTT_ALFI
        End Select

        ' Update the tool name textbox
        ToolName_config.Namemask_textbox.Text = toolName

        ' Update the tool list based on the selected tool type
        Dim filteredTools As List(Of Tool) = localtools.Where(Function(x) x.Type = toolType).ToList()
        If filteredTools.Count > 0 Then
            Refresh_outil(filteredTools(0), ToolPreview_PictureBox)
        End If
    End Sub

    Private Sub V6import_bt_Click(sender As Object, e As EventArgs)
        OpenV6File()
    End Sub


    Private Sub InputBoxes_LostFocus(sender As Object, e As EventArgs) Handles A_TextBox.LostFocus, D1textBox.LostFocus, L1textBox.LostFocus, L2textBox.LostFocus, Chf_textbox.LostFocus, NoTT.LostFocus, L3textBox.LostFocus, D3textBox.LostFocus
        Try
            If NewToolDataGridView.Rows.Count > 0 Then
                Dim i As Integer = NewToolDataGridView.CurrentRow().Index
                Refresh_outil(filteredTools(0), ToolPreview_PictureBox)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ORDERTOOLS_ToolStripButton_Click(sender As Object, e As EventArgs) Handles OrderTools_ToolStripButton.Click
        ClearFilters()
    End Sub

    Private Sub NewToolDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles NewToolDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                '  DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)

            Catch ex As Exception
                MsgBox("invalid cell")
            End Try
            newToolMenu.Show(Cursor.Position)
        End If
    End Sub

    '**********************************

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Dim num As Integer = NewToolDataGridView.SelectedRows().Count

        Dim i As Integer = NewToolDataGridView.CurrentRow().Index + 1

        D1textBox.Text = localtools(i).D1
        L1textBox.Text = localtools(i).L1

        D2textBox.Text = localtools(i).D2
        L2textBox.Text = localtools(i).L2

        D3textBox.Text = localtools(i).D3
        L3textBox.Text = localtools(i).L3

    End Sub

    'Private Sub NewToolDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles NewToolDataGridView.CurrentCellChanged
    '    Dim ds() As Windows.Forms.TextBox = {D_textbox, SD_textbox, CTS_AD_textbox, OL_textbox, L_textbox, CTS_AL_textbox, alpha, NoTT}
    '    Try
    '        manref_TextBox.Text = NewToolDataGridView.SelectedCells(0).Value
    '        For i As Short = 1 To 8
    '            ds(i - 1).Text = NewToolDataGridView.SelectedCells(i).Value
    '        Next
    '        Refresh_outil()
    '    Catch ex As Exception
    '        ' MsgBox("CELL CHANGED - " + ex.ToString)
    '    End Try
    'End Sub

    Private Sub NewToolDataGridView_MouseUp(sender As Object, e As MouseEventArgs) Handles NewToolDataGridView.MouseUp
        If e.Button = MouseButtons.Left Then
            started = True
            Dim num As Integer = NewToolDataGridView.SelectedRows().Count
            Dim i As Integer = NewToolDataGridView.CurrentRow().Index '+ 1
            Dim tmp = localtools.Count

            If num = 1 Then
                Try

                    Dim filePath As String = "tools/" + localtools(i).ManufRef + ".json"
                    Dim json As String = File.ReadAllText(filePath)
                    Dim tool As Tool = JsonConvert.DeserializeObject(Of Tool)(json)
                    localtools(i) = tool
                    D1textBox.Text = tool.D1
                    L1textBox.Text = tool.L1

                    D2textBox.Text = tool.D2
                    L2textBox.Text = tool.L2

                    D3textBox.Text = tool.D3
                    L3textBox.Text = tool.L3
                    Refresh_outil(tool, ToolPreview_PictureBox)
                    Init.Set_Name_auto(tool)


                    'If filteredTools.Count > 0 Then
                    '    D_textbox.Text = filteredTools(i).D1
                    '    L_textbox.Text = filteredTools(i).L1

                    '    CTS_AD_textbox.Text = filteredTools(i).D2
                    '    CTS_AL_textbox.Text = filteredTools(i).L2

                    '    SD_textbox.Text = filteredTools(i).D3
                    '    OL_textbox.Text = filteredTools(i).L3
                    '    Refresh_outil(filteredTools(i), ToolPreview_PictureBox)
                    '    Init.Set_Name_auto(filteredTools(i))

                    'Else
                    '    D_textbox.Text = fullToolsList(i).D1
                    '    L_textbox.Text = fullToolsList(i).L1

                    '    CTS_AD_textbox.Text = fullToolsList(i).D2
                    '    CTS_AL_textbox.Text = fullToolsList(i).L2

                    '    SD_textbox.Text = fullToolsList(i).D3
                    '    OL_textbox.Text = fullToolsList(i).L3
                    '    Refresh_outil(fullToolsList(i), ToolPreview_PictureBox)
                    '    Init.Set_Name_auto(fullToolsList(i))

                    'End If
                Catch ex As Exception
                    MsgBox("tool data error") 'TODO
                End Try

            End If
        End If

    End Sub

    Private Sub Top6_ToolStripButton_Click(sender As Object, e As EventArgs) Handles Top6_ToolStripButton.Click
        OpenV6File()
    End Sub

    Private Sub Manuf_TextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles manuf_comboBox.SelectedIndexChanged
        Set_filter()
    End Sub

    Private Sub ManRef_TextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles manref_TextBox.SelectedIndexChanged
        Set_filter()
    End Sub

    Public Sub Filters_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterMat_ComboBox.SelectedIndexChanged, filterL1_ComboBox.SelectedIndexChanged, filterD1_Combobox.SelectedIndexChanged
        ' Get the selected item from the ComboBox
        Dim selected As String = sender.selectedItem

        ' Check if a selection was made and it's not "0"
        If selected <> "" And selected <> "0" Then

            ' If the sender was the material ComboBox
            If sender.name = "filterMat_ComboBox" Then
                ' Clear the D1 and L1 ComboBoxes
                filterD1_Combobox.DataSource = Nothing
                filterL1_ComboBox.DataSource = Nothing

                ' Create a list to store D1 values
                Dim filterD1 As New List(Of Decimal)

                ' Iterate through the filtered tools to find unique D1 values
                For Each tool As Tool In filteredTools
                    filterD1 = AddFiltersCombobox(tool.D1, filterD1)
                Next

                ' Order the D1 values and set them as the data source for the D1 ComboBox
                filterD1 = filterD1.OrderBy(Function(x) x).ToList()
                With filterD1_Combobox
                    .DataSource = filterD1
                End With
            End If

            ' If the sender was the D1 ComboBox
            If sender.name = "filterD1_Combobox" Then
                ' Clear the L1 ComboBox
                filterL1_ComboBox.DataSource = Nothing
                filterL1_ComboBox.Items.Clear()
            End If

            ' Clear the filtered tools list and reset it to the original list
            filteredTools.Clear()
            filteredTools = localtools

            ' Apply the filters and update the DataGridView
            filteredTools = SetFilters(sender)
            NewToolDataGridView.DataSource = ""
            NewToolDataGridView.DataSource = filteredTools

        Else
            ' If no selection was made or the selection was "0"

            ' If the sender was the material ComboBox
            If sender.name = "filterMat_ComboBox" Then
                ' Reset the filtered tools list and apply the filters
                filteredTools = localtools
                filteredTools = SetFilters(sender)

                ' Update the DataGridView
                NewToolDataGridView.DataSource = ""
                NewToolDataGridView.DataSource = filteredTools
            End If

            ' If the sender was the D1 ComboBox
            If sender.name = "filterD1_Combobox" Then
                ' Reset the filtered tools list and apply the filters
                filteredTools = localtools
                filteredTools = SetFilters(sender)

                ' Update the DataGridView
                NewToolDataGridView.DataSource = ""
                NewToolDataGridView.DataSource = filteredTools
            End If
            If sender.name = "filterL1_ComboBox" Then
                ' Reset the filtered tools list and apply the filters
                filteredTools = localtools
                filteredTools = SetFilters(sender)

                ' Update the DataGridView
                NewToolDataGridView.DataSource = ""
                NewToolDataGridView.DataSource = filteredTools
            End If
        End If
    End Sub

    Function SetFilters(sender As Object)
        ' Get selected filter values
        Dim selD1 As Decimal = GetFilterValues(filterD1_Combobox)
        Dim selL1 As Decimal = 0
        If filterL1_ComboBox.Items.Count > 0 Then
            selL1 = GetFilterValues(filterL1_ComboBox)
        End If
        Dim selMat As String = GetFilterValues(filterMat_ComboBox)

        ' Filter the tools based on the selected values
        Dim filteredTools As List(Of Tool) = FilterTools(selD1, selL1, selMat)

        ' If L1 filter is not selected, populate the L1 combobox based on filtered tools
        If selL1 = 0 Then
            PopulateL1ComboBox(filteredTools)
        End If

        ' Update tool count label
        readToolProgress_Label.Text = filteredTools.Count.ToString()

        ' Return filtered tools
        Return filteredTools
    End Function

    Private Function GetFilterValues(comboBox As ComboBox) As Object
        If comboBox.SelectedValue IsNot Nothing Then
            Return comboBox.SelectedValue
        ElseIf comboBox.Text <> "" Then
            Return comboBox.Text
        Else
            Return 0
        End If
    End Function

    Private Function FilterTools(selD1 As Decimal, selL1 As Decimal, selMat As String) As List(Of Tool)
        Dim toolList As New List(Of Tool)

        For Each tool As Tool In filteredTools
            Dim add As Boolean = True

            If selD1 <> 0 AndAlso selD1 <> tool.D1 Then
                add = False
            End If

            If selL1 <> 0 AndAlso selL1 <> tool.L1 Then
                add = False
            End If

            If selMat <> "" AndAlso selMat <> tool.GroupeMat Then
                add = False
            End If

            If add Then
                toolList.Add(tool)
            End If
        Next

        Return toolList
    End Function

    Private Sub PopulateL1ComboBox(filteredTools As List(Of Tool))
        Dim filterL1 As New List(Of Decimal)

        For Each tool As Tool In filteredTools
            filterL1 = AddFiltersCombobox(tool.L1, filterL1)
        Next

        filterL1 = filterL1.OrderBy(Function(x) x).ToList()

        With filterL1_ComboBox
            .DataSource = filterL1
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub FilterMat_ComboBox_MouseHover(sender As Object, e As EventArgs) Handles filterMat_ComboBox.MouseHover
        ToolTip1.Show("groupe matiere", filterMat_ComboBox)
    End Sub

    Private Sub ToolType_Click(sender As Object, e As EventArgs) Handles FR2T.Click, FRTO.Click, FRBO.Click
        ToolTypeButton_Click(sender, e)
        Console.Write(e.ToString)
    End Sub

    Public Sub ToolTypeButton_Click(sender As Object, e As EventArgs)
        My.Settings.ToolType = sender.ToString
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = sender.ToString
        Console.Write(e.ToString)
        Console.Write(sender)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)
        My.Settings.ToolType = sender.ToString
        My.Settings.Save()
    End Sub

End Class
