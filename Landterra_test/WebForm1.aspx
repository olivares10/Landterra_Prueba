<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Landterra_test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 241px;
            height: 78px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div style="height: 487px" runat="server" id="Registo">
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td align="center">
                                <asp:Label ID="lblTituloFormulario" runat="server" Text="Registro de Emplados."></asp:Label>
                              
                            </td>
                        </tr>
                    </table>
                    <table style="width: 100%;">


                        <tr>
                            <td>Ingrese Nombre Completo del Emplado:</td>
                            <td>
                                <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Seleccione el tipo de Identificacion:</td>
                            <td>
                                <asp:ListBox ID="lbID" runat="server" Height="24px" Width="158px">
                                    <asp:ListItem>Cedula</asp:ListItem>
                                    <asp:ListItem>Pasaporte</asp:ListItem>
                                </asp:ListBox></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Ingreses numero de Identificacion:</td>
                            <td>
                                <asp:TextBox ID="txtIdentificacion" runat="server" Width="170px"></asp:TextBox></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Fecha de Ingreso:</td>
                            <td>
                                <asp:Calendar ID="FechaIngreso" runat="server"></asp:Calendar>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Salario Base:</td>
                            <td>
                                <asp:TextBox ID="txtSalario" runat="server" Width="170px"></asp:TextBox></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Direccion:</td>
                            <td>
                                <textarea id="txtDirecion" cols="20" name="S1" rows="1"></textarea></td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Guardar" /></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div style="height: 487px" runat="server" id="Vacaciones" visible="false">
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
                <ContentTemplate>
                    <table style="width: 100%;">
                        <tr>
                            <td align="center">
                                <asp:Label ID="Label1" runat="server" Text="Registro de Vacaciones"></asp:Label>

                            </td>
                        </tr>
                    </table>
                    <table style="width: 100%;">
                        <asp:HiddenField ID="hfIDEmpleado" runat="server" />
                        <tr>
                            <td>Emplado:</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Fecha de Inicio:</td>
                            <td>
                                <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                            </td>
                            <td>Fecha de Fin:</td>
                            <td>
                                <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Guardar" />

                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div style="height: 487px">            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</bodv>
</html>
