namespace PPAI2022_3k4_G7_GestionRT
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeInvestigaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDeRecursoTecnologicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultadesToolStripMenuItem,
            this.centrosDeInvestigaciónToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // facultadesToolStripMenuItem
            // 
            this.facultadesToolStripMenuItem.Name = "facultadesToolStripMenuItem";
            this.facultadesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.facultadesToolStripMenuItem.Text = "Facultades";
            // 
            // centrosDeInvestigaciónToolStripMenuItem
            // 
            this.centrosDeInvestigaciónToolStripMenuItem.Name = "centrosDeInvestigaciónToolStripMenuItem";
            this.centrosDeInvestigaciónToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.centrosDeInvestigaciónToolStripMenuItem.Text = "Centros de Investigación";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaDeRecursoTecnologicoToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // reservaDeRecursoTecnologicoToolStripMenuItem
            // 
            this.reservaDeRecursoTecnologicoToolStripMenuItem.Name = "reservaDeRecursoTecnologicoToolStripMenuItem";
            this.reservaDeRecursoTecnologicoToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.reservaDeRecursoTecnologicoToolStripMenuItem.Text = "Reserva de Recurso Tecnologico";
            // 
            // masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem
            // 
            this.masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem.Name = "masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem";
            this.masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem.Size = new System.Drawing.Size(308, 20);
            this.masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem.Text = "mas opciones que no van a hacer nada de momento....";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(884, 837);
            this.panelMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.Text = "Secretaría de Ciencia y Técnica - Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosDeInvestigaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaDeRecursoTecnologicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masOpcionesQueNoVanAHacerNadaDeMomentoToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
    }
}

