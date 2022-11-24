Option Explicit On
Imports System.Data.Common
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Color = System.Drawing.Color

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

                NewBD.path_TextBox.Text = fpath



                ReadExcel(fpath)
                NewBD.Show()

                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                End If
            Catch Ex As Exception
                MessageBox.Show("error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If
    End Sub



    Public Sub ReadExcel(fpath As String)

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(fpath)            ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = CType(xlApp.Sheets(1),
                    Worksheet)

        NewBD.DataGridView1.Columns.Clear()
        NewBD.DataGridView1.Rows.Clear()

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
            If Trim(xlWorkSheet.Cells(iRow, 1).value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                NewBD.DataGridView1.Rows.Add()
                Main.readToolProgress_Label.Text += 1
                ' CREATE A STRING ARRAY USING THE VALUES IN EACH ROW OF THE SHEET.
                For i As Integer = 1 To xlWorkSheet.Columns.Count ' iColCount
                    If i > iColCount Then
                        If Trim(xlWorkSheet.Cells(iRow + 1, i).value) = "" Then
                            Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
                        End If
                    Else

                        Dim tmp_string As String = Replace(xlWorkSheet.Cells(iRow + 1, i).value, ".", ",")
                        NewBD.DataGridView1.Rows(iRow - 1).Cells(i - 1).Value = tmp_string
                    End If

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
