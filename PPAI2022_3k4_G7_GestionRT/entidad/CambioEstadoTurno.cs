using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class CambioEstadoTurno
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Estado estadoTurno;

        // Constructor con parametro "fechaFin" opcional donde su valor por defecto es null
        public CambioEstadoTurno(Estado estadoTurno ,DateTime fechaInicio, Nullable<DateTime> fechaFin = null)
        {
            this.estadoTurno = estadoTurno;
            this.fechaInicio = fechaInicio;
            this.fechaFin = (DateTime)fechaFin;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public Estado EstadoTurno { get => estadoTurno; set => estadoTurno = value; }

        public bool esActual() {
            return fechaFin == null;
            /*if (this.fechaFin != null)
            {
                // si la fechaHasta es posterior a la fecha actual es resultado es int > 0
                return DateTime.Compare(this.fechaFin, new DateTime()) > 0;
            }
            return false;
            */
        }

        public bool esReservable () { return this.estadoTurno.esReservable(); }
        public bool esCancelable () { return this.estadoTurno.esCancelable(); }
    }
}
