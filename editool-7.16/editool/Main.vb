
Option Explicit On
Imports System.Text.RegularExpressions
Imports editool.My

Public Class Main
    Public ReadOnly toolsList = New ToolList
    Public started As Boolean = False

    Dim StartLoadTimer As Date
    Dim EndLoadTimer As Date

    ReadOnly color = Drawing.Color.Transparent
    ReadOnly color_green = Drawing.Color.SpringGreen

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR

        My.Settings.DefManuf = "FRAISA"

        Dim type As String = My.Settings.ToolType

        'Dim columns() As String = {"Reference", "D", "SD", "CTS_AD", "OL", "L", "CTS_AL", "a", "z", "chf"} 'set columns titles into string array
        'SetDataGridColumnsTitle(columns) 

        If My.Settings.PrefLang = "en" Then
            Get_files(My.Resources.menu_en)
        Else
            Get_files(My.Resources.menu_fr)
        End If

        Try
            get_outils(My.Resources.outils, "")
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
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles D_textbox.KeyPress, SD_textbox.KeyPress, CTS_AD_textbox.KeyPress, OL_textbox.KeyPress, L_textbox.KeyPress, CTS_AL_textbox.KeyPress
        Dim digitsOnly As New Regex("[^\d]")
        Me.Text = digitsOnly.Replace(Me.Text, "")
    End Sub
    Private Sub Set_pref_lang(lang As String)
        My.Settings.PrefLang = lang
        My.Settings.Save()
    End Sub
    Private Sub ForceName_checkBox_CheckedChanged(sender As Object, e As EventArgs) Handles ForceName_checkBox.CheckedChanged
        If ForceName_checkBox.Checked = True Then
            Name_textbox.Enabled = True
        Else
            Name_textbox.Enabled = False
            ''Set_Name_auto()
        End If
    End Sub
    Private Sub ValidateBt_Click_1(sender As Object, e As EventArgs) Handles ValidateBt.Click

        Dim newTool As New NewTool

        'With {
        '    .D1 = Me.D_textbox.Text,
        '    .D2 = Me.CTS_AD_textbox.Text,
        '    .D3 = Me.SD_textbox.Text,
        '    .L1 = Me.L_textbox.Text,
        '    .L2 = Me.CTS_AL_textbox.Text,
        '    .L3 = Me.OL_textbox.Text,
        '    .AngleDeg = Me.alpha.Text,
        '    .Chanfrein = Me.Chf_textbox.Text,
        '    .RayonBout = Me.Chf_textbox.Text,
        '    .NoTT = Me.NoTT.Text,
        '    .Name = Me.Name_textbox.Text,
        '    .Type = My.Settings.ToolType,
        '    .Code = Me.manuf_comboBox.Text,
        '    .CodeBar = Me.Chf_textbox.Text,
        '    .Manuf = Me.manuf_comboBox.Text,
        '    .ManufRef = Me.manref_TextBox.Text,
        '    .ManufRefSec = Me.filterD1Combobox.Text
        '}

        toolsList.items.count()



        Dim num As Integer = NewToolDataGridView.SelectedRows().Count
        Dim i As Integer = NewToolDataGridView.CurrentRow().Index

        newTool = toolsList.Items(i)

        Create_outil(newTool)
        'REG CREATED TOOLS
        'Dim file_reader As IO.StreamReader
        'file_reader = Open_data_file("reg.txt")
        'Outil_exists(file_reader, Name_textbox.Text)
    End Sub

    Private Sub Lang_en_Click_1(sender As Object, e As EventArgs) Handles Lang_en.Click
        Set_pref_lang("en")
        Get_files(My.Resources.menu_en)
    End Sub
    Private Sub Lang_fr_Click_1(sender As Object, e As EventArgs) Handles Lang_fr.Click
        Set_pref_lang("fr")
        Get_files(My.Resources.menu_fr)
    End Sub

    Private Sub DefineName_Bt_Click(sender As Object, e As EventArgs) Handles DefineName_Bt.Click
        ToolName_config.Show()
    End Sub

    Private Sub FR2T_Click(sender As Object, e As EventArgs) Handles FR2T.Click

        FR2T.BackColor = color_green

        FRBO.BackColor = color
        FRTO.BackColor = color
        FAP.BackColor = color
        AL.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "FR2T"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR

        Refresh_outil()

    End Sub

    Private Sub FAP_Click(sender As Object, e As EventArgs) Handles FAP.Click

        FAP.BackColor = color_green
        FR2T.BackColor = color
        FRTO.BackColor = color
        FRBO.BackColor = color
        AL.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "FP"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FP

        Refresh_outil()

    End Sub

    Private Sub FRBO_Click(sender As Object, e As EventArgs) Handles FRBO.Click

        FRBO.BackColor = color_green
        FR2T.BackColor = color
        FRTO.BackColor = color
        FAP.BackColor = color
        AL.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "FB"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FB

        Refresh_outil()

    End Sub

    Private Sub FRTO_Click(sender As Object, e As EventArgs) Handles FRTO.Click

        FRTO.BackColor = color_green
        FR2T.BackColor = color
        FRBO.BackColor = color
        FAP.BackColor = color
        AL.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "FT"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FT

        Refresh_outil()

    End Sub

    Private Sub FO_Click(sender As Object, e As EventArgs) Handles FO.Click

        FO.BackColor = color_green
        FR2T.BackColor = color
        FRTO.BackColor = color
        FRBO.BackColor = color
        FAP.BackColor = color
        AL.BackColor = color

        My.Settings.ToolType = "FOCA"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FO

        Refresh_outil()

    End Sub
    Private Sub AL_Click(sender As Object, e As EventArgs) Handles AL.Click

        AL.BackColor = color_green
        FR2T.BackColor = color
        FRBO.BackColor = color
        FRTO.BackColor = color
        FAP.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "AL"
        My.Settings.Save()

        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_AL

        Refresh_outil()

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles XML_ToolStripButton.Click
        OpenFile()
    End Sub

    Private Sub V6import_bt_Click(sender As Object, e As EventArgs)
        OpenV6File()
    End Sub

    Private Sub A_TextBox_LostFocus(sender As Object, e As EventArgs) Handles A_TextBox.LostFocus
        Refresh_outil()
    End Sub

    Private Sub D_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub L_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub CTS_AL_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub CTS_AD_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub SD_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub OL_textbox_LostFocus(sender As Object, e As EventArgs)
        Refresh_outil()
    End Sub
    Private Sub NoTT_LostFocus(sender As Object, e As EventArgs) Handles NoTT.LostFocus
        Refresh_outil()
    End Sub

    Private Sub Chf_textbox_LostFocus(sender As Object, e As EventArgs) Handles Chf_textbox.LostFocus
        Refresh_outil()
    End Sub


    Private Sub Webtocsv(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        Dim DataTableOrderTools As DataTable
        DataTableOrderTools = New DataTable

        Dim toolTypeFilter As String = My.Settings.ToolType

        Dim webcsv As WebBrowser = CType(sender, WebBrowser)

        Dim tblrows As HtmlElementCollection
        Dim tblcols As HtmlElementCollection
        Dim column As String

        Dim filterD1 As New List(Of Single)
        Dim filterL1 As New List(Of Single)
        Dim filterMat As New List(Of String)



        Dim row As New List(Of String)()

        tblrows = webcsv.Document.GetElementById("tableTool").GetElementsByTagName("tr")
        NewToolDataGridView.DataSource = Nothing
        'NewToolDataGridView.Columns.Clear()
        'NewToolDataGridView.Rows.Clear()
        readToolProgress_Label.Text = 0



        Dim objList As New List(Of String)
        DataTableOrderTools = New DataTable


        tblcols = tblrows.Item(0).GetElementsByTagName("th")

        If tblcols.Count > 0 Then
            For x As Integer = 0 To tblcols.Count - 1
                column = tblcols.Item(x).InnerHtml
                column = Replace(column, "<br>", " ")

                Dim col = New DataGridViewTextBoxColumn With {
                               .HeaderText = column,
                               .SortMode = DataGridViewColumnSortMode.NotSortable
                           }
                'Dim colIndex As Integer = NewToolDataGridView.Columns.Add(col)
                objList.Add(column)
            Next
        End If

        DataTableOrderTools = SetDataGridColumnsTitle(objList.ToArray, DataTableOrderTools)




        For r As Integer = 2 To tblrows.Count - 2
            tblcols = tblrows.Item(r).GetElementsByTagName("td")

            Dim stock As HtmlElementCollection

            'NewToolDataGridView.Rows.Add()
            Dim newTool = New NewTool
            Try
                stock = tblcols.Item(0).GetElementsByTagName("strong")
                Dim stockVal As Integer
                If stock.Count > 0 Then
                    stockVal = stock(0).InnerHtml
                Else
                    stockVal = 0
                End If

                If tblcols.Item(1).InnerHtml = toolTypeFilter Then
                    'ListBox1.Items.Add(tblcols.Item(2).InnerHtml & " - " & tblcols.Item(3).InnerHtml & " - " & tblcols.Item(4).InnerHtml & " - " & tblcols.Item(8).InnerHtml)
                    readToolProgress_Label.Text += 1
                    With newTool
                        .d1 = tblcols.Item(3).InnerHtml
                        .d2 = tblcols.Item(3).InnerHtml - 0.2
                        .d3 = tblcols.Item(7).InnerHtml
                        .l1 = tblcols.Item(4).InnerHtml
                        If tblcols.Item(5).InnerHtml > 0 Then
                            .L2 = tblcols.Item(5).InnerHtml
                        Else
                            .L2 = newTool.L1
                        End If
                        .l3 = tblcols.Item(6).InnerHtml
                        .nott = tblcols.Item(8).InnerHtml
                        .Type = tblcols.Item(1).InnerHtml
                        .GroupeMat = tblcols.Item(2).InnerHtml
                        .RayonBout = tblcols.Item(9).InnerHtml
                        .Chanfrein = tblcols.Item(10).InnerHtml
                        .CoupeCentre = tblcols.Item(11).InnerHtml
                        .ArrCentre = tblcols.Item(12).InnerHtml
                        .TypeTar = tblcols.Item(13).InnerHtml
                        .PasTar = tblcols.Item(14).InnerHtml
                        .Manuf = tblcols.Item(15).InnerHtml
                        .ManufRef = tblcols.Item(16).InnerHtml
                        .ManufRefSec = Replace(tblcols.Item(17).InnerHtml, "    ", "")
                        '.Link = tblcols.Item(18).InnerHtml
                        .Code = tblcols.Item(21).InnerHtml
                        .CodeBar = tblcols.Item(22).InnerHtml

                        Dim rowTmp() As String = {
                            stockVal,
                            .Type,
                            .GroupeMat,
                            .D1,
                            .L1,
                            .L2,
                            .L3,
                            .D3,
                            .NoTT,
                            .RayonBout,
                            .Chanfrein,
                            .CoupeCentre,
                            .ArrCentre,
                            .TypeTar,
                            .PasTar,
                            .Manuf,
                            .ManufRef,
                            .ManufRefSec,
                            .Code,
                            .CodeBar
                        }

                        DataTableOrderTools.Rows.Add(rowTmp)

                    End With

                    filterD1 = AddFiltersCombobox(newTool.d1, filterD1)
                    filterL1 = AddFiltersCombobox(newTool.l1, filterL1)
                    filterMat = SetFiltersString(newTool.GroupeMat, filterMat)


                    toolsList.items.Add(newTool)
                    'FileImports.FillDataGrid(newTool, NewToolDataGridView)
                End If

            Catch ex As Exception
                'MsgBox("cant read tool")
            End Try


        Next
        NewToolDataGridView.DataSource = DataTableOrderTools




        filterD1 = filterD1.OrderBy(Function(x) x).ToList()
        With filterD1_Combobox
            .DataSource = filterD1
        End With


        filterL1 = filterL1.OrderBy(Function(x) x).ToList()
        With filterL1_ComboBox
            .DataSource = filterL1
        End With

        filterMat = filterMat.OrderBy(Function(x) x).ToList()
        With filterMat_ComboBox
            .DataSource = filterMat
        End With

        EndLoadTimer = Now().ToUniversalTime

        timer_label.Text = DateDiff(DateInterval.Second, StartLoadTimer, EndLoadTimer)


    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles OrderTools_ToolStripButton.Click

        My.Settings.DefManuf = ""
        My.Settings.Save()

        filterD1_Combobox.DataSource = Nothing
        filterD1_Combobox.Items.Clear()
        filterL1_ComboBox.DataSource = Nothing
        filterL1_ComboBox.Items.Clear()
        filterMat_ComboBox.DataSource = Nothing
        filterMat_ComboBox.Items.Clear()

        toolsList.items.clear()

        StartLoadTimer = Now().ToUniversalTime

        timer_label.Text = Now().ToUniversalTime

        Dim web As New WebBrowser
        AddHandler web.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf Webtocsv)
        web.Navigate(New System.Uri("http://tools.semmip.local/"))
        'web.Navigate(New System.Uri("C:/Downloaded%20Web%20Sites/tools.semmip.local/index.php.html"))

    End Sub


    Private Sub NewToolDataGridView_MouseDown(sender As Object, e As MouseEventArgs) Handles NewToolDataGridView.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                '  DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)

            Catch ex As Exception
                ' MsgBox("invalid cell")
            End Try
            newToolMenu.Show(Cursor.Position)
        End If
    End Sub



    '**********************************


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Dim num As Integer = NewToolDataGridView.SelectedRows().Count

        Dim i As Integer = NewToolDataGridView.CurrentRow().Index + 1

        D_textbox.Text = toolsList.items(i).D1
        L_textbox.Text = toolsList.items(i).L1

        CTS_AD_textbox.Text = toolsList.items(i).D2
        CTS_AL_textbox.Text = toolsList.items(i).L2

        SD_textbox.Text = toolsList.items(i).D3
        OL_textbox.Text = toolsList.items(i).L3

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
            Dim tmp = toolsList.items.Count

            If num = 1 Then

                'If My.Settings.DefManuf <> "FRAISA" Then
                '    i = tmp - i
                'End If
                readToolProgress_Label.Text = i
                Try
                    D_textbox.Text = toolsList.items(i).D1
                    L_textbox.Text = toolsList.items(i).L1

                    CTS_AD_textbox.Text = toolsList.items(i).D2
                    CTS_AL_textbox.Text = toolsList.items(i).L2

                    SD_textbox.Text = toolsList.items(i).D3
                    OL_textbox.Text = toolsList.items(i).L3

                    Refresh_outil()
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

    Private Sub FilterD1Combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterD1_Combobox.SelectedIndexChanged
        'If filterD1_Combobox.SelectedItem <> 0 Then
        '    Dim sel As Single = filterD1_Combobox.SelectedItem
        '    Dim filteredTool As New List(Of NewTool)

        '    For Each tool As NewTool In toolsList.items
        '        Dim tmp As Single = tool.D1
        '        If tmp = sel Then
        '            filteredTool.Add(tool)
        '        End If
        '    Next
        '    NewToolDataGridView.DataSource = filteredTool

        '    filterL1_ComboBox.DataSource = Nothing
        '    filterL1_ComboBox.Items.Clear()

        '    Dim filterL1 As New List(Of Single)

        '    For Each tool As NewTool In filteredTool

        '        filterL1 = SetFilters(tool.L1, filterL1)
        '    Next


        '    filterL1 = filterL1.OrderBy(Function(x) x).ToList()
        '    With filterL1_ComboBox
        '        .DataSource = filterL1
        '    End With
        'End If

    End Sub


    Private Sub filterL1_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterL1_ComboBox.SelectedIndexChanged

        'If filterL1_ComboBox.SelectedItem <> 0 Then

        '    Try
        '        Dim filter_D1 As String
        '        Dim filter_L1 As String
        '        Dim filteredTool As New List(Of NewTool)

        '        For Each tool As NewTool In toolsList.items
        '            Dim tmp_L1 As Single = tool.L1
        '            Dim tmp_D1 As Single = tool.D1

        '            If filterD1_Combobox.Items.Count > 0 Then
        '                filter_D1 = filterD1_Combobox.SelectedItem
        '                If filterL1_ComboBox.Items.Count > 0 Then
        '                    filter_L1 = filterL1_ComboBox.SelectedItem

        '                    If tmp_D1 = filter_D1 And tmp_L1 = filter_L1 Then
        '                        filteredTool.Add(tool)
        '                    End If

        '                Else
        '                    If tmp_D1 = filter_D1 Then
        '                        filteredTool.Add(tool)
        '                    End If
        '                End If
        '            Else
        '                If filterL1_ComboBox.SelectedItem = True Then
        '                    filter_L1 = filterL1_ComboBox.SelectedItem

        '                    If tmp_L1 = filter_L1 Then
        '                        filteredTool.Add(tool)
        '                    End If
        '                End If
        '            End If



        '        Next
        '        NewToolDataGridView.DataSource = filteredTool
        '    Catch ex As Exception

        '    End Try

        'End If

    End Sub
    Dim filteredTool As New List(Of NewTool)

    Public Sub filters_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterMat_ComboBox.SelectedIndexChanged, filterL1_ComboBox.SelectedIndexChanged, filterD1_Combobox.SelectedIndexChanged

        If filterMat_ComboBox.SelectedItem <> "" Then
            filteredTool = SetFilters(sender)
            NewToolDataGridView.DataSource = filteredTool

        End If
    End Sub

    Function SetFilters(sender As Object)


        Dim filterCB As ComboBox = sender
        Dim seltmp As String = filterCB.SelectedItem


        If filterCB.SelectedItem <> "" Then
            For Each tool As NewTool In toolsList.Items
                Dim tmpFilter As String

                If sender.Items.Count > 0 Then
                    Select Case sender.name
                        Case "filterMat_ComboBox"
                            tmpFilter = tool.GroupeMat
                            If tmpFilter = seltmp Then
                                filteredTool.Add(tool)

                            End If
                        Case "filterD1_ComboBox"
                            tmpFilter = tool.D1
                        Case "filterL1_ComboBox"
                            tmpFilter = tool.L1
                    End Select

                End If

            Next
        End If

        Return filteredTool



    End Function
End Class
