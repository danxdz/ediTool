Option Explicit On
Imports System.IO
Imports System.Xml
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Module FileImports
    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Public Sub PopulateFilters(ByVal filterList As List(Of Decimal), ByVal comboBox As ComboBox)
        filterList = filterList.OrderBy(Function(x) x).ToList()
        With comboBox
            .DataSource = filterList
        End With
    End Sub


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


    Private Sub Fill_HM_XML(name As String, val As String, type As String)
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
                Main.D_textBox.Text = val
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
                        Main.D_textBox.Text = val
                        Main.CTS_AD_TextBox.Text = val - 0.2

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


                End Select
            ElseIf (reader.Name = "tecsets") Then
                reader.Close()
                FillDataGrid(newTool, Main.NewToolDataGridView)
                Main.toolsList.Tool.Clear()
                Main.filteredTools.Clear()

                Dim sas As List(Of NewTool) = Main.toolsList.Tool

                Main.toolsList.Tool.Add(newTool)

            End If
        End While


        ' End While
        Refresh_outil(newTool)

    End Sub

    Public Sub FillDataGrid(NewTool As NewTool, DGV As DataGridView)

        Dim tmpData = New System.Data.DataTable

        'If Main.toolsList.items.Count > 0 Then
        'tmpData = Main.toolsList.items

        ' End If

        Dim objList() As String = {"ref", "D", "SD", "CTS_AD", "OL", "L", "CTS_AL", "AngDeg", "NoTT", "chf", "manuf"}

        tmpData = SetDataGridColumnsTitle(objList, tmpData)

        With NewTool
            Dim row As New List(Of String) From {
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
        Main.NewToolDataGridView.DataSource = tmpData
        Refresh_outil(NewTool)
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
            .Filter = "XML files (*.xml)|*.xml|Txt files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx|All files (*.*)|*.*",
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
                Main.readToolProgress_Label.Text += 1
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
        Dim newTool As New NewTool
        newTool.Type = type

        name = line(2)

        newTool.GSName = name

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
End Module