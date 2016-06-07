using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tienda.Logica;
using Tienda.Modelo;

namespace Tienda.AppWeb
{
    public partial class frmEditarCategoria : System.Web.UI.Page
    {
        private static Categoria cate = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = 0;
                if (string.IsNullOrEmpty(Request.QueryString["uid"]))
                    Response.Redirect("frmCategoria.aspx");
                if (!int.TryParse(Request.QueryString["uid"], out id))
                    Response.Redirect("frmCategoria.aspx");
                cate = CategoriaBL.TraerPorId(id);
                if (cate != null)
                {
                    //Mostrar Datos en TextBox
                    this.txtCodigo.Text = cate.Codigo;
                    this.txtNombre.Text = cate.Nombre;
                    this.txtObservaciones.Text = cate.Observacion;
                }
            }
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (cate != null)
            {
                cate.Codigo = this.txtCodigo.Text;
                cate.Nombre = this.txtNombre.Text;
                cate.Observacion = this.txtObservaciones.Text;
                bool exito = CategoriaBL.Actualizar(cate);
                if (exito)
                    Response.Redirect("frmCategoria.aspx");
            }
        }
    }
}