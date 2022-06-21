using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Facultad
    {
        private string nombre;
        private string direccion;
        private PersonalCientifico responsable;
        private List<CentroDeInvestigacion> centroDeInvestigacion;

        public Facultad(string nombre, string direccion, PersonalCientifico responsable, List<CentroDeInvestigacion> centroDeInvestigacion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.responsable = responsable;
            this.centroDeInvestigacion = centroDeInvestigacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public PersonalCientifico Responsable { get => responsable; set => responsable = value; }
        public List<CentroDeInvestigacion> CentroDeInvestigacion { get => centroDeInvestigacion; set => centroDeInvestigacion = value; }
    }
}
