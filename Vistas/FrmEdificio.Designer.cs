namespace Vistas
{
    partial class FrmEdificio
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
            this.lblEdifNombre = new System.Windows.Forms.Label();
            this.lblEdifDireccion = new System.Windows.Forms.Label();
            this.lblEdifAdministrador = new System.Windows.Forms.Label();
            this.lblEdifTelefono = new System.Windows.Forms.Label();
            this.txtEdifDireccion = new System.Windows.Forms.TextBox();
            this.txtEdifNombre = new System.Windows.Forms.TextBox();
            this.txtEdifTelefono = new System.Windows.Forms.TextBox();
            this.btnEdifConfirmar = new System.Windows.Forms.Button();
            this.dgvEdificio = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbEdifAdmin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdifNombre
            // 
            this.lblEdifNombre.AutoSize = true;
            this.lblEdifNombre.Location = new System.Drawing.Point(12, 28);
            this.lblEdifNombre.Name = "lblEdifNombre";
            this.lblEdifNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEdifNombre.TabIndex = 4;
            this.lblEdifNombre.Text = "Nombre";
            // 
            // lblEdifDireccion
            // 
            this.lblEdifDireccion.AutoSize = true;
            this.lblEdifDireccion.Location = new System.Drawing.Point(12, 79);
            this.lblEdifDireccion.Name = "lblEdifDireccion";
            this.lblEdifDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblEdifDireccion.TabIndex = 5;
            this.lblEdifDireccion.Text = "Direccion";
            // 
            // lblEdifAdministrador
            // 
            this.lblEdifAdministrador.AutoSize = true;
            this.lblEdifAdministrador.Location = new System.Drawing.Point(12, 135);
            this.lblEdifAdministrador.Name = "lblEdifAdministrador";
            this.lblEdifAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblEdifAdministrador.TabIndex = 6;
            this.lblEdifAdministrador.Text = "Administrador";
            // 
            // lblEdifTelefono
            // 
            this.lblEdifTelefono.AutoSize = true;
            this.lblEdifTelefono.Location = new System.Drawing.Point(12, 186);
            this.lblEdifTelefono.Name = "lblEdifTelefono";
            this.lblEdifTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblEdifTelefono.TabIndex = 7;
            this.lblEdifTelefono.Text = "Telefono";
            // 
            // txtEdifDireccion
            // 
            this.txtEdifDireccion.Location = new System.Drawing.Point(89, 76);
            this.txtEdifDireccion.Name = "txtEdifDireccion";
            this.txtEdifDireccion.Size = new System.Drawing.Size(150, 20);
            this.txtEdifDireccion.TabIndex = 2;
            // 
            // txtEdifNombre
            // 
            this.txtEdifNombre.Location = new System.Drawing.Point(89, 25);
            this.txtEdifNombre.Name = "txtEdifNombre";
            this.txtEdifNombre.Size = new System.Drawing.Size(150, 20);
            this.txtEdifNombre.TabIndex = 1;
            // 
            // txtEdifTelefono
            // 
            this.txtEdifTelefono.Location = new System.Drawing.Point(89, 183);
            this.txtEdifTelefono.Name = "txtEdifTelefono";
            this.txtEdifTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtEdifTelefono.TabIndex = 4;
            // 
            // btnEdifConfirmar
            // 
            this.btnEdifConfirmar.Location = new System.Drawing.Point(73, 229);
            this.btnEdifConfirmar.Name = "btnEdifConfirmar";
            this.btnEdifConfirmar.Size = new System.Drawing.Size(103, 23);
            this.btnEdifConfirmar.TabIndex = 5;
            this.btnEdifConfirmar.Text = "Confirmar Datos";
            this.btnEdifConfirmar.UseVisualStyleBackColor = true;
            this.btnEdifConfirmar.Click += new System.EventHandler(this.btnEdifConfirmar_Click);
            // 
            // dgvEdificio
            // 
            this.dgvEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdificio.Location = new System.Drawing.Point(258, 13);
            this.dgvEdificio.Name = "dgvEdificio";
            this.dgvEdificio.Size = new System.Drawing.Size(514, 203);
            this.dgvEdificio.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(346, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(617, 229);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbEdifAdmin
            // 
            this.cmbEdifAdmin.FormattingEnabled = true;
            this.cmbEdifAdmin.Location = new System.Drawing.Point(88, 132);
            this.cmbEdifAdmin.Name = "cmbEdifAdmin";
            this.cmbEdifAdmin.Size = new System.Drawing.Size(151, 21);
            this.cmbEdifAdmin.TabIndex = 3;
            // 
            // FrmEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 265);
            this.Controls.Add(this.cmbEdifAdmin);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvEdificio);
            this.Controls.Add(this.btnEdifConfirmar);
            this.Controls.Add(this.txtEdifTelefono);
            this.Controls.Add(this.txtEdifNombre);
            this.Controls.Add(this.txtEdifDireccion);
            this.Controls.Add(this.lblEdifTelefono);
            this.Controls.Add(this.lblEdifAdministrador);
            this.Controls.Add(this.lblEdifDireccion);
            this.Controls.Add(this.lblEdifNombre);
            this.MaximizeBox = false;
            this.Name = "FrmEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Edificio";
            this.Load += new System.EventHandler(this.FrmEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdifNombre;
        private System.Windows.Forms.Label lblEdifDireccion;
        private System.Windows.Forms.Label lblEdifAdministrador;
        private System.Windows.Forms.Label lblEdifTelefono;
        private System.Windows.Forms.TextBox txtEdifDireccion;
        private System.Windows.Forms.TextBox txtEdifNombre;
        private System.Windows.Forms.TextBox txtEdifTelefono;
        private System.Windows.Forms.Button btnEdifConfirmar;
        private System.Windows.Forms.DataGridView dgvEdificio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbEdifAdmin;
    }
}