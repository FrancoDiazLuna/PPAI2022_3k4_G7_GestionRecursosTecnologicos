using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class TurnoModel
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string estado;
        
        public TurnoModel(DateTime fechaHoraInicio, DateTime fechaHoraFin, string v)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.estado = v;
        }

        public DateTime getFechaInicio() { return fechaHoraInicio; }
        public DateTime getFechaFin() { return fechaHoraFin; }
        public string getEstado() { return estado; }
    }
}
