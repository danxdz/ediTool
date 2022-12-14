Module Tools
    Public Class NewTool
        Public Property Name As String
        Public Property Type As String
        Public Property D1 As String
        Public Property D2 As Double
        Public Property D3 As Double
        Public Property L1 As Double
        Public Property L2 As Double
        Public Property L3 As Double
        Public Property RayonBout As Double
        Public Property Chanfrein As Double
        Public Property AngleDeg As Double
        Public Property NoTT As Integer
        Public Property GroupeMat As String
        Public Property CoupeCentre As String
        Public Property ArrCentre As String
        Public Property TypeTar As String
        Public Property PasTar As String

        Public Property Manuf As String
        Public Property ManufRef As String
        Public Property ManufRefSec As String


        Public Property Code As String
        Public Property CodeBar As String

    End Class


    Public Class ToolList
        Public Property Name As String
        Public Property BasicDescription As String
        Public Property RoomDescription As String
        Public ReadOnly Property ValidExists As New List(Of String)
        Public ReadOnly Property Objects As New List(Of String)
        Public ReadOnly Property Items As New List(Of NewTool)
    End Class
End Module
