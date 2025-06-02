using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioSucursal negocio = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                DataTable tabla = negocio.ObtenerTablaSucursales();
                gvSucursales.DataSource = tabla;
                gvSucursales.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}