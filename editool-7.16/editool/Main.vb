
Option Explicit On

Imports System.IO
Imports System.Text.RegularExpressions





Public Class Main
    Public ReadOnly toolsList = New ToolList
    Public started As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR

        SetDataTable()

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

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles Ref_filter_TextBox.TextChanged
        Set_filter()
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles Diam_filter_TextBox.TextChanged
        Set_filter()
    End Sub


    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D_textbox.KeyPress, SD_textbox.KeyPress, CTS_AD_textbox.KeyPress, OL_textbox.KeyPress, L_textbox.KeyPress, CTS_AL_textbox.KeyPress
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

        Dim newTool As New NewTool With {
            .D1 = Me.D_textbox.Text,
            .D2 = Me.CTS_AD_textbox.Text,
            .D3 = Me.SD_textbox.Text,
            .L1 = Me.L_textbox.Text,
            .L2 = Me.CTS_AL_textbox.Text,
            .L3 = Me.OL_textbox.Text,
            .AngleDeg = Me.alpha.Text,
            .Chanfrein = Me.Chf_textbox.Text,
            .RayonBout = Me.Chf_textbox.Text,
            .NoTT = Me.NoTT.Text,
            .Name = Me.Name_textbox.Text,
            .Type = My.Settings.ToolType,
            .Code = Me.manuf_TextBox.Text,
            .CodeBar = Me.Chf_textbox.Text,
            .Manuf = Me.manuf_TextBox.Text,
            .ManufRef = Me.manref_TextBox.Text,
            .ManufRefSec = Me.manRefSec_TextBox.Text
        }

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
        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
        FR2T.BackColor = color_green

        FRBO.BackColor = color
        FRTO.BackColor = color
        FAP.BackColor = color
        AL.BackColor = color
        FO.BackColor = color

        My.Settings.ToolType = "FR"
        'My.Settings.NameMask = ToolName_config.MaskTT_FR.Text
        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR

        My.Settings.Save()
        Refresh_outil()

    End Sub

    Private Sub FAP_Click(sender As Object, e As EventArgs) Handles FAP.Click

        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
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
        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
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
        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
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
        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
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
        Dim color = Drawing.Color.Gray
        Dim color_green = Drawing.Color.SpringGreen
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

    Private Sub D_textbox_LostFocus(sender As Object, e As EventArgs) Handles D_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub L_textbox_LostFocus(sender As Object, e As EventArgs) Handles L_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub CTS_AL_textbox_LostFocus(sender As Object, e As EventArgs) Handles CTS_AL_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub CTS_AD_textbox_LostFocus(sender As Object, e As EventArgs) Handles CTS_AD_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub SD_textbox_LostFocus(sender As Object, e As EventArgs) Handles SD_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub OL_textbox_LostFocus(sender As Object, e As EventArgs) Handles OL_textbox.LostFocus
        Refresh_outil()
    End Sub
    Private Sub NoTT_LostFocus(sender As Object, e As EventArgs) Handles NoTT.LostFocus
        Refresh_outil()
    End Sub

    Private Sub Chf_textbox_LostFocus(sender As Object, e As EventArgs) Handles Chf_textbox.LostFocus
        Refresh_outil()
    End Sub


    Private Sub Webtocsv(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        NewToolDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
        NewToolDataGridView.RowHeadersVisible = False

        Dim webcsv As WebBrowser = CType(sender, WebBrowser)

        Dim tblrows As HtmlElementCollection
        Dim tblcols As HtmlElementCollection
        Dim column As String

        Dim row As New List(Of String)()


        ''tblrows = webcsv.Document.GetElementsByTagName("tbody").Item(0).GetElementsByTagName("tr")
        tblrows = webcsv.Document.GetElementById("tableTool").GetElementsByTagName("tr")

        NewToolDataGridView.Columns.Clear()
        NewToolDataGridView.Rows.Clear()
        readToolProgress_Label.Text = 0


        'For r As Integer = 0 To tblrows.Count - 1
        tblcols = tblrows.Item(0).GetElementsByTagName("th")
        If tblcols.Count > 0 Then
            For x As Integer = 0 To tblcols.Count - 1
                column = tblcols.Item(x).InnerHtml
                Replace(column, "VbTab", "")
                Replace(column, "<br>", " ")

                Dim col = New DataGridViewTextBoxColumn With {
                               .HeaderText = Replace(column, "<br>", " "),
                               .SortMode = DataGridViewColumnSortMode.NotSortable
                           }
                Dim colIndex As Integer = NewToolDataGridView.Columns.Add(col)
            Next
        End If

        For r As Integer = 1 To tblrows.Count - 2
            tblcols = tblrows.Item(r).GetElementsByTagName("td")

            readToolProgress_Label.Text += 1

            Dim stock As HtmlElementCollection

            'NewToolDataGridView.Rows.Add()
            Dim newTool = New NewTool

            For x As Integer = 0 To tblcols.Count - 1

                stock = tblcols.Item(x).GetElementsByTagName("strong")
                If stock.Count > 0 Then
                    'NewToolDataGridView.Rows(NewToolDataGridView.RowCount - 2).Cells(0).Value = stock.Item(0).InnerHtml
                    column = stock.Item(0).InnerHtml
                    row.Add(Replace(column, "<br>", " "))

                Else
                    If x = 0 Then
                        row.Add("0")
                    Else
                        column = tblcols.Item(x).InnerHtml
                        Replace(column, "		", "")
                        Replace(column, "<br>", " ")

                        If x = 0 And column = "" Then
                            column = "-"
                        End If

                        If column = "" Then
                            column = "0"
                        End If

                        Try
                            column = Convert.ToDouble(column)
                        Catch ex As Exception
                            'MsgBox("data import error")
                        End Try

                        Select Case x
                            Case 0 : column = x
                            Case 1 : newTool.Type = column
                            Case 2 : newTool.GroupeMat = column
                            Case 3 : newTool.D1 = column
                            Case 4 : newTool.L1 = column
                            Case 5 : If column = 0 Then
                                    newTool.L2 = newTool.L1
                                Else
                                    newTool.L2 = column
                                End If
                            Case 6 : newTool.L3 = column
                            Case 7 : newTool.D3 = column
                            Case 8 : newTool.NoTT = column
                            Case 9 : newTool.RayonBout = column
                            Case 10 : newTool.Chanfrein = column
                            Case 11 : newTool.CoupeCentre = column
                            Case 12 : newTool.ArrCentre = column
                            Case 13 : newTool.TypeTar = column
                            Case 14 : newTool.PasTar = column
                            Case 15 : newTool.Manuf = column
                            Case 16 : newTool.ManufRef = column
                            Case 17 : newTool.ManufRefSec = column
                            Case 18 : newTool.ManufRefSec = column
                            Case 21 : newTool.Code = column
                            Case 22 : newTool.CodeBar = column

                        End Select
                        'NewToolDataGridView.Rows(NewToolDataGridView.RowCount - 2).Cells(x).Value = column

                        'row.Append(column)

                        Dim tmp As String = Strings.Left(column, 2)

                        If tmp <> "		" Then
                            row.Add(Replace(column, "<br>", " "))
                        End If
                    End If

                End If
            Next
            If row.Count > 0 Then
                'NewToolDataGridView.Rows.Insert(0, row.ToArray())
                ListBox1.Items.Add(newTool)

                row.Clear()
                Try
                    newTool.D2 = Convert.ToDouble(newTool.D1) - 0.2
                    CTS_AD_textbox.Text = newTool.D2

                Catch ex As Exception

                End Try

                toolsList.items.Add(newTool)
            End If




        Next
        'ToolList.Text = csv     'show csv in textbox

        'Refresh_outil()
    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles OrderTools_ToolStripButton.Click
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


    Private Sub NewToolDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles NewToolDataGridView.CurrentCellChanged
        Dim ds() As TextBox = {D_textbox, SD_textbox, CTS_AD_textbox, OL_textbox, L_textbox, CTS_AL_textbox, alpha, NoTT}
        Try
            manref_TextBox.Text = NewToolDataGridView.SelectedCells(0).Value
            For i As Short = 1 To 8
                ds(i - 1).Text = NewToolDataGridView.SelectedCells(i).Value
            Next
            Refresh_outil()
        Catch ex As Exception
            ' MsgBox("CELL CHANGED - " + ex.ToString)
        End Try
    End Sub

    Private Sub NewToolDataGridView_MouseUp(sender As Object, e As MouseEventArgs) Handles NewToolDataGridView.MouseUp

        If e.Button = MouseButtons.Left Then
            started = True
            Dim num As Integer = NewToolDataGridView.SelectedRows().Count
            If num > 0 Then
                Dim i As Integer = NewToolDataGridView.CurrentRow().Index
                'Dim tmp = toolsList.items.Count
                'i = tmp - i

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

                End Try

            End If
        End If
    End Sub


    Private Sub Top6_ToolStripButton_Click(sender As Object, e As EventArgs) Handles Top6_ToolStripButton.Click
        OpenV6File()
    End Sub
End Class
