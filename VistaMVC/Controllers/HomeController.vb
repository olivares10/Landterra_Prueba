Imports Negocio
Imports System.Web.Mvc

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        'Dim negocio As New ClassEmpleados() ' Reemplaza con el nombre correcto de tu clase de servicio
        'Dim empleados As DataTable = negocio.ListarEmpleado()

        'If empleados.Rows.Count > 0 Then
        '    ' Puedes pasar los datos a la vista utilizando un modelo si es necesario
        '    ' En este ejemplo, estoy utilizando ViewData para pasar la DataTable directamente
        '    ViewData("ListaEmpleados") = empleados
        '    Return View(empleados)
        '    'Return View()
        'Else
        '    ' Manejar el caso en que no se encuentren empleados
        '    Return View("SinEmpleados")
        'End If
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

End Class
