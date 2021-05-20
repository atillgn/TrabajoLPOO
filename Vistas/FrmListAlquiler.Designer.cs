namespace Vistas
{
    partial class FrmListAlquiler
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
            this.components = new System.ComponentModel.Container();
            this.dgvAlquileres = new System.Windows.Forms.DataGridView();
            this.alquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosDataSet1 = new Vistas.datosDataSet1();
            this.alquilerTableAdapter = new Vistas.datosDataSet1TableAdapters.AlquilerTableAdapter();
            this.cmbEdifList = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbAlqTipoDpto = new System.Windows.Forms.ComboBox();
            this.btnAlqBuscar = new System.Windows.Forms.Button();
            this.ckbAlqEdif = new System.Windows.Forms.CheckBox();
            this.ckbAlqRango = new System.Windows.Forms.CheckBox();
            this.ckbAlqDpto = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.dgvAlquileres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(36, 108);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(1003, 236);
            this.dgvAlquileres.TabIndex = 9;
            // 
            // alquilerBindingSource
            // 
            this.alquilerBindingSource.DataMember = "Alquiler";
            this.alquilerBindingSource.DataSource = this.datosDataSet1;
            // 
            // datosDataSet1
            // 
            this.datosDataSet1.DataSetName = "datosDataSet1";
            this.datosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquilerTableAdapter
            // 
            this.alquilerTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEdifList
            // 
            this.cmbEdifList.FormattingEnabled = true;
            this.cmbEdifList.Location = new System.Drawing.Point(102, 52);
            this.cmbEdifList.Name = "cmbEdifList";
            this.cmbEdifList.Size = new System.Drawing.Size(200, 21);
            this.cmbEdifList.TabIndex = 2;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(463, 40);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(463, 66);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // cmbAlqTipoDpto
            // 
            this.cmbAlqTipoDpto.FormattingEnabled = true;
            this.cmbAlqTipoDpto.Location = new System.Drawing.Point(839, 52);
            this.cmbAlqTipoDpto.Name = "cmbAlqTipoDpto";
            this.cmbAlqTipoDpto.Size = new System.Drawing.Size(200, 21);
            this.cmbAlqTipoDpto.TabIndex = 7;
            // 
            // btnAlqBuscar
            // 
            this.btnAlqBuscar.Location = new System.Drawing.Point(911, 79);
            this.btnAlqBuscar.Name = "btnAlqBuscar";
            this.btnAlqBuscar.Size = new System.Drawing.Size(128, 23);
            this.btnAlqBuscar.TabIndex = 8;
            this.btnAlqBuscar.Text = "Buscar";
            this.btnAlqBuscar.UseVisualStyleBackColor = true;
            this.btnAlqBuscar.Click += new System.EventHandler(this.btnAlqBuscar_Click);
            // 
            // ckbAlqEdif
            // 
            this.ckbAlqEdif.AutoSize = true;
            this.ckbAlqEdif.Location = new System.Drawing.Point(36, 54);
            this.ckbAlqEdif.Name = "ckbAlqEdif";
            this.ckbAlqEdif.Size = new System.Drawing.Size(60, 17);
            this.ckbAlqEdif.TabIndex = 1;
            this.ckbAlqEdif.Text = "Edificio";
            this.ckbAlqEdif.UseVisualStyleBackColor = true;
            this.ckbAlqEdif.CheckedChanged += new System.EventHandler(this.ckbAlqEdif_CheckedChanged);
            // 
            // ckbAlqRango
            // 
            this.ckbAlqRango.AutoSize = true;
            this.ckbAlqRango.Location = new System.Drawing.Point(349, 54);
            this.ckbAlqRango.Name = "ckbAlqRango";
            this.ckbAlqRango.Size = new System.Drawing.Size(108, 17);
            this.ckbAlqRango.TabIndex = 3;
            this.ckbAlqRango.Text = "Rango de fechas";
            this.ckbAlqRango.UseVisualStyleBackColor = true;
            this.ckbAlqRango.CheckedChanged += new System.EventHandler(this.ckbAlqRango_CheckedChanged);
            // 
            // ckbAlqDpto
            // 
            this.ckbAlqDpto.AutoSize = true;
            this.ckbAlqDpto.Location = new System.Drawing.Point(701, 54);
            this.ckbAlqDpto.Name = "ckbAlqDpto";
            this.ckbAlqDpto.Size = new System.Drawing.Size(132, 17);
            this.ckbAlqDpto.TabIndex = 6;
            this.ckbAlqDpto.Text = "Tipo de Departamento";
            this.ckbAlqDpto.UseVisualStyleBackColor = true;
            this.ckbAlqDpto.CheckedChanged += new System.EventHandler(this.ckbAlqDpto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 23);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(998, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 23);
            this.btnVolver.TabIndex = 14;
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
            this.panel2.Size = new System.Drawing.Size(15, 356);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1062, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 356);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(15, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1047, 15);
            this.panel4.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 13);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Lista de Todos los Alquileres";
            // 
            // FrmListAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1075, 379);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckbAlqDpto);
            this.Controls.Add(this.ckbAlqRango);
            this.Controls.Add(this.ckbAlqEdif);
            this.Controls.Add(this.btnAlqBuscar);
            this.Controls.Add(this.cmbAlqTipoDpto);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cmbEdifList);
            this.Controls.Add(this.dgvAlquileres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Alquileres";
            this.Load += new System.EventHandler(this.FrmListAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquileres;
        private datosDataSet1 datosDataSet1;
        private System.Windows.Forms.BindingSource alquilerBindingSource;
        private datosDataSet1TableAdapters.AlquilerTableAdapter alquilerTableAdapter;
        private System.Windows.Forms.ComboBox cmbEdifList;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cmbAlqTipoDpto;
        private System.Windows.Forms.Button btnAlqBuscar;
        private System.Windows.Forms.CheckBox ckbAlqEdif;
        private System.Windows.Forms.CheckBox ckbAlqRango;
        private System.Windows.Forms.CheckBox ckbAlqDpto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitulo;
    }
}