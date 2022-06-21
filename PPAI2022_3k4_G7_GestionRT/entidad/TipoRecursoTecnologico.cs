using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class TipoRecursoTecnologico
    {
        private string nombre;
        private string descripcion;
        private List<Caracteristica> caracteristicas;

        public TipoRecursoTecnologico(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public bool esSeleccionado(string tipo)
        {
            return nombre == tipo;
        }

        public string getNombre() { return nombre; }
    }
}
