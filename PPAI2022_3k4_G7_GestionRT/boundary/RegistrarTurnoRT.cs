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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro desea cancelar la reserva del turno de recurso tecnológico?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestor.tomarSeleccionTipoRecursoTecnologico(cmbTipoRecurso.SelectedItem.ToString());
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }



    }
}
