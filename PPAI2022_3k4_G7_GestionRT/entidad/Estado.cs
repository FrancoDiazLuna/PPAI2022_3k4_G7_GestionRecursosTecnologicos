using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Estado
    {
        private string nombre;
        private string ambito;
        private string descripcion;
        private bool reservable;
        private bool cancelable;

        public Estado(string nombre, string ambito, string descripcion, bool reservable, bool cancelable)
        {
            this.nombre = nombre;
            this.ambito = ambito;
            this.descripcion = descripcion;
            this.reservable = reservable;
            this.cancelable = cancelable;
        }
    }
}
