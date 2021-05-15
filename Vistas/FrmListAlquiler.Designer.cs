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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 80);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(1003, 247);
            this.dgvAlquileres.TabIndex = 0;
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
            this.cmbEdifList.Location = new System.Drawing.Point(78, 24);
            this.cmbEdifList.Name = "cmbEdifList";
            this.cmbEdifList.Size = new System.Drawing.Size(200, 21);
            this.cmbEdifList.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(439, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(439, 38);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // cmbAlqTipoDpto
            // 
            this.cmbAlqTipoDpto.FormattingEnabled = true;
            this.cmbAlqTipoDpto.Location = new System.Drawing.Point(815, 24);
            this.cmbAlqTipoDpto.Name = "cmbAlqTipoDpto";
            this.cmbAlqTipoDpto.Size = new System.Drawing.Size(200, 21);
            this.cmbAlqTipoDpto.TabIndex = 6;
            // 
            // btnAlqBuscar
            // 
            this.btnAlqBuscar.Location = new System.Drawing.Point(887, 51);
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
            this.ckbAlqEdif.Location = new System.Drawing.Point(12, 26);
            this.ckbAlqEdif.Name = "ckbAlqEdif";
            this.ckbAlqEdif.Size = new System.Drawing.Size(60, 17);
            this.ckbAlqEdif.TabIndex = 9;
            this.ckbAlqEdif.Text = "Edificio";
            this.ckbAlqEdif.UseVisualStyleBackColor = true;
            this.ckbAlqEdif.CheckedChanged += new System.EventHandler(this.ckbAlqEdif_CheckedChanged);
            // 
            // ckbAlqRango
            // 
            this.ckbAlqRango.AutoSize = true;
            this.ckbAlqRango.Location = new System.Drawing.Point(325, 26);
            this.ckbAlqRango.Name = "ckbAlqRango";
            this.ckbAlqRango.Size = new System.Drawing.Size(108, 17);
            this.ckbAlqRango.TabIndex = 10;
            this.ckbAlqRango.Text = "Rango de fechas";
            this.ckbAlqRango.UseVisualStyleBackColor = true;
            this.ckbAlqRango.CheckedChanged += new System.EventHandler(this.ckbAlqRango_CheckedChanged);
            // 
            // ckbAlqDpto
            // 
            this.ckbAlqDpto.AutoSize = true;
            this.ckbAlqDpto.Location = new System.Drawing.Point(677, 26);
            this.ckbAlqDpto.Name = "ckbAlqDpto";
            this.ckbAlqDpto.Size = new System.Drawing.Size(132, 17);
            this.ckbAlqDpto.TabIndex = 11;
            this.ckbAlqDpto.Text = "Tipo de Departamento";
            this.ckbAlqDpto.UseVisualStyleBackColor = true;
            this.ckbAlqDpto.CheckedChanged += new System.EventHandler(this.ckbAlqDpto_CheckedChanged);
            // 
            // FrmListAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 340);
            this.Controls.Add(this.ckbAlqDpto);
            this.Controls.Add(this.ckbAlqRango);
            this.Controls.Add(this.ckbAlqEdif);
            this.Controls.Add(this.btnAlqBuscar);
            this.Controls.Add(this.cmbAlqTipoDpto);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cmbEdifList);
            this.Controls.Add(this.dgvAlquileres);
            this.Name = "FrmListAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Alquileres";
            this.Load += new System.EventHandler(this.FrmListAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).EndInit();
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
    }
}