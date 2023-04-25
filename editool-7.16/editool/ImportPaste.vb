Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class ImportPaste
    ' Criar uma nova instância da classe Tool
    Dim tool As New Tool()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Limpar DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        ' Carregar configurações de tool em um Dictionary
        Dim toolParamsDict As New Dictionary(Of String, String)
        For Each line As String In My.Resources._13399_paste.Split(Environment.NewLine)
            Dim fields = line.Split(";"c)
            If fields.Length >= 3 AndAlso fields(2).Contains("@") Then
                toolParamsDict.Add(fields(1), fields(2).Replace("@", ""))
            End If
        Next

        ' Criar colunas da tabela
        DataGridView1.Columns.Add("Nome", "Nome")
        DataGridView1.Columns.Add("Valor", "Valor")

        ' Permitir que o usuário mova as células ao redor da tabela
        DataGridView1.AllowUserToOrderColumns = True



        ' Processar as linhas de entrada do usuário
        For Each line As String In TextBox1.Lines
            If Not String.IsNullOrWhiteSpace(line) Then
                Dim fields = line.Split(vbTab)
                If fields.Length >= 3 AndAlso toolParamsDict.ContainsKey(fields(0)) Then
                    Dim propName = toolParamsDict(fields(0))
                    Dim propInfo = GetType(Tool).GetProperty(propName)
                    Dim value = fields(2).Trim().Split(" "c)
                    propInfo.SetValue(tool, Convert.ChangeType(value(0), propInfo.PropertyType), Nothing)
                    DataGridView1.Rows.Add(propName, value(0))
                End If
            End If
        Next
        Debug.WriteLine(tool)
        Set_Name_auto(tool)


    End Sub





    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        'Dim service As New FirestoreService
        'service.AddToolAsync(newTool)
        Dim localTools As New SQLiteToolDatabase("endMill") 'TODO

        localTools.AddTool(tool)
        graphics.Refresh_outil(tool, Main.ToolPreview_PictureBox)
        FillDataGrid(tool, Main.NewToolDataGridView)
    End Sub
End Class