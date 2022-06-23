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

        public void tomarSeleccionTipoRecursoTecnologico(string tipoRecursoSeleccionado)
        {
            buscarRTPorTipoRTValido(tipoRecursoSeleccionado);
        }

        public void buscarRTPorTipoRTValido(string tipoRecursoSeleccionado)
        {

            listaRecursosTecnologicosValidos = new List<RecursoTecnologico>();

            foreach (RecursoTecnologico recurso in listaRecursoTecnologicosDisponibles)
            {
                if (recurso.esTuTipo(tipoRecursoSeleccionado))
                {
                    //listaRecursosTecnologicosValidos.Add(recurso); --> MOSTRAR RT QUE NO ESTAN DISPONIBLES - COLORES

                    if (recurso.esReservable())
                    {
                        listaRecursosTecnologicosValidos.Add(recurso);
                    }
                }

            }

            listaRecursosMuestra = new List<RecursoTecnologicoMuestra>();

            foreach (RecursoTecnologico recurso in listaRecursosTecnologicosValidos)
            {
                listaRecursosMuestra.Add(recurso.mostrarDatosDeRT(CargaDeDatos.loadMarcas()));
            }

            agruparRTPorCentroInvestigacion();
            asignarColorPorEstadoDeRT();

            
        }

        public void agruparRTPorCentroInvestigacion()
        {
            listaRecursosMuestra.OrderBy(x => x.getCentroInvestigacion());
        }

        public void asignarColorPorEstadoDeRT()
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
    }
}
