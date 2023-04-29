
Option Explicit On
Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Text.RegularExpressions

Public Class NewBD
    Public headersState As Boolean
    Private Sub CbSelectedIndexChanged(sender As Object, e As EventArgs)
        Dim temp As String = ToolNameCb.SelectedItem.ToString
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




    Function ExtractNumbers(line As String) As List(Of Double)

        Dim numbers As New List(Of Double)
        Dim currentNumber As String = ""
        For Each c As Char In line
            If Char.IsDigit(c) OrElse c = "."c Then
                currentNumber &= c
            ElseIf currentNumber.Length > 0 Then
                numbers.Add(Double.Parse(currentNumber))
                currentNumber = ""
            End If
        Next
        If currentNumber.Length > 0 Then
            numbers.Add(Double.Parse(currentNumber))
        End If
        Return numbers
    End Function

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim tempDataGridView As New DataGridView()

        For Each column As DataGridViewColumn In DataGridView1.Columns
            tempDataGridView.Columns.Add(column.Clone())
        Next

        ' Adicione as linhas selecionadas do DataGridView principal ao DataGridView temporário
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            tempDataGridView.Rows.Add(row.Clone())
        Next


        If (e.RowIndex > 0) Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)


            'Dim selectedCell As DataGridViewCell = selectedRow.Cells(e.ColumnIndex)
            For Each cell As DataGridViewCell In selectedRow.Cells


                Dim cellValue As String = cell.Value.ToString()


                Dim numbersList As List(Of Double) = ExtractNumbers(cellValue)
                ' faça algo com a lista de números extraída


                For i As Integer = 0 To numbersList.Count - 1
                    tempDataGridView.Columns.Add("Number " & (i + 1), "Number " & (i + 1))
                    ' tempDataGridView.Rows(e.RowIndex).Cells(DataGridView1.Columns.Count - 1).Value = numbersList(i)
                Next
            Next

        End If

        'DataGridView1.Rows.AddRange(tempDataGridView.Rows.Cast(Of DataGridViewRow).ToArray())
    End Sub


    Private Sub Code_outil_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolNameCb.SelectedIndexChanged, d3Cb.SelectedIndexChanged, d2Cb.SelectedIndexChanged, ManufRef.SelectedIndexChanged, MatCb.SelectedIndexChanged, d1Cb.SelectedIndexChanged
        'UpdateComboBoxes(sender.SelectedItem.ToString())

        Dim cb As ComboBox = DirectCast(sender, ComboBox)
        If cb.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = cb.SelectedItem.ToString()
            selectedColumns.Add(selectedItem)
            UpdateComboBoxes(selectedItem)
        End If

    End Sub

    Private ReadOnly selectedColumns As New List(Of String)

    Private Sub UpdateComboBoxes(selectedItem As String)

        Dim selectedItems As New Dictionary(Of String, String) ' Lista para armazenar os valores selecionados
        ' Armazena os valores selecionados em cada ComboBox
        For Each cb As ComboBox In Controls.OfType(Of ComboBox)()
            If cb.SelectedItem IsNot Nothing Then
                If selectedItems.ContainsKey(cb.Name) Then
                    selectedItems(cb.Name) = cb.SelectedItem.ToString()
                Else
                    selectedItems.Add(cb.Name, cb.SelectedItem.ToString())
                End If


            End If
        Next

        ' Atualiza as ComboBoxes
        For Each cb As ComboBox In Controls.OfType(Of ComboBox)()

            If selectedItems.ContainsKey(cb.Name) = False Then
                cb.Items.Clear()
                If cb.SelectedItem Is Nothing AndAlso cb.SelectedItem <> selectedItem Then ' Não atualize a ComboBox que disparou o evento
                    For Each col As DataGridViewColumn In DataGridView1.Columns
                        If col.HeaderText <> selectedItem AndAlso Not selectedItems.ContainsValue(col.HeaderText) Then ' Não adicione o item selecionado ou itens já selecionados em outras ComboBoxes
                            cb.Items.Add(col.HeaderText)
                        End If
                    Next
                End If
            End If
        Next

        For Each kvp As KeyValuePair(Of String, String) In selectedItems
            Dim tst As ComboBox
            For Each cb As ComboBox In Controls.OfType(Of ComboBox)()
                If cb.Name = kvp.Key Then
                    tst = cb
                    Exit For
                End If
            Next

            If kvp.Value <> selectedItem AndAlso tst.Items.Contains(kvp.Value) Then ' Seleciona apenas se o valor ainda estiver disponível
                tst.SelectedItem = kvp.Value
            End If
        Next
        'selectedItems.Clear()

    End Sub



    Private Sub Headers_CheckedChanged(sender As Object, e As EventArgs) Handles headers.CheckedChanged
        ' headers.Checked = False
        ReadExcel(My.Settings.lastPath)
    End Sub

    Private Sub Headers_Click(sender As Object, e As EventArgs) Handles headers.Click
        headers.Checked = Not headers.Checked
    End Sub

    Private Sub SplitColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplitColumnToolStripMenuItem.Click
        FillComboBoxes()
    End Sub

    Public Sub FillComboBoxes()
        Dim headers As New List(Of String)

        For Each col As DataGridViewColumn In DataGridView1.Columns
            headers.Add(col.HeaderText)
        Next

        For Each cb As ComboBox In Controls.OfType(Of ComboBox)()
            cb.Items.Clear()
            cb.Items.AddRange(headers.ToArray())
        Next
    End Sub

    Private Sub NoTT_cb_SelectedValueChanged(sender As Object, e As EventArgs) Handles NoTT_cb.SelectedValueChanged
        UpdateComboBoxes(sender.SelectedItem.ToString())
    End Sub

    Private Sub NewBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class