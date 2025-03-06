Public Class SessionData
    Private session As String

    Public Function getSession(name As String)
        session = Convert.ToString(HttpContext.Current.Session(name))

        Return session
    End Function

    Public Sub setSession(name As String, data As String)
        HttpContext.Current.Session(name) = data
    End Sub

    Public Sub destroySession()
        HttpContext.Current.Session.Clear()
        HttpContext.Current.Session.Abandon()
        HttpContext.Current.Session.RemoveAll()
    End Sub

End Class
