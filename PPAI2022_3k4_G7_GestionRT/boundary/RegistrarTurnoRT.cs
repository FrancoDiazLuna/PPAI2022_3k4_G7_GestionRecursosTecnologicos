using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pabo.Calendar;
using PPAI2022_3k4_G7_GestionRT.control;
using PPAI2022_3k4_G7_GestionRT.entidad;

namespace PPAI2022_3k4_G7_GestionRT.boundary
{
    public partial class ucRegistrarTurnoRT : UserControl
    {
        private GestorDeTurnosDeRecursoTecnologico gestor;
        
        public ucRegistrarTurnoRT()
        {
            InitializeComponent();
            habilitarPantalla();
        }

        private void habilitarPantalla() 
        {
            gestor = new GestorDeTurnosDeRecursoTecnologico(this);
            gestor.opcionReservarTurnoRT();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro desea cancelar la reserva del turno de recurso tecnológico?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        internal void mostrarTiposDeRT(List<string> lista)
        {
            cmbTipoRecurso.Items.AddRange(lista.ToArray());
        }

        internal void solicitarSeleccionDeTiposDeRT()
        {
            return;
        }

        private void tomarSeleccionDeTipoDeRT(object sender, EventArgs e)
        {
            grbSeleccionDeRecurso.Enabled = true;
            dgvRecursosTecnologicos.Enabled = true;
            btnSeleccionarRT.Enabled = true;
            gestor.tipoDeRTSeleccionado(cmbTipoRecurso.SelectedItem.ToString());
        }

        private void tomarConfirmacionDeReservaDeTurno(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow == null || dgvTurnos.CurrentRow.Cells[3].Value.ToString() == "Reservado" || (chkEmail.Checked == false && chkWhatsapp.Checked == false || (chkEmail.Checked == true && chkWhatsapp.Checked == true) == true) == true)
            {
                if (dgvTurnos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un turno", "Reserva de truno");
                }
                else if (dgvTurnos.CurrentRow.Cells[3].Value.ToString() == "Reservado")
                {
                    MessageBox.Show("Seleccione un turno Disponible", "Reserva de truno");
                }
                else if ((chkEmail.Checked == false && chkWhatsapp.Checked == false) == true)
                {
                    MessageBox.Show("Seleccione una forma de Notificacion", "Reserva de truno");
                }
                else if ((chkEmail.Checked == true && chkWhatsapp.Checked == true) == true)
                {
                    MessageBox.Show("Seleccione UNA SOLA forma de Notificacion", "Reserva de truno");
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea reservar este turno?", "Reserva de truno", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    gestor.confirmarReservaDeTurno();
                    StringBuilder MensajeBuilder = new StringBuilder();
                    string Message = "Su turno ha sido correctamente reservado";
                    MensajeBuilder.Append(Message);

                    if (chkEmail.Checked)
                    {
                        MessageBox.Show("Enviando notificación de reserva por Email");
                        gestor.generarNotificacionReservaDeTurno();
                        MessageBox.Show("Email enviado correctamente.");
                    }

                    if (chkWhatsapp.Checked)
                        MessageBox.Show("Mensaje enviado correctamente.");

                    gestor.finCU();
                }
            }
        }

        private void tomarSeleccionDeRT(object sender, EventArgs e)
        {
            grbNuevoTurno.Enabled = true;
            btnReservar.Enabled = true;
            if (dgvRecursosTecnologicos.CurrentRow != null)
            {
                string centroDeInv = (string)dgvRecursosTecnologicos.CurrentRow.Cells[1].Value;
                int numeroInventario = (int)dgvRecursosTecnologicos.CurrentRow.Cells[0].Value;
                string marca = (string)dgvRecursosTecnologicos.CurrentRow.Cells[2].Value;
                string modelo = (string)dgvRecursosTecnologicos.CurrentRow.Cells[3].Value;
                string estado = (string)dgvRecursosTecnologicos.CurrentRow.Cells[4].Value;
                RecursoTecnologicoMuestra rtm = new RecursoTecnologicoMuestra(centroDeInv, numeroInventario, marca, modelo, estado);

                gestor.recursoTecnologicoSeleccionado(rtm);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de recurso");
            }

            txtTipoRecurso.Text = cmbTipoRecurso.SelectedItem.ToString();
            txtNroDeInventario.Text = dgvRecursosTecnologicos.CurrentRow.Cells[0].Value.ToString();
            txtCentroDePertenencia.Text = dgvRecursosTecnologicos.CurrentRow.Cells[1].Value.ToString();
            txtMarca.Text = dgvRecursosTecnologicos.CurrentRow.Cells[2].Value.ToString();
            txtModelo.Text = dgvRecursosTecnologicos.CurrentRow.Cells[3].Value.ToString();
            txtEstado.Text = dgvRecursosTecnologicos.CurrentRow.Cells[4].Value.ToString();
        }

        internal void mostrarRT(List<RecursoTecnologicoMuestra> listaRecursosMuestra)
        {
            dgvRecursosTecnologicos.Rows.Clear();
            foreach (var recurso in listaRecursosMuestra)
            {
                dgvRecursosTecnologicos.Rows.Add(recurso.getNumetoInventario(), recurso.getCentroDeInvestigacion(), recurso.getMarca(), recurso.getModelo(), recurso.getEstado());
            }
            for (int i = 0; i < dgvRecursosTecnologicos.Rows.Count; i++)
            {
                colorear(i, listaRecursosMuestra[i].getColor());
            }
            dgvRecursosTecnologicos.ClearSelection();
        }

