Option Explicit On
Imports TopSolid.Cad.Design.Automating

Module ts
    Public Sub Create_outil(newTool As NewTool)

        TopSolidHost.Connect()
        TopSolidDesignHost.Connect()

        Dim model_id As String = "Side Mill D20 L35 SD20"

        Dim toolType = newTool.Type
        If toolType <> "" Then My.Settings.ToolType = toolType

        Select Case My.Settings.ToolType
            Case "FR2T"
                model_id = "Side Mill D20 L35 SD20"
            Case "FRTO"
                model_id = "Radiused Mill D16 L40 r3 SD16"
            Case "FRHE"
                model_id = "Ball Nose Mill D8 L30 SD8"
            Case "FOP9"
                model_id = "Spotting Drill D10 SD10"
            Case "FOCA"
                model_id = "Twisted Drill D10 L35 SD10"
            Case "ALFI"
                model_id = "Constant Reamer D10 L20 SD9"
        End Select

        Dim model_fr = Open_file(model_id, TopSolidHost.Pdm.SearchProjectByName("EdiTool"))
        If model_fr.IsEmpty Then
            MsgBox("Can't find file ( " + model_id + " )")
            Exit Sub
        End If

        Try
            If Not TopSolidHost.Application.StartModification("model_fr", True) Then
                MsgBox("StartModification failure")
                Exit Sub
            End If

            TopSolidHost.Documents.EnsureIsDirty(model_fr)
            Set_parametre_outil(model_fr, newTool)
            MakeTool(model_fr)
            TopSolidHost.Pdm.CheckIn(TopSolidHost.Pdm.SearchDocumentByName(
                TopSolidHost.Pdm.SearchProjectByName("EdiTool")(0),
                TopSolidHost.Documents.GetName(model_fr))(0), True)

            MsgBox("Outil " + Main.Name_textbox.Text + " crée")
        Catch
            MsgBox("Failed to create tool")
        Finally
            'TopSolidHost.Application.EndModification(False, False)
        End Try

    End Sub


    Private Sub MakeTool(docId As DocumentId)

        'Dim list_par As List(Of ElementId) = TopSolidHost.Parameters.GetParameters(docId)
        'Dim names As String
        'Dim types As ParameterType
        'For i As Integer = 0 To list_par.Count - 1
        '    types = TopSolidHost.Parameters.GetParameterType(list_par(i))
        '    names = TopSolidHost.Elements.GetName(list_par(i))
        '    'ComboBox1.Items.Add(names)
        'Next

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

    ' This subroutine sets the value of a Real parameter in a TopSolid document
    Private Sub SetReal(TopDoc As DocumentId, paramName As String, paramValue As Decimal)

        ' Find the ElementId of the Real parameter using its name
        Dim paramElementId As ElementId = TopSolidHost.Elements.SearchByName(TopDoc, paramName)

        ' Set the value of the Real parameter using its ElementId and the desired value
        TopSolidHost.Parameters.SetRealValue(paramElementId, paramValue)

    End Sub


    Private Sub Set_parametre_outil(newTool_docId As DocumentId, newTool As NewTool)

        Dim Name As ElementId = TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.Name")

        SetReal(newTool_docId, "D", newTool.D1 / 1000)
        SetReal(newTool_docId, "SD", newTool.D3 / 1000)
        SetReal(newTool_docId, "OL", newTool.L3 / 1000)
        SetReal(newTool_docId, "L", newTool.L1 / 1000)



        If My.Settings.ToolType = "FOC9" Or My.Settings.ToolType = "FOCA" Then
            'Dim tmpAngleRad = Main.A_TextBox.Text * Math.PI / 180
            Dim tmpAngleRad = newTool.AngleDeg
            SetReal(newTool_docId, "A", tmpAngleRad)


            Select Case My.Settings.ToolType
                Case "FOC9"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FOC9)
                Case "FOCA"
                    TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FOCA)

            End Select
        ElseIf My.Settings.ToolType = "ALFI" Then
            TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_AL)
        Else

            SetReal(newTool_docId, "CTS_AD", newTool.D2 / 1000)
            SetReal(newTool_docId, "CTS_AL", newTool.L2 / 1000)
            SetReal(newTool_docId, "CTS_ED", newTool.D2 / 1000)

            'SetReal(newTool_docId, "CTS_AD", Strip_doubles(Main.CTS_AD_textbox.Text))
            'SetReal(newTool_docId, "CTS_AL", Strip_doubles(Main.CTS_AL_textbox.Text))
            'SetReal(newTool_docId, "CTS_ED", Strip_doubles(Main.SD_textbox.Text))

            'Dim CTS_AD_tmp As Double = Strip_doubles(Main.CTS_AD_textbox.Text)
            Dim CTS_AD_tmp As Double = newTool.D2 / 1000


            If CTS_AD_tmp > 0 Then
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp) 'TODO
            Else
                CTS_AD_tmp = Strip_doubles(Main.D_textbox.Text)
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp)
            End If

            'Dim CTS_EL As ElementId = TopSolidHost.Elements.SearchByName(newTool, "CTS_EL")
            'TopSolidHost.Parameters.SetRealValue(CTS_EL, Main.L3.Text / 1000)

            'Dim CTS_EL As Double = Strip_doubles(Main.CTS_AL_textbox.Text)
            Dim CTS_EL As Double = newTool.L2 / 1000
            If (Main.alpha.Text = 0) Then
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            Else
                'CTS_EL = (Strip_doubles(Main.SD_textbox.Text) - Strip_doubles(Main.D_textbox.Text)) / 2
                CTS_EL = newTool.D3 - newTool.D1 / 2
                CTS_EL /= Math.Tan((Main.alpha.Text * Math.PI) / 180)
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            End If

            If My.Settings.ToolType = "FRTO" Then
                Dim r As Double = Strip_doubles(Main.Chf_textbox.Text)
                SetReal(newTool_docId, "r", r) 'TODO
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FT)
            ElseIf My.Settings.ToolType = "FRHE" Then
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FB)
            Else
                TopSolidHost.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FR)
            End If

        End If

        '***************
        'Debug -> get elements param list
        'Dim sys_pard As List(Of ElementId) = TopSolidHost.Elements.GetElements(newTool_docId)
        'Dim tmp As String
        'Dim lst As String() = New String(sys_pard.Count - 1) {}

        'For i As Integer = 0 To sys_pard.Count - 1
        '    tmp = TopSolidHost.Elements.GetName(sys_pard(i))
        '    lst(i) = tmp
        'Next
        '***************

        newTool.PublishParameters(newTool_docId)

        Try
            TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining"), True)
        Catch ex As Exception
        End Try


    End Sub


    Function Open_file(model As String, lib_models As List(Of PdmObjectId))

        Dim model_fr As DocumentId
        Dim temp_model As DocumentId

        ' Check if there are any models in the specified library
        If lib_models.Count > 0 Then

            ' Open the first library in the list
            TopSolidHost.Pdm.OpenProject(lib_models(0))

            ' Search for the specified model in all the libraries
            Dim model_fr_id As New List(Of PdmObjectId)()
            For i As Integer = 0 To (lib_models.Count - 1)
                model_fr_id = TopSolidHost.Pdm.SearchDocumentByName(lib_models(i), model)
            Next


            ' If the model was found, open it and save it as a temporary file
            If model_fr_id.Count > 0 Then
                Try
                    model_fr = TopSolidHost.Documents.GetDocument(model_fr_id(0))
                    temp_model = TopSolidHost.Documents.SaveAs(model_fr, lib_models(0), "temp") 'Main.Name_textbox.Text)
                Catch ex As Exception
                    MsgBox("cant find tool model")
                End Try
            Else
                ' If the model was not found, display an error message
                MsgBox("cant find tool model")
            End If
        Else
            ' If the library was not found, display an error message
            MsgBox("cant find lib 'EdiTool'")
        End If

        ' Return the temporary model document ID
        Return temp_model
    End Function




End Module