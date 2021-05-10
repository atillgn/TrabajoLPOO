namespace Vistas
{
    partial class FrmDepartamento
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
            this.lblDptoCodigo = new System.Windows.Forms.Label();
            this.lblDptoEdifCodigo = new System.Windows.Forms.Label();
            this.lblDptoNumero = new System.Windows.Forms.Label();
            this.lblDptoTipo = new System.Windows.Forms.Label();
            this.lblDptoPiso = new System.Windows.Forms.Label();
            this.lblDptoAmbientes = new System.Windows.Forms.Label();
            this.lblDptoDormitorios = new System.Windows.Forms.Label();
            this.lblDptoBaños = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDptoPrecio = new System.Windows.Forms.Label();
            this.txtDptoCodigo = new System.Windows.Forms.TextBox();
            this.txtDptoPiso = new System.Windows.Forms.TextBox();
            this.txtDptoNumero = new System.Windows.Forms.TextBox();
            this.txtDptoEdifCodigo = new System.Windows.Forms.TextBox();
            this.txtDptoAmbiente = new System.Windows.Forms.TextBox();
            this.txtDptoBaños = new System.Windows.Forms.TextBox();
            this.txtDptoDormitorios = new System.Windows.Forms.TextBox();
            this.txtDptoPrecio = new System.Windows.Forms.TextBox();
            this.cmbDptoDisposicion = new System.Windows.Forms.ComboBox();
            this.cmbDptoTipo = new System.Windows.Forms.ComboBox();
            this.btnDptoConfirmar = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.optAmbiente = new System.Windows.Forms.RadioButton();
            this.optDisposicion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDptoCodigo
            // 
            this.lblDptoCodigo.AutoSize = true;
            this.lblDptoCodigo.Location = new System.Drawing.Point(12, 35);
            this.lblDptoCodigo.Name = "lblDptoCodigo";
            this.lblDptoCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblDptoCodigo.TabIndex = 0;
            this.lblDptoCodigo.Text = "Codigo";
            // 
            // lblDptoEdifCodigo
            // 
            this.lblDptoEdifCodigo.AutoSize = true;
            this.lblDptoEdifCodigo.Location = new System.Drawing.Point(12, 61);
            this.lblDptoEdifCodigo.Name = "lblDptoEdifCodigo";
            this.lblDptoEdifCodigo.Size = new System.Drawing.Size(90, 13);
            this.lblDptoEdifCodigo.TabIndex = 1;
            this.lblDptoEdifCodigo.Text = "Codigo de Edifcio";
            // 
            // lblDptoNumero
            // 
            this.lblDptoNumero.AutoSize = true;
            this.lblDptoNumero.Location = new System.Drawing.Point(9, 117);
            this.lblDptoNumero.Name = "lblDptoNumero";
            this.lblDptoNumero.Size = new System.Drawing.Size(44, 13);
            this.lblDptoNumero.TabIndex = 2;
            this.lblDptoNumero.Text = "Numero";
            // 
            // lblDptoTipo
            // 
            this.lblDptoTipo.AutoSize = true;
            this.lblDptoTipo.Location = new System.Drawing.Point(8, 87);
            this.lblDptoTipo.Name = "lblDptoTipo";
            this.lblDptoTipo.Size = new System.Drawing.Size(28, 13);
            this.lblDptoTipo.TabIndex = 3;
            this.lblDptoTipo.Text = "Tipo";
            // 
            // lblDptoPiso
            // 
            this.lblDptoPiso.AutoSize = true;
            this.lblDptoPiso.Location = new System.Drawing.Point(12, 147);
            this.lblDptoPiso.Name = "lblDptoPiso";
            this.lblDptoPiso.Size = new System.Drawing.Size(27, 13);
            this.lblDptoPiso.TabIndex = 4;
            this.lblDptoPiso.Text = "Piso";
            // 
            // lblDptoAmbientes
            // 
            this.lblDptoAmbientes.AutoSize = true;
            this.lblDptoAmbientes.Location = new System.Drawing.Point(8, 169);
            this.lblDptoAmbientes.Name = "lblDptoAmbientes";
            this.lblDptoAmbientes.Size = new System.Drawing.Size(56, 13);
            this.lblDptoAmbientes.TabIndex = 5;
            this.lblDptoAmbientes.Text = "Ambientes";
            // 
            // lblDptoDormitorios
            // 
            this.lblDptoDormitorios.AutoSize = true;
            this.lblDptoDormitorios.Location = new System.Drawing.Point(9, 195);
            this.lblDptoDormitorios.Name = "lblDptoDormitorios";
            this.lblDptoDormitorios.Size = new System.Drawing.Size(59, 13);
            this.lblDptoDormitorios.TabIndex = 6;
            this.lblDptoDormitorios.Text = "Dormitorios";
            // 
            // lblDptoBaños
            // 
            this.lblDptoBaños.AutoSize = true;
            this.lblDptoBaños.Location = new System.Drawing.Point(12, 221);
            this.lblDptoBaños.Name = "lblDptoBaños";
            this.lblDptoBaños.Size = new System.Drawing.Size(37, 13);
            this.lblDptoBaños.TabIndex = 7;
            this.lblDptoBaños.Text = "Baños";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Disposicion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 9;
            // 
            // lblDptoPrecio
            // 
            this.lblDptoPrecio.AutoSize = true;
            this.lblDptoPrecio.Location = new System.Drawing.Point(12, 274);
            this.lblDptoPrecio.Name = "lblDptoPrecio";
            this.lblDptoPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblDptoPrecio.TabIndex = 10;
            this.lblDptoPrecio.Text = "Precio";
            // 
            // txtDptoCodigo
            // 
            this.txtDptoCodigo.Location = new System.Drawing.Point(104, 32);
            this.txtDptoCodigo.Name = "txtDptoCodigo";
            this.txtDptoCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtDptoCodigo.TabIndex = 1;
            this.txtDptoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoCodigo_KeyPress);
            // 
            // txtDptoPiso
            // 
            this.txtDptoPiso.Location = new System.Drawing.Point(104, 140);
            this.txtDptoPiso.Name = "txtDptoPiso";
            this.txtDptoPiso.Size = new System.Drawing.Size(155, 20);
            this.txtDptoPiso.TabIndex = 4;
            this.txtDptoPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoPiso_KeyPress);
            // 
            // txtDptoNumero
            // 
            this.txtDptoNumero.Location = new System.Drawing.Point(104, 114);
            this.txtDptoNumero.Name = "txtDptoNumero";
            this.txtDptoNumero.Size = new System.Drawing.Size(155, 20);
            this.txtDptoNumero.TabIndex = 4;
            this.txtDptoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoNumero_KeyPress);
            // 
            // txtDptoEdifCodigo
            // 
            this.txtDptoEdifCodigo.Location = new System.Drawing.Point(104, 58);
            this.txtDptoEdifCodigo.Name = "txtDptoEdifCodigo";
            this.txtDptoEdifCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtDptoEdifCodigo.TabIndex = 2;
            this.txtDptoEdifCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoEdifCodigo_KeyPress);
            // 
            // txtDptoAmbiente
            // 
            this.txtDptoAmbiente.Location = new System.Drawing.Point(104, 166);
            this.txtDptoAmbiente.Name = "txtDptoAmbiente";
            this.txtDptoAmbiente.Size = new System.Drawing.Size(155, 20);
            this.txtDptoAmbiente.TabIndex = 5;
            this.txtDptoAmbiente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoAmbiente_KeyPress);
            // 
            // txtDptoBaños
            // 
            this.txtDptoBaños.Location = new System.Drawing.Point(104, 218);
            this.txtDptoBaños.Name = "txtDptoBaños";
            this.txtDptoBaños.Size = new System.Drawing.Size(155, 20);
            this.txtDptoBaños.TabIndex = 7;
            this.txtDptoBaños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoBaños_KeyPress);
            // 
            // txtDptoDormitorios
            // 
            this.txtDptoDormitorios.Location = new System.Drawing.Point(104, 192);
            this.txtDptoDormitorios.Name = "txtDptoDormitorios";
            this.txtDptoDormitorios.Size = new System.Drawing.Size(155, 20);
            this.txtDptoDormitorios.TabIndex = 6;
            this.txtDptoDormitorios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoDormitorios_KeyPress);
            // 
            // txtDptoPrecio
            // 
            this.txtDptoPrecio.Location = new System.Drawing.Point(104, 271);
            this.txtDptoPrecio.Name = "txtDptoPrecio";
            this.txtDptoPrecio.Size = new System.Drawing.Size(155, 20);
            this.txtDptoPrecio.TabIndex = 8;
            this.txtDptoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDptoPrecio_KeyPress);
            // 
            // cmbDptoDisposicion
            // 
            this.cmbDptoDisposicion.FormattingEnabled = true;
            this.cmbDptoDisposicion.Location = new System.Drawing.Point(104, 244);
            this.cmbDptoDisposicion.Name = "cmbDptoDisposicion";
            this.cmbDptoDisposicion.Size = new System.Drawing.Size(155, 21);
            this.cmbDptoDisposicion.TabIndex = 8;
            // 
            // cmbDptoTipo
            // 
            this.cmbDptoTipo.FormattingEnabled = true;
            this.cmbDptoTipo.Location = new System.Drawing.Point(104, 84);
            this.cmbDptoTipo.Name = "cmbDptoTipo";
            this.cmbDptoTipo.Size = new System.Drawing.Size(155, 21);
            this.cmbDptoTipo.TabIndex = 3;
            // 
            // btnDptoConfirmar
            // 
            this.btnDptoConfirmar.Location = new System.Drawing.Point(79, 297);
            this.btnDptoConfirmar.Name = "btnDptoConfirmar";
            this.btnDptoConfirmar.Size = new System.Drawing.Size(106, 23);
            this.btnDptoConfirmar.TabIndex = 9;
            this.btnDptoConfirmar.Text = "Confirmar Datos";
            this.btnDptoConfirmar.UseVisualStyleBackColor = true;
            this.btnDptoConfirmar.Click += new System.EventHandler(this.btnDptoConfirmar_Click);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(276, 45);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(573, 246);
            this.dgvDepartamentos.TabIndex = 11;
            // 
            // optAmbiente
            // 
            this.optAmbiente.AutoSize = true;
            this.optAmbiente.Location = new System.Drawing.Point(384, 22);
            this.optAmbiente.Name = "optAmbiente";
            this.optAmbiente.Size = new System.Drawing.Size(69, 17);
            this.optAmbiente.TabIndex = 12;
            this.optAmbiente.TabStop = true;
            this.optAmbiente.Text = "Ambiente";
            this.optAmbiente.UseVisualStyleBackColor = true;
            this.optAmbiente.CheckedChanged += new System.EventHandler(this.optAmbiente_CheckedChanged);
            // 
            // optDisposicion
            // 
            this.optDisposicion.AutoSize = true;
            this.optDisposicion.Location = new System.Drawing.Point(667, 22);
            this.optDisposicion.Name = "optDisposicion";
            this.optDisposicion.Size = new System.Drawing.Size(79, 17);
            this.optDisposicion.TabIndex = 13;
            this.optDisposicion.TabStop = true;
            this.optDisposicion.Text = "Disposicion";
            this.optDisposicion.UseVisualStyleBackColor = true;
            this.optDisposicion.CheckedChanged += new System.EventHandler(this.optDisposicion_CheckedChanged);
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 328);
            this.Controls.Add(this.optDisposicion);
            this.Controls.Add(this.optAmbiente);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.btnDptoConfirmar);
            this.Controls.Add(this.cmbDptoTipo);
            this.Controls.Add(this.cmbDptoDisposicion);
            this.Controls.Add(this.txtDptoPrecio);
            this.Controls.Add(this.txtDptoDormitorios);
            this.Controls.Add(this.txtDptoBaños);
            this.Controls.Add(this.txtDptoAmbiente);
            this.Controls.Add(this.txtDptoEdifCodigo);
            this.Controls.Add(this.txtDptoNumero);
            this.Controls.Add(this.txtDptoPiso);
            this.Controls.Add(this.txtDptoCodigo);
            this.Controls.Add(this.lblDptoPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDptoBaños);
            this.Controls.Add(this.lblDptoDormitorios);
            this.Controls.Add(this.lblDptoAmbientes);
            this.Controls.Add(this.lblDptoPiso);
            this.Controls.Add(this.lblDptoTipo);
            this.Controls.Add(this.lblDptoNumero);
            this.Controls.Add(this.lblDptoEdifCodigo);
            this.Controls.Add(this.lblDptoCodigo);
            this.MinimizeBox = false;
            this.Name = "FrmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Departamento";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDptoCodigo;
        private System.Windows.Forms.Label lblDptoEdifCodigo;
        private System.Windows.Forms.Label lblDptoNumero;
        private System.Windows.Forms.Label lblDptoTipo;
        private System.Windows.Forms.Label lblDptoPiso;
        private System.Windows.Forms.Label lblDptoAmbientes;
        private System.Windows.Forms.Label lblDptoDormitorios;
        private System.Windows.Forms.Label lblDptoBaños;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDptoPrecio;
        private System.Windows.Forms.TextBox txtDptoCodigo;
        private System.Windows.Forms.TextBox txtDptoPiso;
        private System.Windows.Forms.TextBox txtDptoNumero;
        private System.Windows.Forms.TextBox txtDptoEdifCodigo;
        private System.Windows.Forms.TextBox txtDptoAmbiente;
        private System.Windows.Forms.TextBox txtDptoBaños;
        private System.Windows.Forms.TextBox txtDptoDormitorios;
        private System.Windows.Forms.TextBox txtDptoPrecio;
        private System.Windows.Forms.ComboBox cmbDptoDisposicion;
        private System.Windows.Forms.ComboBox cmbDptoTipo;
        private System.Windows.Forms.Button btnDptoConfirmar;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.RadioButton optAmbiente;
        private System.Windows.Forms.RadioButton optDisposicion;
    }
}