using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Turno
    {
        private DateTime fechaGeneracion;
        private DayOfWeek diaSemana;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private List<CambioEstadoTurno> cambioEstadoTurno;
       

        public Turno(DateTime fechaGeneracion, DayOfWeek diaSemana, DateTime fechaHoraInicio, DateTime fechaHoraFin, List<CambioEstadoTurno> cambioEstadoTurno)
        {
            this.fechaGeneracion = fechaGeneracion;
            this.diaSemana = diaSemana;
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.cambioEstadoTurno = cambioEstadoTurno;
        }

        public DateTime FechaGeneracion { get => fechaGeneracion; }
        public DayOfWeek DiaSemana { get => diaSemana; set => diaSemana = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }

        public CambioEstadoTurno buscarEstadoActual ()
        {
            foreach ( CambioEstadoTurno cet in cambioEstadoTurno)
            {
                if ( cet.esEstadoActual() )
                {
                    return cet;
                }
            }
            return null;
        }

        public void reservarTurno(Estado estadoReservado, DateTime fechaHoraActual )
        {
            CambioEstadoTurno cambioEstadoActual = buscarEstadoActual();  // busca el ultimo cambio de estado de turno
            cambioEstadoActual.setFechaHoraHasta(fechaHoraActual);     // setea la fecha del fin de cambio de estado

            // crea nuevocambio de estado "reservado"
            CambioEstadoTurno nuevoCambioEstado = crearCambioDeEstado(estadoReservado,fechaHoraActual); 
            
            cambioEstadoTurno.Add(nuevoCambioEstado);
        }

        public CambioEstadoTurno crearCambioDeEstado(Estado estadoReservado, DateTime fechaHoraInicio)
        {
            return new CambioEstadoTurno(this.fechaHoraInicio, estadoReservado);
        }
        public bool esPosteriorFechaHoraActual(DateTime fechaActual)
        {
            return DateTime.Compare(this.fechaHoraInicio, fechaActual) > 0;
        }

        public TurnoMuestra GetDatosTurno() {
            CambioEstadoTurno actual = buscarEstadoActual();
            string estado = actual.getNombreEstado();
            TurnoMuestra turno= new TurnoMuestra(this.DiaSemana, this.FechaHoraInicio, this.FechaHoraFin, estado);
            return turno;
        }      

       
        // cual de los dos metodos esta en el diag?
        public bool validarFechaHoraInicio(DateTime timeInicio) 
        {
            return this.fechaHoraInicio >= timeInicio;
        }

        internal TurnoMuestra mostrarTurno()
        {
            return new TurnoMuestra(fechaHoraInicio, fechaHoraFin, cambioEstadoTurno.Last<CambioEstadoTurno>().EstadoTurno.getNombre());
        }
    }
}
