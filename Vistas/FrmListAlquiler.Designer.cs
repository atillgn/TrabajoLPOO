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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquileres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlquileres.Location = new System.Drawing.Point(0, 0);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.Size = new System.Drawing.Size(1022, 209);
            this.dgvAlquileres.TabIndex = 0;
            this.dgvAlquileres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // FrmListAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 209);
            this.Controls.Add(this.dgvAlquileres);
            this.Name = "FrmListAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListAlquiler";
            this.Load += new System.EventHandler(this.FrmListAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlquileres;
        private datosDataSet1 datosDataSet1;
        private System.Windows.Forms.BindingSource alquilerBindingSource;
        private datosDataSet1TableAdapters.AlquilerTableAdapter alquilerTableAdapter;
    }
}