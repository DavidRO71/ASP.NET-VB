Imports System.ComponentModel.DataAnnotations

Public Class UsersData

    Dim userDC As New UserDataDataContext

    Function userDatos() As List(Of UsersDataModel)
        Dim list As List(Of UsersDataModel) = New List(Of UsersDataModel)
        Dim Query = From u In userDC.USER
        Dim listData = Query.ToList()

        For Each datos In listData
            list.Add(New UsersDataModel() With {
                .USER_ID = datos.USER_ID,
                .USER_NAME = datos.USER_NAME,
                .USER_LAST_NAME = datos.USER_LAST_NAME,
                .USER_LOGIN = datos.USER_LOGIN,
                .USER_PWD = datos.USER_PWD,
                .USER_EMAIL = datos.USER_EMAIL
            })
        Next

        Return list

    End Function

    Public Function editData(id As Integer) As UsersDataModel
        Dim datos As UsersDataModel

        datos = userDC.USER.Where(Function(u) u.USER_ID = id).[Select](Function(u) New UsersDataModel() With {
            .USER_ID = u.USER_ID,
            .USER_NAME = u.USER_NAME,
            .USER_LAST_NAME = u.USER_LAST_NAME,
            .USER_LOGIN = u.USER_LOGIN,
            .USER_PWD = u.USER_PWD,
            .USER_EMAIL = u.USER_EMAIL
        }).SingleOrDefault()

        Return datos

    End Function

    Public Function updateData(model As UsersDataModel) As Boolean
        Dim u As USER = userDC.USER.Where(Function(x) x.USER_ID = model.USER_ID).Single()
        u.USER_NAME = model.USER_NAME
        u.USER_LAST_NAME = model.USER_LAST_NAME
        u.USER_LOGIN = model.USER_LOGIN
        u.USER_PWD = model.USER_PWD
        u.USER_EMAIL = model.USER_EMAIL
        userDC.SubmitChanges()
        Return True

    End Function

    Public Function detailData(id As Integer) As UsersDataModel
        Dim datos As UsersDataModel

        datos = userDC.USER.Where(Function(u) u.USER_ID = id).[Select](Function(u) New UsersDataModel() With {
            .USER_ID = u.USER_ID,
            .USER_NAME = u.USER_NAME,
            .USER_LAST_NAME = u.USER_LAST_NAME,
            .USER_LOGIN = u.USER_LOGIN,
            .USER_PWD = u.USER_PWD,
            .USER_EMAIL = u.USER_EMAIL
        }).SingleOrDefault()

        Return datos

    End Function

    'Public Function deleteData(model As UsersDataModel) As Boolean
    '    Dim u As USER = userDC.USER.Where(Function(x) x.USER_ID = model.USER_ID).Single()
    '    userDC.USER.DeleteOnSubmit(u)
    '    userDC.SubmitChanges()
    '    Return True
    'End Function

    Public Function deleteData(id As Integer) As Boolean
        Dim u As USER = userDC.USER.Where(Function(x) x.USER_ID = id).Single()
        userDC.USER.DeleteOnSubmit(u)
        userDC.SubmitChanges()
        Return True
    End Function

End Class

Public Class UsersDataModel

    <Display(Name:="ID")>
    Public Property USER_ID As String

    <Display(Name:="Name")>
    Public Property USER_NAME As String

    <Display(Name:="Last Name")>
    Public Property USER_LAST_NAME As String

    <Display(Name:="Login")>
    Public Property USER_LOGIN As String

    <Display(Name:="Password")>
    Public Property USER_PWD As String

    <Display(Name:="Email")>
    Public Property USER_EMAIL As String

End Class
