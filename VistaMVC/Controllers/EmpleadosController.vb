Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ado
Imports VistaMVC.Data

Namespace Controllers
    Public Class EmpleadosController
        Inherits System.Web.Mvc.Controller

        Private db As New VistaMVCContext

        ' GET: Empleados
        Function Index() As ActionResult
            Return View(db.Empleados.ToList())
        End Function

        ' GET: Empleados/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As Empleados = db.Empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            Return View(empleados)
        End Function

        ' GET: Empleados/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Empleados/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,NombreCompleto,TipoIdentificacion,NumeroIdentificacion,FechaIngreso,SalarioBaseMensual,Direccion")> ByVal empleados As Empleados) As ActionResult
            If ModelState.IsValid Then
                db.Empleados.Add(empleados)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empleados)
        End Function

        ' GET: Empleados/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As Empleados = db.Empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            Return View(empleados)
        End Function

        ' POST: Empleados/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,NombreCompleto,TipoIdentificacion,NumeroIdentificacion,FechaIngreso,SalarioBaseMensual,Direccion")> ByVal empleados As Empleados) As ActionResult
            If ModelState.IsValid Then
                db.Entry(empleados).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(empleados)
        End Function

        ' GET: Empleados/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empleados As Empleados = db.Empleados.Find(id)
            If IsNothing(empleados) Then
                Return HttpNotFound()
            End If
            Return View(empleados)
        End Function

        ' POST: Empleados/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empleados As Empleados = db.Empleados.Find(id)
            db.Empleados.Remove(empleados)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
