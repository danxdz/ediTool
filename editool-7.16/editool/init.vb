Module outils_base
    Dim dt As DataTable
    Public Sub set_filter()
        Dim dv As DataView = New DataView(dt)
        Dim str_tmp As String

        If Main.Diam_filter_TextBox.Text = "" Then
            str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%'"
        ElseIf Main.Ref_filter_TextBox.Text = "" Then

            str_tmp = "D LIKE '%" + Main.Diam_filter_TextBox.Text + "%'"
        Else
            str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%' AND D like '%" + Main.Diam_filter_TextBox.Text + "%'"
        End If
        dt.DefaultView.RowFilter = str_tmp
    End Sub
    Function Check_zero(param As String, value As String)
        ''Dim tmp_string As String = value
        ''tmp_string = Replace(tmp_string, ".", ",") ' replace , -> .
        ''Dim result As Double = tmp_string

        If param = "CTS_AL" And value = 0 Then
            Return Main.L_textbox.Text
        Else
            Return value
        End If
        If param = "CTS_AD" And value = 0 Then
            Return Main.D_textbox.Text
        Else
            Return value
        End If
    End Function
    Function Pick_param(param As String)
        Select Case param
            Case "D" : Return Main.D_textbox.Text
            Case "L" : Return Main.L_textbox.Text
            Case "OL" : Return Main.OL_textbox.Text
            Case "SD" : Return Main.SD_textbox.Text
            Case "CTS_AL" : Return Check_zero(param, Main.CTS_AL_textbox.Text)
            Case "CTS_AD" : Return Check_zero(param, Main.CTS_AD_textbox.Text)
            Case "NoTT" : Return Main.NoTT.Text
            Case "A" : Return Main.A_TextBox.Text
            Case "r" : Return Main.chf.Text
            Case Else
                MsgBox("no param found, check outil name mask config")
        End Select
    End Function
    Public Sub Set_Name_auto()

        If Main.ForceName_checkBox.Checked = False Then
            Try
                Dim Namemask As String = ToolName_config.Namemask_textbox.Text
                Dim ToolType = My.Settings.ToolType

                ''Dim temp As String = ToolType + " " + Namemask
                Dim temp As String = Namemask
                Dim formated As String = ""
                Dim tempL, res, code_temp As String

                For i As Integer = 0 To Namemask.Length
                    tempL = Left(temp, 1)
                    If tempL = "[" Then
                        If formated = "" Then
                            formated = Left(Namemask, i)
                        End If
                        code_temp = temp
                        For j As Integer = 0 To temp.Length

                            If Left(code_temp, 1) = "]" Then
                                Dim parameter_temp As String = Left(temp, j)
                                res = Right(parameter_temp, parameter_temp.Length - 1)
                                formated += Pick_param(res)
                                j = temp.Length
                            End If
                            code_temp = Right(code_temp, code_temp.Length - 1)

                        Next
                        temp = Right(code_temp, code_temp.Length)
                    Else
                        formated += tempL
                        If temp.Length > 0 Then
                            temp = Right(temp, temp.Length - 1)
                        Else
                            i = Namemask.Length

                        End If
                    End If

                Next

                'If L2.Text = "" Or L2.Text = "0" Then
                ''Main.Name_textbox.Text = "FR Ø" + Main.D_textbox.Text + " " + Main.NoTT.Text + "z" ' nome =  FR Ø + diamètre de coupe + numero d dents
                Main.Name_textbox.Text = formated
                ''If Main.L_textbox.Text <> "" And Main.L_textbox.Text <> "0" Then
                ''Main.Name_textbox.Text += " Lc" + Main.L_textbox.Text ' nome += Longueur de coupe
                ''End If
                ''If Main.CTS_AL_textbox.Text <> "" And Main.CTS_AL_textbox.Text <> "0" Then
                ''Main.Name_textbox.Text += " Lu" + Main.CTS_AL_textbox.Text ' nome += Longueur util
                ''
                design()
            Catch ex As Exception
                MsgBox("Name Mask Error - " + ex.ToString)

            End Try
        End If

    End Sub

    Public Sub Set_grid()
        dt = New DataTable

        'dt.Columns.Add("index", GetType(String))            ' --------> option to add index to DataGridView1
        dt.Columns.Add("Reference", GetType(String))
        dt.Columns.Add("D", GetType(String))
        dt.Columns.Add("SD", GetType(String))
        dt.Columns.Add("CTS_AD", GetType(String))
        dt.Columns.Add("OL", GetType(String))
        dt.Columns.Add("L", GetType(String))
        dt.Columns.Add("CTS_AL", GetType(String))
        dt.Columns.Add("a", GetType(String))
        dt.Columns.Add("z", GetType(String))
        dt.Columns.Add("chf", GetType(String))

    End Sub


    Public Sub Get_prefs(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        Dim pref_lang As String = Right(splitLine(0), 2)

    End Sub
    Public Sub Get_files(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim labels() As Label = {
            Main.menu_1, Main.menu_2, Main.menu_3, Main.menu_4,
            Main.menu_5, Main.menu_6, Main.menu_7, Main.menu_8,
            Main.menu_9, Main.menu_10, Main.menu_11, Main.menu_12}

        For i As Integer = 0 To labels.Length - 1
            labels(i).Text = splitLine(i)
        Next

        Main.ForceName_checkBox.Text = splitLine(labels.Length)
        Main.AutoOpen_checkBox.Text = splitLine(labels.Length + 1)
        Main.ValidateBt.Text = splitLine(labels.Length + 2)
        Main.DefineName_Bt.Text = splitLine(labels.Length + 3)

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
