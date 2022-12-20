Imports TopSolid.Cad.Design.Automating

Module ts

    Public Sub Create_outil(newTool As NewTool)



        'TopSolidHost.Connect(1, 0, "server") 'option to network server
        TopSolidHost.Connect()
        TopSolidDesignHost.Connect()

        Dim model_fr As New DocumentId
        Dim model_id As String = "Side Mill D20 L35 SD20"
        Dim toolType = newTool.Type

        If toolType <> "" Then
            My.Settings.ToolType = toolType
            My.Settings.Save()
        Else
            toolType = My.Settings.ToolType
        End If

        Select Case toolType
            Case "FR2T"
                model_id = "Side Mill D20 L35 SD20"
            Case "FT"
                model_id = "Radiused Mill D16 L40 r3 SD16"
            Case "FB"
                model_id = "Ball Nose Mill D8 L30 SD8"
            Case "FP"
                model_id = "Spotting Drill D10 SD10"
            Case "FOCA"
                model_id = "Twisted Drill D10 L35 SD10"
            Case "AL"
                model_id = "Constant Reamer D10 L20 SD9"
        End Select

        Dim lib_models As List(Of PdmObjectId)
        lib_models = TopSolidHost.Pdm.SearchProjectByName("EdiTool")
        ''newTool_lib = TopSolidHost.Pdm.SearchProjectByName("EdiTool")

        Try
            model_fr = Open_file(model_id, lib_models)
            If model_fr.IsEmpty Then
                MsgBox("can't find file ( " + model_id + " )")
            Else
                If TopSolidHost.Application.StartModification("model_fr", True) Then
                    'Modify document.
                    Try
                        TopSolidHost.Documents.EnsureIsDirty(model_fr)
                        '// Perform document modification.

                        MakeTool(model_fr)
                        TopSolidHost.Pdm.CheckIn(TopSolidHost.Pdm.SearchDocumentByName(lib_models(0), TopSolidHost.Documents.GetName(model_fr))(0), True)

                        MsgBox("Outil " + Main.Name_textbox.Text + " crée")

                    Catch
                        '// End modification (failure).
                        MsgBox("failure not dirty - EndModification")
                        TopSolidHost.Application.EndModification(False, False)
                    End Try
                Else
                    MsgBox("StartModification failure")
                    TopSolidHost.Application.EndModification(False, False)
                End If
            End If
        Catch
            MsgBox("Cant open file, close everything in Topsolid" + Environment.NewLine + Environment.NewLine + "Impossible ouvrir le fichier, fermer tout sur Topsolid")
            Try
                TopSolidHost.Application.EndModification(False, False)
            Catch
            End Try
        End Try


    End Sub

    Private Function IsInt(val As Integer)
        If Integer.TryParse(val, Nothing) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub GetV6Tool()
        Dim newTool As New NewTool
        'NewBD.DataGridView1.SelectedCells.Count '-> get selected rows number
        Dim Temp_row As String = NewBD.DataGridView1.CurrentCell.Value
        Dim line() As String
        Temp_row = Replace(Temp_row, ",", ".")
        Temp_row = Replace(Temp_row, "  ", "")
        line = Split(Temp_row, ";")

        Dim type, name, d1, d2, d3, l1, l2, l3, NoTT As String

        type = line(0)



        Select Case type
            Case "FR"
                type = "Side Mill D20 L35 SD20"
            Case "FT"
                type = "Radiused Mill D16 L40 r3 SD16"
            Case "FR_HEMI "
                type = "FB"
            Case "FP"
                type = "Spotting Drill D10 SD10"
            Case "FO"
                type = "Twisted Drill D10 L35 SD10"
            Case "AL"
                type = "Constant Reamer D10 L20 SD9"
        End Select

        My.Settings.ToolType = type

        My.Settings.Save()
        newTool.Type = type

        name = line(2)

        newTool.Name = name
        Main.Name_textbox.Text = name


        d1 = Replace(line(8), "Tool.Diam=", "")

        l1 = Replace(line(9), "Tool.UtilLength=", "")
        d2 = Replace(line(12), "Tool.DiamPoky=", "")
        l2 = Replace(line(10), "Tool.ZProg=", "")
        d3 = Replace(line(18), "Tool.LinkType=QC", "")
        l3 = Replace(line(19), "Tool.TotalLength=", "")
        NoTT = Replace(line(17), "Tool.NbCogs=", "")




        If IsInt(d1) Then
            newTool.D1 = Int(d1)
            Main.D_textbox.Text = Int(d1)
        End If

        newTool.L1 = Replace(line(9), "Tool.UtilLength=", "")
        newTool.D2 = Replace(line(12), "Tool.DiamPoky=", "")
        newTool.L2 = Replace(line(10), "Tool.ZProg=", "")
        newTool.D3 = Replace(line(18), "Tool.LinkType=QC", "")
        newTool.L3 = Replace(line(19), "Tool.TotalLength=", "")
        newTool.NoTT = Replace(line(17), "Tool.NbCogs=", "")

    End Sub

    Private Sub MakeTool(docId As DocumentId)

        Dim list_par As List(Of ElementId) = TopSolidHost.Parameters.GetParameters(docId)
        Dim names As String
        Dim types As ParameterType
        For i As Integer = 0 To list_par.Count - 1
            types = TopSolidHost.Parameters.GetParameterType(list_par(i))
            names = TopSolidHost.Elements.GetName(list_par(i))
            'ComboBox1.Items.Add(names)
        Next

        Set_parametre_outil(docId)
        TopSolidHost.Application.EndModification(True, False)

        If Main.AutoOpen_checkBox.Checked = True Then
            TopSolidHost.Documents.Open(docId)
        End If

        TopSolidHost.Documents.Save(docId)
        ''TopSolidHost.Documents.Close(newTool, False, False)

    End Sub
    Function Strip_doubles(tmp As String)
        Dim tmp_string As String = tmp
        tmp_string = Replace(tmp_string, ".", ",") ' replace , -> .
        Dim res As Double = tmp_string / 1000 '  get de Double from String and scale mm to m (SI units)
        Return res
    End Function

    Private Sub SetReal(newtool As DocumentId, dbl As String, value As Double)

        Dim tmpReal As ElementId = TopSolidHost.Elements.SearchByName(newtool, dbl)
        TopSolidHost.Parameters.SetRealValue(tmpReal, value)

    End Sub

    Private Sub Set_parametre_outil(newTool_docId As DocumentId)

        SetReal(newTool_docId, "D", Strip_doubles(Main.D_textbox.Text))
        SetReal(newTool_docId, "SD", Strip_doubles(Main.SD_textbox.Text))
        SetReal(newTool_docId, "OL", Strip_doubles(Main.OL_textbox.Text))
        SetReal(newTool_docId, "L", Strip_doubles(Main.L_textbox.Text))

        Dim Name As ElementId = TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.Name")

        If My.Settings.ToolType = "FP" Or My.Settings.ToolType = "FOCA" Then
            Dim tmpAngleRad = Main.A_TextBox.Text * Math.PI / 180
            SetReal(newTool_docId, "A", tmpAngleRad)

            Select Case My.Settings.ToolType
                Case "FP"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FP)
                Case "FO"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FO)

            End Select
        ElseIf My.Settings.ToolType = "AL" Then
            TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_AL)
        Else
            SetReal(newTool_docId, "CTS_AD", Strip_doubles(Main.CTS_AD_textbox.Text))
            SetReal(newTool_docId, "CTS_AL", Strip_doubles(Main.CTS_AL_textbox.Text))
            SetReal(newTool_docId, "CTS_ED", Strip_doubles(Main.SD_textbox.Text))

            Dim CTS_AD_tmp As Double = Strip_doubles(Main.CTS_AD_textbox.Text)
            If CTS_AD_tmp > 0 Then
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp) 'TODO
            Else
                CTS_AD_tmp = Strip_doubles(Main.D_textbox.Text)
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp)
            End If

            'Dim CTS_EL As ElementId = TopSolidHost.Elements.SearchByName(newTool, "CTS_EL")
            'TopSolidHost.Parameters.SetRealValue(CTS_EL, Main.L3.Text / 1000)
            Dim CTS_EL As Double = Strip_doubles(Main.CTS_AL_textbox.Text)
            If (Main.alpha.Text = 0) Then
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            Else
                CTS_EL = (Strip_doubles(Main.SD_textbox.Text) - Strip_doubles(Main.D_textbox.Text)) / 2
                CTS_EL /= Math.Tan((Main.alpha.Text * Math.PI) / 180)
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            End If

            If My.Settings.ToolType = "FT" Then
                Dim r As Double = Strip_doubles(Main.Chf_textbox.Text)
                SetReal(newTool_docId, "r", r) 'TODO
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FT)
            ElseIf My.Settings.ToolType = "FB" Then
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FB)
            Else
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FR)
            End If

        End If

        '***************
        'Debug -> get elements param list
        'Dim sys_pard As List(Of ElementId) = TopSolidHost.Elements.GetElements(newTool)
        'Dim tmp As String
        'Dim lst As String() = New String(sys_pard.Count - 1) {}

        'For i As Integer = 0 To sys_pard.Count - 1
        'tmp = TopSolidHost.Elements.GetName(sys_pard(i))
        'lst(i) = tmp
        'Next
        '***************


        TopSolidHost.Parameters.PublishText(newTool_docId, "Designation_outil", New SmartText(TopSolidHost.Parameters.GetDescriptionParameter(newTool_docId)))

        TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber"), Main.manref_TextBox.Text)

        TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.Manufacturer"), Main.manuf_comboBox.Text)

        TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
        Try
            TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining"), True)
        Catch ex As Exception
        End Try


    End Sub

    Function Open_file(model As String, lib_models As List(Of PdmObjectId))

        Dim model_fr As DocumentId
        Dim temp_model As DocumentId

        If lib_models.Count > 0 Then
            TopSolidHost.Pdm.OpenProject(lib_models(0))
            Dim model_fr_id As List(Of PdmObjectId)
            For i As Integer = 0 To (lib_models.Count - 1)
                model_fr_id = TopSolidHost.Pdm.SearchDocumentByName(lib_models(i), model)
            Next

            If model_fr_id.Count > 0 Then
                model_fr = TopSolidHost.Documents.GetDocument(model_fr_id(0))
                temp_model = TopSolidHost.Documents.SaveAs(model_fr, lib_models(0), "temp") 'Main.Name_textbox.Text)
            End If
        Else
            MsgBox("cant find lib 'EdiTool'")
            'Close()
        End If
        Return temp_model
    End Function

End Module