Module Tools
    Public Class NewTool
        Public Property Name As String
        Public Property Type As String
        Public Property D1 As Single
        Public Property D2 As Single
        Public Property D3 As Single
        Public Property L1 As Single
        Public Property L2 As Single
        Public Property L3 As Single
        Public Property RayonBout As Single
        Public Property Chanfrein As Single
        Public Property AngleDeg As Single
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

    End Class


    Public Class ToolList
        Public Property Name As String
        Public Property BasicDescription As String
        Public Property RoomDescription As String
        Public Property ValidExists As New List(Of String)
        Public Property Objects As New List(Of String)
        Public Property Items As New List(Of NewTool)
    End Class
End Module
