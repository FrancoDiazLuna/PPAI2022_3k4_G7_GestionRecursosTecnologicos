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
        private List<Caracteristica> caracteristicas = new List<Caracteristica>();

        public TipoRecursoTecnologico(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public void agregarCaracteristica (Caracteristica caracteristica)
        {
            caracteristicas.Add(caracteristica);
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        
        public bool esTuNombre(string tipoRT)
        {
            return nombre == tipoRT;
        }

    }
}
