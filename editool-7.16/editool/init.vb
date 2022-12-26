﻿Option Explicit On

Module outils_base
    Dim DataTable_buffer As DataTable
    Public Sub Set_filter()
        'Dim dv As New DataView(DataTable_buffer)
        'Dim str_tmp As String

        'If Main.Diam_filter_TextBox.Text = "" Then
        '    str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%'"
        'ElseIf Main.Ref_filter_TextBox.Text = "" Then

        '    str_tmp = "D LIKE '%" + Main.Diam_filter_TextBox.Text + "%'"
        'Else
        '    str_tmp = "Reference LIKE '%" + Main.Ref_filter_TextBox.Text + "%' AND D like '%" + Main.Diam_filter_TextBox.Text + "%'"
        'End If
        'DataTable_buffer.DefaultView.RowFilter = str_tmp
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
            Return Main.D_textBox.Text
        Else
            Return value
        End If
    End Function
    Function Pick_param(param As String)
        Select Case param
            Case "D" : Return Main.D_textBox.Text
            Case "L" : Return Main.L_textbox.Text
            Case "OL" : Return Main.OL_textbox.Text
            Case "SD" : Return Main.SD_textbox.Text
            Case "CTS_AL" : Return Check_zero(param, Main.CTS_AL_textbox.Text)
            Case "CTS_AD" : Return Check_zero(param, Main.CTS_AD_textbox.Text)
            Case "NoTT" : Return Main.NoTT.Text
            Case "A" : Return Main.A_TextBox.Text
            Case "r" : Return Main.Chf_textbox.Text
            Case Else
                MsgBox("no param found, check outil name mask config")
        End Select
    End Function

    Public Sub Set_Name_auto()

        If Main.ForceName_checkBox.Checked = False Then
            Try
                Dim Namemask As String = ToolName_config.Namemask_textbox.Text
                Dim ToolType = My.Settings.NameMask

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

                'ToolPreview()
            Catch ex As Exception
                MsgBox("Name Mask Error - " + ex.ToString)

            End Try
        End If

    End Sub

    Public Function SetDataGridColumnsTitle(columns() As String, dt As DataTable)

        For Each col As String In columns
            dt.Columns.Add(col, GetType(String))
        Next
        'dt.Columns.Add("index", GetType(String))            ' --------> option to add index to DataGridView1
        Return dt
    End Function


    Public Sub Get_prefs(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
        Dim pref_lang As String = Right(splitLine(0), 2)

    End Sub
    Public Sub Get_files(data As String)
        Dim splitLine() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim labels() As Label = {
            Main.menu_1, Main.menu_2, Main.menu_3, Main.menu_4,
            Main.menu_5, Main.menu_6, Main.menu_7, Main.menu_8,
            Main.menu_9, Main.menu_10}

        For i As Integer = 0 To labels.Length - 1
            labels(i).Text = splitLine(i)
        Next

        Main.ForceName_checkBox.Text = splitLine(labels.Length)
        Main.AutoOpen_checkBox.Text = splitLine(labels.Length + 1)
        Main.ValidateBt.Text = splitLine(labels.Length + 2)
        Main.DefineName_Bt.Text = splitLine(labels.Length + 3)

    End Sub
    Function AddFiltersCombobox(tmp As Single, filter As List(Of Single))

        If filter.Count > 0 Then
            If filter.Contains(tmp) = False Then
                filter.Add(tmp)
            End If
        Else
            filter.Add(0)
            filter.Add(tmp)
        End If
        Return filter

    End Function
    Function AddFiltersStringCombobox(str As String, filter As List(Of String))

        If str <> "" Then
            If filter.Count > 0 Then
                If filter.Contains(str) = False Then
                    filter.Add(str)
                End If
            Else
                filter.Add("")
                filter.Add(str)
            End If
        End If
        Return filter


    End Function

    Public Sub GetDefaultTools(data As String, filter As String)
        Dim full_file() As String = data.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        Dim single_line As String
        Dim line() As String
        '                           0      1    2       3       4     5     6       7     8     9
        Dim objList() As String = {"ref", "D", "SD", "CTS_AD", "OL", "L", "CTS_AL", "a", "z", "chf"}

        DataTable_buffer = New DataTable
        DataTable_buffer = SetDataGridColumnsTitle(objList, DataTable_buffer)


        Dim filterD1 As New List(Of Single)
        Dim filterL1 As New List(Of Single)


        For i As Integer = 0 To 4000 'full_file.Length - 1
            single_line = full_file(i)
            line = Split(single_line, ";")

            Dim newtool As New NewTool

            DataTable_buffer.Rows.Add(line)
                Dim tmp_line() As String = line.ToArray

                newtool = FileImports.Fill_newTool(line(1), line(3), line(2), line(5), line(6), line(4), line(8), "FR2T", "0", "0", "0", "0", "0", "0", "0", "FRAISA", line(0), "0", "0", "0")
                Main.toolsList.items.add(newtool)


                filterD1 = AddFiltersCombobox(line(1), filterD1)
                filterL1 = AddFiltersCombobox(line(5), filterL1)


        Next


        filterD1 = filterD1.OrderBy(Function(x) x).ToList()
        With Main.filterD1_Combobox
            .DataSource = filterD1
        End With


        filterL1 = filterL1.OrderBy(Function(x) x).ToList()
        With Main.filterL1_ComboBox
            .DataSource = filterL1
        End With



        'if we want to filter/order data
        'DataTable_buffer.DefaultView.Sort = "d ASC"
        'Main.NewToolDataGridView.DataSource = DataTable_buffer.DefaultView.ToTable

        'Main.NewToolDataGridView.DataSource = DataTable_buffer



    End Sub




End Module
