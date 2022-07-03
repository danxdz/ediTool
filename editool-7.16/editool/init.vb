Module outils_base
    Dim dt As DataTable
    Public Sub set_filter()
        Dim dv As DataView = New DataView(dt)
        Dim str_tmp As String

        If Main.TextBox10.Text = "" Then
            str_tmp = "Reference LIKE '%" + Main.TextBox9.Text + "%'"
        ElseIf Main.TextBox9.Text = "" Then
            str_tmp = "d1 LIKE '%" + Main.TextBox10.Text + "%'"
        Else
            str_tmp = "Reference LIKE '%" + Main.TextBox9.Text + "%' AND d1 like '%" + Main.TextBox10.Text + "%'"
        End If
        dt.DefaultView.RowFilter = str_tmp
    End Sub
    Public Sub Set_Name_auto()
        Try
            'If L2.Text = "" Or L2.Text = "0" Then
            Main.Name_textbox.Text = "FR Ø" + Main.d1.Text + " " + Main.NoTT.Text + "z" ' nome =  FR Ø + diamètre de coupe + numero d dents
            If Main.L2.Text <> "" And Main.L2.Text <> "0" Then
                Main.Name_textbox.Text += " Lc" + Main.L2.Text ' nome += Longueur de coupe
            End If
            If Main.L3.Text <> "" And Main.L3.Text <> "0" Then
                Main.Name_textbox.Text += " Lu" + Main.L3.Text ' nome += Longueur util
            End If
            design()
        Catch ex As Exception
            '  MsgBox("SET NAME AUTO - " + ex.ToString)

        End Try
    End Sub

    Public Sub Set_grid()
        dt = New DataTable

        'dt.Columns.Add("index", GetType(String))            ' --------> option to add index to DataGridView1
        dt.Columns.Add("Reference", GetType(String))
        dt.Columns.Add("d1", GetType(String))
        dt.Columns.Add("d2", GetType(String))
        dt.Columns.Add("d3", GetType(String))
        dt.Columns.Add("l1", GetType(String))
        dt.Columns.Add("l2", GetType(String))
        dt.Columns.Add("l3", GetType(String))
        dt.Columns.Add("a", GetType(String))
        dt.Columns.Add("z", GetType(String))
        dt.Columns.Add("chf", GetType(String))

    End Sub


    Public Sub Get_prefs(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        Dim pref_lang As String = Right(splitLine(0), 2)


        Main.sel_lang.Text = pref_lang



    End Sub
    Public Sub Get_files(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim labels() As Label = {
            Main.menu_1, Main.menu_2, Main.menu_3, Main.menu_4,
            Main.menu_5, Main.menu_6, Main.menu_7, Main.menu_8,
            Main.menu_9, Main.menu_10, Main.menu_11, Main.menu_12}

        For i As Integer = 0 To 11
            labels(i).Text = splitLine(i)
        Next

        Main.create.Text = splitLine(12)

    End Sub

    Public Sub get_outils(data As String, filter As String)
        Dim full_file() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim single_line As String
        Dim line() As String


        For i As Integer = 0 To full_file.Length - 1
            single_line = full_file(i)
            line = Split(single_line, ";")

            If filter = "" Then
                dt.Rows.Add(line)
            Else
                Dim tmp As String = Strings.Left(line(0), filter.Length)
                If filter = tmp Then
                    dt.Rows.Add(line)
                End If
            End If


        Next
        Main.DataGridView1.DataSource = dt


    End Sub






    Public Sub Fill_db(file_reader As System.IO.StreamReader, filter As String)
        Dim index As Integer = 1
        Dim textline As String = ""
        Dim splitLine() As String

        Do While file_reader.Peek <> -1
            textline = file_reader.ReadLine()
            splitLine = Split(textline, ";")

            'Dim list As New List(Of String)()             --------------> option to add index to DataGridView1
            ' List.Add(index)
            'For l = 0 To splitLine.Length - 1
            'List.Add(splitLine(l))
            'Next
            'ReDim splitLine(9)
            'For x = 0 To list.Count - 1
            'splitLine(x) = list.Item(x)
            'Next


            If filter = "" Then
                dt.Rows.Add(splitLine)
            Else
                Dim tmp As String = Strings.Left(splitLine(0), filter.Length)
                If filter = tmp Then
                    dt.Rows.Add(splitLine)
                End If
            End If
            index += 1
        Loop
        Main.DataGridView1.DataSource = dt
        file_reader.Close()
    End Sub

End Module
