Option Explicit On

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
            TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.ManufacturerPartNumber"), ManufRef)
            TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Manufacturer"), Manuf)
            TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Code"), CodeBar)
            TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.Author"), "Editool")
            TopSolidHost.Parameters.SetTextValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.PartNumber"), Code)

            TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
            TopSolidHost.Parameters.PublishText(DocId, "Designation_outil", New SmartText(TopSolidHost.Parameters.GetDescriptionParameter(DocId)))
            TopSolidHost.Parameters.PublishText(DocId, "codeBar", New SmartText(TopSolidHost.Parameters.GetCodeParameter(DocId)))
            TopSolidHost.Parameters.PublishText(DocId, "id", New SmartText(TopSolidHost.Parameters.GetPartNumberParameter(DocId)))

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
    End Class
End Module
