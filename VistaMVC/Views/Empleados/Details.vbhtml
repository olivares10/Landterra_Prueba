@ModelType ado.Empleados
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Empleados</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NombreCompleto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NombreCompleto)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TipoIdentificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TipoIdentificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NumeroIdentificacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NumeroIdentificacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FechaIngreso)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FechaIngreso)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SalarioBaseMensual)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SalarioBaseMensual)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Direccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Direccion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
