using PPAI2022_3k4_G7_GestionRT.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.control
{
    public class GestorDeTurnosDeRecursoTecnologico
    {
        private List<RecursoTecnologico> listaRecursosTecnologicosValidos;
        private List<RecursoTecnologico> listaRecursoTecnologicosDisponibles;
        private List<RecursoTecnologicoMuestra> listaRecursosMuestra;
        private Sesion activa= CargaDeDatos.loadSesion();
        private Usuario deLaSesion;
        private RecursoTecnologico seleccionado;
        List<CentroDeInvestigacion> centrosInvestigacion = CargaDeDatos.listarCentros();
        DateTime fechaActual;
        

        // metodo 1
        public List<string> buscarTiposDeRT()
        {
            List<String> nombresTiposDeRT = new List<String>();
            List<entidad.TipoRecursoTecnologico> tiposRT = CargaDeDatos.loadTiposRecursoTecnologico();
            if (tiposRT.Count != 0)
            {
                foreach(entidad.TipoRecursoTecnologico tipoRT in tiposRT )
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
            /*ME PARECE QUE CON EL CAMBIO QUE SE HIZO EN EL CARGA DE DATOS PASANDOLE AL CI EL LOADrECURSO DE ESE CENTRO ES SUFICIENTE
            centrosInvestigacion[0].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC1());
            centrosInvestigacion[1].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC2());
            centrosInvestigacion[2].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC3());*/
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
        public List<> recursoTecnologicoSeleccionado(RecursoTecnologicoMuestra RtSeleccionado)
        {
            seleccionado = CargaDeDatos.getRecursoPorNroInventario(RtSeleccionado.getNumetoInventario(), RtSeleccionado.getCentroDeInvestigacion());
            obtenerUsuarioLogueado();
            if (verificarCIDelUsuario())
            {
                getFechaHoraActual();
                List<Turnos> listaTurnos = seleccionado.getTurnosPosterioresFechaHoraActual(fechaActual);

            }
           




           
        }

        public void obtenerUsuarioLogueado()
        {
           return deLaSesion = activa.getUsuarioSesion();
        }

        public bool verificarCIDelUsuario() {            
            return seleccionado.buscarCientifico(centrosInvestigacion, deLaSesion);
        }

        public 

        public void registrarConfirmacionDeReservaDeTurno()
        {
            Estado estadoReservado = buscarEstadoReservado();
            // seguir con el metodo

        }
        public Estado buscarEstadoReservado()
        {
            List<Estados> listaEstados = CargaDeDatos.loadEstados();
            foreach (Estado est in listaEstados )
            {
                if (est.esReservado()) { return est; }
            }
            return null;
        }
        
        public void getFechaHoraActual()
        {
            fechaActual = DateTime.Now;           
        } 
           
    }
}
                                                 