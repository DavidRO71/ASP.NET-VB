@ModelType LoginMVC.UsersDataModel
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<div class="container">
        
    <div class="card card-container">
        <h2>Delete User</h2>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_ID) :
                @Html.DisplayFor(Function(model) model.USER_ID)
            </dt>

            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_NAME) :
                @Html.DisplayFor(Function(model) model.USER_NAME)
            </dt>

            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_LAST_NAME) :
                @Html.DisplayFor(Function(model) model.USER_LAST_NAME)
            </dt>

            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_LOGIN) :
                @Html.DisplayFor(Function(model) model.USER_LOGIN)
            </dt>

            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_PWD) :
                @Html.DisplayFor(Function(model) model.USER_PWD)
            </dt>

            <dt>
                @Html.DisplayNameFor(Function(model) model.USER_EMAIL) :
                @Html.DisplayFor(Function(model) model.USER_EMAIL)
            </dt>
            <hr />
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-signin" />
            </div>
        End Using

        <div>
            <h4>@Html.ActionLink("Back to List", "Users")</h4>
        </div>
    </div>
</div>
