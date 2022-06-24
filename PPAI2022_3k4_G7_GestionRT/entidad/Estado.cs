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

        public Estado(string nombre, string ambito, string descripcion, bool reservable, bool cancelable)
        {
            this.nombre = nombre;
            this.ambito = ambito;
            this.descripcion = descripcion;
            this.reservable = reservable;
            this.cancelable = cancelable;
        }

        public Estado(string nombre, string ambito, string descripcion)
        {
            this.nombre = nombre;
            this.ambito = ambito;
            this.descripcion = descripcion;
        }

        public bool esReservable() { return this.reservable; }
        public bool esCancelable() { return this.cancelable; }

        public bool esAmbitoTurno(string ambito) { return this.ambito.Equals(ambito); }

        public bool esReservado() { return nombre == "Reservado"; }
      
        public bool esAmbitoTurno() { return ambito == "Turno"; }

        public string getNombre() { return nombre; }

    }
}
