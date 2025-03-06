@ModelType LoginMVC.UserLogin
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<div class="container">
    <div class="card card-container">
        <h2 class="titleLogin">Login</h2>
        @Code
            'Users es el metodo que se encuentra en el controlador HomeController pero el que tiene <HttpPost>
            'Ya que los datos se envian por POST --> FormMethod.Post
            Using (Html.BeginForm("Users", "Home", FormMethod.Post, New With {.class = "form-signin"}))
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @<div>
                    <div>
                        @Html.TextBoxFor(Function(u) u.Email, New With {.class = "form-control", .placeHolder = "Email"})
                        @Html.ValidationMessageFor(Function(u) u.Email, "", New With {.class = "text-danger"})
                    </div>
                    <div>
                        @Html.PasswordFor(Function(u) u.Password, New With {.class = "form-control", .placeHolder = "Password"})
                        @Html.ValidationMessageFor(Function(u) u.Password, "", New With {.class = "text-danger"})
                    </div>
                    <br />
                </div>
                @<Input type="submit" value="Send" class="btn btn-signin" />
            End Using
        End Code

        <br>
        <h4>@Html.ActionLink("Sign in", "SignIn", "Home")</h4>

        @Code
            If ViewBag.Message <> "" Then
                @<script type="text/javascript">
                     alert('Email or Password are incorrect')
                     document.location = "Index";
                </script>
            End If
        End Code
    </div>
</div>

