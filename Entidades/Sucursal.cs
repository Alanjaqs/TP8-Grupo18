using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
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

        
        public int getIdSucursal() { return IdSucursal; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public int getIdProvincia() { return IdProvincia; }
        public string getDireccion() { return direccion; }

        
        public void setIdSucursal(int id) { IdSucursal = id; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public void setDescripcion(string descripcion) { this.descripcion = descripcion; }
        public void setIdProvincia(int id) { IdProvincia = id; }
        public void setDireccion(string direccion) { this.direccion = direccion; }


    }
}
