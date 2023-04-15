Imports Google.Cloud.Firestore

Module Firebase_IO

    Public Class FirestoreService
        Private ReadOnly db As FirestoreDb

        Public Sub New()
            Dim projectId = "editools-000"
            Me.db = FirestoreDb.Create(projectId)
        End Sub

        Public Sub AddToolAsync(tool As NewTool)

            Dim type = tool.Type
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
    End Class

End Module
