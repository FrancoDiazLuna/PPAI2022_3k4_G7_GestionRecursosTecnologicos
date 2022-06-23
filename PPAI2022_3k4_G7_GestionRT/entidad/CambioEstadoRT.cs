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
        private Estado estadoRT;

        public CambioEstadoRT(Estado estado, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.estadoRT = estado;
        }
        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public Estado EstadoRT { get => estadoRT; set => estadoRT = value; }

        public bool esEstadoActual()
        {
            return fechaHasta == null; 
        }

        public bool esReservable()
        {
            return this.estadoRT.esReservable();
        }

        public string getNombreEstado() { return estadoRT.getNombre(); }
    }
}

