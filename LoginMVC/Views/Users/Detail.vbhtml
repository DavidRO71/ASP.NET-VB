@ModelType LoginMVC.UsersDataModel
@Code
    ViewData("Title") = "Detail"
    Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<div class="container">

    <div class="card containerDetail">
        <h2>Detail user</h2>
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

            <p>
                <hr />
                <div>
                    <h4>
                        @Html.ActionLink("Edit", "Edit", New With {.id = Model.USER_ID}) |
                        @Html.ActionLink("Back to List", "Users")
                    </h4>
                </div>

            </p>

        </dl>
    </div>
</div>