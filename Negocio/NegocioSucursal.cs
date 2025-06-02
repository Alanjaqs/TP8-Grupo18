using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioSucursal
    {
        public int EliminarSucursal(int IdSucursal)
        {
            int filasAfectadas;
            AccesoDatos datos = new AccesoDatos();
            filasAfectadas = datos.EjecutarTransaccion("DELETE FROM Sucursal WHERE Id_Sucursal = " + IdSucursal, datos.ObtenerConexion());
            return filasAfectadas;
        }

        public DataTable ObtenerProvincias()
        {
            AccesoDatos datos = new AccesoDatos();
            DataTable tabla = datos.ObtenerTabla("Provincias", "SELECT * FROM Provincia");
            return tabla;
        }
    }
}
