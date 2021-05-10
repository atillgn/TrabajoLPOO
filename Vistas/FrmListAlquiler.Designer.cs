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
            this.lblAlqList = new System.Windows.Forms.Label();
            this.lblAlqRango = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbAlqTipoDpto = new System.Windows.Forms.ComboBox();
            this.lblAlqTipoDpto = new System.Windows.Forms.Label();
            this.btnAlqBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Location = new System.Drawing.Point(12, 15);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(499, 250);
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
            this.cmbEdifList.Location = new System.Drawing.Point(690, 38);
            this.cmbEdifList.Name = "cmbEdifList";
            this.cmbEdifList.Size = new System.Drawing.Size(200, 21);
            this.cmbEdifList.TabIndex = 1;
            // 
            // lblAlqList
            // 
            this.lblAlqList.AutoSize = true;
            this.lblAlqList.Location = new System.Drawing.Point(550, 41);
            this.lblAlqList.Name = "lblAlqList";
            this.lblAlqList.Size = new System.Drawing.Size(41, 13);
            this.lblAlqList.TabIndex = 2;
            this.lblAlqList.Text = "Edificio";
            // 
            // lblAlqRango
            // 
            this.lblAlqRango.AutoSize = true;
            this.lblAlqRango.Location = new System.Drawing.Point(550, 113);
            this.lblAlqRango.Name = "lblAlqRango";
            this.lblAlqRango.Size = new System.Drawing.Size(89, 13);
            this.lblAlqRango.TabIndex = 3;
            this.lblAlqRango.Text = "Rango de fechas";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(690, 96);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(690, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // cmbAlqTipoDpto
            // 
            this.cmbAlqTipoDpto.FormattingEnabled = true;
            this.cmbAlqTipoDpto.Location = new System.Drawing.Point(690, 183);
            this.cmbAlqTipoDpto.Name = "cmbAlqTipoDpto";
            this.cmbAlqTipoDpto.Size = new System.Drawing.Size(200, 21);
            this.cmbAlqTipoDpto.TabIndex = 6;
            // 
            // lblAlqTipoDpto
            // 
            this.lblAlqTipoDpto.AutoSize = true;
            this.lblAlqTipoDpto.Location = new System.Drawing.Point(550, 186);
            this.lblAlqTipoDpto.Name = "lblAlqTipoDpto";
            this.lblAlqTipoDpto.Size = new System.Drawing.Size(113, 13);
            this.lblAlqTipoDpto.TabIndex = 7;
            this.lblAlqTipoDpto.Text = "Tipo de Departamento";
            // 
            // btnAlqBuscar
            // 
            this.btnAlqBuscar.Location = new System.Drawing.Point(656, 242);
            this.btnAlqBuscar.Name = "btnAlqBuscar";
            this.btnAlqBuscar.Size = new System.Drawing.Size(128, 23);
            this.btnAlqBuscar.TabIndex = 8;
            this.btnAlqBuscar.Text = "Buscar";
            this.btnAlqBuscar.UseVisualStyleBackColor = true;
            this.btnAlqBuscar.Click += new System.EventHandler(this.btnAlqBuscar_Click);
            // 
            // FrmListAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 277);
            this.Controls.Add(this.btnAlqBuscar);
            this.Controls.Add(this.lblAlqTipoDpto);
            this.Controls.Add(this.cmbAlqTipoDpto);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblAlqRango);
            this.Controls.Add(this.lblAlqList);
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
        private System.Windows.Forms.Label lblAlqList;
        private System.Windows.Forms.Label lblAlqRango;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cmbAlqTipoDpto;
        private System.Windows.Forms.Label lblAlqTipoDpto;
        private System.Windows.Forms.Button btnAlqBuscar;
    }
}