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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Estado(string nombre, string ambito, string descripcion)
        {
            this.nombre = nombre;
            this.ambito = ambito;
            this.descripcion = descripcion;
        }

        public bool esReservado() { return nombre == "Reservado"; }

        internal bool esReservable() { return nombre == "Disponible"; }

        public bool esAmbitoTurno() { return ambito == "Turno"; }


    }
}
