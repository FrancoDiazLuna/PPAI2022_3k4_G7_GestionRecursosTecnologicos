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
        PersonalCientifico cientifico;

        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }

        public Usuario(string nombre, string clave, bool habilitado, PersonalCientifico cientifico)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.habilitado = habilitado;
            this.cientifico = cientifico;
        }

        public Usuario(string nombre, string clave, bool habilitado)
        {
            this.nombre = nombre;
            this.clave = clave;
            this.habilitado = habilitado;
        }

        public Usuario getUsuario()
        {
            return this;
        }
    }
}
