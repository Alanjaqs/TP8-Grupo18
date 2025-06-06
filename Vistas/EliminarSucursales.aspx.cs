﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        NegocioSucursal negocio = new NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSucursal = Convert.ToInt32(txtEliminar.Text);

            bool operacionExitosa = negocio.EliminarSucursal(IdSucursal);

            if (operacionExitosa)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con exito";
                lblMensaje.ForeColor = Color.Green;
                txtEliminar.Text = "";
            }
            else
            {
                lblMensaje.Text = "El ID de sucursal no existe";
                lblMensaje.ForeColor = Color.Red;
                txtEliminar.Text = "";
            }
        }
    }
}