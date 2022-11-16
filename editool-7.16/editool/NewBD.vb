


Public Class NewBD




    Private Sub Nom_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nom_cb.SelectedIndexChanged
        Dim temp As String = nom_cb.SelectedItem.ToString
        nom_cb.Items.Remove(temp)
    End Sub

    Private Sub open_file_bt_Click(sender As Object, e As EventArgs) Handles open_file_bt.Click
        OpenFile()
    End Sub

End Class