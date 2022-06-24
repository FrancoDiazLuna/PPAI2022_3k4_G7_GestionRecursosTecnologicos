using PPAI2022_3k4_G7_GestionRT.boundary;
using PPAI2022_3k4_G7_GestionRT.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPAI2022_3k4_G7_GestionRT.control
{
    public class GestorDeTurnosDeRecursoTecnologico
    {
        private List<TipoRecursoTecnologico> listaTipoRTDisponibles;
        private List<RecursoTecnologico> listaRecursoTecnologicosDisponibles;
        private List<Estado> listaEstados;
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra;
        private Sesion activa= CargaDeDatos.loadSesion();
        private Usuario deLaSesion;
        private RecursoTecnologico seleccionado;
        List<CentroDeInvestigacion> centrosInvestigacion = CargaDeDatos.listarCentros();
        private List<Turno> listaTurnosRTSeleccionado;
        private Dictionary<string, List<TurnoMuestra>> turnosOrdenados;
        private Turno turnoElegido;
        private List<TurnoMuestra> listaTurnos;
        private Turno turnoSeleccion;
        private DateTime fechaActual;
        private InterfazDeCorreoElectronico interfazDeCorreoElectronico;
        private ucRegistrarTurnoRT ucRegistrarTurnoRT;

        public GestorDeTurnosDeRecursoTecnologico(ucRegistrarTurnoRT ucRegistrarTurnoRT)
        {
            this.ucRegistrarTurnoRT = ucRegistrarTurnoRT;
            listaTipoRTDisponibles = CargaDeDatos.loadTiposRecursoTecnologico();
            listaRecursoTecnologicosDisponibles = CargaDeDatos.loadRecursosTecnologicos();
            listaEstados = CargaDeDatos.loadEstados();
        }
        internal void opcionReservarTurnoRT()
        {
            ucRegistrarTurnoRT.mostrarTiposDeRT(buscarTiposDeRT());
            ucRegistrarTurnoRT.solicitarSeleccionDeTiposDeRT();
        }

        public List<String> buscarTiposDeRT()
        {
            List<String> nombresTiposDeRT = new List<String>();
            List<TipoRecursoTecnologico> tiposRT = CargaDeDatos.loadTiposRecursoTecnologico();
            if (tiposRT.Count != 0)
            {
                foreach(TipoRecursoTecnologico tipoRT in tiposRT )
                {
                    nombresTiposDeRT.Add(tipoRT.Nombre);
                }
            }
            return nombresTiposDeRT;
        }

        public void tipoDeRTSeleccionado(string tipoRecursoSeleccionado)
        {
            buscarRT(tipoRecursoSeleccionado);
        }

        public void buscarRT(string tipoRecursoSeleccionado)
        {
            listaRecursosMuestra = new List<RecursoTecnologicoMuestra>();

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTuTipo(tipoRecursoSeleccionado))
                {
                    listaRecursosMuestra.Add(recurso.buscarDatosRT(CargaDeDatos.loadMarcas(), centrosInvestigacion));
                }
            }
            marcarColorXEstado();
            agruparRTPorCentroInvestigacion();
            ucRegistrarTurnoRT.mostrarRT(listaRecursosMuestra);
        }

        public void agruparRTPorCentroInvestigacion()
        {
            listaRecursosMuestra.OrderBy(x => x.getCentroDeInvestigacion());
        }

        public void marcarColorXEstado()
        {
            foreach (RecursoTecnologicoMuestra recurso in listaRecursosMuestra)
            {
                switch (recurso.getEstado())
                {
                    case "Disponible":
                        recurso.setColor(1);//Azul
                        break;
                    case "En mantenimiento":
                        recurso.setColor(2);//Verde
                        break;
                    case "Mantenimiento correctivo"://Gris
                        recurso.setColor(3);
                        break;
                    default:
                        recurso.setColor(0);//No color -> Blanco
                        break;
                }
            }
        }
        public void recursoTecnologicoSeleccionado(RecursoTecnologicoMuestra RtSeleccionado)
        {
            seleccionado = CargaDeDatos.getRecursoPorNroInventario(RtSeleccionado.getNumetoInventario(), RtSeleccionado.getCentroDeInvestigacion());
            obtenerUsuarioLogueado();
            if (verificarCIDelUsuario())
            {
                obtenerTurnosReservables(buscarTurnosDelRTSeleccionado(seleccionado));
            }
        }

        private List<TurnoMuestra> buscarTurnosDelRTSeleccionado(RecursoTecnologico seleccionado)
        {
            listaTurnos = seleccionado.getTurnosPosterioresFechaHoraActual(fechaActual);
            return listaTurnos;
        }

        public void obtenerUsuarioLogueado()
        {
           deLaSesion = activa.getUsuarioSesion();
        }

        public bool verificarCIDelUsuario() {            
            return seleccionado.buscarCientifico(centrosInvestigacion, deLaSesion);
        }


        
        public void turnoSeleccionado(DataGridViewRow currentRow)
        {

            foreach (var turnoDisponible in listaTurnos)
            {
                string fecha = currentRow.Cells[0].Value.ToString();
                string horaInicio = currentRow.Cells[1].Value.ToString();
                string horaFin = currentRow.Cells[2].Value.ToString();
                string estado = currentRow.Cells[3].Value.ToString();

                Turno t = CargaDeDatos.getTurno(turnoDisponible.FechaHoraInicio, turnoDisponible.DiaSemana);

                TurnoMuestra comparable = t.mostrarTurno();

                string fechaComparable = comparable.FechaHoraInicio.ToShortDateString();
                string horaInicioComparable = comparable.FechaHoraInicio.ToShortTimeString();
                string horaFinComparable = comparable.FechaHoraFin.ToShortTimeString();
                string estadoComparable = comparable.Estado;

                if (fecha == fechaComparable && horaInicio == horaInicioComparable && horaFin == horaFinComparable && estado == estadoComparable)
                {
                    turnoElegido = t;
                }
            }
        }

        public void confirmarReservaDeTurno()
        {
            registrarConfirmacionDeReservaDeTurno();
        }

        //public void registrarConfirmacionDeReservaDeTurno()
        //{
        //    foreach (var estado in listaEstados)
        //    {
        //        if (estado.esAmbitoTurno())
        //        {
        //            if (estado.esReservado())
        //            {
        //                seleccionado.reservarTurno(turnoSeleccionado, estado, cientificoLogueado);
        //            }
        //        }
        //    }
        //}
        public void registrarConfirmacionDeReservaDeTurno()
        {
            Estado estadoReservado = buscarEstadoReservado();
            seleccionado.actualizarEstadoTurno(turnoSeleccion, estadoReservado, fechaActual);
        }

        public Estado buscarEstadoReservado()
        {
            List<Estado> listaEstados = CargaDeDatos.loadEstados();
            foreach (Estado est in listaEstados)
            {
                if (est.esAmbitoTurno()) {
                    if (est.esReservable()) {
                        return est;
                    }
                }
            }
            return null;
        }
        
        public void getFechaHoraActual()
        {
            fechaActual = DateTime.Now;           
        }

        public void obtenerTurnosReservables(List<TurnoMuestra> turnoMuestras)
        {
            getFechaHoraActual();

            turnosOrdenados = ordenarYAgruparTurnos(turnoMuestras);

            Dictionary<string, bool> disponibilidadAMostrar = determinarDisponibilidadTurnos();

            ucRegistrarTurnoRT.mostrarYSolicitarSeleccionTurnos(disponibilidadAMostrar, recursoTecnologicoSeleccionado);
        }

        public Dictionary<string, bool> determinarDisponibilidadTurnos()
        {
            Dictionary<string, bool> disponibilidad = new Dictionary<string, bool>();

            foreach (var entry in turnosOrdenados.Keys)
            {
                disponibilidad.Add(entry, false);
                foreach (var turno in turnosOrdenados[entry])
                {
                    if (turno.Estado == "Disponible")
                    {
                        disponibilidad[entry] = true;
                        break;
                    }
                }
            }
            return disponibilidad;
        }

        public Dictionary<string, List<TurnoMuestra>> ordenarYAgruparTurnos(List<TurnoMuestra> turnoMuestras)
        {
            Dictionary<string, List<TurnoMuestra>> turnosOrdenados = new Dictionary<string, List<TurnoMuestra>>();
            List<TurnoMuestra> turnos = new List<TurnoMuestra>();

            foreach (var turno in turnoMuestras)
            {

                if (turnosOrdenados.ContainsKey(turno.FechaHoraInicio.ToShortDateString()))
                {
                    turnosOrdenados[turno.FechaHoraInicio.ToShortDateString()].Add(turno);
                }
                else
                {
                    List<TurnoMuestra> list = new List<TurnoMuestra>();
                    list.Add(turno);
                    turnosOrdenados.Add(turno.FechaHoraInicio.ToShortDateString(), list);
                }
            }

            return turnosOrdenados;
        }

        internal void tomarSleccionDia(DateTime date)
        {
            string dateFormatted = date.ToShortDateString();
            if (turnosOrdenados.ContainsKey(dateFormatted))
            {
                ucRegistrarTurnoRT.mostrarDiaSeleccionado(turnosOrdenados[dateFormatted]);
            }
        }

        public void generarNotificacionReservaDeTurno()
        {
            interfazDeCorreoElectronico = new InterfazDeCorreoElectronico();
            var mensaje = new StringBuilder("Se registro el turno del Recurso");
            string email = deLaSesion.Cientifico.CorreoPersonal;
            //mensaje, email, seleccionado.getNroInventario().ToString(), turnoElegido.FechaHoraInicio.ToString()
            interfazDeCorreoElectronico.generarNotififacionReservaDeTurno();
        }

        public void finCU()
        {
            MessageBox.Show("Reserva realizada con éxito", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucRegistrarTurnoRT.Dispose();
        }

    }

        
}
                                                 