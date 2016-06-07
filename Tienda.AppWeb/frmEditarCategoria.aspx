<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmEditarCategoria.aspx.cs" Inherits="Tienda.AppWeb.frmEditarCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="form-horizontal">
    
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Codigo" CssClass="col-lg-2 control-label"></asp:Label>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Nombre" CssClass="col-lg-2 control-label"></asp:Label>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Observaciones" CssClass="col-lg-2 control-label"></asp:Label>
                <div class="col-lg-6">
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="50px" Width="250px" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-lg-offset-2">
                    <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn btn-primary" OnClick="btnCrear_Click"/>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger"/>
                </div>
            </div>

        </form>
    </div>

</body>
</html>
