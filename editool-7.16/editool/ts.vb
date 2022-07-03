
Imports TopSolid.Kernel.Automating
Imports TopSolid.Cad.Design.Automating

Module ts


    Public Sub Create_outil()


        'TopSolidHost.Connect(1, 0, "server")
        TopSolidHost.Connect()
        TopSolidDesignHost.Connect()

        Dim model_fr As New DocumentId
        Dim model_id As String

        'model_id = "Thenmodel_fr" --> FR 2T
        'model_id = "model_ft" --> Ft Rayon/Chanfrein
        'model_id = "model_fo" --> Foret
        'etc


        ''model_id = "123" '---->   19_5bceb813-ab67-4cf3-9345-adf8c15c9140&3_3150

        'model_id = "model2"

        model_id = "FR Ø8 3z Lc15 Lu25"

        'model_id = "Fraise 2 tailles D20 L35 SD20"
        ' model_id = "Side Mill"

        Try
            model_fr = Open_file(model_id)
            If model_fr.IsEmpty Then
                MsgBox("can't find file ( " + model_id + " )")
            Else
                If TopSolidHost.Application.StartModification("model_fr", True) Then
                    'Modify document.
                    Try
                        '// Make document modifiable.
                        'TopSolidHost.Application.StartModification("makeTool", False)
                        TopSolidHost.Documents.EnsureIsDirty(model_fr)
                        '// Perform document modification.
                        MakeTool(model_fr)
                    Catch
                        '// End modification (failure).
                        MsgBox("failure not dirty&")
                        TopSolidHost.Application.EndModification(False, False)
                    End Try
                Else
                    MsgBox("failure not dirty 2")
                    TopSolidHost.Application.EndModification(False, False)
                End If
            End If
        Catch
            MsgBox("failure start mod")
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
        TopSolidHost.Application.EndModification(True, True)
        MsgBox("Outil " + Form1.Name_textbox.Text + " crée")

    End Sub
    Private Sub Set_parametre_outil(newTool As DocumentId)

        Dim list_par(0, 2) As String

        list_par = {{"D", 0, Form1.d1.Text}, {"DD", 0, Form1.d3.Text}, {"SD", 0, Form1.d2.Text}, {"L", 0, Form1.L2.Text}, {"LD", 0, Form1.L3.Text}, {"OL", 0, Form1.L1.Text}, {"FB", 0, Form1.chf.Text}, {"NoTT", 0, Form1.NoTT.Text}, {"Name", 0, Form1.Name_textbox.Text}}
        ''list_par = {{"D", 0, Form1.d1.Text}, {"SD", 0, Form1.d2.Text}, {"L", 0, Form1.L2.Text}, {"OL", 0, Form1.L1.Text}, {"Nom", 0, Form1.Name_textbox.Text}}

        For i As Integer = 0 To 6 ' numero de parametres Double
            Dim p_elementId As ElementId = TopSolidHost.Elements.SearchByName(newTool, list_par(i, 0)) ' get parameter by names from array
            Dim tmp_string As String = list_par(i, 2)
            tmp_string = Replace(tmp_string, ".", ",") ' eliminate ,
            Dim fb_tmp As Double = tmp_string / 1000 '  get de Double from String and scale mm to m (SI units)



            '***********************************************
            If list_par(i, 0) = "LD" Then

                If fb_tmp = 0 Then
                    fb_tmp = list_par(3, 1)

                End If

                '     fb_tmp = 0.1 / 1000
                'End If
                'If fb_tmp = 0 And list_par(i, 0) = "DD" Then
                '   fb_tmp = Replace(Form1.d1.Text, ".", ",") / 1000
            End If
            '***********************************************
            list_par(i, 1) = fb_tmp


            TopSolidHost.Parameters.SetRealValue(p_elementId, fb_tmp)

        Next

        Dim NoTT As ElementId = TopSolidHost.Elements.SearchByName(newTool, "NoTT")
        TopSolidHost.Parameters.SetIntegerValue(NoTT, Form1.NoTT.Text)



        Dim sys_par As List(Of ElementId) = TopSolidHost.Parameters.GetParameters(newTool)
        Dim tmp As String

        For i As Integer = 0 To sys_par.Count - 1
            tmp = TopSolidHost.Elements.GetName(sys_par(i))
            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.VirtualDocument" Then
                TopSolidHost.Parameters.SetBooleanValue(sys_par(i), False)
            End If

            'If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.PartNumber" Then
            'TopSolidHost.Parameters.SetTextValue(sys_par(i), Form1.DataGridView1.SelectedCells(0).Value)
            'End If
            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber" Then
                TopSolidHost.Parameters.SetTextValue(sys_par(i), Form1.DataGridView1.SelectedCells(0).Value)
            End If

            'If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining" Then
            'TopSolidHost.Parameters.SetBooleanValue(sys_par(i), False)
            'End If

            If TopSolidHost.Elements.GetName(sys_par(i)) = "$TopSolid.Kernel.TX.Properties.Manufacturer" Then
                TopSolidHost.Parameters.SetTextValue(sys_par(i), "FRAISA")
            End If

        Next

    End Sub

    Function Open_file(model As String)
        Dim lib_models As List(Of PdmObjectId)

        ''        11_ec439f6b-111d-4721-bf4d-81251317f992&65537_2524



        lib_models = TopSolidHost.Pdm.SearchProjectByName("EdiTool")

        ''lib_models = TopSolidHost.Pdm.SearchProjectByName("TopSolid Machining User Tools")


        ''11_9a853b31-91a3-4f21-8b69-d41096477dfc&65537_12056
        Dim model_fr As DocumentId
        ' Dim ass_model As DocumentId

        'Dim model_ass As String = "model_fr+porte_outil"

        Dim temp_model As DocumentId
        'Dim temp_ass_model As DocumentId





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
                temp_model = TopSolidHost.Documents.SaveAs(model_fr, lib_models(0), Form1.Name_textbox.Text)


            End If
        Else
            MsgBox("cant find lib")
            'Close()

        End If
        Return temp_model
    End Function

End Module
