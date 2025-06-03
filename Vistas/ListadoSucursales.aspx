<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

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
            <asp:Label ID="lblListado" runat="server" Text="Listado de sucursales" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <br /><br />
            Búsqueda ingrese ID sucursal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBuscar" runat="server" Width="200px" ValidationGroup="1"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" ValidationGroup="1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Todos" OnClick="btnMostrar_Click"/>
        &nbsp;
            <asp:RequiredFieldValidator ID="rfvBuscar" runat="server" ControlToValidate="txtBuscar" ErrorMessage="Debe ingresar un ID de sucursal" ValidationGroup="1">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="revBuscar" runat="server" ControlToValidate="txtBuscar" ErrorMessage="Solo se permiten numeros" ForeColor="Black" ValidationExpression="^\d+$" ValidationGroup="1">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:ValidationSummary ID="vsBuscar" runat="server" ValidationGroup="1" />
            <br />
            <br />
            <asp:GridView ID="gvSucursales" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Id_Sucursal"></asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre"></asp:TemplateField>
                    <asp:TemplateField HeaderText="Descripcion"></asp:TemplateField>
                    <asp:TemplateField HeaderText="Provincia"></asp:TemplateField>
                    <asp:TemplateField HeaderText="Direccion"></asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
