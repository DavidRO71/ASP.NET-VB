Imports System.Threading.Tasks
Imports System.Web.Mvc

Namespace Controllers
    Public Class UsersController
        Inherits Controller

        Dim sessionObj As New SessionData()
        Dim obj As New UsersData()

        ' GET: Users
        Function Users() As ActionResult
            ViewBag.User = sessionObj.getSession("userName")
            If ViewBag.User = "" Then
                Return RedirectToAction("Index", "Home")
            Else
                clearCache()
                Return View(obj.userDatos)
            End If
        End Function

        Function Close() As ActionResult
            sessionObj.destroySession()
            Return RedirectToAction("Index", "Home")
        End Function

        Function Edit(id As Integer) As ActionResult
            ViewBag.User = sessionObj.getSession("userName")
            If ViewBag.User = "" Then
                Return RedirectToAction("Index", "Home")
            Else
                clearCache()
                Return View(obj.editData(id))
            End If

        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Edit(model As UsersDataModel) As Task(Of ActionResult)
            If obj.updateData(model) = False Then
                Return RedirectToAction("Users")
            Else
                Return View(model)
            End If
        End Function

        'Elimina los datos del cache de nuestro navegador
        Sub clearCache()
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache)
            Response.Cache.SetAllowResponseInBrowserHistory(False)
            Response.Cache.SetNoStore()
        End Sub

        Function Detail(id As Integer) As ActionResult
            ViewBag.User = sessionObj.getSession("userName")
            If ViewBag.User = "" Then
                Return RedirectToAction("Index", "Home")
            Else
                clearCache()
                Return View(obj.editData(id))
            End If

        End Function

        Function Delete(id As Integer) As ActionResult
            ViewBag.User = sessionObj.getSession("userName")
            If ViewBag.User = "" Then
                Return RedirectToAction("Index", "Home")
            Else
                clearCache()
                Return View(obj.editData(id))
            End If

        End Function

        '<HttpPost>
        '<AllowAnonymous>
        'Public Async Function Delete(model As UsersDataModel) As Task(Of ActionResult)
        '    If obj.deleteData(model) = True Then
        '        Return RedirectToAction("Users")
        '    Else
        '        Return View(model)
        '    End If
        'End Function


        <HttpPost>
        <AllowAnonymous>
        Public Async Function Delete(model As UsersDataModel, id As Integer) As Task(Of ActionResult)
            If obj.deleteData(id) = True Then
                Return RedirectToAction("Users")
            Else
                Return View(model)
            End If
        End Function


        Function Create() As ActionResult
            ViewBag.User = sessionObj.getSession("userName")
            If ViewBag.User = "" Then
                Return RedirectToAction("Index", "Home")
            Else
                clearCache()
                Return View()
            End If
        End Function

        <HttpPost>
        <AllowAnonymous>
        Public Async Function Create(data As SignIn) As Task(Of ActionResult)
            If ModelState.IsValid Then
                If data.signIn() = False Then
                    ViewBag.Message = "The user o the email already exists"
                    Return View("Create", data)
                Else
                    Return RedirectToAction("Users")
                End If
            Else
                Return View("Create")
            End If
        End Function


    End Class
End Namespace