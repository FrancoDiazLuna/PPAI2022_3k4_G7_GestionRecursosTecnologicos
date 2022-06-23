﻿using System;
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
        private List<CambioEstadoTurno> cambioEstadoTurno = new List<CambioEstadoTurno>();

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

        public CambioEstadoTurno obtenerCambioEstadoTurnoActual ()
        {
            foreach ( CambioEstadoTurno cet in cambioEstadoTurno)
            {
                if ( cet.esActual() )
                {
                    return cet;
                }
            }
            return null;
        }

        public void reservarTurno(Estado estadoReservado)
        {
            cambioEstadoTurno.Last().FechaFin = DateTime.Now;

            var nuevoCambioEstado = new CambioEstadoTurno(this.fechaHoraInicio, estadoReservado);

            cambioEstadoTurno.Add(nuevoCambioEstado);
        }

        public bool esPosteriorFechaHoraActual() { return DateTime.Compare(this.fechaHoraInicio, new DateTime()) > 0; }
        // cual de los dos metodos esta en el diag?
        public bool validarFechaHoraInicio(DateTime timeInicio) 
        {
            return this.fechaHoraInicio >= timeInicio;
        }


    }
}
