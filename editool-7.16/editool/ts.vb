
Imports TopSolid.Kernel.Automating
Imports TopSolid.Cad.Design.Automating
Imports System.ComponentModel

Module ts

    Public Sub Create_outil()


        'TopSolidHost.Connect(1, 0, "server")
        TopSolidHost.Connect()
        TopSolidDesignHost.Connect()

        Dim model_fr As New DocumentId
        Dim model_id As String = "Side Mill D20 L35 SD20"

        'model_id = "model_fr" --> FR 2T
        'model_id = "model_ft" --> Ft Rayon/Chanfrein
        'model_id = "model_fo" --> Foret
        'etc

        ''model_id = "FR 2T D20 L35 SD20"
        Select Case My.Settings.ToolType
            Case "FR"
                model_id = "Side Mill D20 L35 SD20"
            Case "FT"
                model_id = "Radiused Mill D16 L40 r3 SD16"
            Case "FB"
                model_id = "Ball Nose Mill D8 L30 SD8"
            Case "FP"
                model_id = "Spotting Drill D10 SD10"
            Case "FO"
                model_id = "Twisted Drill D10 L35 SD10"
            Case "AL"
                model_id = "Constant Reamer D10 L20 SD9"
        End Select



        Dim lib_models As List(Of PdmObjectId)
        lib_models = TopSolidHost.Pdm.SearchProjectByName("EdiTool")
        ''lib_models = TopSolidHost.Pdm.SearchProjectByName("TopSolid Machining User Tools")
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
            MsgBox("Cant open file, close everything in TopSolid")
            Try
                TopSolidHost.Application.EndModification(False, False)
            Catch
            End Try
        End Try


    End Sub
    Private Sub MakeTool(newTool As DocumentId)

        Dim list_par As List(Of ElementId) = TopSolidHost.Parameters.GetParameters(newTool)
        Dim names As String
        Dim types As ParameterType
        For i As Integer = 0 To list_par.Count - 1
            types = TopSolidHost.Parameters.GetParameterType(list_par(i))
            names = TopSolidHost.Elements.GetName(list_par(i))
            'ComboBox1.Items.Add(names)
        Next

        Set_parametre_outil(newTool)
        TopSolidHost.Application.EndModification(True, False)

        If Main.AutoOpen_checkBox.Checked = True Then
            TopSolidHost.Documents.Open(newTool)
        End If

        TopSolidHost.Documents.Save(newTool)
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

    Private Sub Set_parametre_outil(newTool As DocumentId)

        'list_par = {{"D", 0, Main.d1.Text}, {"CTS_AD", 0, Main.d3.Text}, {"SD", 0, Main.d2.Text}, {"L", 0, Main.L2.Text}, {"CTS_AL", 0, Main.L3.Text}, {"OL", 0, Main.L1.Text}, {"FB", 0, Main.chf.Text}, {"NoTT", 0, Main.NoTT.Text}, {"Name", 0, Main.Name_textbox.Text}}
        'Dim D As ElementId = TopSolidHost.Elements.SearchByName(newTool, "D")
        'TopSolidHost.Parameters.SetRealValue(D, strip_doubles(Main.d1.Text))
        SetReal(newTool, "D", Strip_doubles(Main.D_textbox.Text))
        SetReal(newTool, "SD", Strip_doubles(Main.SD_textbox.Text))
        SetReal(newTool, "OL", Strip_doubles(Main.OL_textbox.Text))
        SetReal(newTool, "L", Strip_doubles(Main.L_textbox.Text))

        Dim Name As ElementId = TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Kernel.TX.Properties.Name")

        If My.Settings.ToolType = "FP" Or My.Settings.ToolType = "FO" Then
            Dim tmpAngleRad = Main.A_TextBox.Text * Math.PI / 180
            SetReal(newTool, "A", tmpAngleRad)



            Select Case My.Settings.ToolType
                Case "FP"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FP)
                Case "FO"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FO)

            End Select
        ElseIf My.Settings.ToolType = "AL" Then
            TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_AL)
        Else
            SetReal(newTool, "CTS_AD", Strip_doubles(Main.CTS_AD_textbox.Text))
            SetReal(newTool, "CTS_AL", Strip_doubles(Main.CTS_AL_textbox.Text))
            SetReal(newTool, "CTS_ED", Strip_doubles(Main.SD_textbox.Text))

            Dim CTS_AD_tmp As Double = Strip_doubles(Main.CTS_AD_textbox.Text)
            If CTS_AD_tmp > 0 Then
                SetReal(newTool, "CTS_EBD", CTS_AD_tmp) 'TODO
            Else
                CTS_AD_tmp = Strip_doubles(Main.D_textbox.Text)
                SetReal(newTool, "CTS_EBD", CTS_AD_tmp)
            End If

            'Dim CTS_EL As ElementId = TopSolidHost.Elements.SearchByName(newTool, "CTS_EL")
            'TopSolidHost.Parameters.SetRealValue(CTS_EL, Main.L3.Text / 1000)
            Dim CTS_EL As Double = Strip_doubles(Main.CTS_AL_textbox.Text)
            If (Main.alpha.Text = 0) Then
                SetReal(newTool, "CTS_EL", CTS_EL) 'TODO
            Else
                CTS_EL = (Strip_doubles(Main.SD_textbox.Text) - Strip_doubles(Main.D_textbox.Text)) / 2
                CTS_EL /= Math.Tan((Main.alpha.Text * Math.PI) / 180)
                SetReal(newTool, "CTS_EL", CTS_EL) 'TODO
            End If

            If My.Settings.ToolType = "FT" Then
                Dim r As Double = Strip_doubles(Main.chf.Text)
                SetReal(newTool, "r", r) 'TODO
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


        TopSolidHost.Parameters.PublishText(newTool, "Designation_outil", New SmartText(TopSolidHost.Parameters.GetDescriptionParameter(newTool)))

        TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber"), Main.manref_TextBox.Text)

        TopSolidHost.Parameters.SetTextValue(
                TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Kernel.TX.Properties.Manufacturer"),
                Main.Man.Text)

        TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
        Try
            TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining"), True)
        Catch ex As Exception
        End Try


    End Sub

    Function Open_file(model As String, lib_models As List(Of PdmObjectId))

        Dim model_fr As DocumentId
        Dim temp_model As DocumentId

        If lib_models.Count > 0 Then
            TopSolidHost.Pdm.OpenProject(lib_models(0))
            ''11_b54f2f06-10da-4a62-aa3f-57f906aa506c&2_40027
            Dim model_fr_id As List(Of PdmObjectId)
            For i As Integer = 0 To (lib_models.Count - 1)
                model_fr_id = TopSolidHost.Pdm.SearchDocumentByName(lib_models(i), model)

            Next

            '--->   19_9a853b31-91a3-4f21-8b69-d41096477dfc&65537_35683
            If model_fr_id.Count > 0 Then

                model_fr = TopSolidHost.Documents.GetDocument(model_fr_id(0))
                temp_model = TopSolidHost.Documents.SaveAs(model_fr, lib_models(0), Main.Name_textbox.Text)


            End If
        Else
            MsgBox("cant find lib")
            'Close()

        End If
        Return temp_model
    End Function

End Module
