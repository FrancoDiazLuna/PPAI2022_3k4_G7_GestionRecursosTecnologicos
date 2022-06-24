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

        public CambioEstadoTurno(DateTime fechaInicio, DateTime fechaFin, Estado estadoTurno)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.estadoTurno = estadoTurno;
        }

        public CambioEstadoTurno(DateTime fechaInicio, Estado estadoTurno)
        {
            this.fechaInicio = fechaInicio;
            this.estadoTurno = estadoTurno;
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        public Estado EstadoTurno
        {
            get { return estadoTurno; }
            set { estadoTurno = value; }
        }

        public bool esEstadoActual() {
            // Si se instancia sin generar fechaHoraHasta toma por default minValue
            if (fechaFin.ToShortDateString() == "01/01/0001")
                return true;
            else
                return false;
        }
        public string getNombreEstado()
        {
            return estadoTurno.getNombre();
        }

        public bool esReservable () { return this.estadoTurno.esReservable(); }
        public bool esCancelable () { return this.estadoTurno.esCancelable(); }

        public void setFechaHoraHasta (DateTime fechaHoraFin)
        {
            this.fechaFin = fechaHoraFin;
        }
    }
}
