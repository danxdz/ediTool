Option Explicit On
Imports System.Reflection
Imports EdiTool.ToolsModule

Module ToolsModule

    Public ReadOnly fullToolsList = New List(Of Tool)

    Public Class Tool
        Public Property Id As String
        Public Property Name As String
        Public Property Type As String
        Public Property D1 As Double
        Public Property D2 As Double
        Public Property D3 As Double
        Public Property L1 As Double
        Public Property L2 As Double
        Public Property L3 As Double
        Public Property CorRadius As Double
        Public Property CorChamfer As Double
        Public Property AngleColl As Double
        Public Property AnglePoint As Double
        Public Property NoTT As Integer
        Public Property GroupeMat As String
        Public Property ToolMaterial As String
        Public Property CoupeCentre As String 'Boolean
        Public Property ArrCentre As String ' Boolean
        Public Property TypeTar As String
        Public Property PasTar As String

        Public Property Manuf As String
        Public Property ManufRef As String
        Public Property ManufRefSec As String

        Public Property Code As String
        Public Property CodeBar As String



        Public Sub New()

            If (D1 > 0) Then D2 = D1 - 0.2
            If (L1 > 0) Then L2 = L1

            If Me.Type = "drill" Then AnglePoint = 140
            ValidateProperties()
        End Sub


        Public Sub AddTool()

            'Dim service As New FirestoreService
            'service.AddToolAsync(newTool)
            Dim localTools As New SQLiteToolDatabase(Type) 'TODO

            localTools.AddTool(Me)
            graphics.Refresh_outil(Me, Main.ToolPreview_PictureBox)
            FillDataGrid(Me, Main.NewToolDataGridView)
            Main.localtools.add(Me)


        End Sub

        Public Sub SetType(toolType As String)
            Select Case toolType
                Case "c", "f", "hss"
                    My.Settings.ToolType = "drill"
                Case "endMill"
                    My.Settings.ToolType = "endMill"
            End Select
            Dim localtools = New List(Of Tool)

            localtools = GetAllToolsByType()
            If localtools.Count > 0 Then
                Main.NewToolDataGridView.DataSource = ""
            End If
            For Each tool As Tool In localtools
                FillDataGrid(tool, Main.NewToolDataGridView)

            Next
        End Sub

        Private Sub ValidateProperties()
            If Type = "drill" AndAlso AnglePoint <> 140 Then
                Throw New InvalidOperationException("Invalid AnglePoint value for drill type.")
            End If

            If D2 > D1 Then
                Throw New InvalidOperationException("Invalid D2 value. D2 should be less than D1.")
            End If

            If L2 > L1 Then
                Throw New InvalidOperationException("Invalid L2 value. L2 should be less than or equal to L1.")
            End If
        End Sub
        Public Sub PublishParameters(DocId)

            Dim topSolidKernel As Assembly = api.GetTsAssembly()

            Dim smartTextType As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.SmartText")
            Dim elementIdType As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.ElementId")

            'Dim smartTextConstructor = smartTextType.GetConstructor({GetType(String)})

            Dim smartTextConstructor = smartTextType.GetConstructor({elementIdType})

            'Dim elementId As Object = Activator.CreateInstance(elementIdType)

            Dim elementId = api.TopSolidExt.Parameters.GetDescriptionParameter(DocId)
            Dim smartTextInstance As Object = smartTextConstructor.Invoke({elementId})
            api.TopSolidExt.Parameters.PublishText(DocId, "Designation_outil", smartTextInstance)

            'TopSolidHost.Parameters.GetCodeParameter(DocId)
            elementId = api.TopSolidExt.Parameters.GetCodeParameter(DocId)
            smartTextInstance = smartTextConstructor.Invoke({elementId})
            api.TopSolidExt.Parameters.PublishText(DocId, "codeBar", smartTextInstance)

            'TopSolidHost.Parameters.GetPartNumberParameter(DocId)
            elementId = api.TopSolidExt.Parameters.GetPartNumberParameter(DocId)
            smartTextInstance = smartTextConstructor.Invoke({elementId})
            api.TopSolidExt.Parameters.PublishText(DocId, "id", smartTextInstance)


            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber"), ManufRef)
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Manufacturer"), Manuf)
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Code"), CodeBar)
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.PartNumber"), Code)
            api.TopSolidExt.Parameters.SetBooleanValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
            ' api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Author"), "Editool")

            'Debug -> get elements param list
            'Dim sys_pard As List(Of ElementId) = TopSolidHost.Elements.GetElements(DocId)
            'Dim tmp As String
            'Dim lst As String() = New String(sys_pard.Count - 1) {}

            'For i As Integer = 0 To sys_pard.Count - 1
            '    tmp = TopSolidHost.Elements.GetName(sys_pard(i))
            '    If tmp = "" Then
            '        tmp = TopSolidHost.Elements.GetDescription(sys_pard(i))

            '        lst(i) = "aze"
            '    End If
            '    lst(i) = tmp
            'Next

            '***************
        End Sub



        Public Shared Function GetAllToolsByType()
            Dim fullToolsList As New List(Of Tool)

            Dim toolType As String = If(My.Settings.ToolType = "", "endMill", My.Settings.ToolType)
            Dim db As New SQLiteToolDatabase(toolType)

            Dim localtools As List(Of Tool) = db.GetAllTools()

            If localtools IsNot Nothing Or localtools.Count > 0 Then
                For Each tool As Tool In localtools
                    fullToolsList.Add(tool)
                    FillDataGrid(tool, Main.NewToolDataGridView)
                Next
            End If
            Tool.GetToolsTypes(fullToolsList)

            Return localtools

        End Function

        Public Shared Function GetToolsTypes(tools As List(Of Tool)) As List(Of String)
            Dim toolTypes As New List(Of String)
            Dim Filter As String = "FR2T"


            'For Each tool As NewTool In tools.Tool.Where(Function(t) t.Type.Contains(Filter))

            For Each tool As Tool In tools
                If Not toolTypes.Contains(tool.Type) Then
                    toolTypes.Add(tool.Type)
                    Dim btn As New ToolStripButton With {
                        .Text = tool.Type
                    }

                    ' .ToolTipText = tool.

                    AddHandler btn.Click, AddressOf Main.ToolTypeButton_Click
                    ' Main.ToolStrip1.Items.Add(btn)
                End If
            Next

            Return toolTypes
        End Function

    End Class


End Module
