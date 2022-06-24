using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI2022_3k4_G7_GestionRT.control
{
    public class GestorDeCorreoElectronico
    {
        public GestorDeCorreoElectronico()
        {

        }

        public void enviarCorreoElectronico(StringBuilder Mensaje, string destinatario, string NombreRecurso, string FechaReserva)
        {
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Recurso reservado: ", NombreRecurso, "Fecha Reserva: {0:dd/MM/yyyy}", FechaReserva, "Horario: {0:HH:mm:ss} Hrs", FechaReserva));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("secretariacienciaytecnica@gmail.com");
                string para = destinatario;
                mail.To.Add(para);
                mail.Subject = "Confirmación de Reserva de Turno";
                mail.Body = Mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("SecretariaCienciaYTecnica@gmail.com", "DSI2022TPI");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
