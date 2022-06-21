using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class CambioEstadoRT
    {
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;
        private Estado estado;

        public DateTime fechaDesde { get => _fechaDesde; set => _fechaDesde = value; }
        public DateTime fechaHasta { get => _fechaHasta; set => _fechaHasta = value; }
        public Estado Estado { get => estado; set => estado = value; }

        public CambioEstadoRT(DateTime fechaDesde, DateTime fechaHasta, Estado estado)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            Estado = estado;
        }
    }

}

