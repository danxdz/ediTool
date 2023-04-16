Option Explicit On

Public Class ToolName_config
    Private Sub SaveBt_Click(sender As Object, e As EventArgs) Handles SaveBt.Click
        'My.Settings.NameMask = Namemask_textbox.Text
        My.Settings.MaskTT_FR = MaskTT_FR.Text
        My.Settings.MaskTT_FT = MaskTT_FT.Text
        My.Settings.MaskTT_FB = MaskTT_FB.Text
        My.Settings.MaskTT_FOP9 = MaskTT_FOC9.Text
        My.Settings.MaskTT_FOCA = MaskTT_FO.Text
        My.Settings.MaskTT_ALFI = MaskTT_AL.Text
        My.Settings.Save()
        Me.Hide()
        ' Set_Name_auto(filtered) 'TODO
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelBt.Click
        Me.Hide()
    End Sub
    Private Sub MaskTT_FR_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FR.TextChanged
        My.Settings.MaskTT_FR = Me.MaskTT_FR.Text
        My.Settings.Save()

    End Sub
    Private Sub MaskTT_FT_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FT.TextChanged
        My.Settings.MaskTT_FT = Me.MaskTT_FT.Text
        My.Settings.Save()

    End Sub
    Private Sub MaskTT_FB_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FB.TextChanged
        My.Settings.MaskTT_FB = Me.MaskTT_FB.Text
        My.Settings.Save()

    End Sub
    Private Sub MaskTT_FP_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FOC9.TextChanged
        My.Settings.MaskTT_FOP9 = Me.MaskTT_FOC9.Text
        My.Settings.Save()

    End Sub
    Private Sub MaskTT_FO_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FO.TextChanged
        My.Settings.MaskTT_FOCA = Me.MaskTT_FO.Text
        My.Settings.Save()

    End Sub
    Private Sub MaskTT_AL_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_AL.TextChanged
        My.Settings.MaskTT_ALFI = Me.MaskTT_AL.Text
        My.Settings.Save()

    End Sub

    Private Sub ToolName_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.MaskTT_ALFI = "" Then
            Set_default_toolname_masks(My.Resources.tooltypes)
        Else
            MaskTT_FR.Text = My.Settings.MaskTT_FR
            MaskTT_FT.Text = My.Settings.MaskTT_FT
            MaskTT_FB.Text = My.Settings.MaskTT_FB
            MaskTT_FOC9.Text = My.Settings.MaskTT_FOP9
            MaskTT_FO.Text = My.Settings.MaskTT_FOCA
            MaskTT_AL.Text = My.Settings.MaskTT_ALFI
        End If
        My.Settings.Save()
    End Sub
    Public Sub Set_default_toolname_masks(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        Dim labels() As TextBox = {MaskTT_FR, MaskTT_FT, MaskTT_FB, MaskTT_FOC9, MaskTT_FO, MaskTT_AL}
        For i As Integer = 0 To labels.Length - 1
            labels(i).Text = splitLine(i)
        Next
    End Sub
    Private Sub All_ResetBt_Click(sender As Object, e As EventArgs) Handles All_ResetBt.Click
        Set_default_toolname_masks(My.Resources.tooltypes)
    End Sub
    Private Sub ResetBt_Click(sender As Object, e As EventArgs) Handles FR_ResetBt.Click
        Me.MaskTT_FR.Text = "FR Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]"
        My.Settings.Save()
    End Sub
    Private Sub FT_ResetBt_Click(sender As Object, e As EventArgs) Handles FT_ResetBt.Click
        Me.MaskTT_FT.Text = "FT Ø[D] r[r] [NoTT]z Lc[L] Lu[CTS_AL]"
        My.Settings.Save()
    End Sub
    Private Sub FB_ResetBt_Click(sender As Object, e As EventArgs) Handles FB_ResetBt.Click
        Me.MaskTT_FB.Text = "FB Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]"
        My.Settings.Save()
    End Sub
    Private Sub FAP_ResetBt_Click(sender As Object, e As EventArgs) Handles FAP_ResetBt.Click
        Me.MaskTT_FOC9.Text = "FP Ø[D] A[A]"
        My.Settings.Save()
    End Sub
    Private Sub FO_ResetBt_Click(sender As Object, e As EventArgs) Handles FO_ResetBt.Click
        Me.MaskTT_FO.Text = "FO Ø[D] [NoTT]z A[A] Lc[L]"
        My.Settings.Save()
    End Sub
    Private Sub AL_ResetBt_Click(sender As Object, e As EventArgs) Handles AL_ResetBt.Click
        Me.MaskTT_AL.Text = "AL Ø[D] Lc[L]"
        My.Settings.Save()
    End Sub
End Class