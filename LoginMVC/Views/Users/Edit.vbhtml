@ModelType LoginMVC.UsersDataModel
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

    <div class="container">

        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="card card-container">
                <h2>Edit User</h2>
                <!--<h4>UsersDataModel</h4>-->
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_ID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_ID, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_ID, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_NAME, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_NAME, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_NAME, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_LAST_NAME, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_LAST_NAME, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_LAST_NAME, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_LOGIN, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_LOGIN, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_LOGIN, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_PWD, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_PWD, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_PWD, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.USER_EMAIL, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.USER_EMAIL, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.USER_EMAIL, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <hr />
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Save" class="btn btn-signin" />
                    </div>
                    <div class="col-md-offset-2 col-md-10" >
                        <h4>@Html.ActionLink("Back to List", "Users")</h4>
                    </div>
                </div>
            </div>
        End Using


    </div>