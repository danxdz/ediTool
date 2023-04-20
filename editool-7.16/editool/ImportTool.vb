Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Media.Media3D
Imports System.Xml

Public Class ImportTool
    ReadOnly newTool As New Tool()
    Private filter As DataTable

    Private Sub ImportTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Dim dataGridView1 As New DataGridView()

        '' Adicionar colunas ao controle DataGridView
        'DataGridView1.Columns.Add("Coluna1", "Texto")
        'Dim coluna2 As New DataGridViewComboBoxColumn()
        'coluna2.HeaderText = "ComboBox"
        'coluna2.Name = "ComboBox"
        'Dim cell As New DataGridViewComboBoxCell()
        'cell.Items.Add("Opção 1")
        'cell.Items.Add("Opção 2")
        'cell.Items.Add("Opção 3")
        'coluna2.CellTemplate = cell
        'DataGridView1.Columns.Add(coluna2)

        '' Adicionar linhas ao controle DataGridView
        'DataGridView1.Rows.Add("Valor 1", "Opção 1")
        'DataGridView1.Rows.Add("Valor 2", "Opção 2")
        'DataGridView1.Rows.Add("Valor 3", "Opção 3")

        filter = GetUrl()



    End Sub

    Private Sub AddFraisaTool()


        Dim splitLine() As String = My.Resources.DIN400_tool_params.Split(New String() {Environment.NewLine}, StringSplitOptions.None).ToArray

        Dim paramToPropDict As New Dictionary(Of String, String)
        For Each line As String In splitLine
            Dim fields() As String = line.Split(";"c)
            If fields.Count > 2 Then
                paramToPropDict.Add(fields(0), fields(1))

            End If
        Next



        Dim xmlFile As String

        If Main.debugMode = True Then
            xmlFile = Me.RefTextBox.Text + ".xml" '  "15520501.xml" '"15520260.xml"
        Else
            xmlFile = GetFile()
        End If

        Dim documentoXml As New XmlDocument()

        documentoXml.Load(xmlFile)

        Dim xmlDoc As XmlElement = documentoXml.DocumentElement

        Dim toolNode As XmlNode = xmlDoc.SelectSingleNode("//Tool")

        ' Cria uma nova instância da classe NewTool

        For Each node As XmlNode In toolNode.ChildNodes
            ' Aqui você pode percorrer todos os parâmetros de cada toolNode
            For Each paramNode As XmlNode In node.SelectNodes("Property-Data")
                Dim paramName As String = paramNode.SelectSingleNode("PropertyName").InnerText.Trim()
                Dim paramValue As String = paramNode.SelectSingleNode("Value").InnerText.Trim()

                ' Verifica se o nome do parâmetro existe no dicionário
                If paramToPropDict.ContainsKey(paramName) Then
                    Dim propName As String = paramToPropDict(paramName)

                    ' Usa reflection para definir o valor da propriedade correspondente na classe NewTool
                    Dim prop As PropertyInfo = GetType(Tool).GetProperty(propName)
                    'Correcting name
                    If IsNumeric(paramValue) Then
                        paramValue = paramValue.Replace(",", ".")
                    End If
                    If (paramValue = "FSA") Then paramValue = "FRAISA" 'TODO check list to show right name
                    prop.SetValue(newTool, Convert.ChangeType(paramValue, prop.PropertyType), Nothing)
                End If
            Next
        Next
        Set_Name_auto(newTool)
        newTool.Name = Main.Name_textbox.Text

        FillDataGrid(newTool, DataGridView1)
        Refresh_outil(newTool, ToolPreview_PictureBox)
        Debug.WriteLine(newTool)
    End Sub

    Private Sub find_Bt_Click(sender As Object, e As EventArgs) Handles findBt.Click
        AddFraisaTool()
    End Sub

    Private Function GetFile() As String
        Dim itemCode As String = RefTextBox.Text

        itemCode = itemCode.Replace(",", "")
        itemCode = itemCode.Replace(".", "")

        If itemCode <> "" Then
            Dim url As String = "https://fsa.salessupportserver.com/CIMDataService_3S-FSA/DownloadService.svc/web/GetExport?OrderCode=" + itemCode + "&ExportType=din4000xml2016"
            Dim nomeArquivo As String = itemCode + ".xml"

            Try
                Dim cliente As New WebClient()
                Dim resposta As String = cliente.DownloadString(url)
                If resposta = "Exception occured - please contact support" Then
                    outputLabel.Text = "Tool not found"
                    Return ""
                End If
                File.WriteAllText(nomeArquivo, resposta)
                outputLabel.Text = "Tool found!"
                Return nomeArquivo
            Catch ex As Exception
                outputLabel.Text = "Error downloading tool: " + ex.Message
                Return ""
            End Try
        Else
            outputLabel.Text = "Fill tool reference"
            Return ""
        End If
        outputLabel.Visible = True
    End Function

    Private Sub saveBt_Click(sender As Object, e As EventArgs) Handles saveBt.Click
        Dim service As New FirestoreService
        service.AddToolAsync(newTool)
    End Sub

    Public Function GetUrl()

        Dim dt As New DataTable()
        dt.Columns.Add("Code", GetType(String))
        dt.Columns.Add("ManufRef", GetType(String))
        dt.Columns.Add("GroupeMat", GetType(String))
        dt.Columns.Add("D1", GetType(Double))


        Dim url As String = "https://webshop.fraisa.ch/index.php/fraeswerkzeuge?lng=fr"

        Try
            Dim request As HttpWebRequest = WebRequest.Create(url)
            request.Method = "GET"
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3"

            Using response As HttpWebResponse = request.GetResponse()
                Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                    Dim html As String = reader.ReadToEnd()

                    ' procurar o início e o fim da seção tbody
                    Dim tbodyStart As Integer = html.IndexOf("<tbody>")
                    Dim tbodyEnd As Integer = html.IndexOf("</tbody>") + "</tbody>".Length

                    ' extrair o conteúdo da seção tbody
                    Dim tbodyContent As String = html.Substring(tbodyStart, tbodyEnd - tbodyStart)


                    Dim lines As String() = tbodyContent.Split({"<tr class="}, StringSplitOptions.RemoveEmptyEntries)

                    Dim results As New List(Of String)

                    For Each line As String In lines
                        If line.Contains("</tr>") Then
                            results.Add("<tr class>" & line.Split({"</tr>"}, StringSplitOptions.None)(0) & "</tr>")
                        End If
                    Next
                    For Each result As String In results
                        Dim columns As String() = result.Split({"<td>", "</td>"}, StringSplitOptions.RemoveEmptyEntries)

                        If columns.Length = 10 Then ' verificar se a linha contém todas as colunas esperadas
                            Dim row As DataRow = dt.NewRow()

                            row("Code") = columns(1).Trim().Replace("<td style=""text-align: left;"">", "")
                            row("ManufRef") = columns(2).Trim().Replace("<td style=""text-align: left;"">", "")
                            row("GroupeMat") = columns(3).Trim().Replace("<td style="""">", "")
                            row("D1") = Double.Parse(columns(4).Trim().Replace("<td style="""">", ""))

                            dt.Rows.Add(row)

                        End If
                    Next

                End Using
            End Using

            Return dt

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return Nothing
        End Try
    End Function


    Private Sub RefTextBox_TextChanged(sender As Object, e As EventArgs) Handles RefTextBox.TextChanged

        If filter IsNot Nothing Then

            ' Filtra as linhas do DataTable com base no texto inserido no TextBox
            Dim filteredRows As DataRow() = filter.Select("Code LIKE '" & RefTextBox.Text & "%'")

            ' Cria uma nova tabela com as linhas filtradas
            Dim filteredTable As DataTable = filter.Clone()
            For Each row As DataRow In filteredRows
                filteredTable.ImportRow(row)
            Next

            ' Atualiza o conteúdo do ListBox com os itens filtrados
            ListBox1.DataSource = filteredTable
            ListBox1.DisplayMember = "Code" ' Define a coluna que será exibida no ListBox

        End If

    End Sub


End Class


