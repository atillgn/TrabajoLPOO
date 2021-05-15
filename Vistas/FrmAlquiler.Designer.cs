namespace Vistas
{
    partial class FrmAlquiler
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
            this.lblEdificio = new System.Windows.Forms.Label();
            this.cmbEdif_Codigo = new System.Windows.Forms.ComboBox();
            this.cmbDpto_Codigo = new System.Windows.Forms.ComboBox();
            this.cmbInq_Codigo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlquilerConfirmar = new System.Windows.Forms.Button();
            this.btnAlquilerMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Location = new System.Drawing.Point(12, 15);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(41, 13);
            this.lblEdificio.TabIndex = 0;
            this.lblEdificio.Text = "Edificio";
            // 
            // cmbEdif_Codigo
            // 
            this.cmbEdif_Codigo.FormattingEnabled = true;
            this.cmbEdif_Codigo.Location = new System.Drawing.Point(100, 12);
            this.cmbEdif_Codigo.Name = "cmbEdif_Codigo";
            this.cmbEdif_Codigo.Size = new System.Drawing.Size(290, 21);
            this.cmbEdif_Codigo.TabIndex = 1;
            this.cmbEdif_Codigo.SelectedIndexChanged += new System.EventHandler(this.cmbEdif_Codigo_SelectedIndexChanged);
            // 
            // cmbDpto_Codigo
            // 
            this.cmbDpto_Codigo.FormattingEnabled = true;
            this.cmbDpto_Codigo.Location = new System.Drawing.Point(100, 39);
            this.cmbDpto_Codigo.Name = "cmbDpto_Codigo";
            this.cmbDpto_Codigo.Size = new System.Drawing.Size(290, 21);
            this.cmbDpto_Codigo.TabIndex = 2;
            this.cmbDpto_Codigo.SelectedIndexChanged += new System.EventHandler(this.cmbDpto_Codigo_SelectedIndexChanged);
            // 
            // cmbInq_Codigo
            // 
            this.cmbInq_Codigo.FormattingEnabled = true;
            this.cmbInq_Codigo.Location = new System.Drawing.Point(100, 66);
            this.cmbInq_Codigo.Name = "cmbInq_Codigo";
            this.cmbInq_Codigo.Size = new System.Drawing.Size(290, 21);
            this.cmbInq_Codigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inquilino";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(100, 94);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(290, 20);
            this.dtpDesde.TabIndex = 6;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(100, 121);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(290, 20);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hasta";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(100, 147);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(290, 20);
            this.txtPrecioFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio final";
            // 
            // btnAlquilerConfirmar
            // 
            this.btnAlquilerConfirmar.Location = new System.Drawing.Point(315, 181);
            this.btnAlquilerConfirmar.Name = "btnAlquilerConfirmar";
            this.btnAlquilerConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnAlquilerConfirmar.TabIndex = 12;
            this.btnAlquilerConfirmar.Text = "Registrar";
            this.btnAlquilerConfirmar.UseVisualStyleBackColor = true;
            this.btnAlquilerConfirmar.Click += new System.EventHandler(this.btnAlquilerConfirmar_Click);
            // 
            // btnAlquilerMostrar
            // 
            this.btnAlquilerMostrar.Location = new System.Drawing.Point(15, 181);
            this.btnAlquilerMostrar.Name = "btnAlquilerMostrar";
            this.btnAlquilerMostrar.Size = new System.Drawing.Size(128, 23);
            this.btnAlquilerMostrar.TabIndex = 13;
            this.btnAlquilerMostrar.Text = "Registro de Alquileres";
            this.btnAlquilerMostrar.UseVisualStyleBackColor = true;
            this.btnAlquilerMostrar.Click += new System.EventHandler(this.btnAlquilerMostrar_Click);
            // 
            // FrmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 216);
            this.Controls.Add(this.btnAlquilerMostrar);
            this.Controls.Add(this.btnAlquilerConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInq_Codigo);
            this.Controls.Add(this.cmbDpto_Codigo);
            this.Controls.Add(this.cmbEdif_Codigo);
            this.Controls.Add(this.lblEdificio);
            this.Name = "FrmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Alquiler";
            this.Load += new System.EventHandler(this.FrmAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdificio;
        private System.Windows.Forms.ComboBox cmbEdif_Codigo;
        private System.Windows.Forms.ComboBox cmbDpto_Codigo;
        private System.Windows.Forms.ComboBox cmbInq_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlquilerConfirmar;
        private System.Windows.Forms.Button btnAlquilerMostrar;
    }
}