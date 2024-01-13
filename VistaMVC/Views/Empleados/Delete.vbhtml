@ModelType ado.Empleados
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
