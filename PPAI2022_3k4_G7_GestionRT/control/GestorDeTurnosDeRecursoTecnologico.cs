using PPAI2022_3k4_G7_GestionRT.boundary;
using PPAI2022_3k4_G7_GestionRT.entidad;
using PPAI2022_3k4_G7_GestionRT.entidad.soporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI2022_3k4_G7_GestionRT.control
{
    public class GestorDeTurnosDeRecursoTecnologico
    {
        private List<TipoRecursoTecnologico> listaTipoRTDisponibles;
        private List<RecursoTecnologico> listaRecursoTecnologicosDisponibles;
        private List<Estado> listaEstados;
        private List<RecursoTecnologico> listaRecursosTecnologicosValidos;
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra;
        private Sesion activa= CargaDeDatos.loadSesion();
        private Usuario deLaSesion;
        private RecursoTecnologico seleccionado;
        List<CentroDeInvestigacion> centrosInvestigacion = CargaDeDatos.listarCentros();

        internal void opcionReservarTurnoRT()
        {
            ucRegistrarTurnoRT.mostrarTiposDeRT(buscarTiposDeRT());
            ucRegistrarTurnoRT.solicitarSeleccionDeTiposDeRT();
        }

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

        public void tomarSeleccionTipoRecursoTecnologico(string tipoRecursoSeleccionado)
        {
            tipoDeRTSeleccionado(tipoRecursoSeleccionado);
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
            listaRecursosTecnologicosValidos = new List<RecursoTecnologico>();

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTuTipo(tipoRecursoSeleccionado))
                {

                    recurso.buscarDatosRT(CargaDeDatos.loadMarcas(), centrosInvestigacion);
                   
                }

            }
            marcarColorXEstado();
            agruparRTPorCentroInvestigacion();
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
        public List<TurnoMuestra> recursoTecnologicoSeleccionado(RecursoTecnologicoMuestra RtSeleccionado)
        {
            seleccionado = CargaDeDatos.getRecursoPorNroInventario(RtSeleccionado.getNumetoInventario(), RtSeleccionado.getCentroDeInvestigacion());
            obtenerUsuarioLogueado();
            if (verificarCIDelUsuario())
            {
                getFechaHoraActual();
                List<TurnoMuestra> listaTurnos = seleccionado.getTurnosPosterioresFechaHoraActual(fechaActual);
                // aca se llama al metodo clasificar por colores 
                return listaTurnos;
             }
            return null;
        }

        public void obtenerUsuarioLogueado()
        {
           deLaSesion = activa.getUsuarioSesion();
        }

        public bool verificarCIDelUsuario() {            
            return seleccionado.buscarCientifico(centrosInvestigacion, deLaSesion);
        }
        public void turnoSeleccionado(TurnoMuestra turnoMuestra)
        {
            turnoSeleccion = CargaDeDatos.getTurno(turnoMuestra.FechaHoraInicio, turnoMuestra.DiaSemana);
        }

        public void confirmarReservaDeTurno()
        {
            registrarConfirmacionDeReservaDeTurno();
        }

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

        public void generarNotificacionReservaDeTurno()
        {
            interfazDeCorreoElectronico = new InterfazDeCorreoElectronico();
            var mensaje = new StringBuilder("Se registro el turno del Recurso");
            string email = deLaSesion.Cientifico.CorreoPersonal;
            interfazDeCorreoElectronico.generarNotififacionReservaDeTurno(mensaje, email, seleccionado.getNroInventario().ToString(), turnoSeleccion.FechaHoraInicio.ToString());
        }

        public void finCU()
        {
            MessageBox.Show("Reserva realizada con éxito", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
           
    }
}
                                                 