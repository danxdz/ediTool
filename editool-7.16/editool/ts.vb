
Imports TopSolid.Kernel.Automating
Imports TopSolid.Cad.Design.Automating

Module ts

    Public Sub Create_outil()


        'TopSolidHost.Connect(1, 0, "server")
        TopSolidHost.Connect()
        TopSolidDesignHost.Connect()

        Dim model_fr As New DocumentId
        Dim model_id As String

        'model_id = "model_fr" --> FR 2T
        'model_id = "model_ft" --> Ft Rayon/Chanfrein
        'model_id = "model_fo" --> Foret
        'etc

        ''model_id = "FR 2T D20 L35 SD20"
        model_id = "Side Mill D20 L35 SD20"

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
            TopSolidHost.Application.EndModification(False, False)
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
        SetReal(newTool, "CTS_AD", Strip_doubles(Main.CTS_AD_textbox.Text))
        SetReal(newTool, "OL", Strip_doubles(Main.OL_textbox.Text))
        SetReal(newTool, "L", Strip_doubles(Main.L_textbox.Text))
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



        Dim Name As ElementId = TopSolidHost.Elements.SearchByName(newTool, "$TopSolid.Kernel.TX.Properties.Name")




        TopSolidHost.Parameters.SetTextParameterizedValue(Name, "FR 2T Ø[D] Lc[L] SD[SD]")



        Dim sys_par As List(Of ElementId) = TopSolidHost.Parameters.GetParameters(newTool)
        Dim tmp As String

        For i As Integer = 0 To sys_par.Count - 1
            tmp = TopSolidHost.Elements.GetName(sys_par(i))
            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.VirtualDocument" Then
                TopSolidHost.Parameters.SetBooleanValue(sys_par(i), False)
            End If



            'If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.PartNumber" Then
            'TopSolidHost.Parameters.SetTextValue(sys_par(i), Main.DataGridView1.SelectedCells(0).Value)
            'End If
            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber" Then
                TopSolidHost.Parameters.SetTextValue(sys_par(i), Main.DataGridView1.SelectedCells(0).Value)
            End If

            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining" Then
                TopSolidHost.Parameters.SetBooleanValue(sys_par(i), True)
            End If

            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.Manufacturer" Then
                TopSolidHost.Parameters.SetTextValue(sys_par(i), "FRAISA")
            End If

        Next

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
