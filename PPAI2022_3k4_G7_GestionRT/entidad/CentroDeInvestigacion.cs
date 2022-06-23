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
        private int tiempoAntelacionReserva;
        private List<RecursoTecnologico> recursosTecnologicos;
        private AsignacionDirector directorCI;
        private AsignacionRespTecnologico responsableTecnologico;
        private List<AsignacionCientifico> cientificos;

        
        public CentroDeInvestigacion(string nombre, string sigla, string direccion, int tiempoAntelacionReserva, List<RecursoTecnologico> recursosTecnologicos, List<AsignacionCientifico> cientificos)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.recursosTecnologicos = recursosTecnologicos;
            this.cientificos = cientificos;
        }
        
        public string getNombreCI()
        {
            return nombre;
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

        public void setRecursosTecnologicos(List<RecursoTecnologico> recursos)
        {
            recursosTecnologicos = recursos;
        }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            return recursosTecnologicos; 
        }
        
        public bool buscarCientifico(Usuario deLaSesion)
        {
             misCientificosActivos(deLaSesion);

            return true;
        }

        public bool misCientificosActivos(Usuario deLaSesion)
        {
            bool validar = false;// validar nombre y si es lo que retorna
            foreach(AsignacionCientifico asignacion in cientificos)
            {
                if(asignacion.EsCientificoActivo())
                {
                    if (asignacion.compararUsuario(deLaSesion))
                    {
                        validar = asignacion.compararUsuario(deLaSesion);
                        break;
                    }
                }
            }
            return validar;
        }

    }
} 

