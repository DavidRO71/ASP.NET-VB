<!DOCTYPE html>

@Imports System.Web.Optimization

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Scripts.Render("~/bundles/jqueryvalunobtrusive")

    @Styles.Render("~/Content/css")

</head>
<body>

    @Code
        'Antigua version
        'Dim user As String = Convert.ToString(Session("userName"))
        'If user <> "" Then
        If ViewBag.User <> "" Then
            @<div class="head">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Users", "Users")</li>
                    <li>@Html.ActionLink("Exit", "Close", "Users")</li>
                </ul>
            </div>
            @<br>
            '@<br>
            '@<h2>Welcome: @ViewBag.User</h2>
        End If

    End Code

    <div>
        @RenderBody()
    </div>

    <footer class="footer">
        <p>&copy; DRO-INFO 2019</p>
    </footer>
</body>
</html>
