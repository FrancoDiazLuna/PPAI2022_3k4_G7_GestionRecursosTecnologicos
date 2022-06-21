using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class CentroDeInvestigacion
    {
        private string nombre;
        private string sigla;
        private string direccion;
        private string email;
        private int nroResolucion;
        private DateTime fechaResolucion;
        private string reglamento;
        private DateTime fechaAlta;
        private DateTime fechaBaja;
        private string motivoBaja;
        private string caracteristicasGenerales;
        private string edificio;
        private string coordenadas;

        private List<RecursoTecnologico> recursosTecnologicos = new List<RecursoTecnologico>();
        private AsignacionDirector directorCI;
        private AsignacionRespTecnologico responsableTecnologico;
        private List<AsignacionCientifico> cientificos;

        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string email, int nroResolucion, DateTime fechaResolucion, string reglamento, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja, string caracteristicasGenerales, string edificio, string coordenadas, AsignacionDirector directorCI)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.email = email;
            this.nroResolucion = nroResolucion;
            this.fechaResolucion = fechaResolucion;
            this.reglamento = reglamento;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.motivoBaja = motivoBaja;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.edificio = edificio;
            this.coordenadas = coordenadas;
            this.directorCI = directorCI;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public void agregarRT(RecursoTecnologico rt)
        {
            this.recursosTecnologicos.Add(rt); 
        }

        public void agregarAsignacionCientifico (AsignacionCientifico cientifico)
        {
            this.cientificos.Add(cientifico);
        }


        public bool esTuRecursoTecnologico(RecursoTecnologico recursoTecnologico)
        {
            bool esTuRecurso = false;
            
            foreach(RecursoTecnologico rt in this.recursosTecnologicos)
            {
                esTuRecurso = rt.Equals(recursoTecnologico);
            }
            return esTuRecurso;
        }




    }
} 

