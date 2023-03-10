Option Explicit On
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
            TopSolidHost.Parameters.SetBooleanValue(TopSolidHost.Elements.SearchByName(DocId, "$TopSolid.Kernel.TX.Properties.VirtualDocument"), False)
            TopSolidHost.Parameters.PublishText(DocId, "Designation_outil", New SmartText(TopSolidHost.Parameters.GetDescriptionParameter(DocId)))
            TopSolidHost.Parameters.PublishText(DocId, "codeBar", New SmartText(TopSolidHost.Parameters.GetCodeParameter(DocId)))
            TopSolidHost.Parameters.PublishText(DocId, "id", New SmartText(TopSolidHost.Parameters.GetManufacturerPartNumberParameter(DocId)))
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
