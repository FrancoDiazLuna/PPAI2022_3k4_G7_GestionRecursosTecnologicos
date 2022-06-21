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

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public Estado EstadoTurno { get => estadoTurno; set => estadoTurno = value; }

        public bool esActual()
        {
            if (fechaFin.ToShortDateString() == "1/1/0001")
                return true;
            else
                return false;
        }
    }
}
