Option Explicit On
Imports System.IO
Imports System.Text

Public Class ELEM
    Public Property Name As String
    Public Property Type As String
    Public Property D1 As String
    Public Property D2 As String
    Public Property D3 As String
    Public Property L1 As String
    Public Property L2 As String
    Public Property L3 As String
    Public Property RayonBout As String
    Public Property Chanfrein As String
    Public Property AngleDeg As String

End Class

Module ImportV6

    Public Sub OpenV6File()
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog With {
            .InitialDirectory = "C:\Missler\Config\DataBase\Tools\french",
            .Filter = "All files (*.*)|*.*|Txt files (*.txt)|*.txt",
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




End Module