        private void colorear(int fila, int color)
        {
            switch (color)
            {
                case 1:
                    dgvRecursosTecnologicos.Rows[fila].Cells[0].Style.BackColor = Color.LightBlue;
                    dgvRecursosTecnologicos.Rows[fila].Cells[1].Style.BackColor = Color.LightBlue;
                    dgvRecursosTecnologicos.Rows[fila].Cells[2].Style.BackColor = Color.LightBlue;
                    dgvRecursosTecnologicos.Rows[fila].Cells[3].Style.BackColor = Color.LightBlue;
                    dgvRecursosTecnologicos.Rows[fila].Cells[4].Style.BackColor = Color.LightBlue;
                    break;
                case 2:
                    dgvRecursosTecnologicos.Rows[fila].Cells[0].Style.BackColor = Color.LightSeaGreen;
                    dgvRecursosTecnologicos.Rows[fila].Cells[1].Style.BackColor = Color.LightSeaGreen;
                    dgvRecursosTecnologicos.Rows[fila].Cells[2].Style.BackColor = Color.LightSeaGreen;
                    dgvRecursosTecnologicos.Rows[fila].Cells[3].Style.BackColor = Color.LightSeaGreen;
                    dgvRecursosTecnologicos.Rows[fila].Cells[4].Style.BackColor = Color.LightSeaGreen;
                    break;
                case 3:
                    dgvRecursosTecnologicos.Rows[fila].Cells[0].Style.BackColor = Color.LightGray;
                    dgvRecursosTecnologicos.Rows[fila].Cells[1].Style.BackColor = Color.LightGray;
                    dgvRecursosTecnologicos.Rows[fila].Cells[2].Style.BackColor = Color.LightGray;
                    dgvRecursosTecnologicos.Rows[fila].Cells[3].Style.BackColor = Color.LightGray;
                    dgvRecursosTecnologicos.Rows[fila].Cells[4].Style.BackColor = Color.LightGray;
                    break;
            }
        }

        private void colorearTurnos(int fila, string estado)
        {
            switch (estado)
            {
                case "Disponible":
                    dgvTurnos.Rows[fila].Cells[0].Style.BackColor = Color.LightBlue;
                    dgvTurnos.Rows[fila].Cells[1].Style.BackColor = Color.LightBlue;
                    dgvTurnos.Rows[fila].Cells[2].Style.BackColor = Color.LightBlue;
                    dgvTurnos.Rows[fila].Cells[3].Style.BackColor = Color.LightBlue;
                    break;
                case "Pendiente":
                    dgvTurnos.Rows[fila].Cells[0].Style.BackColor = Color.LightSeaGreen;
                    dgvTurnos.Rows[fila].Cells[1].Style.BackColor = Color.LightSeaGreen;
                    dgvTurnos.Rows[fila].Cells[2].Style.BackColor = Color.LightSeaGreen;
                    dgvTurnos.Rows[fila].Cells[3].Style.BackColor = Color.LightSeaGreen;
                    break;
                case "Reservado":
                    dgvTurnos.Rows[fila].Cells[0].Style.BackColor = Color.LightSalmon;
                    dgvTurnos.Rows[fila].Cells[1].Style.BackColor = Color.LightSalmon;
                    dgvTurnos.Rows[fila].Cells[2].Style.BackColor = Color.LightSalmon;
                    dgvTurnos.Rows[fila].Cells[3].Style.BackColor = Color.LightSalmon;
                    break;
            }
        }

        internal void mostrarYSolicitarSeleccionTurnos(Dictionary<string, bool> disponibilidadAMostrar, Action<RecursoTecnologicoMuestra> recursoTecnologicoSeleccionado)
        {
            foreach (var dia in disponibilidadAMostrar)
            {
                DateItem item = new DateItem();
                if (dia.Value)
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Green;
                    calendario.AddDateInfo(item);
                }
                else
                {
                    item.Date = DateTime.Parse(dia.Key);
                    item.BackColor1 = Color.Red;
                    calendario.AddDateInfo(item);
                }
            }
        }

        private void calendar_DayClick(object sender, DayClickEventArgs e)
        {
            dgvTurnos.Rows.Clear();
            if (calendario.SelectedDates.Count > 0)
            {
                DateTime date = calendario.SelectedDates[0].Date;
                gestor.tomarSleccionDia(date);
            }
        }

        internal void mostrarDiaSeleccionado(List<TurnoMuestra> turnos)
        {
            foreach (var turno in turnos)
            {
                dgvTurnos.Rows.Add(turno.FechaHoraInicio.ToShortDateString(), turno.FechaHoraInicio.ToShortTimeString(), turno.FechaHoraFin.ToShortTimeString(), turno.Estado);
            }
            for (int i = 0; i < dgvTurnos.Rows.Count; i++)
            {
                colorearTurnos(i, turnos[i].Estado);
            }
            dgvTurnos.ClearSelection();
        }

        private void tomarSeleccionTurno(object sender, DataGridViewCellEventArgs e)
        {
            gestor.turnoSeleccionado(dgvTurnos.CurrentRow);
        }
    }
}
