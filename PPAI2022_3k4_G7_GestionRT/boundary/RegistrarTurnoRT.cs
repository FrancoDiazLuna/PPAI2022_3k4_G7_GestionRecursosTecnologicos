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

        private void btnReservar_Click(object sender, EventArgs e)
        {

            gestor.finCU();
        }

        private void tomarSeleccionDeRT(object sender, EventArgs e)
        {
            grbNuevoTurno.Enabled = true;
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

        private void calendario_DayClick(object sender, DayClickEventArgs e)
        {
            dgvTurnos.Rows.Clear();
            if (calendario.SelectedDates.Count > 0)
            {
                DateTime date = calendario.SelectedDates[0].Date;
                gestor.tomarSeleccionDia(date);
            }
        }
    }
}
