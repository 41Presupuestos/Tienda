using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tienda.Modelo;
using Tienda.Logica;

namespace Tienda.AppWeb
{
    public partial class frmCrearCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try 
            {
                var cate = new Categoria()
                {
                    Codigo = this.txtCodigo.Text,
                    Nombre = this.txtNombre.Text,
                    Observacion = this.txtObservaciones.Text
                };
                bool exito = CategoriaBL.Crear(cate);
                if (exito)
                    Response.Redirect("frmCategoria.aspx");
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error", "alert('No se pudo guardar los datos')", true);
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Error", "alert('Error al grabar')", true);
            }
        }
    }
}