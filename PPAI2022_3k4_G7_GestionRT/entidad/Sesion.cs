using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Usuario deLaSesion;

        public Sesion(DateTime fechaHoraInicio, DateTime fechaHoraFin, Usuario usuario)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.deLaSesion = usuario;
        }
        public Usuario getUsuarioSesion()
        {
            return deLaSesion;
        }


    }
}
