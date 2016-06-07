using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tienda.Logica;

namespace Tienda.AppWeb
{
    public partial class frmCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            CargarDatos();
        }

        protected void CargarDatos()
        {
            this.gvCategorias.DataSource = CategoriaBL.ListarTodos();
            this.gvCategorias.DataBind();
        }

        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Eliminar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);
                bool exito = CategoriaBL.Eliminar(id);
                if (exito)
                    CargarDatos();
            }
        }


    }
}