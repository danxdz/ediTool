Option Explicit On
Imports System.IO
Imports System.Net
Imports System.Xml
Imports editool.Tools
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Module FileImports

    Dim StartLoadTimer As Date
    Dim EndLoadTimer As Date

    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Public Function Fill_newTool(d1 As String, d2 As String, d3 As String, l1 As String, l2 As String, l3 As String, nott As String, type As String, groupeMat As String,
                            Rbout As String, chanfrein As String, coupeCentre As String, arrCentre As String, typeTar As String, pasTar As String, manuf As String,
                            manufRef As String, manufRefSec As String, code As String, codeBar As String)
        Dim newtool As New NewTool

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
            .RayonBout = Rbout
            .Chanfrein = chanfrein
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
                Main.OL_textbox.Text = val
            Case "cuttingEdges"
                Main.NoTT.Text = val

            Case "cuttingLength"
                Main.L_textbox.Text = val
            Case "toolShaftDiameter"
                Main.SD_textbox.Text = val
            Case "toolDiameter"
                Main.D_textbox.Text = val
            Case "taperHeight"
                Main.CTS_AL_textbox.Text = val
            Case "tipDiameter"
                Main.CTS_AD_textbox.Text = val
            Case "toolTotalLength"
                Main.OL_textbox.Text = val
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

        Dim newTool As New NewTool

        Main.NewToolDataGridView.DataSource = ""
        Main.NewToolDataGridView.Columns.Clear()

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
                        Main.OL_textbox.Text = val
                        newTool.L3 = val
                    Case "cuttingEdges"
                        Main.NoTT.Text = val
                        newTool.NoTT = val
                    Case "cuttingLength"
                        Main.L_textbox.Text = val
                        newTool.L1 = val

                    Case "toolShaftDiameter"
                        Main.SD_textbox.Text = val
                        newTool.D3 = val
                    Case "toolDiameter"
                        Main.D_textbox.Text = val
                        Main.CTS_AD_textbox.Text = val - 0.2

                        newTool.D1 = val
                        newTool.D2 = val - 0.2

                    Case "taperHeight"
                        Main.CTS_AL_textbox.Text = val
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
                FillDataGrid(newTool, Main.NewToolDataGridView)
                Main.toolsList.Tool.Clear()
                Main.filteredTools.Clear()

                'Dim sas As List(Of NewTool) = Main.toolsList.Tool

                Main.toolsList.Tool.Add(newTool, Main.NewToolDataGridView)

            End If
        End While

        Refresh_outil(newTool, Main.ToolPreview_PictureBox)

    End Sub

    Public Sub FillDataGrid(NewTool As NewTool, DGV As DataGridView)

        Dim tmpData = New System.Data.DataTable

        'If Main.toolsList.items.Count > 0 Then
        'tmpData = Main.toolsList.items

        ' End If

        Dim objList() As String = {"Name", "ref", "D", "SD", "CTS_AD", "OL", "L", "CTS_AL", "AngDeg", "NoTT", "chf", "manuf"}

        tmpData = SetDataGridColumnsTitle(objList, tmpData)

        With NewTool
            Dim row As New List(Of String) From {
            .Name,
            .ManufRef,
            .D1,
            .D3,
            .D2,
            .L3,
            .L1,
            .L2,
            .AngleDeg,
            .NoTT,
            .Chanfrein,
            .Manuf
        }

            tmpData.Rows.add(row.ToArray())
        End With

        DGV.DataSource = tmpData
        Refresh_outil(NewTool, Main.ToolPreview_PictureBox)
    End Sub

    Public Sub OpenXmlFile()
        Dim startPath As String = ""
        Dim myStream As Stream

        ' If My.Settings.lastPath <> "" Then
        'startPath = My.Settings.lastPath
        'My.Settings.Save()
        'End If

        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = startPath,
            .Filter = "XML files (*.xml)|*.xml;*.XML|TXT files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx|All files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try

                NewBD.DataGridView1.Columns.Clear()
                NewBD.DataGridView1.Rows.Clear()

                myStream = openFileDialog1.OpenFile()
                Dim fpath As String = openFileDialog1.FileName

                NewBD.path_TextBox.Text = fpath
                My.Settings.lastPath = fpath
                My.Settings.Save()

                If openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3) = "xml" Then
                    LoadXML(fpath)
                Else
                    ReadExcel(fpath)
                    NewBD.Show()

                End If

            Catch Ex As Exception
                MessageBox.Show("error: " & Ex.Message)
            End Try
        End If
    End Sub

    Public Sub ReadExcel(fpath As String)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(fpath)            ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = CType(xlApp.Sheets(1),
                    Worksheet)
        Dim iCol As Integer
        Dim iColCount As Integer = 0

        For iCol = 1 To xlWorkSheet.Columns.Count
            Try
                If Trim(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).value) = "" Then
                    Exit For        ' BAIL OUT IF REACHED THE LAST COL.
                Else
                    Dim col = New DataGridViewTextBoxColumn With {
                        .HeaderText = xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).value,
                        .SortMode = DataGridViewColumnSortMode.NotSortable
                    }
                    Dim colIndex As Integer = NewBD.DataGridView1.Columns.Add(col)        ' ADD A NEW COLUMN.
                    NewBD.nom_cb.Items.Add(xlWorkSheet.Cells(NewBD.Row_NumericUpDown.Value, iCol).value)

                    iColCount += 1

                End If
            Catch ex As Exception
                NewBD.Row_NumericUpDown.Value += 1
            End Try

        Next

        Dim list As New List(Of String)()
        ' ADD ROWS TO THE GRID.
        Dim iRow As Integer
        For iRow = 1 To xlWorkSheet.Rows.Count
            If Trim(xlWorkSheet.Cells(iRow, 1).value) = "" And Trim(xlWorkSheet.Cells(iRow, 2).value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                NewBD.DataGridView1.Rows.Add()
                Preload.toolCountLabel.Text += 1
                ' CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                For i As Integer = 1 To iColCount

                    Dim tmp_string As String = Replace(xlWorkSheet.Cells(iRow, i).value, ".", ",")
                    NewBD.DataGridView1.Rows(iRow - 1).Cells(i - 1).Value = tmp_string
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
        Dim newTool As New NewTool With {
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
            Main.D_textbox.Text = Int(d1)
        End If
        newTool.L1 = Replace(line(9), "Tool.UtilLength=", "")
        newTool.D2 = Replace(line(12), "Tool.DiamPoky=", "")
        newTool.L2 = Replace(line(10), "Tool.ZProg=", "")
        newTool.D3 = Replace(line(18), "Tool.LinkType=QC", "")
        newTool.L3 = Replace(line(19), "Tool.TotalLength=", "")
        newTool.NoTT = Replace(line(17), "Tool.NbCogs=", "")

    End Sub

    Private Sub Webtocsv(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        Dim DataTableOrderTools As New Data.DataTable

        Dim toolTypeFilter As String = My.Settings.ToolType

        Dim webcsv As WebBrowser = CType(sender, WebBrowser)

        Dim tblrows As HtmlElementCollection
        Dim tblcols As HtmlElementCollection
        Dim column As String

        Dim filterD1 As New List(Of Decimal)
        Dim filterL1 As New List(Of Decimal)
        Dim filterMat As New List(Of String)

        Dim row As New List(Of String)()
        With Main

            tblrows = webcsv.Document.GetElementById("tableTool").GetElementsByTagName("tr")
            .NewToolDataGridView.DataSource = Nothing
            'NewToolDataGridView.Columns.Clear()
            'NewToolDataGridView.Rows.Clear()
            Preload.toolCountLabel.Text = 0
            Dim objList As New List(Of String)
            tblcols = tblrows.Item(0).GetElementsByTagName("th")

            If tblcols.Count > 0 Then
                For x As Integer = 0 To tblcols.Count - 1
                    column = tblcols.Item(x).InnerHtml
                    column = Replace(column, "<br>", " ")

                    objList.Add(column)
                Next
            End If

            DataTableOrderTools = SetDataGridColumnsTitle(objList.ToArray, DataTableOrderTools)

            For r As Integer = 0 To tblrows.Count - 2
                tblcols = tblrows.Item(r).GetElementsByTagName("td")

                Dim stock As HtmlElementCollection

                Dim newTool = New NewTool
                Try
                    stock = tblcols.Item(0).GetElementsByTagName("strong")
                    Dim stockVal As Integer
                    If stock.Count > 0 Then
                        stockVal = stock(0).InnerHtml
                    Else
                        stockVal = 0
                    End If

                    'Get all tools
                    'If tblcols.Item(1).InnerHtml = toolTypeFilter Then   ' Or 1 = 1 Then
                    'ListBox1.Items.Add(tblcols.Item(2).InnerHtml & " - " & tblcols.Item(3).InnerHtml & " - " & tblcols.Item(4).InnerHtml & " - " & tblcols.Item(8).InnerHtml)

                    Preload.ToolCount()

                        With newTool
                            .Type = tblcols.Item(1).InnerHtml
                            .GroupeMat = tblcols.Item(2).InnerHtml
                            .d1 = tblcols.Item(3).InnerHtml
                            .d2 = tblcols.Item(3).InnerHtml - 0.2
                            .l1 = tblcols.Item(4).InnerHtml
                            If tblcols.Item(5).InnerHtml > 0 Then
                                .L2 = tblcols.Item(5).InnerHtml
                            Else
                                .L2 = newTool.L1
                            End If
                            .l3 = tblcols.Item(6).InnerHtml
                            .d3 = tblcols.Item(7).InnerHtml
                            .nott = tblcols.Item(8).InnerHtml
                            .RayonBout = tblcols.Item(9).InnerHtml
                            .Chanfrein = tblcols.Item(10).InnerHtml
                            .CoupeCentre = tblcols.Item(11).InnerHtml
                            .ArrCentre = tblcols.Item(12).InnerHtml
                            .TypeTar = tblcols.Item(13).InnerHtml
                            .PasTar = tblcols.Item(14).InnerHtml
                            .Manuf = tblcols.Item(15).InnerHtml
                            .ManufRef = tblcols.Item(16).InnerHtml
                            .ManufRefSec = Replace(tblcols.Item(17).InnerHtml, "    ", "")
                            '.Link = tblcols.Item(18).InnerHtml
                            .Code = tblcols.Item(21).InnerHtml
                            .CodeBar = tblcols.Item(22).InnerHtml

                            Dim rowTmp() As String = {
                                stockVal,
                                .Type,
                                .GroupeMat,
                                .D1,
                                .L1,
                                .L2,
                                .L3,
                                .D3,
                                .NoTT,
                                .RayonBout,
                                .Chanfrein,
                                .CoupeCentre,
                                .ArrCentre,
                                .TypeTar,
                                .PasTar,
                                .Manuf,
                                .ManufRef,
                                .ManufRefSec,
                                .Code,
                                .CodeBar
                            }

                            DataTableOrderTools.Rows.Add(rowTmp)

                        End With

                        filterD1 = AddFiltersCombobox(newTool.d1, filterD1)
                        filterL1 = AddFiltersCombobox(newTool.l1, filterL1)
                        filterMat = AddFiltersStringCombobox(newTool.GroupeMat, filterMat)
                        .toolsList.Tool.Add(newTool)
                    'FileImports.FillDataGrid(newTool, NewToolDataGridView)
                    ' End If

                Catch ex As Exception
                    'MsgBox("cant read tool")
                End Try
            Next

            Dim toolTypes As List(Of String) = ToolList.GetToolsTypes(.toolsList)
            .NewToolDataGridView.DataSource = DataTableOrderTools

            filterD1 = filterD1.OrderBy(Function(x) x).ToList()
            With .filterD1_Combobox
                .DataSource = filterD1
            End With
            filterL1 = filterL1.OrderBy(Function(x) x).ToList()
            With .filterL1_ComboBox
                .DataSource = filterL1
            End With
            filterMat = filterMat.OrderBy(Function(x) x).ToList()
            With .filterMat_ComboBox
                .DataSource = filterMat
            End With

            EndLoadTimer = Now().ToUniversalTime

            .timer_label.Text = DateDiff(DateInterval.Second, StartLoadTimer, EndLoadTimer)
        End With

    End Sub

    Private Sub OrderAndSetComboBoxDataSource(list As List(Of String), combobox As ComboBox)
        list = list.OrderBy(Function(x) x).ToList()
        With combobox
            .DataSource = list
        End With
    End Sub

    Public Sub GetOrderTools()
        StartLoadTimer = Now().ToUniversalTime

        'My.Settings.DefManuf = ""
        'My.Settings.Save()

        With Main
            .filterD1_Combobox.DataSource = Nothing
            .filterD1_Combobox.Items.Clear()
            .filterL1_ComboBox.DataSource = Nothing
            .filterL1_ComboBox.Items.Clear()
            .filterMat_ComboBox.DataSource = Nothing
            .filterMat_ComboBox.Items.Clear()

            'toolsList.tool.clear()

            .timer_label.Text = Now().ToUniversalTime
        End With

        Dim web As New WebBrowser
        AddHandler web.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf Webtocsv)

        Dim url As String = "http://tools.semmip.loca/"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "HEAD"
        Try
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            MessageBox.Show("Connected to " & url)
            response.Close()
        Catch ex As WebException
            'MessageBox.Show("Failed to connect to OrderTools") ' " & url)
            Main.OrderTools_ToolStripButton.Enabled = False
            If File.Exists("C:\Downloaded Web Sites\tools.semmip.local\index.php.html") Then
                ' O arquivo existe, pode carregá-lo no controle WebBrowser
                web.Navigate(New Uri("C:\Downloaded Web Sites\tools.semmip.local\index.php.html"))

            Else
                web.Navigate(New Uri("C:\Users\user\Downloads\tools.semmip.local\tools.semmip.local\index.php.html"))
            End If

            Console.WriteLine("web: ", web)
        End Try
    End Sub

End Module