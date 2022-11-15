
Option Explicit On

Imports System.IO
Imports System.Text.RegularExpressions





Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim file_reader As IO.StreamReader
        ToolName_config.Namemask_textbox.Text = My.Settings.MaskTT_FR
        SetDataTable()

        If My.Settings.PrefLang = "en" Then
            Get_files(My.Resources.menu_en)
        Else
            Get_files(My.Resources.menu_fr)
        End If

        Try
            get_outils(My.Resources.outils, "")
            Set_Name_auto()
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
        Create_outil()
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
        NewBD.Show()
    End Sub
End Class
