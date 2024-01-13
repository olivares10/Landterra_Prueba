@ModelType IEnumerable(Of ado.Empleados)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.NombreCompleto)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TipoIdentificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NumeroIdentificacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FechaIngreso)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SalarioBaseMensual)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NombreCompleto)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TipoIdentificacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NumeroIdentificacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FechaIngreso)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SalarioBaseMensual)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Direccion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
