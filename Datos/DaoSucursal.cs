using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoSucursal
    {
        public int EliminarSucursal(int IdSucursal)
        {
            int filasAfectadas;
            AccesoDatos datos = new AccesoDatos();
            filasAfectadas = datos.EjecutarTransaccion("DELETE FROM Sucursal WHERE Id_Sucursal = " + IdSucursal, datos.ObtenerConexion());
            return filasAfectadas;
        }

        public DataTable ObtenerTablaSucursales()
        {
            AccesoDatos datos = new AccesoDatos();
            DataTable tabla = datos.ObtenerTabla("Sucursales", "SELECT S.Id_Sucursal AS ID_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion FROM " +
            "Sucursal S INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia");
            return tabla;
        }


        public DataTable ObtenerProvincias()
        {
            AccesoDatos datos = new AccesoDatos();
            DataTable tabla = datos.ObtenerTabla("Provincias", "SELECT * FROM Provincia");
            return tabla;
        }

        public DataTable BuscarSucursal(string IdSucursal)
        {
            AccesoDatos datos = new AccesoDatos();
            DataTable tabla = datos.ObtenerTabla("Sucursales", "SELECT S.Id_Sucursal AS ID_Sucursal, S.NombreSucursal AS Nombre, S.DescripcionSucursal AS Descripcion, " +
            "P.DescripcionProvincia AS Provincia, S.DireccionSucursal AS Direccion FROM " +
            "Sucursal S INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia WHERE S.Id_Sucursal = " + IdSucursal);
            return tabla;
        }
    }
}
