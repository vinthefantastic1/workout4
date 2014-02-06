Imports MongoDB.Bson
Imports MongoDB.Driver
Imports MongoDB.Driver.Builders
Imports MongoDB.Driver.Linq

Namespace workout4
    Public Class homeController
        Inherits System.Web.Mvc.Controller

        Dim connectionString As String = "mongodb://localhost"
        Dim mongo As New MongoClient(connectionString)
        Dim mserver = mongo.GetServer
        Dim db = mserver.GetDatabase("workouts")
        Dim vlc As MongoCollection(Of workoutSession)

        '
        ' GET: /home

        Function Index() As ActionResult

            vlc = db.GetCollection(Of workoutSession)("workoutSessions")
            Dim vw = (From v In vlc Select v)
            Return View(vw.tolist)

            Return View()
        End Function

        '
        ' GET: /home/Details/5

        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' GET: /home/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /home/Create

        <HttpPost()> _
        Function Create(ByVal collection As FormCollection) As ActionResult
            '  Try
            ' TODO: Add insert logic here
            vlc = db.GetCollection(Of workoutSession)("workoutSessions")

            Dim nwo As New workoutSession

            nwo.workoutId = nwo.id.ToString
            nwo.exerciseName = collection("exercisename")
            nwo.reps = collection("reps")
            nwo.weight = collection("weight")
            nwo.bodyPart = collection("bodypart")

            vlc.Insert(nwo)

            Return RedirectToAction("Index")
            ' Catch ex As Exception
            'ViewData("error") = ex.Message
            ' Return View()
            ' End Try
        End Function

        '
        ' GET: /home/Edit/5

        Function Edit(ByVal id As String) As ActionResult

            vlc = db.GetCollection(Of workoutSession)("workoutSessions")

            Dim vw = (From v In vlc Where v.workoutId.Equals(id)).First

            Return View(vw)
        End Function

        '
        ' POST: /home/Edit/5

        <HttpPost()> _
        Function Edit(ByVal id As String, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                vlc = db.GetCollection(Of workoutSession)("workoutSessions")

                Dim vw = (From v In vlc Where v.workoutId.Equals(id)).First

                Dim nwo = vw

                nwo.exerciseName = collection("exercisename")
                nwo.reps = collection("reps")
                nwo.weight = collection("weight")
                nwo.bodyPart = collection("bodypart")
                nwo.workoutDate = Convert.ToDateTime(collection("workoutDate"))

                vlc.Save(nwo)


                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /home/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /home/Delete/5

        <HttpPost()> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        Function about() As ActionResult

            Return View()
        End Function
    End Class
End Namespace