using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursal negocio = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                DataTable tabla = negocio.ObtenerProvincias();
                ddlProvincia.DataSource = tabla;
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }

        }

        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            ddlProvincia.SelectedIndex = 0;
        }
    }
}