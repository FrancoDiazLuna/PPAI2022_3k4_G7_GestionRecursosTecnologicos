﻿namespace PPAI2022_3k4_G7_GestionRT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admFacultades = new System.Windows.Forms.ToolStripMenuItem();
            this.admCentrosDeInvestigación = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaTurnoDeRecursoTecnológico = new System.Windows.Forms.ToolStripMenuItem();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeRecursosTecnológicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBajaDeFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeRecursosTecnológicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTipoDeRecursoTecnológicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTipoDeRecursoTecnológicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTiposDeRecursoTecnológicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirInformeDeCIYRTDeFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteDeActividadDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.administracionToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admFacultades,
            this.admCentrosDeInvestigación,
            this.administraciónDeRecursosTecnológicosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // admFacultades
            // 
            this.admFacultades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarFacultadToolStripMenuItem,
            this.registrarBajaDeFacultadToolStripMenuItem,
            this.modificarFacultadToolStripMenuItem,
            this.consultarFacultadToolStripMenuItem});
            this.admFacultades.Name = "admFacultades";
            this.admFacultades.Size = new System.Drawing.Size(221, 22);
            this.admFacultades.Text = "De Facultades";
            // 
            // admCentrosDeInvestigación
            // 
            this.admCentrosDeInvestigación.Name = "admCentrosDeInvestigación";
            this.admCentrosDeInvestigación.Size = new System.Drawing.Size(221, 22);
            this.admCentrosDeInvestigación.Text = "De Centros de Investigación";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaTurnoDeRecursoTecnológico});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // reservaTurnoDeRecursoTecnológico
            // 
            this.reservaTurnoDeRecursoTecnológico.Name = "reservaTurnoDeRecursoTecnológico";
            this.reservaTurnoDeRecursoTecnológico.Size = new System.Drawing.Size(274, 22);
            this.reservaTurnoDeRecursoTecnológico.Text = "Reservar turno de recurso tecnológico";
            this.reservaTurnoDeRecursoTecnológico.Click += new System.EventHandler(this.reservaTurnoDeRecursoTecnológico_Click);
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1184, 937);
            this.panelMain.TabIndex = 1;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioDeRecursosTecnológicosToolStripMenuItem,
            this.estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem,
            this.emitirInformeDeCIYRTDeFacultadToolStripMenuItem,
            this.generarReporteDeActividadDeUsuarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // inventarioDeRecursosTecnológicosToolStripMenuItem
            // 
            this.inventarioDeRecursosTecnológicosToolStripMenuItem.Name = "inventarioDeRecursosTecnológicosToolStripMenuItem";
            this.inventarioDeRecursosTecnológicosToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.inventarioDeRecursosTecnológicosToolStripMenuItem.Text = "Inventario de recursos tecnológicos";
            // 
            // estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem
            // 
            this.estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem.Name = "estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem";
            this.estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem.Text = "Estadísticas de uso de recursos tecnológicos";
            // 
            // registrarFacultadToolStripMenuItem
            // 
            this.registrarFacultadToolStripMenuItem.Name = "registrarFacultadToolStripMenuItem";
            this.registrarFacultadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarFacultadToolStripMenuItem.Text = "Registrar facultad";
            // 
            // registrarBajaDeFacultadToolStripMenuItem
            // 
            this.registrarBajaDeFacultadToolStripMenuItem.Name = "registrarBajaDeFacultadToolStripMenuItem";
            this.registrarBajaDeFacultadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.registrarBajaDeFacultadToolStripMenuItem.Text = "Registrar baja de facultad";
            // 
            // modificarFacultadToolStripMenuItem
            // 
            this.modificarFacultadToolStripMenuItem.Name = "modificarFacultadToolStripMenuItem";
            this.modificarFacultadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.modificarFacultadToolStripMenuItem.Text = "Modificar facultad";
            // 
            // consultarFacultadToolStripMenuItem
            // 
            this.consultarFacultadToolStripMenuItem.Name = "consultarFacultadToolStripMenuItem";
            this.consultarFacultadToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.consultarFacultadToolStripMenuItem.Text = "Consultar facultad";
            // 
            // administraciónDeRecursosTecnológicosToolStripMenuItem
            // 
            this.administraciónDeRecursosTecnológicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTipoDeRecursoTecnológicoToolStripMenuItem,
            this.registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem,
            this.modificarTipoDeRecursoTecnológicoToolStripMenuItem,
            this.consultarTiposDeRecursoTecnológicoToolStripMenuItem});
            this.administraciónDeRecursosTecnológicosToolStripMenuItem.Name = "administraciónDeRecursosTecnológicosToolStripMenuItem";
            this.administraciónDeRecursosTecnológicosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.administraciónDeRecursosTecnológicosToolStripMenuItem.Text = "De Recursos Tecnológicos";
            // 
            // registrarTipoDeRecursoTecnológicoToolStripMenuItem
            // 
            this.registrarTipoDeRecursoTecnológicoToolStripMenuItem.Name = "registrarTipoDeRecursoTecnológicoToolStripMenuItem";
            this.registrarTipoDeRecursoTecnológicoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.registrarTipoDeRecursoTecnológicoToolStripMenuItem.Text = "Registrar tipo de recurso tecnológico";
            // 
            // registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem
            // 
            this.registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem.Name = "registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem";
            this.registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem.Text = "Registrar baja de tipo de recurso tecnológico";
            // 
            // modificarTipoDeRecursoTecnológicoToolStripMenuItem
            // 
            this.modificarTipoDeRecursoTecnológicoToolStripMenuItem.Name = "modificarTipoDeRecursoTecnológicoToolStripMenuItem";
            this.modificarTipoDeRecursoTecnológicoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.modificarTipoDeRecursoTecnológicoToolStripMenuItem.Text = "Modificar tipo de recurso tecnológico";
            // 
            // consultarTiposDeRecursoTecnológicoToolStripMenuItem
            // 
            this.consultarTiposDeRecursoTecnológicoToolStripMenuItem.Name = "consultarTiposDeRecursoTecnológicoToolStripMenuItem";
            this.consultarTiposDeRecursoTecnológicoToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.consultarTiposDeRecursoTecnológicoToolStripMenuItem.Text = "Consultar tipos de recurso tecnológico";
            // 
            // emitirInformeDeCIYRTDeFacultadToolStripMenuItem
            // 
            this.emitirInformeDeCIYRTDeFacultadToolStripMenuItem.Name = "emitirInformeDeCIYRTDeFacultadToolStripMenuItem";
            this.emitirInformeDeCIYRTDeFacultadToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.emitirInformeDeCIYRTDeFacultadToolStripMenuItem.Text = "Emitir informe de CI y RT de facultad";
            // 
            // generarReporteDeActividadDeUsuarioToolStripMenuItem
            // 
            this.generarReporteDeActividadDeUsuarioToolStripMenuItem.Name = "generarReporteDeActividadDeUsuarioToolStripMenuItem";
            this.generarReporteDeActividadDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.generarReporteDeActividadDeUsuarioToolStripMenuItem.Text = "Generar reporte de actividad de usuario";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem,
            this.acercaDelSistemaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la ayuda";
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            this.acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            this.acercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDelSistemaToolStripMenuItem.Text = "Acerca del sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaría de Ciencia y Técnica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admFacultades;
        private System.Windows.Forms.ToolStripMenuItem admCentrosDeInvestigación;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaTurnoDeRecursoTecnológico;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBajaDeFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeRecursosTecnológicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTipoDeRecursoTecnológicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBajaDeTipoDeRecursoTecnológicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTipoDeRecursoTecnológicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTiposDeRecursoTecnológicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeRecursosTecnológicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasDeUsoDeRecursosTecnológicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirInformeDeCIYRTDeFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteDeActividadDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
    }
}

