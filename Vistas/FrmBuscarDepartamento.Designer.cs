namespace Vistas
{
    partial class FrmBuscarDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.rdbBanios = new System.Windows.Forms.RadioButton();
            this.rdbAmbientes = new System.Windows.Forms.RadioButton();
            this.rdbPrecio = new System.Windows.Forms.RadioButton();
            this.lblBanios = new System.Windows.Forms.Label();
            this.lblAmbientes = new System.Windows.Forms.Label();
            this.lblDisposicion = new System.Windows.Forms.Label();
            this.lblTipoDpto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblRangoFecha = new System.Windows.Forms.Label();
            this.dgvDpto = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.cmbDisposicion = new System.Windows.Forms.ComboBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAmbientes = new System.Windows.Forms.TextBox();
            this.cmbTipoDpto = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 23);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(4, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscador de Departamentos para Alquilar";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(882, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "<--- Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 502);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(941, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 502);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(16, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 16);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblOrdenar);
            this.panel5.Controls.Add(this.rdbBanios);
            this.panel5.Controls.Add(this.rdbAmbientes);
            this.panel5.Controls.Add(this.rdbPrecio);
            this.panel5.Controls.Add(this.lblBanios);
            this.panel5.Controls.Add(this.lblAmbientes);
            this.panel5.Controls.Add(this.lblDisposicion);
            this.panel5.Controls.Add(this.lblTipoDpto);
            this.panel5.Controls.Add(this.lblPrecio);
            this.panel5.Controls.Add(this.lblRangoFecha);
            this.panel5.Controls.Add(this.dgvDpto);
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.btnAlquilar);
            this.panel5.Controls.Add(this.cmbDisposicion);
            this.panel5.Controls.Add(this.txtBaños);
            this.panel5.Controls.Add(this.txtPrecio);
            this.panel5.Controls.Add(this.txtAmbientes);
            this.panel5.Controls.Add(this.cmbTipoDpto);
            this.panel5.Controls.Add(this.dtpHasta);
            this.panel5.Controls.Add(this.dtpDesde);
            this.panel5.Location = new System.Drawing.Point(46, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(866, 426);
            this.panel5.TabIndex = 4;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(22, 131);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(66, 13);
            this.lblOrdenar.TabIndex = 19;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // rdbBanios
            // 
            this.rdbBanios.AutoSize = true;
            this.rdbBanios.Location = new System.Drawing.Point(239, 129);
            this.rdbBanios.Name = "rdbBanios";
            this.rdbBanios.Size = new System.Drawing.Size(55, 17);
            this.rdbBanios.TabIndex = 18;
            this.rdbBanios.TabStop = true;
            this.rdbBanios.Text = "Baños";
            this.rdbBanios.UseVisualStyleBackColor = true;
            this.rdbBanios.CheckedChanged += new System.EventHandler(this.rdbBanios_CheckedChanged);
            // 
            // rdbAmbientes
            // 
            this.rdbAmbientes.AutoSize = true;
            this.rdbAmbientes.Location = new System.Drawing.Point(159, 129);
            this.rdbAmbientes.Name = "rdbAmbientes";
            this.rdbAmbientes.Size = new System.Drawing.Size(74, 17);
            this.rdbAmbientes.TabIndex = 17;
            this.rdbAmbientes.TabStop = true;
            this.rdbAmbientes.Text = "Ambientes";
            this.rdbAmbientes.UseVisualStyleBackColor = true;
            this.rdbAmbientes.CheckedChanged += new System.EventHandler(this.rdbAmbientes_CheckedChanged);
            // 
            // rdbPrecio
            // 
            this.rdbPrecio.AutoSize = true;
            this.rdbPrecio.Location = new System.Drawing.Point(98, 129);
            this.rdbPrecio.Name = "rdbPrecio";
            this.rdbPrecio.Size = new System.Drawing.Size(55, 17);
            this.rdbPrecio.TabIndex = 16;
            this.rdbPrecio.TabStop = true;
            this.rdbPrecio.Text = "Precio";
            this.rdbPrecio.UseVisualStyleBackColor = true;
            this.rdbPrecio.CheckedChanged += new System.EventHandler(this.rdbPrecio_CheckedChanged);
            // 
            // lblBanios
            // 
            this.lblBanios.AutoSize = true;
            this.lblBanios.Location = new System.Drawing.Point(658, 93);
            this.lblBanios.Name = "lblBanios";
            this.lblBanios.Size = new System.Drawing.Size(40, 13);
            this.lblBanios.TabIndex = 15;
            this.lblBanios.Text = "Baños:";
            // 
            // lblAmbientes
            // 
            this.lblAmbientes.AutoSize = true;
            this.lblAmbientes.Location = new System.Drawing.Point(658, 32);
            this.lblAmbientes.Name = "lblAmbientes";
            this.lblAmbientes.Size = new System.Drawing.Size(59, 13);
            this.lblAmbientes.TabIndex = 14;
            this.lblAmbientes.Text = "Ambientes:";
            // 
            // lblDisposicion
            // 
            this.lblDisposicion.AutoSize = true;
            this.lblDisposicion.Location = new System.Drawing.Point(375, 94);
            this.lblDisposicion.Name = "lblDisposicion";
            this.lblDisposicion.Size = new System.Drawing.Size(64, 13);
            this.lblDisposicion.TabIndex = 13;
            this.lblDisposicion.Text = "Disposicion:";
            // 
            // lblTipoDpto
            // 
            this.lblTipoDpto.AutoSize = true;
            this.lblTipoDpto.Location = new System.Drawing.Point(375, 32);
            this.lblTipoDpto.Name = "lblTipoDpto";
            this.lblTipoDpto.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDpto.TabIndex = 12;
            this.lblTipoDpto.Text = "Tipo Departamento:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 94);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio maximo:";
            // 
            // lblRangoFecha
            // 
            this.lblRangoFecha.AutoSize = true;
            this.lblRangoFecha.Location = new System.Drawing.Point(16, 32);
            this.lblRangoFecha.Name = "lblRangoFecha";
            this.lblRangoFecha.Size = new System.Drawing.Size(72, 13);
            this.lblRangoFecha.TabIndex = 10;
            this.lblRangoFecha.Text = "RangoFecha:";
            // 
            // dgvDpto
            // 
            this.dgvDpto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.dgvDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDpto.Location = new System.Drawing.Point(19, 152);
            this.dgvDpto.Name = "dgvDpto";
            this.dgvDpto.Size = new System.Drawing.Size(825, 254);
            this.dgvDpto.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(769, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(688, 123);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(75, 23);
            this.btnAlquilar.TabIndex = 7;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // cmbDisposicion
            // 
            this.cmbDisposicion.FormattingEnabled = true;
            this.cmbDisposicion.Location = new System.Drawing.Point(445, 91);
            this.cmbDisposicion.Name = "cmbDisposicion";
            this.cmbDisposicion.Size = new System.Drawing.Size(121, 21);
            this.cmbDisposicion.TabIndex = 6;
            // 
            // txtBaños
            // 
            this.txtBaños.Location = new System.Drawing.Point(704, 91);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(121, 20);
            this.txtBaños.TabIndex = 5;
            this.txtBaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaños_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(94, 90);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtAmbientes
            // 
            this.txtAmbientes.Location = new System.Drawing.Point(723, 29);
            this.txtAmbientes.Name = "txtAmbientes";
            this.txtAmbientes.Size = new System.Drawing.Size(121, 20);
            this.txtAmbientes.TabIndex = 3;
            this.txtAmbientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmbientes_KeyPress);
            // 
            // cmbTipoDpto
            // 
            this.cmbTipoDpto.FormattingEnabled = true;
            this.cmbTipoDpto.Location = new System.Drawing.Point(482, 29);
            this.cmbTipoDpto.Name = "cmbTipoDpto";
            this.cmbTipoDpto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDpto.TabIndex = 2;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(94, 44);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(94, 18);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // FrmBuscarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(957, 525);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBuscarDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarDepartamento";
            this.Load += new System.EventHandler(this.FrmBuscarDepartamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvDpto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.ComboBox cmbDisposicion;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAmbientes;
        private System.Windows.Forms.ComboBox cmbTipoDpto;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBanios;
        private System.Windows.Forms.Label lblAmbientes;
        private System.Windows.Forms.Label lblDisposicion;
        private System.Windows.Forms.Label lblTipoDpto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblRangoFecha;
        private System.Windows.Forms.RadioButton rdbBanios;
        private System.Windows.Forms.RadioButton rdbAmbientes;
        private System.Windows.Forms.RadioButton rdbPrecio;
        private System.Windows.Forms.Label lblOrdenar;
    }
}