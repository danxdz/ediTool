Option Explicit On
Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Runtime.Remoting
Imports System.Text
Imports System.Xml
Imports System.Xml.Schema
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
                Main.manuf_TextBox.Text = val
            Case "manufacturer"
                Main.manref_TextBox.Text = val
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

    Private Sub Fill_Fraisa_XML(name As String, val As String)
        Select Case name
            Case "orderingCode"
                Main.manuf_TextBox.Text = val
            Case "manufacturer"
                Main.manref_TextBox.Text = val
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



    Private Sub LoadXML(path As String)

        Dim Xml_type As Integer = 0 '1= Hypermill | 2= Fraisa
        Dim last_name As String = ""
        Dim val As String = ""

        Dim reader As New XmlTextReader(path)
        While reader.Read()
            Dim count As Integer = reader.AttributeCount()
            Dim hash As Integer = reader.GetHashCode()

            If XmlNodeType.Element And reader.Name <> "" Then

                If reader.Name = "tecsets" Then
                    reader.Close()
                End If
                If Xml_type = 0 Then
                    If reader.Name = "omtdx" Then
                        Xml_type = "1"
                    ElseIf reader.Name = "Tool-Data" Then
                        Xml_type = "2"
                    End If
                End If

                Dim name As String = reader.Name
                val = reader.Value

                If Xml_type = 1 Then

                    Dim col = New DataGridViewTextBoxColumn With {
                            .HeaderText = "<" + reader.Name & ">",
                            .SortMode = DataGridViewColumnSortMode.NotSortable
                        }
                    Dim colIndex As Integer = NewBD.DataGridView1.Columns.Add(col)

                    Dim type As String = reader.GetAttribute("type")

                    If name <> "" Then

                        Fill_HM_XML(name, val, type)
                    End If
                Else
                    If name <> "" And val <> "" Then
                        Fill_Fraisa_XML(name, val)
                    Else
                        If last_name <> name Or last_name <> "PropertyName" Then
                            last_name = name
                        Else
                            last_name = ""
                        End If
                    End If
                End If

            Else
                If XmlNodeType.Text And last_name <> "" Then
                    If last_name = "PropertyName" Then
                        last_name = reader.Value
                    Else
                        val = reader.Value
                        Fill_Fraisa_XML(last_name, val)
                    End If
                End If
                End If
        End While
    End Sub
    Public Sub OpenFile()
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "c:\",
            .Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*|CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try


                NewBD.DataGridView1.Columns.Clear()
                NewBD.DataGridView1.Rows.Clear()

                '' myStream = openFileDialog1.OpenFile()
                Dim fpath As String = openFileDialog1.FileName

                NewBD.path_TextBox.Text = fpath

                '<contact>
                '<name>Patrick Hines</name>
                '<phone type = "home" > 206 - 555 - 144</phone>
                '<phone type = "work" > 425 - 555 - 145</phone>
                '</contact>

                If openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3) = "xml" Then
                    LoadXML(fpath)
                Else
                    ReadExcel(fpath)
                End If
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
