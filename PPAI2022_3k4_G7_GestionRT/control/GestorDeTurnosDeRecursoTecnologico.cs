using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.control
{
    internal class GestorDeTurnosDeRecursoTecnologico
    {


        
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

        /*
        public List<Object> buscarRTReservable(string tipoSeleccionado) {
            List<Object> recursosTecnologicosReservables = new List<Object>();
            List<entidad.RecursoTecnologico> listaRT = CargaDeDatos.loadRecursoTecnologico();
            foreach(entidad.RecursoTecnologico RT in listaRT) {
                if ( RT.esTuTipo(tipoSeleccionado) ) {
                    //RT.buscarDatos();
                }
            }
        }
        */

    }
}
