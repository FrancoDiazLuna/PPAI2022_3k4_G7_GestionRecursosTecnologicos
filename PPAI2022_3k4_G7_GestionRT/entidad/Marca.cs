using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Marca
    {
        private string nombre;
        private List<Modelo> modelos;

        public Marca(string nombre, List<Modelo> modelos)
        {
            this.nombre = nombre;
            this.modelos = modelos;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string value)
        {
            nombre = value;
        }


        public bool esDeEstaMarca(Modelo modelo) 
        {
            return modelos.Contains(modelo);
        }
    }
}
