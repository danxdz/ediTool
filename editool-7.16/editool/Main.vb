
Option Explicit On

Imports System.IO
Imports System.Text.RegularExpressions

Imports System.Net
Imports System.Text




Public Class Main
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

    Private Sub Refresh_outil()
        ToolPreview()
        Set_Name_auto()
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
        Create_outil(0)
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

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim ds() As TextBox = {D_textbox, SD_textbox, CTS_AD_textbox, OL_textbox, L_textbox, CTS_AL_textbox, alpha, NoTT}
        Try
            manref_TextBox.Text = DataGridView1.SelectedCells(0).Value
            For i As Short = 1 To 8
                ds(i - 1).Text = DataGridView1.SelectedCells(i).Value
            Next
            Refresh_outil()
        Catch ex As Exception
            ' MsgBox("CELL CHANGED - " + ex.ToString)
        End Try
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
        Set_Name_auto()

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

        Set_Name_auto()

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

        Set_Name_auto()

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

        Set_Name_auto()

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

        My.Settings.ToolType = "FO"
        My.Settings.Save()
        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FO

        Set_Name_auto()

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

        Set_Name_auto()

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        OpenFile()
    End Sub


    Private Sub V6import_bt_Click(sender As Object, e As EventArgs) Handles v6import_bt.Click
        OpenV6File()
    End Sub

    Private Sub A_TextBox_LostFocus(sender As Object, e As EventArgs) Handles A_TextBox.LostFocus
        Set_Name_auto()
    End Sub

    Private Sub D_textbox_LostFocus(sender As Object, e As EventArgs) Handles D_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub L_textbox_LostFocus(sender As Object, e As EventArgs) Handles L_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub CTS_AL_textbox_LostFocus(sender As Object, e As EventArgs) Handles CTS_AL_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub CTS_AD_textbox_LostFocus(sender As Object, e As EventArgs) Handles CTS_AD_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub SD_textbox_LostFocus(sender As Object, e As EventArgs) Handles SD_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub OL_textbox_LostFocus(sender As Object, e As EventArgs) Handles OL_textbox.LostFocus
        Set_Name_auto()
    End Sub
    Private Sub NoTT_LostFocus(sender As Object, e As EventArgs) Handles NoTT.LostFocus
        Set_Name_auto()
    End Sub

    Private Sub Chf_textbox_LostFocus(sender As Object, e As EventArgs) Handles Chf_textbox.LostFocus
        Set_Name_auto()
    End Sub


    Private Sub webtocsv(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)



        Dim webcsv As WebBrowser = CType(sender, WebBrowser)

        Dim tblrows As HtmlElementCollection
        Dim tblcols As HtmlElementCollection
        Dim column As String = ""
        Dim csv As String = ""




        ''tblrows = webcsv.Document.GetElementsByTagName("tbody").Item(0).GetElementsByTagName("tr")
        tblrows = webcsv.Document.GetElementById("tableTool").GetElementsByTagName("tr")

        OrderToolsDataGridView.Columns.Clear()
        OrderToolsDataGridView.Rows.Clear()
        readToolProgress_Label.Text = 0


        'For r As Integer = 0 To tblrows.Count - 1
        tblcols = tblrows.Item(0).GetElementsByTagName("th")
        If tblcols.Count > 0 Then
            For x As Integer = 0 To tblcols.Count - 1
                column = tblcols.Item(x).InnerHtml
                Replace(column, "VbTab", "")
                Replace(column, "<br>", "")

                Dim col = New DataGridViewTextBoxColumn With {
                               .HeaderText = Replace(column, "<br>", " "),
                               .SortMode = DataGridViewColumnSortMode.NotSortable
                           }
                Dim colIndex As Integer = OrderToolsDataGridView.Columns.Add(col)
            Next
        End If

        For r As Integer = 1 To tblrows.Count - 2
            tblcols = tblrows.Item(r).GetElementsByTagName("td")

            readToolProgress_Label.Text += 1

            Dim stock As HtmlElementCollection

            OrderToolsDataGridView.Rows.Add()

            For x As Integer = 0 To tblcols.Count - 1

                stock = tblcols.Item(x).GetElementsByTagName("strong")
                If stock.Count > 0 Then
                    OrderToolsDataGridView.Rows(OrderToolsDataGridView.RowCount - 2).Cells(0).Value = stock.Item(0).InnerHtml
                Else
                    column = tblcols.Item(x).InnerHtml
                    'Replace(column, "VbTab", "")
                    Replace(column, "<br>", " ")
                    OrderToolsDataGridView.Rows(OrderToolsDataGridView.RowCount - 2).Cells(x).Value = column
                End If
            Next
        Next
        'ToolList.Text = csv     'show csv in textbox

    End Sub

    Private Sub test()

        ' Create a request for the URL. 		
        'Dim request As WebRequest = WebRequest.Create("http://tools.semmip.local/")
        Dim request As WebRequest = WebRequest.Create("C:/Downloaded%20Web%20Sites/tools.semmip.local/index.php.html")

        ' If required by the server, set the credentials.
        request.Credentials = CredentialCache.DefaultCredentials
        ' Get the response.
        Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
        ' Display the status.
        Console.WriteLine(response.StatusDescription)
        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()
        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)
        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()





        ' Display the content.
        Console.WriteLine(responseFromServer)
        ' Cleanup the streams and the response.
        reader.Close()
        dataStream.Close()
        response.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim web As New WebBrowser
        AddHandler web.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf webtocsv)
        web.Navigate(New System.Uri("http://tools.semmip.local/"))
        'web.Navigate(New System.Uri("C:/Downloaded%20Web%20Sites/tools.semmip.local/index.php.html"))

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
