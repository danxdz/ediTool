Option Explicit On
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel          ' EXCEL APPLICATION.



Public Class NewBD
    Private Sub Validate_bt_Click(sender As Object, e As EventArgs) Handles valider_bt.Click

    End Sub

    ' CREATE EXCEL OBJECTS.
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet



    Private Sub ReadExcel(ByVal sFile As String)
        Dim TempData() As String


        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Open(sFile)            ' WORKBOOK TO OPEN THE EXCEL FILE.
        xlWorkSheet = xlWorkBook.Worksheets("Sheet1")       ' NAME OF THE WORK SHEET.

        Dim iRow As Integer
        For iRow = 1 To xlWorkSheet.Columns.Count
            If Trim(xlWorkSheet.Cells(2, iRow).value) = "" Then
                Exit For        ' BAIL OUT IF REACHED THE LAST ROW.
            Else
                ' POPULATE COMBO BOX.

                'nom_cb.Items.Add(xlWorkSheet.Cells(2, iRow).value)
                TempData.Append(xlWorkSheet.Cells(2, iRow).value.ToString)

                'cmbEmp.Items.Add(xlWorkSheet.Cells(iRow, 1).value)
            End If
        Next
        'Main.DataGridView1.DataSource = TempData
        nom_cb.Items.AddRange(TempData)

        xlWorkBook.Close() : xlApp.Quit()

        ' CLEAN UP. (CLOSE INSTANCES OF EXCEL OBJECTS.)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
    End Sub

    Private Sub Open_file_bt_Click(sender As Object, e As EventArgs) Handles open_file_bt.Click
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

    Private Sub Nom_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nom_cb.SelectedIndexChanged
        Dim temp As String = nom_cb.SelectedItem.ToString
        nom_cb.Items.Remove(temp)
    End Sub
End Class