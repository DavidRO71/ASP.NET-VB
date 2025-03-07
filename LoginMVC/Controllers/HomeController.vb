Imports System.Threading.Tasks
Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Dim sessionObj As New SessionData()

        ' GET: Home
        Function Index() As ActionResult
            'sessionObj.destroySession()
            Return View()
        End Function

        <AllowAnonymous>
        Function Users() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Users(data As UserLogin) As Task(Of ActionResult)
            If ModelState.IsValid Then
                Dim loginSuccessful As Boolean = Await Task.Run(Function() data.Login())
                If loginSuccessful Then
                    'Session("username") = data.userName
                    sessionObj.setSession("userName", data.userName)
                    ViewBag.User = sessionObj.getSession("userName")
                    Return RedirectToAction("Users", "Users")
                Else
                    ViewBag.Message = "Error"
                    Return View("Index")
                End If
            Else
                Return View("Index")
            End If
        End Function

        <AllowAnonymous>
        Function SignIn() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function SignIn(data As SignIn) As Task(Of ActionResult)
            If ModelState.IsValid Then
                If data.signIn() = False Then
                    ViewBag.Message = "The user o the email already exists"
                    Return View("SignIn", data)
                Else
                    Return RedirectToAction("Index", "Home")
                End If
            Else
                Return View("SignIn")
            End If
        End Function

    End Class
End Namespace