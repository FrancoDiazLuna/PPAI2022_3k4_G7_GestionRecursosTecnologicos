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
        private DateTime estadoTurno;

        public CambioEstadoTurno(DateTime fechaInicio, DateTime fechaFin, DateTime estadoTurno)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.estadoTurno = estadoTurno;
        }
    }
}
