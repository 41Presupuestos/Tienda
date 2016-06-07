<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCategoria.aspx.cs" Inherits="Tienda.AppWeb.frmCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvCategorias" runat="server"  CssClass="table table-bordered table-hover" AutoGenerateColumns="false" OnRowCommand="gvCategorias_RowCommand">
            <Columns>
                <asp:HyperLinkField HeaderText ="Codigo" DataTextField="Codigo" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="frmEditarCategoria.aspx?uid={0}"/>
                <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                <asp:BoundField HeaderText="Observaciones" DataField="Observacion"/>
                <asp:TemplateField ShowHeader="false" >
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/img/Eliminar.png" Height="25px" Width="25px" OnClientClick="return confirm('¿Està seguro de eliminar?');" CommandName="Eliminar" CommandArgument='<%#Eval("Id")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>