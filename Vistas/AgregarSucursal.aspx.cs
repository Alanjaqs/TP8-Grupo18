using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursal negocio = new NegocioSucursal();
        Sucursal sucursal;
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

         protected void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int IdProvincia = Convert.ToInt32(ddlProvincia.SelectedItem.Value);
            string direccion = txtDireccion.Text;

            sucursal = new Sucursal(nombre, descripcion, IdProvincia, direccion);
            bool operacionExitosa = negocio.AgregarSucursal(sucursal);

            if (operacionExitosa)
            {
                lblMensaje.Text = "La sucursal se ha agregado con exito";
                lblMensaje.ForeColor = Color.Green;
                LimpiarCampos();
            }
            else
            {
                lblMensaje.Text = "La sucursal no pudo ser agregada";
                lblMensaje.ForeColor = Color.Red;
                LimpiarCampos();
            }
        }
    }
}