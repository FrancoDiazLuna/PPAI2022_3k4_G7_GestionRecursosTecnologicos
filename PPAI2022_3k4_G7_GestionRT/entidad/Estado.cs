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
        

        //public bool esReservado() { return nombre == "Reservado"; }       huele aun mas raro
        // internal bool esReservable() { return nombre == "Disponible"; }      huele raro
        // Estado = (Nombre: "nomEst1", reservable: true , cancelable: false)
        // Varios estados pueden ser Reservables o cancelables. esReservable y esCancelable NO SON ESTADOS

        public bool esReservable() { return this.reservable; }
        public bool esCancelable() { return this.cancelable; }

        public bool esAmbitoTurno(string ambito) { return this.ambito.Equals(ambito); }


    }
}
