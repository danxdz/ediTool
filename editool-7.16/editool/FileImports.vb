Option Explicit On
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Runtime.Remoting
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
Imports editool.Tools
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Color = System.Drawing.Color
Imports XmlSchema = System.Xml.Schema.XmlSchema

Module FileImports
    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Private Sub Fill_HM_XML(name As String, val As String, type As String)
        Select Case name
            Case "orderingCode"
                Main.manref_TextBox.Text = val
            Case "manufacturer"
                Main.manuf_TextBox.Text = val
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
                        Main.manuf_TextBox.Text = val
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
                        newTool.D1 = val

                    Case "taperHeight"
                        Main.CTS_AL_textbox.Text = val
                        newTool.L2 = val '???? not sure

                    Case "tipDiameter"
                        Main.CTS_AD_textbox.Text = val

                        'plungeAngle
                        'tipDiameter
                        'cornerRadius

                End Select
            ElseIf (reader.Name = "tecsets") Then
                reader.Close()
                FillDataGrid(newTool, Main.NewToolDataGridView)
                Main.toolsList.items.Add(newTool)

            End If
        End While


        ' End While
        Refresh_outil()

    End Sub

    Private Sub FillDataGrid(NewTool As NewTool, DGV As DataGridView)

        Dim objList As New List(Of String)({"ref", "D", "CTS_AD", "SD", "L", "CTS_AL", "OL", "NoTT", "chf", "manuf"})

        Dim rowIndex As Integer

        If DGV.Rows.Count = 0 Then
            For i As Integer = 0 To objList.Count - 1

                Dim col = New DataGridViewTextBoxColumn With {
                            .HeaderText = objList(i),
                            .SortMode = DataGridViewColumnSortMode.NotSortable
                        }
                Dim colIndex As Integer = DGV.Columns.Add(col)
            Next
            rowIndex = DGV.Rows.Count - 1
        Else
            rowIndex = DGV.Rows.Count - 1
        End If

        Dim row As New List(Of String) From {
            NewTool.ManufRef,
            NewTool.D1,
            NewTool.D2,
            NewTool.D3,
            NewTool.L1,
            NewTool.L2,
            NewTool.L3,
            NewTool.NoTT,
            NewTool.Chanfrein,
            NewTool.Manuf
        }

        DGV.Rows.Insert(0, row.ToArray())

    End Sub

    Public Sub OpenFile()
        Dim startPath As String = ""
        Dim myStream As Stream

        ' If My.Settings.lastPath <> "" Then
        'startPath = My.Settings.lastPath
        'My.Settings.Save()
        'End If

        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = startPath,
            .Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx",
            .FilterIndex = 2,
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




End Module