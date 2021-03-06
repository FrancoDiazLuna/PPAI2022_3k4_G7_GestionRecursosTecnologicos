using PPAI2022_3k4_G7_GestionRT.boundary;
using PPAI2022_3k4_G7_GestionRT.control;
using PPAI2022_3k4_G7_GestionRT.entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI2022_3k4_G7_GestionRT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Sesion sesion = CargaDeDatos.loadSesion();
        }

        private void reservaTurnoDeRecursoTecnológico_Click(object sender, EventArgs e)
        {
            ucRegistrarTurnoRT uc = new ucRegistrarTurnoRT();
            showControl(uc);

        }

        public void showControl(Control control)
        {
            limpiarPanelPrincipal();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            panelMain.Controls.Add(control);
        }

        private void limpiarPanelPrincipal()
        {
            panelMain.Controls.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
