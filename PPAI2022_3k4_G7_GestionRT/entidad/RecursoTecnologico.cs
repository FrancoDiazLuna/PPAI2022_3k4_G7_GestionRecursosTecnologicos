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

           
        //public void buscarDatosRT(List<CentroDeInvestigacion> centrosDeInvestigacion)
        //{
        //    String nombreCI = "";
        //    if (this.buscarEstadoActual() == true)
        //    {
        //        /*
        //        En teoria esta seria la dependencia con el Centro de Investigacion
        //        Con esto, sabriamos si el nombre del CI al cual pertenece el RT
        //         */
        //        foreach (CentroDeInvestigacion ci : centrosDeInvestigacion)
        //        {
        //            if (ci.esTuRecursoTecnologico(this) == true)
        //            {
        //                nombreCI = ci.getNombre();
        //            }
        //        }
        //        /*
        //        Faltan modeloYmarca + nroInventario
        //        Verificar que debemos devolver, si un objeto con todos los datos o una lista
        //         */
        //    }
        //    Object datosRt = new Object();

        //    //return datosRt;
        //}

        //public Boolean buscarEstadoActual()
        //{
        //    Boolean esReservable = false;
        //    if (!cambiosEstadosRT.isEmpty())
        //    {
        //        for (CambioEstadoRT c:cambiosEstadosRT)
        //        {
        //            if (c.esEstadoActual())
        //            {
        //                esReservable = c.esReservable();
        //                break;
        //            }
        //        }
        //    }
        //    return esReservable;
        //}
        
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
                foreach (CentroDeInvestigacion centro in centrosInvestigacion)
                {
                    if (centro.esTuRecursoTecnologico(this))
                    {
                        centroDeInvestigacion = centro.getNombreCI();
                        break;
                    }

                }
                int nroInv = this.getNroInventario();
                List<String> modeloYMarca = mostrarMarcaYModelo(marcas);
                string nombreEstado = cambioEstadoActual.EstadoRT.getNombre();
                return new RecursoTecnologicoMuestra(centroDeInvestigacion, nroInv, modeloYMarca[1], modeloYMarca[0], nombreEstado);
            }
            return recurso;
        }

        public int getNroInventario() { return nroInventario; }

     
        public List<String> mostrarMarcaYModelo(List<Marca> marcas)
        {
            List<String> modeloYMarca = new List<string>();
            modeloYMarca.Add(this.modelo.getNombreModelo());
            modeloYMarca.Add(this.modelo.getMarca(marcas));
            return modeloYMarca;
        }

       

        //public List<Turno> obtenerTurnos(bool esCientificodelCentro) //Ver observacion 3 y resolver lo q pide
        //{
        //    List<Turno> turnosDisponibles = new List<Turno>();
        //    DateTime date = DateTime.Now;

        //    if (esCientificodelCentro)
        //    {
        //        foreach (Turno turno in listaTurno)
        //            if (turno.validarFechaHoraInicio(date))
        //            {
        //                turnosDisponibles.Add(turno);
        //            }

        //    }
        //    else
        //    {
        //        foreach (Turno turno in listaTurno)
        //            if (turno.validarFechaHoraInicio(date.AddDays(centroInvestigacion.getTiempoAntelacionReserva())))
        //            {
        //                turnosDisponibles.Add(turno);
        //            }
        //    }

        //    return turnosDisponibles;
        //}
    }
}
