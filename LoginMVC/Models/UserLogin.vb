Imports System.ComponentModel.DataAnnotations

Public Class UserLogin
    <EmailAddress>
    <Required(ErrorMessage:="<font color='red'>Email is required</font>")>
    <Display(Name:="Email")>
    Public Property Email As String

    <StringLength(100, ErrorMessage:="<font color='red'>{0} must have at least {2} caracters</font>", MinimumLength:=3)>
    <Required(ErrorMessage:="<font color='red'>Password is required</font>")>
    <Display(Name:="Password")>
    Public Property Password As String

    Public Property userName As String

    Dim User As New UserDataDataContext
    Public Function Login()
        'LINQ
        Dim Query = From u In User.USER
                    Where u.USER_EMAIL = Email And u.USER_PWD = Password Select u
        If Query.Count() > 0 Then
            Dim UserData = Query.ToList()

            For Each Dato In UserData
                userName = Dato.USER_NAME
            Next
            Return True
        Else
            Return False
        End If
    End Function

End Class
