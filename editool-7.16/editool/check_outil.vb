Friend Module check_outil

    Public Sub Outil_exists(file_reader As System.IO.StreamReader, nom As String)

        Dim index As Integer = 1
        Dim textline As String = ""

        Do While file_reader.Peek <> -1
            textline = file_reader.ReadLine()
            If textline = nom Then
                Dim result As Integer = MessageBox.Show("Outil existant", "Outil existant", MessageBoxButtons.OK)
                If result = 1 Then
                    file_reader.Close()
                    Exit Sub
                End If
            End If
            index += 1
        Loop

        file_reader.Close()

        Dim path As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        path = New Uri(path).LocalPath

        Dim file_path As String = path + "\" + "reg.txt"

        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(file_path, True)

        file.WriteLine(nom)
        file.Close()
        'Create_outil()

    End Sub

End Module
