namespace PPAI2022_3k4_G7_GestionRT.boundary
{
    partial class ucRegistrarTurnoRT
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegistrarTurnoRT = new System.Windows.Forms.Label();
            this.panelDatosDeReserva = new System.Windows.Forms.Panel();
            this.cmbTipoRecurso = new System.Windows.Forms.ComboBox();
            this.lblSelTipoRT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgvRecursosTecnologicos = new System.Windows.Forms.DataGridView();
            this.NroDeInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroDeInvestigación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDatosDeReserva.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursosTecnologicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRegistrarTurnoRT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDatosDeReserva, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRegistrarTurnoRT
            // 
            this.lblRegistrarTurnoRT.AutoSize = true;
            this.lblRegistrarTurnoRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegistrarTurnoRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarTurnoRT.Location = new System.Drawing.Point(3, 0);
            this.lblRegistrarTurnoRT.Name = "lblRegistrarTurnoRT";
            this.lblRegistrarTurnoRT.Size = new System.Drawing.Size(894, 45);
            this.lblRegistrarTurnoRT.TabIndex = 2;
            this.lblRegistrarTurnoRT.Text = "Registrar reserva de turno para utilización de recurso tecnológico";
            // 
            // panelDatosDeReserva
            // 
            this.panelDatosDeReserva.Controls.Add(this.label1);
            this.panelDatosDeReserva.Controls.Add(this.dgvRecursosTecnologicos);
            this.panelDatosDeReserva.Controls.Add(this.cmbTipoRecurso);
            this.panelDatosDeReserva.Controls.Add(this.lblSelTipoRT);
            this.panelDatosDeReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosDeReserva.Location = new System.Drawing.Point(3, 48);
            this.panelDatosDeReserva.Name = "panelDatosDeReserva";
            this.panelDatosDeReserva.Size = new System.Drawing.Size(894, 804);
            this.panelDatosDeReserva.TabIndex = 3;
            // 
            // cmbTipoRecurso
            // 
            this.cmbTipoRecurso.FormattingEnabled = true;
            this.cmbTipoRecurso.Location = new System.Drawing.Point(240, 17);
            this.cmbTipoRecurso.Name = "cmbTipoRecurso";
            this.cmbTipoRecurso.Size = new System.Drawing.Size(275, 21);
            this.cmbTipoRecurso.TabIndex = 1;
            this.cmbTipoRecurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelTipoRT
            // 
            this.lblSelTipoRT.AutoSize = true;
            this.lblSelTipoRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelTipoRT.Location = new System.Drawing.Point(12, 15);
            this.lblSelTipoRT.Name = "lblSelTipoRT";
            this.lblSelTipoRT.Size = new System.Drawing.Size(222, 20);
            this.lblSelTipoRT.TabIndex = 0;
            this.lblSelTipoRT.Text = "Seleccione un tipo de recurso:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 858);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 39);
            this.panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.Location = new System.Drawing.Point(0, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 39);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReservar.Location = new System.Drawing.Point(808, 0);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(86, 39);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // dgvRecursosTecnologicos
            // 
            this.dgvRecursosTecnologicos.AllowUserToAddRows = false;
            this.dgvRecursosTecnologicos.AllowUserToDeleteRows = false;
            this.dgvRecursosTecnologicos.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvRecursosTecnologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursosTecnologicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDeInventario,
            this.CentroDeInvestigación,
            this.Marca,
            this.Modelo,
            this.Estado});
            this.dgvRecursosTecnologicos.Location = new System.Drawing.Point(16, 98);
            this.dgvRecursosTecnologicos.Name = "dgvRecursosTecnologicos";
            this.dgvRecursosTecnologicos.ReadOnly = true;
            this.dgvRecursosTecnologicos.RowHeadersVisible = false;
            this.dgvRecursosTecnologicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursosTecnologicos.Size = new System.Drawing.Size(599, 143);
            this.dgvRecursosTecnologicos.TabIndex = 2;
            // 
            // NroDeInventario
            // 
            this.NroDeInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroDeInventario.HeaderText = "Nro de Inventario";
            this.NroDeInventario.Name = "NroDeInventario";
            this.NroDeInventario.ReadOnly = true;
            // 
            // CentroDeInvestigación
            // 
            this.CentroDeInvestigación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CentroDeInvestigación.HeaderText = "Centro de Investigación";
            this.CentroDeInvestigación.Name = "CentroDeInvestigación";
            this.CentroDeInvestigación.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un recurso tecnológico:";
            // 
            // ucRegistrarTurnoRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucRegistrarTurnoRT";
            this.Size = new System.Drawing.Size(900, 900);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelDatosDeReserva.ResumeLayout(false);
            this.panelDatosDeReserva.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursosTecnologicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRegistrarTurnoRT;
        private System.Windows.Forms.Panel panelDatosDeReserva;
        private System.Windows.Forms.ComboBox cmbTipoRecurso;
        private System.Windows.Forms.Label lblSelTipoRT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvRecursosTecnologicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroDeInvestigación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
