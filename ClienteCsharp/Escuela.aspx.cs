using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteCsharp
{
    public partial class Escuela : System.Web.UI.Page
    {
        private srEscuela.wsEscuelaSoapClient servicio;
        private void Listar()
        {
            servicio = new srEscuela.wsEscuelaSoapClient();
            gvEscuela.DataSource = servicio.Listar();
            gvEscuela.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Listar();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            servicio = new srEscuela.wsEscuelaSoapClient();
            String texto = txtTexto.Text.Trim();
            String criterio = ddlCriterio.Text.Trim();
            gvEscuela.DataSource=servicio.Buscar(texto, criterio);
            gvEscuela.DataBind();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            servicio = new srEscuela.wsEscuelaSoapClient();
            String codEscuela = txtTexto0.Text.Trim();
            String escuela = txtTexto1.Text.Trim();
            servicio.Agregar(codEscuela, escuela);
            Listar();
        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            servicio = new srEscuela.wsEscuelaSoapClient();
            String codEscuela = txtTexto0.Text.Trim();
            String escuela = txtTexto1.Text.Trim();
            servicio.Actualizar(codEscuela, escuela);
            Listar();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            servicio = new srEscuela.wsEscuelaSoapClient();
            String codEscuela = txtTexto0.Text.Trim();
            servicio.Eliminar(codEscuela);
            Listar();
        }
    }
}