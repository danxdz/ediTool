Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class ImportPaste
    ' Criar uma nova instância da classe Tool
    Dim tool As New Tool()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = Nothing
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        ' Carregar configurações de tool em um Dictionary
        Dim toolParamsDict As New Dictionary(Of String, String)
        For Each line As String In My.Resources._13399_paste.Split(Environment.NewLine)
            Dim fields = line.Split(";"c)
            If fields(2).Contains("@") Then
                toolParamsDict.Add(fields(1), fields(2).Replace("@", ""))
            End If
        Next

        ' Criar colunas da tabela
        DataGridView1.Columns.Add("Nome", "Nome")
        DataGridView1.Columns.Add("Valor", "Valor")

        ' Permitir que o usuário mova as células ao redor da tabela
        DataGridView1.AllowUserToOrderColumns = True

        If TextBox1.Text <> "" Then
            tool.ManufRef = TextBox1.Lines(0).Trim()
            DataGridView1.Rows.Add("Ref.", tool.ManufRef)

        End If

        ' Processar as linhas de entrada do usuário
        For Each line As String In TextBox1.Lines
            If Not String.IsNullOrWhiteSpace(line) Then
                Dim fields = line.Split(vbTab)
                If fields.length < 2 Then
                    fields = line.Split(" ")
                    fields = line.Split(";")
                End If

                If fields.Length >= 2 AndAlso toolParamsDict.ContainsKey(fields(0)) Then
                    Dim propName = toolParamsDict(fields(0))
                    Dim propInfo = GetType(Tool).GetProperty(propName)
                    Dim value = fields(fields.Length - 1).Trim().Split(" "c)
                    If value(0) = "" Then
                        fields(fields.Length - 2).Trim().Split(" "c)
                    End If
                    Try
                        propInfo.SetValue(tool, Convert.ChangeType(value(0), propInfo.PropertyType), Nothing)
                        DataGridView1.Rows.Add(propName, value(0))
                    Catch ex As Exception

                    End Try
                End If
            End If
        Next
        Debug.WriteLine(tool)


        DataGridView1.Rows.Add("Name", Set_Name_auto(tool))


    End Sub




    Public Sub AddTool(tool)

        'Dim service As New FirestoreService
        'service.AddToolAsync(newTool)
        Dim localTools As New SQLiteToolDatabase(tool.Type) 'TODO

        localTools.AddTool(tool)
        graphics.Refresh_outil(tool, Main.ToolPreview_PictureBox)
        FillDataGrid(tool, Main.NewToolDataGridView)
        Main.fullToolsList.add(tool)


    End Sub



    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        AddTool(tool)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Limpar DataGridView

        TextBox1.Text = ""
    End Sub
End Class