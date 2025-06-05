using Datos;
using Entidades;
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
        public bool EliminarSucursal(int IdSucursal)
        {
            int cantFilas = 0;
            DaoSucursal dao = new DaoSucursal();
            cantFilas = dao.EliminarSucursal(IdSucursal);
            if (cantFilas == 1)
                return true;
            else 
                return false;
        }

        public DataTable ObtenerTablaSucursales()
        {
            DaoSucursal dao = new DaoSucursal();
            DataTable tabla = dao.ObtenerTablaSucursales();
            return tabla;
        }


        public DataTable ObtenerProvincias()
        {
            DaoSucursal dao = new DaoSucursal();
            DataTable tabla = dao.ObtenerProvincias();
            return tabla;
        }

        public DataTable BuscarSucursal(string IdSucursal)
        {
            DaoSucursal dao = new DaoSucursal();
            DataTable tabla = dao.BuscarSucursal(IdSucursal);
            return tabla;
        }

        public bool AgregarSucursal(Sucursal sucursal)
        {
            int cantFilas = 0;
            DaoSucursal dao = new DaoSucursal();
            cantFilas = dao.AgregarSucursal(sucursal);
            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }
}

