using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
     public class AsignacionCientifico
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico cientifico;

        public AsignacionCientifico(DateTime fechaDesde, DateTime fechaHasta, PersonalCientifico cientifico)
        {
            this.cientifico = cientifico;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
        }

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }


        // Funcion que verifica el estado activo del cientifico
        public bool EsCientificoActivo()
        {
            return this.fechaHasta == null;     
        }
    }
}
