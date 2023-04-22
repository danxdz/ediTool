Option Explicit On

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

        ' filter = GetUrl() ' TODO



    End Sub



    Private Function CheckFraisaTypes(id As String) As String
        'sources from FRAISA.com
        Dim radiusMill() As Integer = {8107, 8720, 15502, 15572, 15573, 15574, 15575, 15582, 15583, 15584, 15585, 8507, 6032, 6034, 6036, 6038, 6040, 6042, 6044, 7284, 7288, 7340, 7344, 7620, 7624, 15268, 5257, 45319, 500022, 500023, 500024, 500025, 500046, 500047, 500048, 500049, 500050, 500051, 500052, 500053, 500054, 500055, 500056, 500057, 500058, 500059, 500060, 500061, 500062, 500063, 500064, 500065, 500066, 500067, 500068, 500069, 500070, 500071, 500072, 500073, 500074, 500075, 500076, 500077, 500085, 500086, 8617, 8117, 5234, 5250, 5252, 5640, 5645, 5650, 5752, 5754, 5756, 5762, 5764, 6531, 6532, 6533, 6534, 6535, 6536, 6538, 6735, 6736, 6738, 6740, 6742, 6744, 7100, 7104, 7200, 7204, 7600, 7604, 7608, 15226, 31410, 31420, 35400, 95752, 95754, 95756, 7210, 15512, 7610, 7612, 7614, 7212, 6816, 6818, 6820, 6823}
        Dim ballMill() As Integer = {6062, 6064, 6066, 6068, 6070, 6072, 6074, 7400, 7404, 7408, 7460, 7464, 7484, 7488, 7500, 7540, 7544, 7550, 7402, 7554, 5286, 5288, 5289, 5580, 5782, 5784, 5786, 5787, 5791, 5792, 5793, 5794, 5796, 6460, 6461, 6462, 6463, 6464, 6481, 6482, 6483, 6560, 6561, 6562, 6563, 6564, 6565, 6566, 6567, 6568, 6579, 6581, 6582, 6583, 6765, 6766, 6768, 6770, 6772, 6774, 7450, 7454, 7458, 7470, 7474, 7478, 15781, 15795, 31700, 35700, 45298, 45785, 95782, 95784, 95786, 95787, 95791, 95793, 915795, 7472, 7490, 7492, 7494, 6832, 6836, 6840, 6844, 6846, 6847, 6848, 6849}
        Dim endMill() As Integer = {500043, 500042, 500041, 500040, 500015, 500014, 500013, 500012, 500011, 500010, 500009, 500008, 500007, 500006, 500005, 500004, 500003, 500002, 500001, 500000, 95717, 95716, 95714, 95712, 46310, 46300, 45713, 45710, 45709, 45372, 45371, 45362, 45360, 45355, 45336, 45334, 45333, 45326, 45325, 45323, 45322, 45317, 20030, 20025, 20020, 15754, 15752, 15725, 15711, 15607, 15606, 15590, 15589, 15561, 15560, 15559, 15557, 15550, 15535, 15530, 15525, 15520, 15510, 15507, 15506, 15505, 15500, 15359, 15299, 15298, 15297, 15260, 15254, 15251, 15250, 15248, 15242, 15239, 15238, 15236, 15233, 15232, 15225, 15223, 15222, 15210, 15208, 15207, 8805, 8800, 8618, 8616, 8614, 8608, 8606, 8604, 8521, 8502, 8500, 8404, 8323, 8321, 8320, 8315, 8313, 8311, 8310, 8305, 8303, 8302, 8301, 8300, 8121, 8115, 8112, 8111, 8105, 8102, 8101, 8100, 6812, 6811, 6810, 6809, 6807, 6804, 6802, 6800, 6508, 6506, 6505, 6504, 6503, 6502, 6501, 6500, 5724, 5723, 5722, 5721, 5717, 5716, 5714, 5712, 5400, 5336, 5335, 5329, 5297, 5279, 5272, 5255, 5249, 5237, 5225, 5219, 5218, 5215, 5214, 5213, 5200, 5036, 780, 700, 695, 665, 659, 650, 621, 619, 610, 609, 540, 410, 400, 393, 391, 200, 190, 110}
        Dim drilTool() As Integer = {52020, 52111, 52112, 52710, 52724, 52801, 52915, 52920, 52925, 52930, 57014, 57015, 57020, 57710, 62011, 62014, 62015, 72011, 72015, 72020, 92310, 92360, 500048}
        Dim spotDrill() As Integer = {92008, 92020, 92040}
        Dim tslotcutter() As Integer = {910, 915, 905}
        Dim conicalBarrelTool() As Integer = {8530, 8535, 8540, 8545, 8550}
        Dim chamferedProfileCutter() As Integer = {7930, 7940, 7942}
        Dim materialDetail() = {"FG0001 'HM-MG10'", "FG0002: 'HM'", "FG0003: 'HSS-PM/F'", "FG0004: 'HM-XT'", "FG0005: 'HM-XR'", "FG0006: 'HM-XA'", "FG0007: 'HM-Plus'", "FG0008: 'HM-Micro'", "FG0009 'CBN'", "FG0010: 'HSS-Co8'", "FG0011: 'HM-X10'", "FG0012: 'CVD'", "FG0013: 'HM-MG6'"}
        Dim coolants() = {"1 'External coolant'", "2: 'Internal coolant'", "3: 'External air'", "4: 'Internal air'", "5: 'Minimum Quantity Lubrication', 0: 'Unkown'"}
        Dim coolantsType() = {"1 'external'", "2: 'internal'", "3: 'externalAir'", "4: 'externalAir'", "5: 'mql', 0: 'Unkown'"}

        If radiusMill.Any(Function(textID) id.StartsWith(textID)) Then Return "radiusMill"
        If ballMill.Any(Function(textID) id.StartsWith(textID)) Then Return "ballMill"
        If endMill.Any(Function(textID) id.StartsWith(textID)) Then Return "endMill"
        If tslotcutter.Any(Function(textID) id.StartsWith(textID)) Then Return "tslotcutter"
        If conicalBarrelTool.Any(Function(textID) id.StartsWith(textID)) Then Return "conicalBarrelTool"
        If chamferedProfileCutter.Any(Function(textID) id.StartsWith(textID)) Then Return "chamferedProfileCutter"
        If spotDrill.Any(Function(textID) id.StartsWith(textID)) Then Return "spotDrill"
        If drilTool.Any(Function(textID) id.StartsWith(textID)) Then Return "drilTool"

        Return "endMill"

    End Function

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

        If Main.debugMode <> True Then
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
        newTool.Type = CheckFraisaTypes(Me.RefTextBox.Text)
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

            Dim url As String = "https://fsa.salessupportserver.com/CIMDataService_3S-FSA/DownloadService.svc/web/GetExport?ExportType=din4000xml2016&OrderCode=" + itemCode
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


        Dim url As String = "https://webshop.fraisa.ch/index.php/fraeswerkzeuge?lng=" + My.Settings.PrefLang

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


