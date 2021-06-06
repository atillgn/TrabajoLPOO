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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListAlquiler));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAlqEliminar = new System.Windows.Forms.Button();
            this.txtAlqCantidad = new System.Windows.Forms.TextBox();
            this.lblAlqCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlquileres
            // 
            this.dgvAlquileres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.dgvAlquileres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlquileres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlquileres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlquileres.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlquileres.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlquileres.EnableHeadersVisualStyles = false;
            this.dgvAlquileres.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvAlquileres.Location = new System.Drawing.Point(36, 108);
            this.dgvAlquileres.Name = "dgvAlquileres";
            this.dgvAlquileres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlquileres.RowHeadersVisible = false;
            this.dgvAlquileres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAlquileres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.cmbEdifList.Location = new System.Drawing.Point(114, 52);
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
            this.btnAlqBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnAlqBuscar.FlatAppearance.BorderSize = 2;
            this.btnAlqBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnAlqBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(156)))), ((int)(((byte)(249)))));
            this.btnAlqBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlqBuscar.ForeColor = System.Drawing.Color.White;
            this.btnAlqBuscar.Location = new System.Drawing.Point(911, 79);
            this.btnAlqBuscar.Name = "btnAlqBuscar";
            this.btnAlqBuscar.Size = new System.Drawing.Size(128, 27);
            this.btnAlqBuscar.TabIndex = 8;
            this.btnAlqBuscar.Text = "Buscar";
            this.btnAlqBuscar.UseVisualStyleBackColor = true;
            this.btnAlqBuscar.Click += new System.EventHandler(this.btnAlqBuscar_Click);
            // 
            // ckbAlqEdif
            // 
            this.ckbAlqEdif.AutoSize = true;
            this.ckbAlqEdif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlqEdif.ForeColor = System.Drawing.Color.White;
            this.ckbAlqEdif.Location = new System.Drawing.Point(36, 54);
            this.ckbAlqEdif.Name = "ckbAlqEdif";
            this.ckbAlqEdif.Size = new System.Drawing.Size(72, 21);
            this.ckbAlqEdif.TabIndex = 1;
            this.ckbAlqEdif.Text = "Edificio";
            this.ckbAlqEdif.UseVisualStyleBackColor = true;
            this.ckbAlqEdif.CheckedChanged += new System.EventHandler(this.ckbAlqEdif_CheckedChanged);
            // 
            // ckbAlqRango
            // 
            this.ckbAlqRango.AutoSize = true;
            this.ckbAlqRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlqRango.ForeColor = System.Drawing.Color.White;
            this.ckbAlqRango.Location = new System.Drawing.Point(322, 52);
            this.ckbAlqRango.Name = "ckbAlqRango";
            this.ckbAlqRango.Size = new System.Drawing.Size(135, 21);
            this.ckbAlqRango.TabIndex = 3;
            this.ckbAlqRango.Text = "Rango de fechas";
            this.ckbAlqRango.UseVisualStyleBackColor = true;
            this.ckbAlqRango.CheckedChanged += new System.EventHandler(this.ckbAlqRango_CheckedChanged);
            // 
            // ckbAlqDpto
            // 
            this.ckbAlqDpto.AutoSize = true;
            this.ckbAlqDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlqDpto.ForeColor = System.Drawing.Color.White;
            this.ckbAlqDpto.Location = new System.Drawing.Point(669, 52);
            this.ckbAlqDpto.Name = "ckbAlqDpto";
            this.ckbAlqDpto.Size = new System.Drawing.Size(169, 21);
            this.ckbAlqDpto.TabIndex = 6;
            this.ckbAlqDpto.Text = "Tipo de Departamento";
            this.ckbAlqDpto.UseVisualStyleBackColor = true;
            this.ckbAlqDpto.CheckedChanged += new System.EventHandler(this.ckbAlqDpto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.pictureBox2);
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
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(26, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(141, 13);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Lista de Todos los Alquileres";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(998, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 371);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1062, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 371);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(15, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1047, 15);
            this.panel4.TabIndex = 13;
            // 
            // btnAlqEliminar
            // 
            this.btnAlqEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAlqEliminar.FlatAppearance.BorderSize = 2;
            this.btnAlqEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAlqEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAlqEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlqEliminar.ForeColor = System.Drawing.Color.White;
            this.btnAlqEliminar.Location = new System.Drawing.Point(36, 349);
            this.btnAlqEliminar.Name = "btnAlqEliminar";
            this.btnAlqEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnAlqEliminar.TabIndex = 10;
            this.btnAlqEliminar.Text = "Eliminar";
            this.btnAlqEliminar.UseVisualStyleBackColor = true;
            this.btnAlqEliminar.Click += new System.EventHandler(this.btnAlqEliminar_Click);
            // 
            // txtAlqCantidad
            // 
            this.txtAlqCantidad.Location = new System.Drawing.Point(890, 352);
            this.txtAlqCantidad.Name = "txtAlqCantidad";
            this.txtAlqCantidad.Size = new System.Drawing.Size(149, 20);
            this.txtAlqCantidad.TabIndex = 11;
            // 
            // lblAlqCantidad
            // 
            this.lblAlqCantidad.AutoSize = true;
            this.lblAlqCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlqCantidad.ForeColor = System.Drawing.Color.White;
            this.lblAlqCantidad.Location = new System.Drawing.Point(728, 353);
            this.lblAlqCantidad.Name = "lblAlqCantidad";
            this.lblAlqCantidad.Size = new System.Drawing.Size(154, 17);
            this.lblAlqCantidad.TabIndex = 18;
            this.lblAlqCantidad.Text = "Cantidad de Alquileres:";
            // 
            // FrmListAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1075, 394);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlqCantidad);
            this.Controls.Add(this.txtAlqCantidad);
            this.Controls.Add(this.btnAlqEliminar);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button btnAlqEliminar;
        private System.Windows.Forms.TextBox txtAlqCantidad;
        private System.Windows.Forms.Label lblAlqCantidad;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}