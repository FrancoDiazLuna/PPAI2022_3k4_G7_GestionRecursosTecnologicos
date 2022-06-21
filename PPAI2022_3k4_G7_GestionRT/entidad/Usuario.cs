using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Usuario
    {
        private string nombre;
        private string clave;
        private bool habilitado;
       

        public Usuario(string nombre, string clave, bool habilitado)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.habilitado = habilitado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
