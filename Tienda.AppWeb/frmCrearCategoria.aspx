<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCrearCategoria.aspx.cs" Inherits="Tienda.AppWeb.frmCrearCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Observaciones"></asp:Label>
        <asp:TextBox ID="txtObservaciones" runat="server" Height="16px" Width="250px"></asp:TextBox>
        <br />
        <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />
    
    </div>
    </form>
</body>
</html>
