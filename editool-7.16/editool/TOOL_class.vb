Option Explicit On
Imports System.Reflection

Module Tools
    Public Class NewTool
        Private Property Name As String
        Public Property Type As String
        Public Property D1 As Decimal
        Public Property D2 As Decimal
        Public Property D3 As Decimal
        Public Property L1 As Decimal
        Public Property L2 As Decimal
        Public Property L3 As Decimal
        Public Property RayonBout As Decimal
        Public Property Chanfrein As Decimal
        Public Property AngleDeg As Decimal
        Public Property NoTT As Integer
        Public Property GroupeMat As String
        Public Property CoupeCentre As String 'Boolean
        Public Property ArrCentre As String ' Boolean
        Public Property TypeTar As String
        Public Property PasTar As String

        Public Property Manuf As String
        Public Property ManufRef As String
        Public Property ManufRefSec As String

        Public Property Code As String
        Public Property CodeBar As String

        Public Property GSName As Integer

            Get
                Return Name
            End Get
            Set(value As Integer)
                Name = value
            End Set
        End Property


        Public Sub PublishParameters(DocId)

            Dim topSolidKernel As Assembly = api.GetTsAssembly()

            Dim smartTextType As Type = topSolidKernel.GetType("TopSolid.Kernel.Automating.SmartText")
            Dim constructor = smartTextType.GetConstructor({GetType(String)})


            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber"), ManufRef)
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Manufacturer"), Manuf)
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Code"), CodeBar)
            ' api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Author"), "Editool")
            api.TopSolidExt.Parameters.SetTextValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.PartNumber"), Code)

            api.TopSolidExt.Parameters.SetBooleanValue(api.TopSolidExt.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
            Dim smartTextTypeInstance = constructor.Invoke({"Designation_outil1"})

            'smartTextType = api.TopSolidExt.Parameters.GetDescriptionParameter(DocId)
            api.TopSolidExt.Parameters.PublishText(DocId, "Designation_outil", smartTextTypeInstance)
            'smartTextType = api.TopSolidExt.Parameters.GetCodeParameter(DocId)
            smartTextTypeInstance = constructor.Invoke({"codeBar"})

            api.TopSolidExt.Parameters.PublishText(DocId, "codeBar", smartTextTypeInstance)
            'smartTextType = api.TopSolidExt.Parameters.GetPartNumberParameter(DocId)
            smartTextTypeInstance = constructor.Invoke({"id"})

            api.TopSolidExt.Parameters.PublishText(DocId, "id", smartTextTypeInstance)

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


    End Class

    Public Class ToolList
        Public Property Name As String
        Public Property BasicDescription As String
        Public Property RoomDescription As String
        Public Property ValidExists As New List(Of String)
        Public Property Objects As New List(Of String)
        Public Property Tool As New List(Of NewTool)


        Public Shared Function GetToolsTypes(tools As ToolList) As List(Of String)
            Dim toolTypes As New List(Of String)
            Dim Filter As String = "FR2T"


            'For Each tool As NewTool In tools.Tool.Where(Function(t) t.Type.Contains(Filter))

            For Each tool As NewTool In tools.Tool
                If Not toolTypes.Contains(tool.Type) Then
                    toolTypes.Add(tool.Type)
                    Dim btn As New ToolStripButton With {
                        .Text = tool.Type
                    }

                    ' .ToolTipText = tool.

                    AddHandler btn.Click, AddressOf Main.ToolTypeButton_Click
                    Main.ToolStrip1.Items.Add(btn)
                End If
            Next

            Return toolTypes
        End Function

    End Class


End Module
