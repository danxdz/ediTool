
Option Explicit On


Public Class NewBD

    Private Sub Nom_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nom_cb.SelectedIndexChanged
        Dim temp As String = nom_cb.SelectedItem.ToString
        'nom_cb.Items.Remove(temp)
    End Sub

    Private Sub Open_file_bt_Click(sender As Object, e As EventArgs) Handles open_file_bt.Click
        OpenXmlFile()
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

        Dim NewTool As New Tool

        Dim num As Integer = DataGridView1.SelectedRows().Count
        Dim index As Integer = DataGridView1.CurrentRow().Index
        With NewTool

            .D1 = DataGridView1.Rows(index).Cells(3).Value
            .D2 = Replace(DataGridView1.Rows(index).Cells(3).Value, ".", ",") - 0.2
            .D3 = DataGridView1.Rows(index).Cells(7).Value

            .L1 = DataGridView1.Rows(index).Cells(4).Value
            .L2 = DataGridView1.Rows(index).Cells(5).Value
            .L3 = DataGridView1.Rows(index).Cells(6).Value

            .NoTT = DataGridView1.Rows(index).Cells(8).Value

            .CorRadius = DataGridView1.Rows(index).Cells(9).Value
            .CorChamfer = DataGridView1.Rows(index).Cells(10).Value

            .Manuf = DataGridView1.Rows(index).Cells(15).Value
            .ManufRef = DataGridView1.Rows(index).Cells(16).Value
            .ManufRefSec = DataGridView1.Rows(index).Cells(17).Value

            .Code = DataGridView1.Rows(index).Cells(21).Value
            .CodeBar = DataGridView1.Rows(index).Cells(22).Value

            .Type = DataGridView1.Rows(index).Cells(1).Value

        End With

        If num = 1 Then
            Create_outil(NewTool)
        End If

    End Sub

    Private Sub valider_bt_Click(sender As Object, e As EventArgs) Handles valider_bt.Click

    End Sub

    Private Sub NewBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class