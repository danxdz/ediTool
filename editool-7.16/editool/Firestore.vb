Imports FirebaseAdmin
Imports FirebaseAdmin.Auth
Imports Google.Apis.Auth.OAuth2
Imports Google.Cloud.Firestore
Imports Google.Cloud.Firestore.V1
Imports Grpc.Auth
Imports Grpc.Core

Module Firebase_IO

    Public Class FirestoreService
        Private ReadOnly db As FirestoreDb

        Public Sub New()
            Dim projectId = "editools-000"
            Me.db = FirestoreDb.Create(projectId)

        End Sub

        Public Sub AddToolAsync(tool As NewTool)

            Dim type = tool.Type
            If type = "" Then 'TODO
                type = "FR2T"
            End If
            Dim collection = db.Collection(type)


            ' Adiciona um novo documento ao Firestore com um ID aleatório
            Dim docRef = collection.Document()

            Dim data = New With {
                tool.Name,
                tool.Type,
                tool.D1,
                tool.D2,
                tool.D3,
                tool.L1,
                tool.L2,
                tool.L3,
                tool.RayonBout,
                tool.Chanfrein,
                tool.AngleDeg,
                tool.NoTT,
                tool.GroupeMat,
                tool.CoupeCentre,
                tool.ArrCentre,
                tool.TypeTar,
                tool.PasTar,
                tool.Manuf,
                tool.ManufRef,
                tool.ManufRefSec,
                tool.Code,
                tool.CodeBar
            }

            Dim res = docRef.SetAsync(data)
            Debug.WriteLine(res)
        End Sub
        Public Function GetTools(type As String) As List(Of NewTool)
            Dim collection = db.Collection(type)
            Dim query = collection.OrderBy("Name")
            Try
                Dim querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult()

                Dim tools = New List(Of NewTool)()

                For Each docSnapshot As DocumentSnapshot In querySnapshot.Documents
                    If docSnapshot.Exists Then
                        Dim data = docSnapshot.ToDictionary()
                        Dim tool = New NewTool With {
                                .Name = data("Name"),
                                .Type = data("Type"),
                                .D1 = data("D1"),
                                .D2 = data("D2"),
                                .D3 = data("D3"),
                                .L1 = data("L1"),
                                .L2 = data("L2"),
                                .L3 = data("L3"),
                                .RayonBout = data("RayonBout"),
                                .Chanfrein = data("Chanfrein"),
                                .AngleDeg = data("AngleDeg"),
                                .NoTT = data("NoTT"),
                                .GroupeMat = data("GroupeMat"),
                                .CoupeCentre = data("CoupeCentre"),
                                .ArrCentre = data("ArrCentre"),
                                .TypeTar = data("TypeTar"),
                                .PasTar = data("PasTar"),
                                .Manuf = data("Manuf"),
                                .ManufRef = data("ManufRef"),
                                .ManufRefSec = data("ManufRefSec"),
                                .Code = data("Code"),
                                .CodeBar = data("CodeBar")
                                }
                        tools.Add(tool)
                    End If
                Next

                Return tools


            Catch ex As Exception

            End Try

        End Function

    End Class
End Module
