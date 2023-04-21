Imports FirebaseAdmin
Imports FirebaseAdmin.Auth
Imports Google.Apis.Auth.OAuth2
Imports Google.Cloud.Firestore

Module Firebase_IO

    Public Class FirestoreService
        Private ReadOnly db As FirestoreDb

        Public Sub New()
            Try
                ' Dim value As String = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS")

                Me.db = New FirestoreDbBuilder With {
                    .projectId = "editools-000",
                    .Credential = GoogleCredential.GetApplicationDefault()
                }.Build()

            Catch ex As Exception

            End Try

>>>>>>>>> Temporary merge branch 2

                Dim projectId = "editools-000"
            Dim Credential = GoogleCredential.GetApplicationDefault()
            Me.db = firestoreDbBuilder

            Catch ex As Exception

            End Try
        End Sub

        Public Sub AddToolAsync(tool As Tool)

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
<<<<<<<<< Temporary merge branch 1
        Public Function GetTools(type As String) As List(Of NewTool)
=========
        Public Function GetTools(type As String) As List(Of Tool)
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
                Dim querySnapshot = query.GetSnapshotAsync().GetAwaiter().GetResult()
                                        .RayonBout = data("RayonBout"),
                                        .Chanfrein = data("Chanfrein"),
                                        .AngleDeg = data("AngleDeg"),
                                        .NoTT = data("NoTT"),
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
>>>>>>>>> Temporary merge branch 2

            Try

                Dim collection = db.Collection(type)
                Dim query = collection.OrderBy("Name")
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
