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

        public bool esActual()
        {
            return fechaHasta == null;
            /*
            if (fechaHasta != null)
                /* { 
                    if (this.fechaHasta != null) {
                        // si la fechaHasta es posterior a la fecha actual es resultado es int > 0
                        // hoy el 21,,,,, si la fecha hasta resulta serr cargada con anteriorirdad por ejem 25.
                        // 20 - > 25
                            periodicidadMant = cada cuanto tiempo;
                            duracionMant = cant de dias del mantenimiento aproximado 
                     EJEMPLO 1 vez al mes
                           4 dias
                           hoy es 21/06
                           el 21/07 hasta el 24/07 + 1 el recurso va estar en disponible
                        A PARTIR DE DEFINIR EL METODO DE ARRIBA SE PUEDE UTILIZAR EL RETURN DE ABAJO
                         return DateTime.Compare(this.fechaHasta, FECHA CALCULADA A PARTIR DEL MANTENIMIENTO) > 0;
                        
                return false;
                }
            }
            return true;
             */
        }
    }
}

