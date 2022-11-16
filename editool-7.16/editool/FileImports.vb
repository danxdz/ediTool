Option Explicit On
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel          ' EXCEL APPLICATION.

Module FileImports
    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    Public Sub OpenFile()
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "c:\",
            .Filter = "Txt files (*.xlsx)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                '' myStream = openFileDialog1.OpenFile()
                Dim fpath As String = openFileDialog1.FileName


                ReadExcel(fpath)
                NewBD.Show()

                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub

    Public Sub ReadExcel(ByVal sFile As String)
        Dim TempData As New DataTable
        'TempData = SetNewDataTable(TempData)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(sFile)            ' WORKBOOK TO OPEN THE EXCEL FILE.

        Try
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")       ' NAME OF THE WORK SHEET.
        Catch ex As Exception
            Try
                xlWorkSheet = xlWorkBook.Worksheets("Feuille 1")       ' NAME OF THE WORK SHEET.
            Catch exs As Exception
            End Try
        End Try

        Dim iRow As Integer
        Dim iCol As Integer
        Dim combos As New DataGridViewComboBoxColumn With {
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
            .DisplayStyleForCurrentCellOnly = True
        }

        combos.Items.AddRange(Drawing.Color.Red, Drawing.Color.Yellow, Drawing.Color.Green, Drawing.Color.Blue)
        combos.ValueType = GetType(Drawing.Color)
        'TempData.Columns.Add(xlWorkSheet.Cells(1, 1).value)
        NewBD.DataGridView1.Columns.Add(combos)
        For iCol = 1 To xlWorkSheet.Columns.Count
            If Trim(xlWorkSheet.Cells(1, iCol).value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                ' POPULATE COMBO BOX.
                TempData.Columns.Add(xlWorkSheet.Cells(1, iCol).value)

            End If
        Next



        For iRow = 2 To xlWorkSheet.Rows.Count
            If Trim(xlWorkSheet.Cells(iRow, 1).value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                ' POPULATE COMBO BOX.

                NewBD.nom_cb.Items.Add(xlWorkSheet.Cells(iRow, 1).value)

                TempData.Rows.Add(xlWorkSheet.Cells(iRow, 1).value)
                'cmbEmp.Items.Add(xlWorkSheet.Cells(iRow, 1).value)
            End If
        Next
        NewBD.DataGridView1.DataSource = TempData


        xlWorkBook.Close() : xlApp.Quit()

        ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
    End Sub

End Module
