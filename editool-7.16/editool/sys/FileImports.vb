Option Explicit On

Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices.ComTypes
Imports System.Text.RegularExpressions
Imports System.Xml
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Module FileImports


    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Public Function Fill_newTool(d1 As String, d2 As String, d3 As String, l1 As String, l2 As String, l3 As String, nott As String, type As String, groupeMat As String,
                            Rbout As String, chanfrein As String, coupeCentre As String, arrCentre As String, typeTar As String, pasTar As String, manuf As String,
                            manufRef As String, manufRefSec As String, code As String, codeBar As String)
        Dim newtool As New Tool

        With newtool
            .D1 = d1
            .D2 = d1 - 0.2
            .D3 = d3
            .L1 = l1
            If l2 > 0 Then
                .L2 = l2
            Else
                .L2 = l1
            End If
            .L3 = l3
            .NoTT = nott
            .Type = type
            .GroupeMat = groupeMat
            .CorRadius = Rbout
            .CorChamfer = chanfrein
            .CoupeCentre = coupeCentre
            .ArrCentre = arrCentre
            .TypeTar = typeTar
            .PasTar = pasTar
            .Manuf = manuf
            .ManufRef = manufRef
            .ManufRefSec = Replace(manufRefSec, "    ", "")
            '.Link = tblcols.Item(18).InnerHtml
            .Code = code
            .CodeBar = codeBar
        End With
        Return newtool
    End Function

    Private Sub Fill_HM_XML(name As String, val As String)
        Select Case name
            Case "orderingCode"
                Main.manref_TextBox.Text = val
            Case "manufacturer"
                Main.manuf_comboBox.Text = val
            Case "toolTotalLength"
                Main.L3textBox.Text = val
            Case "cuttingEdges"
                Main.NoTT.Text = val

            Case "cuttingLength"
                Main.L1textBox.Text = val
            Case "toolShaftDiameter"
                Main.D3textBox.Text = val
            Case "toolDiameter"
                Main.D1textBox.Text = val
            Case "taperHeight"
                Main.L2textBox.Text = val
            Case "tipDiameter"
                Main.D2textBox.Text = val
            Case "toolTotalLength"
                Main.L3textBox.Text = val
        End Select
    End Sub

    Private Function FindTool(reader As XmlTextReader)
        While reader.Read()
            If reader.Name = "tools" Then
                Return reader
            End If
        End While
        Return reader
    End Function
    Private Sub LoadXML(path As String)

        Dim newTool As New Tool

        'Main.NewToolDataGridView.DataSource = ""
        ' Main.NewToolDataGridView.Columns.Clear()

        Dim reader As New XmlTextReader(path)
        FindTool(reader)
        While reader.Read()
            If reader.Name = "param" Then
                Dim val1 = reader.Value
                Dim type As String = reader.GetAttribute("type")
                Dim name As String = reader.GetAttribute("name")
                Dim val As String = reader.GetAttribute("value")

                Select Case name
                    Case "orderingCode"
                        Main.manref_TextBox.Text = val
                        newTool.ManufRef = val
                    Case "manufacturer"
                        Main.manuf_comboBox.Text = val
                        newTool.Manuf = val
                    Case "toolTotalLength"
                        Main.L3textBox.Text = val
                        newTool.L3 = val
                    Case "cuttingEdges"
                        Main.NoTT.Text = val
                        newTool.NoTT = val
                    Case "cuttingLength"
                        Main.L1textBox.Text = val
                        newTool.L1 = val

                    Case "toolShaftDiameter"
                        Main.D3textBox.Text = val
                        newTool.D3 = val
                    Case "toolDiameter"
                        Main.D1textBox.Text = val
                        Main.D2textBox.Text = val - 0.2

                        newTool.D1 = val
                        newTool.D2 = val - 0.2
                    Case "taperHeight"
                        Main.L2textBox.Text = val
                        If val <> 0 Then
                            newTool.L2 = val '???? not sure
                        Else
                            newTool.L2 = newTool.L2
                        End If

                    Case "tipDiameter"
                        'Main.CTS_AD_textbox.Text = val

                        'plungeAngle
                    Case "cornerRadius"
                        Main.Chf_textbox.Text = val
                    Case "cuttingMaterial"
                        newTool.Type = val
                End Select
            ElseIf (reader.Name = "tecsets") Then
                reader.Close()
                Main.TabControl1.TabIndex = 3
                FillDataGrid(newTool, Main.DataGridView1)
                'Main.fullToolsList.Clear()
                'Main.filteredTools.Clear()

                'Dim sas As List(Of NewTool) = Main.toolsList.Tool

                Main.localtools.Add(newTool) ', Main.NewToolDataGridView)

            End If
        End While
        If newTool.D1 = 0 Then
            ImportFSA.ExtractXMLData(path)
        End If
        Main.ImportTabPage.Show()

        Refresh_outil(newTool, Main.ToolPreview_PictureBox)
    End Sub

    Public Sub FillDataGrid(NewTool As Tool, DGV As DataGridView)
        Dim objProperties() As String = {"GroupeMat", "ManufRef", "D1", "L1", "NoTT"}
        Dim tmpData As Data.DataTable
        If DGV.Columns.Count <> 0 Then
            tmpData = DGV.DataSource
        Else
            tmpData = New Data.DataTable()
        End If

        If tmpData.Columns.Count = 0 Then
            tmpData.Columns.Add("GroupeMat")
            tmpData.Columns.Add("ManufRef")
            tmpData.Columns.Add("D1", GetType(Double)) 'Definir coluna D1 como Double
            tmpData.Columns.Add("L1", GetType(Double)) 'Definir coluna L1 como Double
            tmpData.Columns.Add("NoTT", GetType(Integer)) 'Definir coluna NoTT como Integer
        End If


        Dim row As DataRow = tmpData.NewRow()
        row("GroupeMat") = NewTool.GroupeMat
        row("ManufRef") = NewTool.ManufRef
        row("D1") = Double.Parse(NewTool.D1)
        row("L1") = Double.Parse(NewTool.L1)
        row("NoTT") = Integer.Parse(NewTool.NoTT)
        tmpData.Rows.Add(row)

        DGV.DataSource = tmpData
        Refresh_outil(NewTool, Main.ToolPreview_PictureBox)
    End Sub

    Public Function OpenFilesByType() As String
        'filters to Open files by types
        Dim filter As String = "All files (*.*)|*.*|XML files (*.xml)|*.xml;*.XML|TXT files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx"

        Dim myStream As Stream
        Dim startPath As String = ""


        Dim openFileDialog As New OpenFileDialog With {
            .InitialDirectory = startPath,
            .Filter = filter,
            .FilterIndex = 1,
            .RestoreDirectory = True
        }
        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog.OpenFile()
                Dim fpath As String = openFileDialog.FileName

                NewBD.path_TextBox.Text = fpath
                My.Settings.lastPath = fpath
                My.Settings.Save()

                Dim fExtension As String = openFileDialog.FileName.Substring(openFileDialog.FileName.Length - 3)

                If fExtension = "xml" Then
                    LoadXML(fpath)
                ElseIf fExtension = "lsx" Then
                    LoadExcel(fpath)

                End If

            Catch Ex As Exception
                MessageBox.Show("error: " & Ex.Message)
            End Try
        End If
    End Function

    Public Sub LoadExcel(fpath)
        NewBD.DataGridView1.DataSource = Nothing
        NewBD.DataGridView1.Columns.Clear()
        NewBD.DataGridView1.Rows.Clear()
        NewBD.Show()



        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim ExcelDataSet As System.Data.DataSet
        Dim ExcelAdapter As System.Data.OleDb.OleDbDataAdapter

        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + fpath + ";Extended Properties=Excel 12.0;")
        Try
            ExcelAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            ExcelAdapter.TableMappings.Add("Table", "Excel Data")
            ExcelDataSet = New System.Data.DataSet
            ExcelAdapter.Fill(ExcelDataSet)
            NewBD.DataGridView1.DataSource = ExcelDataSet.Tables(0)
            MyConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString, "Importing Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Public Sub LoadExcel_old(fpath)

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing

        Try
            'Excel setup
            xlApp = New Excel.Application With {
                .ScreenUpdating = False,
                .DisplayAlerts = False
            }

            'Open file
            xlWorkBook = xlApp.Workbooks.Open(fpath)

            'Select worksheet
            xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

            'Read headers
            Dim headers As New List(Of String)()
            Dim colCount As Integer = xlWorkSheet.UsedRange.Columns.Count
            If NewBD.headers.Checked = True Then
                For i As Integer = 1 To colCount
                    Dim header As String = Trim(xlWorkSheet.Range(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, i), xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, i)).Value)
                    If String.IsNullOrEmpty(header) Then
                        Exit For
                    End If

                    headers.Add(header)

                    ' Adicionar nova coluna ao DataGridView
                    Dim column As New DataGridViewTextBoxColumn With {
                .HeaderText = header,
                .SortMode = DataGridViewColumnSortMode.NotSortable
            }

                    NewBD.DataGridView1.Columns.Add(column)
                    NewBD.ToolNameCb.Items.Add(header)
                Next

            End If


            ' Ler os dados
            Dim data As New List(Of List(Of String))()
            Dim rowCount As Integer = xlWorkSheet.UsedRange.Rows.Count
            For i As Integer = NewBD.Row_NumericUpDown.Value + 1 To NewBD.Row_NumericUpDown.Value + 10 'rowCount
                Dim rowData As New List(Of String)()

                For j As Integer = 1 To colCount
                    Dim cellValue As Object = xlWorkSheet.Range(xlWorkSheet.Cells(i, j), xlWorkSheet.Cells(i, j)).Value
                    Dim cellStringValue As String = ""
                    If cellValue IsNot Nothing Then
                        cellStringValue = cellValue.ToString()
                    End If

                    rowData.Add(cellStringValue)
                Next

                ' Adicionar a linha ao DataGridView

                NewBD.DataGridView1.Rows.Add(rowData.ToArray())

            Next

            NewBD.FillComboBoxes()

        Finally
            ' Limpar recursos do Excel
            If xlWorkSheet IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            End If

            If xlWorkBook IsNot Nothing Then
                xlWorkBook.Close(SaveChanges:=False)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            End If
        End Try
    End Sub



    Public Sub ReadExcel(fpath As String)



        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing

        Try
            'Excel setup
            xlApp = New Excel.Application
            xlApp.ScreenUpdating = False
            xlApp.DisplayAlerts = False

            'Open file
            xlWorkBook = xlApp.Workbooks.Open(fpath)

            'Select worksheet
            xlWorkSheet = CType(xlWorkBook.Sheets(1), Excel.Worksheet)

            'Read headers
            Dim headers As New List(Of String)()
            Dim colCount As Integer = xlWorkSheet.UsedRange.Columns.Count
            For i As Integer = 1 To colCount
                Dim header As String = Trim(xlWorkSheet.Range(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, i), xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, i)).Value)
                If String.IsNullOrEmpty(header) Then
                    Exit For
                End If

                headers.Add(header)

                ' Adicionar nova coluna ao DataGridView
                Dim column As New DataGridViewTextBoxColumn With {
            .HeaderText = header,
            .SortMode = DataGridViewColumnSortMode.NotSortable
        }

                NewBD.DataGridView1.Columns.Add(column)
                NewBD.ToolNameCb.Items.Add(header)
            Next


            ' Ler os dados
            Dim data As New List(Of List(Of String))()
            Dim rowCount As Integer = xlWorkSheet.UsedRange.Rows.Count
            For i As Integer = NewBD.Row_NumericUpDown.Value + 1 To 10 'rowCount
                Dim rowData As New List(Of String)()

                For j As Integer = 1 To colCount
                    Dim cellValue As Object = xlWorkSheet.Range(xlWorkSheet.Cells(i, j), xlWorkSheet.Cells(i, j)).Value

                    Dim cellStringValue As String = ""
                    If cellValue IsNot Nothing Then
                        cellStringValue = cellValue.ToString()
                    End If

                    rowData.Add(cellStringValue)
                Next

                ' Adicionar a linha ao DataGridView

                NewBD.DataGridView1.Rows.Add(rowData.ToArray())

            Next

            NewBD.FillComboBoxes()

        Finally
            ' Limpar recursos do Excel
            If xlWorkSheet IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            End If

            If xlWorkBook IsNot Nothing Then
                xlWorkBook.Close(SaveChanges:=False)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            End If
        End Try
    End Sub

    Public Sub ReadExcel_old(fpath As String)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(fpath)            ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = CType(xlApp.Sheets(NewBD.Row_NumericUpDown.Value), Worksheet)
        Dim iCol As Integer
        Dim iColCount As Integer = 0

        For iCol = 1 To xlWorkSheet.Columns.Count
            Try
                If Trim(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).Value) = "" Then
                    Exit For        ' BAIL OUT IF REACHED THE LAST COL.
                Else
                    Dim col = New DataGridViewTextBoxColumn With {
                        .HeaderText = xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).Value,
                        .SortMode = DataGridViewColumnSortMode.NotSortable
}
                    Dim colIndex As Integer = NewBD.DataGridView1.Columns.Add(col)        ' ADD A NEW COLUMN.
                    NewBD.ToolNameCb.Items.Add(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).Value)

                    iColCount += 1

                End If
            Catch ex As Exception
                NewBD.Row_NumericUpDown.Value += 1
            End Try

        Next

        Dim list As New List(Of String)()
        ' ADD ROWS TO THE GRID.
        Dim iRow As Integer
        For iRow = 1 To 10 ' xlWorkSheet.Rows.Count
            If Trim(xlWorkSheet.Cells(iRow, 1).Value) = "" And Trim(xlWorkSheet.Cells(iRow, 2).Value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                NewBD.DataGridView1.Rows.Add()
                Preload.toolCountLabel.Text += 1
                ' CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                For i As Integer = 1 To iColCount
                    If (xlWorkSheet.Cells(iRow, i).Value IsNot Nothing) Then
                        Dim tmp_string As String = Replace(xlWorkSheet.Cells(iRow, i).Value, ".", ",")
                        NewBD.DataGridView1.Rows(iRow - 1).Cells(i - 1).Value = tmp_string
                    End If
                    'End If

                    'list.Add(xlWorkSheet.Cells(iRow, i).value)
                Next
                ' NewBD.DataGridView1.Rows.Add(list)
                'NewBD.DataGridView1.Rows.Add(xlWorkSheet.Cells(iRow, iCol).value)
            End If

        Next

        xlWorkBook.Close() : xlApp.Quit()

        ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing

    End Sub

    Private Function IsInt(val As Integer)
        If Integer.TryParse(val, Nothing) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub GetV6Tool()
        'NewBD.DataGridView1.SelectedCells.Count '-> get selected rows number
        Dim Temp_row As String = NewBD.DataGridView1.CurrentCell.Value
        Dim line() As String
        Temp_row = Replace(Temp_row, ",", ".")
        Temp_row = Replace(Temp_row, "  ", "")
        line = Split(Temp_row, ";")

        Dim type, name, d1, d2, d3, l1, l2, l3, NoTT As String

        type = line(0)

        Select Case type
            Case "FR"
                type = "Side Mill D20 L35 SD20"
            Case "FT"
                type = "Radiused Mill D16 L40 r3 SD16"
            Case "FR_HEMI "
                type = "FB"
            Case "FP"
                type = "Spotting Drill D10 SD10"
            Case "FO"
                type = "Twisted Drill D10 L35 SD10"
            Case "AL"
                type = "Constant Reamer D10 L20 SD9"
        End Select

        My.Settings.ToolType = type

        My.Settings.Save()
        Dim newTool As New Tool With {
            .Type = type
        }

        name = line(2)

        newTool.Name = name

        Main.Name_textbox.Text = name

        d1 = Replace(line(8), "Tool.Diam=", "")
        l1 = Replace(line(9), "Tool.UtilLength=", "")
        d2 = Replace(line(12), "Tool.DiamPoky=", "")
        l2 = Replace(line(10), "Tool.ZProg=", "")
        d3 = Replace(line(18), "Tool.LinkType=QC", "")
        l3 = Replace(line(19), "Tool.TotalLength=", "")
        NoTT = Replace(line(17), "Tool.NbCogs=", "")

        If IsInt(d1) Then
            newTool.D1 = Int(d1)
            Main.D1textBox.Text = Int(d1)
        End If
        newTool.L1 = Replace(line(9), "Tool.UtilLength=", "")
        newTool.D2 = Replace(line(12), "Tool.DiamPoky=", "")
        newTool.L2 = Replace(line(10), "Tool.ZProg=", "")
        newTool.D3 = Replace(line(18), "Tool.LinkType=QC", "")
        newTool.L3 = Replace(line(19), "Tool.TotalLength=", "")
        newTool.NoTT = Replace(line(17), "Tool.NbCogs=", "")

    End Sub



    Public Sub ClearFilters()
        With Main
            .filterD1_Combobox.DataSource = Nothing
            .filterD1_Combobox.Items.Clear()
            .filterL1_ComboBox.DataSource = Nothing
            .filterL1_ComboBox.Items.Clear()
            .filterMat_ComboBox.DataSource = Nothing
            .filterMat_ComboBox.Items.Clear()
        End With
    End Sub
End Module