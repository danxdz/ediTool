Public Class ToolName_config
    Private Sub SaveBt_Click(sender As Object, e As EventArgs) Handles SaveBt.Click
        My.Settings.NameMask = Namemask_textbox.Text


        My.Settings.MaskTT_FR = MaskTT_FR.Text
        My.Settings.MaskTT_FT = MaskTT_FT.Text
        My.Settings.MaskTT_FB = MaskTT_FB.Text
        My.Settings.MaskTT_FP = MaskTT_FP.Text
        My.Settings.MaskTT_FO = MaskTT_FO.Text
        My.Settings.MaskTT_AL = MaskTT_AL.Text

        My.Settings.Save()
        Me.Hide()
        Set_Name_auto()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CancelBt.Click
        Me.Hide()

    End Sub

    Private Sub ResetBt_Click(sender As Object, e As EventArgs) Handles FR_ResetBt.Click
        Namemask_textbox.Text = "Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]"
    End Sub

    Private Sub MaskTT_FR_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FR.TextChanged
        My.Settings.MaskTT_FR = Me.MaskTT_FR.Text

    End Sub

    Private Sub MaskTT_FT_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FT.TextChanged
        My.Settings.MaskTT_FT = Me.MaskTT_FT.Text

    End Sub

    Private Sub MaskTT_FB_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FB.TextChanged
        My.Settings.MaskTT_FB = Me.MaskTT_FB.Text

    End Sub

    Private Sub MaskTT_FP_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FP.TextChanged
        My.Settings.MaskTT_FP = Me.MaskTT_FP.Text

    End Sub

    Private Sub MaskTT_FO_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_FO.TextChanged
        My.Settings.MaskTT_FO = Me.MaskTT_FO.Text

    End Sub

    Private Sub MaskTT_AL_TextChanged(sender As Object, e As EventArgs) Handles MaskTT_AL.TextChanged
        My.Settings.MaskTT_AL = Me.MaskTT_AL.Text

    End Sub

    Private Sub ToolName_config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.MaskTT_AL = "" Then
            Set_default_toolname_masks(My.Resources.tooltypes)
        Else
            MaskTT_FR.Text = My.Settings.MaskTT_FR
            MaskTT_FT.Text = My.Settings.MaskTT_FT
            MaskTT_FB.Text = My.Settings.MaskTT_FB
            MaskTT_FP.Text = My.Settings.MaskTT_FP
            MaskTT_FO.Text = My.Settings.MaskTT_FO
            MaskTT_AL.Text = My.Settings.MaskTT_AL
        End If
    End Sub
    Public Sub Set_default_toolname_masks(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim labels() As TextBox = {MaskTT_FR, MaskTT_FT, MaskTT_FB, MaskTT_FP, MaskTT_FO, MaskTT_AL}

        For i As Integer = 0 To labels.Length - 1
            labels(i).Text = splitLine(i)
        Next


    End Sub

    Private Sub All_ResetBt_Click(sender As Object, e As EventArgs) Handles All_ResetBt.Click
        Set_default_toolname_masks(My.Resources.tooltypes)
    End Sub
End Class