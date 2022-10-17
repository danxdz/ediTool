
Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class Main


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim file_reader As IO.StreamReader

        Set_grid()
        Try

            Dim path As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

            path = New Uri(path).LocalPath

            Dim csvFile As String = path + "\config" 'My.Application.Info.DirectoryPath & "\config.json"
            Try
                Dim outFile As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(csvFile)
                Dim data As String = outFile.ReadToEnd()
                outFile.Close()
                Get_prefs(data)
            Catch
                MsgBox("new config file")
                Set_pref_lang("fr")
            End Try


            If Me.sel_lang.Text = "en" Then
                Get_files(My.Resources.menu_en)

            Else
                Get_files(My.Resources.menu_fr)


            End If


        Catch ex As Exception
            MsgBox("no config file   -->" & ex.ToString)
            Close()
            End
        End Try
        Try
            get_outils(My.Resources.outils, "")
            Set_Name_auto()
        Catch ex As Exception
            MsgBox("no db file    -->" & ex.ToString)
            Close()
            End
        End Try
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        set_filter()
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        set_filter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles create.Click

        Create_outil()

        'REG CREATED TOOLS
        'Dim file_reader As IO.StreamReader
        'file_reader = Open_data_file("reg.txt")
        'Outil_exists(file_reader, Name_textbox.Text)

    End Sub

    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim ds() As TextBox = {D_textbox, SD_textbox, CTS_AD_textbox, OL_textbox, L_textbox, CTS_AL_textbox, alpha, NoTT}
        Try
            For i As Short = 1 To 8
                ds(i - 1).Text = DataGridView1.SelectedCells(i).Value
            Next
            Refresh_outil()
        Catch ex As Exception
            ' MsgBox("CELL CHANGED - " + ex.ToString)
        End Try

    End Sub

    Private Sub Refresh_outil()
        design()
        Set_Name_auto()
    End Sub

    Private Sub D1_TextChanged(sender As Object, e As EventArgs) Handles D_textbox.TextChanged, SD_textbox.TextChanged, CTS_AD_textbox.TextChanged, OL_textbox.TextChanged, L_textbox.TextChanged, CTS_AL_textbox.TextChanged

    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D_textbox.KeyPress, SD_textbox.KeyPress, CTS_AD_textbox.KeyPress, OL_textbox.KeyPress, L_textbox.KeyPress, CTS_AL_textbox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles D_textbox.KeyPress, SD_textbox.KeyPress, CTS_AD_textbox.KeyPress, OL_textbox.KeyPress, L_textbox.KeyPress, CTS_AL_textbox.KeyPress
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Me.Text = digitsOnly.Replace(Me.Text, "")
    End Sub

    Private Sub NoTT_TextChanged(sender As Object, e As EventArgs) Handles NoTT.TextChanged

    End Sub

    Private Sub Lang_fr_Click(sender As Object, e As EventArgs) Handles lang_fr.Click

        Set_pref_lang("fr")

        Get_files(My.Resources.menu_fr)
    End Sub

    Private Sub Lang_en_Click(sender As Object, e As EventArgs) Handles lang_en.Click
        Set_pref_lang("en")
        Get_files(My.Resources.menu_en)
    End Sub
    Private Sub Set_pref_lang(lang As String)
        Dim path As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)

        path = New Uri(path).LocalPath

        Dim csvFile As String = path + "\config" 'My.Application.Info.DirectoryPath & "\config.json"

        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

        outFile.WriteLine("default_lang " + lang)
        outFile.Close()

        'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
    End Sub

    Private Sub CTS_AD_label_Click(sender As Object, e As EventArgs) Handles CTS_AD_label.Click

    End Sub
End Class
