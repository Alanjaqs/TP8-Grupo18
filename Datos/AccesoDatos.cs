﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesoDatos
    {
        string conexionBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(conexionBDSucursales);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection conexion)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, conexion);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int EjecutarTransaccion(string consultaSql, SqlConnection conexion)
        {
            int filasAfectadas;
            SqlCommand command = new SqlCommand(consultaSql, ObtenerConexion());
            filasAfectadas = command.ExecuteNonQuery();
            ObtenerConexion().Close();
            return filasAfectadas;

        }

        public DataTable ObtenerTabla(String nombreTabla, String consultaSql)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = ObtenerConexion();
            SqlDataAdapter adaptador = ObtenerAdaptador(consultaSql, conexion);
            adaptador.Fill(ds, nombreTabla);
            conexion.Close();
            return ds.Tables[nombreTabla];
        }
    }
}
