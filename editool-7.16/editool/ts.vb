Option Explicit On

Imports System.IO
Imports Microsoft.Win32
Imports System.Reflection
Imports TopSolid.Kernel.Automating
Imports Microsoft.Office.Interop.Excel
Imports System.Security.Cryptography

Module ts
    Public ReadOnly api As New TopSolidAPI()

    Private Sub InitializeApi()
        Try
            api.Initialize()
            ' Do something with the API here
        Catch ex As Exception
            ' Handle any errors that occur during initialization
        End Try
    End Sub

    Public Class TopSolidAPI

        Public TopSolidExt As Object
        Public TopSolidDesignExt As Object
        Private _pdmObjectID As Object
        Private _documentID As Object

        Public Property PdmObjectID As Object
            Get
                Return _pdmObjectID
            End Get
            Set(value As Object)
                _pdmObjectID = value
            End Set
        End Property

        Public Property DocumentId As Object
            Get
                Return _documentID
            End Get
            Set(value As Object)
                _documentID = value
            End Set
        End Property

        Private Property TopSolidPath As String

        Friend Function CopyModelFile(model, libModel)
            Return CopyFile(model, libModel)

        End Function
        Friend Sub Initialize()
            GetTsPdmObjectId()

        End Sub
        Friend Function GetTsAssembly()
            Return GetTsDLL()

        End Function
        Friend Function StartModif()
            Return StartModifTopSolid()
        End Function

        Private Function CopyFile(model, lib_models)

            'Dim topSolidKernel As Assembly = api.GetTsAssembly()
            'Dim documentIdType As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.DocumentId")
            'Dim documentIdConstructor As ConstructorInfo = documentIdType.GetConstructor(New Type() {GetType(String)})
            'Dim pdmDocumentId As String = "your_pdm_document_id_here"
            'Dim documentIdInstance As Object = documentIdConstructor.Invoke(New Object() {pdmDocumentId})

            'Dim model_fr As Object
            'Dim model_fr As DocumentId

            Dim temp_model As Object

            ' Check if there are any models in the specified library
            If lib_models IsNot Nothing Then

                ' Open the first object in the list
                TopSolidExt.Pdm.OpenProject(lib_models(0))

                ' Search for the specified model in all the models
                Dim model_fr_id
                'For i As Integer = 0 To (lib_models.Count - 1)
                'model_fr_id = TopSolidExt.Pdm.SearchDocumentByName(lib_models(i), model)
                model_fr_id = TopSolidExt.Pdm.SearchDocumentByName(lib_models(0), model)
                'Next


                Try
                    api.TopSolidExt.Application.EndModification(False, False)

                Catch

                End Try


                Dim customToolsProjectName = My.Settings.customToolLib
                Dim customProject
                Try
                    customProject = TopSolidExt.Pdm.SearchProjectByName(customToolsProjectName)(0)
                Catch ex As Exception

                End Try

                If customProject Is Nothing Then
                    customProject = TopSolidExt.Pdm.CreateProject(customToolsProjectName, True)
                End If

                model_fr_id.RemoveRange(1, model_fr_id.Count - 1)

                ' If the model was found, open it and save it as a temporary file
                If model_fr_id.Count > 0 Then
                    Try

                        'model_fr = TopSolidExt.Documents.GetDocument(model_fr_id(0))
                        'model_fr = TopSolidExt.Pdm.GetCurrentProject() 'TopSolidExt.Pdm.GetDocument(model_fr_id(0))

                        ' Appeler la méthode CopySeveral avec la liste de PdmObjectId
                        temp_model = TopSolidExt.Pdm.CopySeveral(model_fr_id, customProject)


                        'temp_model = TopSolidExt.Pdm.CopySeveral(models, sfg) 'lib_models(0), "temp") 
                    Catch ex As Exception
                        MsgBox("cant copy tool model")
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

        Private Function GetSelectedMenuItem() As ToolStripMenuItem
            For Each mainMenuItem As ToolStripMenuItem In Main.MenuStrip1.Items
                For Each subMenuItem As ToolStripMenuItem In mainMenuItem.DropDownItems
                    If subMenuItem.Checked Then
                        Return subMenuItem
                    End If

                    For Each subSubMenuItem As ToolStripMenuItem In subMenuItem.DropDownItems
                        If subSubMenuItem.Checked Then
                            Return subSubMenuItem
                        End If
                    Next
                Next
            Next

            Return Nothing
        End Function
        Private Function StartModifTopSolid()

            'Dim conn = GetTsPdmObjectId()

            Dim topSolidKernel As Assembly = GetTsDLL()
            Dim type As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.TopSolidHostInstance")
            TopSolidExt = Activator.CreateInstance(type)
            TopSolidExt.Connect()

            Dim PdmObjectIdType = topSolidKernel.GetType("TopSolid.Kernel.Automating.PdmObjectId")


            If Main.MenuStrip1.Items.Count > 0 Then
                Dim toolLib = My.Settings.toolLib
                If toolLib = " Default" Then
                    PdmObjectIdType = TopSolidExt.Pdm.SearchProjectByName("TopSolid Machining User Tools")
                ElseIf toolLib = " EdiTool" Then
                    PdmObjectIdType = TopSolidExt.Pdm.SearchProjectByName("Editool") ' OpenProject
                End If
            End If

            Return PdmObjectIdType

        End Function
        Private Function GetTsDLL() As Assembly
            TopSolidPath = GetTopSolidPath()

            ' Load DLL's
            Dim topSolidKernelSxPath As String = Path.Combine(TopSolidPath, "bin", "TopSolid.Kernel.SX.dll")
            Console.WriteLine($"Loading dll: {topSolidKernelSxPath}")
            Dim topSolidKernelSx As Assembly = Assembly.LoadFrom(topSolidKernelSxPath)
            '*************************
            Dim topSolidKernelPath As String = Path.Combine(TopSolidPath, "bin", "TopSolid.Kernel.Automating.dll")
            Console.WriteLine($"Loading dll: {topSolidKernelPath}")
            Dim topSolidKernel As Assembly = Assembly.LoadFrom(topSolidKernelPath)
            Return topSolidKernel
        End Function
        Private Function GetTsPdmObjectId()
            Try
                TopSolidPath = GetTopSolidPath()

                Dim topSolidKernel As Assembly = GetTsDLL()

                Dim type As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.TopSolidHostInstance")
                TopSolidExt = Activator.CreateInstance(type)
                Dim pdmObjectIdType = topSolidKernel.GetType("TopSolid.Kernel.Automating.PdmObjectId")
                Dim DocumentIdType = topSolidKernel.GetType("TopSolid.Kernel.Automating.DocumentId")
                Dim listType = GetType(List(Of )).MakeGenericType(pdmObjectIdType)

                'TopSolidExt.Connect()
                'TopSolidExt.Pdm.OpenProject("Editool")
                'listType = TopSolidExt.Pdm.SearchProjectByName("EdiTool")


                Return listType


            Catch ex As Exception
                Console.WriteLine($"Failed to load dll: {ex.Message}")
            End Try

        End Function


    End Class



    ReadOnly keyPath As String = "SOFTWARE\TOPSOLID\TopSolid'Cam"

    'Function to get the last subkey of a given key
    Private Function GetLastSubKey()

        Dim subKeys() As String = Registry.LocalMachine.OpenSubKey(keyPath).GetSubKeyNames()

        If subKeys.Length > 0 Then
            Return subKeys(subKeys.Length - 1)
        Else
            Return ""
        End If
    End Function

    'Function to get the TopSolid path
    Public Function GetTopSolidPath() As String

        Dim subKey As String = GetLastSubKey()

        If Not String.IsNullOrEmpty(subKey) Then
            Dim path As String = Registry.GetValue("HKEY_LOCAL_MACHINE\" & keyPath & "\" & subKey, "InstallDir", "")
            Return path
        Else
            Return "TS path not found"
        End If
    End Function

    'Function to get the TopSolid version
    Public Function GetTopSolidVersion() As String
        Dim subKey As String = GetLastSubKey()

        If Not String.IsNullOrEmpty(subKey) Then
            Dim version As String = Registry.GetValue("HKEY_LOCAL_MACHINE\" & keyPath & "\" & subKey, "Version", "")
            Return version
        Else
            Return "no TS version founded"
        End If
    End Function



    Public Sub Create_outil(newTool As NewTool)
        Dim modelLib = api.StartModif()
        Console.WriteLine(":  ", modelLib)
        'TopSolidHost.Connect()
        'TopSolidDesignHost.Connect()

        Dim model_id As String = "Fraise 2 Tailles D20 L35 SD20"

        Dim toolType = newTool.Type
        If toolType <> "" Then My.Settings.ToolType = toolType

        Select Case My.Settings.ToolType
            Case "FR2T"
                model_id = "Side Mill D20 L35 SD20"'"Fraise 2 tailles D20 L35 SD20"
            Case "FRTO"
                model_id = "Fraise hémisphérique D8 L30 SD8"
            Case "FRHE"
                model_id = "Ball Nose Mill D8 L30 SD8"'"Fraise hémisphérique D8 L30 SD8"
            Case "FOP9"
                model_id = "Spotting Drill D10 SD10"
            Case "FOCA"
                model_id = "Twisted Drill D10 L35 SD10"
            Case "ALFI"
                model_id = "Constant Reamer D10 L20 SD9"
        End Select




        ''Dim asss As List(Of PdmObjectId) = TopSolidHost.Pdm.SearchProjectByName("EdiTool")
        ''TopSolidHost.Pdm.OpenProject(asss(0))
        'InitializeApi()

        ' api.TopSolidExt.Connect()

        Dim model_fr = api.CopyModelFile(model_id, modelLib)
        'Open_file(model_id, api.TopSolidExt.Pdm.SearchProjectByName("EdiTool"))

        '********
        '********
        '********
        '********
        '********
        'uncomment to unblock TS
        'api.TopSolidExt.Application.EndModification(True, False)

        If model_fr(0).isEmpty Then
            MsgBox("Can't find file ( " + model_id + " )")
            api.TopSolidExt.Application.EndModification(True, False)

            Exit Sub
        End If

        Try
            If Not api.TopSolidExt.Application.StartModification("model_fr", True) Then
                MsgBox("StartModification failure")
                api.TopSolidExt.Application.EndModification(True, False)

                Exit Sub
            End If

            Dim tmp = api.TopSolidExt.Documents.GetDocument(model_fr(0))

            api.TopSolidExt.Documents.EnsureIsDirty(tmp)
            Set_parametre_outil(tmp, newTool)


            api.TopSolidExt.Application.EndModification(True, False)

            If Main.AutoOpen_checkBox.Checked = True Then
                api.TopSolidExt.Documents.Open(tmp)
            End If

            api.TopSolidExt.Documents.Save(tmp)

            ''TopSolidHost.Documents.Close(newTool, False, False)


            If Main.AutoCheckIn_checkBox.Checked = True Then
                Dim customToolProject = My.Settings.customToolLib
                api.TopSolidExt.Pdm.CheckIn(api.TopSolidExt.Pdm.SearchDocumentByName(
            api.TopSolidExt.Pdm.SearchProjectByName(customToolProject)(0),
            api.TopSolidExt.Documents.GetName(tmp))(0), True)

            End If



            MsgBox("Outil " + Main.Name_textbox.Text + " crée")
        Catch ex As Exception

            MsgBox("Failed to edit copied ( new ) tool")
        Finally
            Try
                api.TopSolidExt.Application.EndModification(False, False)

            Catch ex As Exception
                Console.Write("app closed -> modification end")
            End Try
        End Try

    End Sub

    Function Strip_doubles(tmp As String)
        Dim tmp_string As String = tmp
        tmp_string = Replace(tmp_string, ".", ",") ' replace , -> .
        Dim res As Double = tmp_string / 1000 '  get de Double from String and scale mm to m (SI units)
        Return res
    End Function

    ' This subroutine sets the value of a Real parameter in a TopSolid document
    'Private Sub SetReal(TopDoc As DocumentId, paramName As String, paramValue As Decimal)
    Private Sub SetReal(TopDoc, paramName, paramValue)

        ' Find the ElementId of the Real parameter using its name
        Dim paramElementId = api.TopSolidExt.Elements.SearchByName(TopDoc, paramName)

        ' Set the value of the Real parameter using its ElementId and the desired value
        api.TopSolidExt.Parameters.SetRealValue(paramElementId, paramValue)

    End Sub


    Private Sub Set_parametre_outil(newTool_docId, newTool)

        Dim ToolType = My.Settings.ToolType

        'Dim Name As ElementId = TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.Name")
        Dim Name = api.TopSolidExt.Elements.SearchByName(newTool_docId, "$TopSolid.Kernel.TX.Properties.Name")

        Dim D1 As Decimal = newTool.D1 / 1000
        Dim D2 As Decimal = newTool.D2 / 1000
        Dim D3 As Decimal = newTool.D3 / 1000
        Dim L1 As Decimal = newTool.L1 / 1000
        Dim L2 As Decimal = newTool.L2 / 1000
        Dim L3 As Decimal = newTool.L3 / 1000

        SetReal(newTool_docId, "D", D1)
        SetReal(newTool_docId, "SD", D3)
        SetReal(newTool_docId, "OL", L3)
        SetReal(newTool_docId, "L", L1)


        If ToolType = "FOC9" Or ToolType = "FOCA" Then
            'Dim tmpAngleRad = Main.A_TextBox.Text * Math.PI / 180
            Dim tmpAngleRad = newTool.AngleDeg
            SetReal(newTool_docId, "A", tmpAngleRad)

            Select Case ToolType
                Case "FOC9"
                    api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FOP9)
                Case "FOCA"
                    api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FOCA)
            End Select

        ElseIf ToolType = "ALFI" Then
            api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_ALFI)
        Else

            SetReal(newTool_docId, "CTS_AD", D2)
            SetReal(newTool_docId, "CTS_AL", L2)
            SetReal(newTool_docId, "CTS_ED", D2)

            Dim CTS_AD_tmp As Double = D2

            If CTS_AD_tmp > 0 Then
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp) 'TODO ****************
            Else
                CTS_AD_tmp = Strip_doubles(Main.D_textbox.Text) ' if 0 gets from TextBox
                SetReal(newTool_docId, "CTS_EBD", CTS_AD_tmp)
            End If

            Dim CTS_EL As Double = L2
            If (Main.alpha.Text = 0) Then
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            Else
                CTS_EL = newTool.D3 - newTool.D1 / 2
                CTS_EL /= Math.Tan((Main.alpha.Text * Math.PI) / 180)
                SetReal(newTool_docId, "CTS_EL", CTS_EL) 'TODO
            End If

            If ToolType = "FRTO" Then
                Dim r As Double = Strip_doubles(Main.Chf_textbox.Text)
                SetReal(newTool_docId, "r", r) 'TODO
                api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FT)
            ElseIf ToolType = "FRHE" Then
                api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FB)
            Else
                api.TopSolidExt.Parameters.SetTextParameterizedValue(Name, My.Settings.MaskTT_FR)
            End If

        End If

        '***************
        'Debug -> get elements param list
        'Dim sys_pard As List(Of ElementId) = TopSolidHost.Elements.GetElements(newTool_docId)
        'Dim tmp As String
        'Dim lst As String() = New String(sys_pard.Count - 1) {}

        'For i As Integer = 0 To sys_pard.Count - 1
        'tmp = TopSolidHost.Elements.GetName(sys_pard(i))
        'lst(i) = tmp
        'Next
        '***************

        newTool.PublishParameters(newTool_docId)

        Try
            'TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(newTool_docId, "$TopSolid.Cam.NC.Tool.TX.MachiningComponents.NotAllowedForMachining"), True)
        Catch ex As Exception
        End Try


    End Sub






End Module