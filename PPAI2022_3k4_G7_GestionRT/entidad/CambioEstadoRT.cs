using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class CambioEstadoRT
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private Estado estado;

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public CambioEstadoRT(DateTime fechaDesde, DateTime fechaHasta, Estado estado)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            Estado = estado;
        }

        public CambioEstadoRT(DateTime fechaDesde, Estado estado)
        {
            this.fechaDesde = fechaDesde;
            this.estado = estado;
        }

        public bool esActual()
        {
            if (fechaHasta.ToShortDateString() == "1/1/0001")
                return true;
            else
                return false;
        }
    }

}

