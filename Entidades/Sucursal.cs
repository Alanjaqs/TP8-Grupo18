using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Sucursal
    {
        private int IdSucursal;
        private string nombre;
        private string descripcion;
        private int IdProvincia;
        private string direccion;

        // Contructor
        public Sucursal(string nombre, string descripcion, int idProvincia, string direccion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.IdProvincia = idProvincia;
            this.direccion = direccion;
        }

    }
}
