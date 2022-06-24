using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class TurnoMuestra
    {
        private DayOfWeek diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private string estado;
        private int color;

        public TurnoMuestra(DayOfWeek diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, string estado)
        {
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.estado = estado;
        }

        public DayOfWeek DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public string Estado { get => estado; set => estado = value; }

        public void setColor(int nroColor)
        {
            this.color = nroColor;
        }
        internal int getColor()
        {
            return color;
        }
    }
}
