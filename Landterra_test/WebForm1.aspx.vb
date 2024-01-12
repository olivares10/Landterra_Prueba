Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsNothing(Request.Params.Get("__EVENTTARGET")) Then
            If Request.Params.Get("__EVENTTARGET").ToString() = "liVacaciones" Then
                CargarEditar(CInt(Request.Params.Get("__EVENTARGUMENT").ToString()))
            End If

        End If
    End Sub

    Private Sub CargarEditar(ByVal IDTransaccion As Integer)
        txtIDEmpleado.Text = IDTransaccion

        'Dim dtAprobado As DataTable = Sql("select * from Bodega_Transacciones where IDTransaccion = '" & txtIDAnularTransS.Text & "'", "tblAprobado").Tables(0)
        'If CInt(dtAprobado.Rows(0)("IDEstadoTrans")) = 3 Then
        '    TryCast(Me.Parent.FindControl("MensajeJQuery1"), MensajeJQuery).ShowMessage("No se Puede Anular una transaccion Aplicada", 2)
        '    ScriptManager.RegisterClientScriptBlock(Me.uppanelSalidas, Page.GetType(), "Script", "oculatarModalAnularS();", True)
        'End If
        'upAnularTransS.Update()
        'ScriptManager.RegisterClientScriptBlock(Me.uppanelSalidas, Page.GetType(), "Script", "mostrarModalAnularS();", True)
    End Sub

End Class