Imports MongoDB.Bson

Public Class workoutSession
    Property id As ObjectId
    Property workoutId As String
    Property workoutDate As DateTime
    Property exerciseName As String
    Property weight As Integer
    Property reps As Integer
    Property bodyPart As String


    Public Sub New()
        id = ObjectId.GenerateNewId

    End Sub

End Class
