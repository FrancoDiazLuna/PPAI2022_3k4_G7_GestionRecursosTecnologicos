using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class PersonalCientifico
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int nroDocumento;
        private int nroTelefono;
        private string correoInstitucional;
        private string correoPersonal;
        private Usuario usuarioPersonal;

        public PersonalCientifico(int legajo, string nombre, string apellido, int nroDocumento, int nroTelefono, string correoInstitucional, string correoPersonal, Usuario usuarioPersonal)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroDocumento = nroDocumento;
            this.nroTelefono = nroTelefono;
            this.correoInstitucional = correoInstitucional;
            this.correoPersonal = correoPersonal;
            this.usuarioPersonal = usuarioPersonal;
        }

        public PersonalCientifico(int legajo, string nombre, string apellido, int nroDocumento, int nroTelefono, string correoInstitucional, string correoPersonal)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroDocumento = nroDocumento;
            this.nroTelefono = nroTelefono;
            this.correoInstitucional = correoInstitucional;
            this.correoPersonal = correoPersonal;
        }

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NroDocumento { get => nroDocumento; set => nroDocumento = value; }
        public int NroTelefono { get => nroTelefono; set => nroTelefono = value; }
        public string CorreoInstitucional { get => correoInstitucional; set => correoInstitucional = value; }
        public string CorreoPersonal { get => correoPersonal; set => correoPersonal = value; }
        public Usuario UsuarioPersonal { get => usuarioPersonal; set => usuarioPersonal = value; }
    }
}
