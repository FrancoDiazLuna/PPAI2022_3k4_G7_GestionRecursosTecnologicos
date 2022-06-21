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

        private List<RecursoTecnologico> recursoTecnologicos;

        private

        private AsignacionDirector directorCI;
        private List<AsignacionCientifico> cientificos = new ArrayList<AsignacionCientifico>();

        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string email, int nroResolucion, DateTime fechaResolucion, string reglamento, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja, string caracteristicasGenerales, string edificio, string coordenadas, List<RecursoTecnologico> recursoTecnologicos, AsignacionDirector directorCI, List<AsignacionCientifico> cientificos)
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
            this.recursoTecnologicos = recursoTecnologicos;
            this.directorCI = directorCI;
            this.cientificos = cientificos;

            if (nombre == null || direccion == null)
            {
                throw new RuntimeException("CentroInvestigacion datos faltantes");
            }
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
} 

