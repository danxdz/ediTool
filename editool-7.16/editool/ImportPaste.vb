Imports System.Text.RegularExpressions

Public Class ImportPaste
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim texto As String = TextBox1.Text

        Dim splitLine() As String = My.Resources._13399_paste.Split(New String() {Environment.NewLine}, StringSplitOptions.None).ToArray
        Dim paramToPropDict As New Dictionary(Of String, String)
        Dim toolParamsList As New List(Of String)

        For Each line As String In splitLine
            Dim fields() As String = line.Split(";"c)
            If (fields.Count > 3) Then
                paramToPropDict.Add(fields(1), fields(2).Replace("@", ""))
                toolParamsList.Add(fields(2).Replace("@", ""))
            End If
        Next

        'Criar uma nova instância da classe Tool
        Dim tool As New Tool()


        ' Criar colunas da tabela
        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.HeaderText = "Nome"
        colNome.Name = "Nome"

        Dim colDescricao As New DataGridViewTextBoxColumn()
        colDescricao.HeaderText = "Descrição"
        colDescricao.Name = "Descrição"

        Dim colValor As New DataGridViewTextBoxColumn()
        colValor.HeaderText = "Valor"
        colValor.Name = "Valor"

        Dim colTool As New DataGridViewComboBoxColumn()
        colTool.HeaderText = "Tool"
        colTool.Name = "Tool"
        colTool.DataSource = toolParamsList


        ' Adicionar colunas à tabela
        DataGridView1.Columns.Add(colNome)
        DataGridView1.Columns.Add(colDescricao)
        DataGridView1.Columns.Add(colValor)
        DataGridView1.Columns.Add(colTool)


        ' Permitir que o usuário mova as células ao redor da tabela
        DataGridView1.AllowUserToOrderColumns = True



        Dim linhas() As String = texto.Split(vbCrLf)

        For Each linha As String In linhas
            If linha <> "" Then

                linha = linha.Replace(vbLf, "").Replace(vbTab, ";")
                Dim colunas() As String = linha.Split(";")

                Dim value = colunas(2).Split(" ")

                Dim comboCell As New DataGridViewComboBoxCell()

                If paramToPropDict.ContainsKey(colunas(0)) Then
                    Dim propInfo = GetType(Tool).GetProperty(paramToPropDict(colunas(0)))
                    propInfo.SetValue(tool, Convert.ChangeType(value(0), propInfo.PropertyType), Nothing)

                    comboCell.ValueMember = propInfo.GetValue(tool)

                End If

                DataGridView1.Rows.Add(colunas(0), colunas(1), value(0))
            End If
        Next

    End Sub

End Class