using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class AsignacionDirector
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico personalCientifico;

        public AsignacionDirector(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.personalCientifico = personalCientifico;
        }

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public PersonalCientifico PersonalCientifico { get => personalCientifico; set => personalCientifico = value; }
    }
}
