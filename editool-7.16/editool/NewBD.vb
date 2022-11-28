


Public Class NewBD




    Private Sub Nom_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nom_cb.SelectedIndexChanged
        Dim temp As String = nom_cb.SelectedItem.ToString
        'nom_cb.Items.Remove(temp)
    End Sub

    Private Sub Open_file_bt_Click(sender As Object, e As EventArgs) Handles open_file_bt.Click
        OpenFile()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles Row_NumericUpDown.ValueChanged
        If path_TextBox.Text <> "" Then
            FileImports.ReadExcel(path_TextBox.Text)
        End If

    End Sub



    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        If e.Button = MouseButtons.Right Then
            Try
                '  DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)

            Catch ex As Exception
                ' MsgBox("invalid cell")
            End Try
            RC_Menu_NewDB.Show(Cursor.Position)
        End If

    End Sub

    Private Sub RC_Menu_NewDB_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RC_Menu_NewDB.Opening

    End Sub

    Private Sub Del_tool_Click(sender As Object, e As EventArgs) Handles del_tool.Click
        Dim num As Integer = DataGridView1.SelectedRows().Count
        If num = 1 Then

            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow().Index)
        Else
            Dim beginSel As Integer

            For bs As Integer = 0 To DataGridView1.RowCount
                If DataGridView1.Rows(bs).Selected Then
                    beginSel = bs
                    Exit For

                End If
            Next

            Dim dif As Integer = num + beginSel

            For ind As Integer = beginSel To dif - 1

                If DataGridView1.Rows(beginSel).Selected Then
                    DataGridView1.Rows.RemoveAt(beginSel)
                End If
            Next


        End If
    End Sub

    Private Sub NewTool_Click(sender As Object, e As EventArgs) Handles new_tool.Click
        Create_outil(1)

    End Sub
End Class