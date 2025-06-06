<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.EliminarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lblEliminar" runat="server" Text="Eliminar Sucursal" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <br /><br />
            Ingresar ID sucursal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEliminar" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Height="26px" ValidationGroup="1" Width="69px" />
&nbsp;
            <asp:RequiredFieldValidator ID="rfvEliminar" runat="server" ControlToValidate="txtEliminar" ErrorMessage="Debe ingresar un ID" ForeColor="Red" ValidationGroup="1">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="revEliminar" runat="server" ControlToValidate="txtEliminar" ErrorMessage="Solo se permiten numeros" ValidationGroup="1" ForeColor="Red" ValidationExpression="^\d+$">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:ValidationSummary ID="vsEliminar" runat="server" ForeColor="Red" ValidationGroup="1" />
        </div>
    </form>
</body>
</html>
