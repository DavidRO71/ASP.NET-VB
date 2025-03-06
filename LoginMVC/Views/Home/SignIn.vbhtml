@ModelType LoginMVC.SignIn
@Code
    ViewData("Title") = "SignIn"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<div class="container">
    <div class="card card-container">
        <h3 class="titleLogin">Register</h3>
        @Code
            Using (Html.BeginForm("SignIn", "Home", FormMethod.Post, New With {.class = "form-signin"}))
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @<div>
                    <div>
                        @Html.TextBoxFor(Function(u) u.Name, New With {.class = "form-control", .placeHolder = "Name"})
                        @Html.ValidationMessageFor(Function(u) u.Name, "", New With {.class = "text-danger"})
                    </div><br />
                    <div>
                        @Html.TextBoxFor(Function(u) u.LastName, New With {.class = "form-control", .placeHolder = "Last Name"})
                        @Html.ValidationMessageFor(Function(u) u.LastName, "", New With {.class = "text-danger"})
                    </div><br />
                    <div>
                        @Html.TextBoxFor(Function(u) u.User, New With {.class = "form-control", .placeHolder = "Login"})
                        @Html.ValidationMessageFor(Function(u) u.User, "", New With {.class = "text-danger"})
                    </div><br />
                    <div>
                        @Html.TextBoxFor(Function(u) u.Email, New With {.class = "form-control", .placeHolder = "Email"})
                        @Html.ValidationMessageFor(Function(u) u.Email, "", New With {.class = "text-danger"})
                    </div><br />
                    <div>
                        @Html.PasswordFor(Function(u) u.Password, New With {.class = "form-control", .placeHolder = "Password"})
                        @Html.ValidationMessageFor(Function(u) u.Password, "", New With {.class = "text-danger"})
                    </div><br />
                    @Code
                        If ViewBag.Message <> "" Then
                            @<p class="error-message">@ViewBag.Message</p>
                        End If
                    End Code
                </div>
                @<input type="submit" value="Register" class="btn btn-signin " />
                        End Using
        End Code
        <br />
        @Html.ActionLink("Login", "Index", "Home")
    </div>
</div>

