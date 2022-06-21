﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class RecursoTecnologico
    {
        private int nroInventario;
        private DateTime fechaAlta;
        private Modelo modelo;
        private int periodicidadMant;  // periodicidad de mantenimiento en dias
        private int duracionMant;   // duracionMant
        private List<Turno> listaTurno;
        private List<CambioEstadoRT> cambiosEstadosRT;
        private AsignacionRespTecnologico responsableTecnologico;
        private List<CaracteristicaDelRecurso> caracteristica;
        private TipoRecursoTecnologico tipoDeRecurso;

        public RecursoTecnologico(int nroInventario, DateTime fechaAlta, Modelo modelo, int periodicidadMant, int duracionMant, List<Turno> listaTurno, List<CambioEstadoRT> cambiosEstadosRT, AsignacionRespTecnologico responsableTecnologico, List<CaracteristicaDelRecurso> caracteristica, TipoRecursoTecnologico tipoDeRecurso)
        {
            this.nroInventario = nroInventario;
            this.fechaAlta = fechaAlta;
            this.modelo = modelo;
            this.periodicidadMant = periodicidadMant;
            this.duracionMant = duracionMant;
            this.listaTurno = listaTurno;
            this.cambiosEstadosRT = cambiosEstadosRT;
            this.responsableTecnologico = responsableTecnologico;
            this.caracteristica = caracteristica;
            this.tipoDeRecurso = tipoDeRecurso;
        }

        public int NroInventario { get => nroInventario; set => nroInventario = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int PeriodicidadMant { get => periodicidadMant; set => periodicidadMant = value; }
        public int DuracionMant { get => duracionMant; set => duracionMant = value; }
        public List<Turno> ListaTurno { get => listaTurno; set => listaTurno = value; }
        public List<CambioEstadoRT> CambiosEstadosRT { get => cambiosEstadosRT; set => cambiosEstadosRT = value; }
        public AsignacionRespTecnologico ResponsableTecnologico { get => responsableTecnologico; set => responsableTecnologico = value; }
        public List<CaracteristicaDelRecurso> Caracteristica { get => caracteristica; set => caracteristica = value; }
        internal TipoRecursoTecnologico TipoDeRecurso { get => tipoDeRecurso; set => tipoDeRecurso = value; }

        public void buscarDatosRT(List<CentroDeInvestigacion> centrosDeInvestigacion)
        {
            String nombreCI = "";
            if (this.buscarEstadoActual() == true)
            {
                /*
                En teoria esta seria la dependencia con el Centro de Investigacion
                Con esto, sabriamos si el nombre del CI al cual pertenece el RT
                 */
                for (CentroDeInvestigacion ci: centrosDeInvestigacion)
                {
                    if (ci.esTuRecursoTecnologico(this) == true)
                    {
                        nombreCI = ci.getNombre();
                    }
                }
                /*
                Faltan modeloYmarca + nroInventario
                Verificar que debemos devolver, si un objeto con todos los datos o una lista
                 */
            }
            Object datosRt = new Object();


            //return datosRt;
        }

        public Boolean buscarEstadoActual()
        {
            Boolean esReservable = false;
            if (!cambiosEstadosRT.isEmpty())
            {
                for (CambioEstadoRT c:cambiosEstadosRT)
                {
                    if (c.esEstadoActual())
                    {
                        esReservable = c.esReservable();
                        break;
                    }
                }
            }
            return esReservable;
        }
    }
}
