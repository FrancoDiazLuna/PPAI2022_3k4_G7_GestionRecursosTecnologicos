using PPAI2022_3k4_G7_GestionRT.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI2022_3k4_G7_GestionRT.boundary
{
    public class InterfazDeCorreoElectronico
    {
        private GestorDeCorreoElectronico gestor;
        public InterfazDeCorreoElectronico()
        {
        }

        public void generarNotififacionReservaDeTurno(StringBuilder mensaje, string destinatario, string NombreRecurso, string FechaReserva) 
        {
            gestor = new GestorDeCorreoElectronico();
            gestor.enviarCorreoElectronico(mensaje, destinatario, NombreRecurso, FechaReserva);
        }

    }
}
