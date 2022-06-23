using System;
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
        private List<CaracteristicasDelRecurso> caracteristica;
        private TipoRecursoTecnologico tipoDeRecurso;
        private CambioEstadoRT cambioEstadoActual = null;


        public RecursoTecnologico(int nroInventario, Modelo modelo, TipoRecursoTecnologico tipoDeRecurso, List<CambioEstadoRT> cambiosEstadosRT, List<Turno> listaTurno)
        {
            this.nroInventario = nroInventario;
            this.modelo = modelo;
            this.listaTurno = listaTurno;
            this.cambiosEstadosRT = cambiosEstadosRT;
            this.tipoDeRecurso = tipoDeRecurso;
        }
        
        public bool esTuTipo(string nombreTipoRecurso)
        {
            return this.tipoDeRecurso.esTuTipo(nombreTipoRecurso);
        }

        public CambioEstadoRT buscarEstadoActual()
        {
            CambioEstadoRT cambioEstadoRT = null;

            if (cambiosEstadosRT.Count>0)
              {
                foreach (CambioEstadoRT cambio in cambiosEstadosRT)                
                  {
                       if (cambio.esEstadoActual())
                       { 
                        cambioEstadoRT= cambio;
                           break;
                       }
                   }
               }

            return cambioEstadoRT;
        }
        
        public RecursoTecnologicoMuestra buscarDatosRT(List<Marca> marcas, List<CentroDeInvestigacion> centrosInvestigacion)
        {
            RecursoTecnologicoMuestra recurso = null;
            cambioEstadoActual = buscarEstadoActual();
            string centroDeInvestigacion = "";
            if( cambioEstadoActual.esReservable() && cambioEstadoActual!= null)
            {
                if (buscarCIdelRT(centrosInvestigacion) != null)
                {
                    centroDeInvestigacion = buscarCIdelRT(centrosInvestigacion).getNombreCI();
                }
                int nroInv = this.getNroInventario();
                List<String> modeloYMarca = mostrarMarcaYModelo(marcas);
                string nombreEstado = cambioEstadoActual.EstadoRT.getNombre();
                return new RecursoTecnologicoMuestra(centroDeInvestigacion, nroInv, modeloYMarca[1], modeloYMarca[0], nombreEstado);
            }
            return recurso;
        }

        public int getNroInventario() { return nroInventario; }

        //se separa en un método aparte para reutilizarlo en buscarCientifico
        public CentroDeInvestigacion buscarCIdelRT(List<CentroDeInvestigacion> ci)
        {
            CentroDeInvestigacion centroInvestigacion = null;
            foreach (CentroDeInvestigacion centro in ci)
            {
                if (centro.esTuRecursoTecnologico(this))
                {
                    centroInvestigacion = centro;
                    break;
                }

            }
            return centroInvestigacion;
        }

     
        public List<String> mostrarMarcaYModelo(List<Marca> marcas)
        {
            List<String> modeloYMarca = new List<string>();
            modeloYMarca.Add(this.modelo.getNombreModelo());
            modeloYMarca.Add(this.modelo.getMarca(marcas));
            return modeloYMarca;
        }

        public bool buscarCientifico(List<CentroDeInvestigacion> ci, Usuario deLaSesion)
        { 
            return buscarCIdelRT(ci).buscarCientifico(deLaSesion);
        }

        public List<TurnoMuestra> getTurnosPosterioresFechaHoraActual(DateTime fechaActual)
        {
            List<TurnoMuestra> turnosPosterioresFechaHoraActual = new List<TurnoMuestra>();
            foreach(Turno turno in listaTurno)
            {
                if (turno.esPosteriorFechaHoraActual(fechaActual))
                {
                    turnosPosterioresFechaHoraActual.Add(turno.GetDatosTurno());
                }
            }
            return turnosPosterioresFechaHoraActual;
        }
        public void actualizarEstadoTurno (Turno turno, Estado estadoReservado, DateTime fechaHoraActual) // metodo invocado desde el gestor
        {
            foreach(Turno t in listaTurno)
            {
                if (t.Equals(turno))
                {
                    t.reservarTurno(estadoReservado, fechaHoraActual);
                    break;
                }
            }
           
            
            // se necesita el objeto turnoSeleccionado
            // se aplica el metodo --->  turnoSeleccionado.reservarTurno( estadoReservado, fechaHoraActual )
        }
    }
}
