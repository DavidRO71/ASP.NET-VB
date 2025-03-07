@ModelType IEnumerable(Of LoginMVC.UsersDataModel)
@Code
ViewData("Title") = "Users"
Layout = "~/Views/Shared/_LayoutPage1.vbhtml"
End Code

<h2>View Users</h2>

<p>
    <h3>@Html.ActionLink("Create New", "Create")</h3>
    <form action="@Url.Action("Create", "Users")" method="get">
        <button type="submit" class="btn btn-new">Create New</button>
    </form>
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.USER_NAME)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.USER_LAST_NAME)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.USER_LOGIN)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.USER_PWD)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.USER_EMAIL)
        </th>
        <th>
            Actions
        </th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.USER_NAME)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.USER_LAST_NAME)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.USER_LOGIN)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.USER_PWD)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.USER_EMAIL)
        </td>
        <th class="centrado">
            @Html.ActionLink("Edit", "Edit", New With {.id = item.USER_ID}) |
            @Html.ActionLink("Detail", "Detail", New With {.id = item.USER_ID}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.USER_ID})
        </th>
    </tr>
Next

</table>
