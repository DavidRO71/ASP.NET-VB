Imports System.ComponentModel.DataAnnotations
Public Class SignIn
    <Required(ErrorMessage:="<font color='red'>The name is required</font>")>
    <Display(Name:="Name")>
    Public Property Name As String

    <Required(ErrorMessage:="<font color='red'>The lastname is required</font>")>
    <Display(Name:="Lastname")>
    Public Property LastName As String

    <Required(ErrorMessage:="<font color='red'>The user is required</font>")>
    <Display(Name:="User")>
    Public Property User As String

    <EmailAddress>
    <Required(ErrorMessage:="<font color='red'>Email is required</font>")>
    <Display(Name:="Email")>
    Public Property Email As String

    <StringLength(100, ErrorMessage:="<font color='red'>{0} must have at least {2} caracters</font>", MinimumLength:=3)>
    <Required(ErrorMessage:="<font color='red'>Password is required</font>")>
    <Display(Name:="Password")>
    Public Property Password As String

    Dim userDC As New UserDataDataContext
    Dim us As New USER

    Public Function signIn()
        'Comprobamos que el usuario no existe en la tabla con:
        'El mismo Email y Nombre
        Dim Query = From u In userDC.USER
                    Where u.USER_EMAIL = Email And u.USER_NAME = User Select u
        If Query.Count() > 0 Then
            Return False
        Else
            us.USER_NAME = Name
            us.USER_LAST_NAME = LastName
            us.USER_LOGIN = User
            us.USER_EMAIL = Email
            us.USER_PWD = Password

            userDC.USER.InsertOnSubmit(us)
            userDC.SubmitChanges()
            Return True
        End If
    End Function
End Class
