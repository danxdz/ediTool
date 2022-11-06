Public Class ToolName_config
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.NameMask = Namemask_textbox.Text
        My.Settings.Save()
        Me.Hide()
        Set_Name_auto()

    End Sub

    Private Sub Namemask_textbox_TextChanged(sender As Object, e As EventArgs) Handles Namemask_textbox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Namemask_textbox.Text = "FR Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]"
    End Sub
End Class