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
            this.lblEdifCodigo = new System.Windows.Forms.Label();
            this.lblEdifNombre = new System.Windows.Forms.Label();
            this.lblEdifDireccion = new System.Windows.Forms.Label();
            this.lblEdifAdministrador = new System.Windows.Forms.Label();
            this.lblEdifTelefono = new System.Windows.Forms.Label();
            this.txtEdifCodigo = new System.Windows.Forms.TextBox();
            this.txtEdifDireccion = new System.Windows.Forms.TextBox();
            this.txtEdifAdminitrador = new System.Windows.Forms.TextBox();
            this.txtEdifNombre = new System.Windows.Forms.TextBox();
            this.txtEdifTelefono = new System.Windows.Forms.TextBox();
            this.btnEdifConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdifCodigo
            // 
            this.lblEdifCodigo.AutoSize = true;
            this.lblEdifCodigo.Location = new System.Drawing.Point(13, 39);
            this.lblEdifCodigo.Name = "lblEdifCodigo";
            this.lblEdifCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblEdifCodigo.TabIndex = 0;
            this.lblEdifCodigo.Text = "Codigo";
            // 
            // lblEdifNombre
            // 
            this.lblEdifNombre.AutoSize = true;
            this.lblEdifNombre.Location = new System.Drawing.Point(13, 76);
            this.lblEdifNombre.Name = "lblEdifNombre";
            this.lblEdifNombre.Size = new System.Drawing.Size(44, 13);
            this.lblEdifNombre.TabIndex = 4;
            this.lblEdifNombre.Text = "Nombre";
            // 
            // lblEdifDireccion
            // 
            this.lblEdifDireccion.AutoSize = true;
            this.lblEdifDireccion.Location = new System.Drawing.Point(13, 112);
            this.lblEdifDireccion.Name = "lblEdifDireccion";
            this.lblEdifDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblEdifDireccion.TabIndex = 5;
            this.lblEdifDireccion.Text = "Direccion";
            // 
            // lblEdifAdministrador
            // 
            this.lblEdifAdministrador.AutoSize = true;
            this.lblEdifAdministrador.Location = new System.Drawing.Point(13, 155);
            this.lblEdifAdministrador.Name = "lblEdifAdministrador";
            this.lblEdifAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lblEdifAdministrador.TabIndex = 6;
            this.lblEdifAdministrador.Text = "Administrador";
            // 
            // lblEdifTelefono
            // 
            this.lblEdifTelefono.AutoSize = true;
            this.lblEdifTelefono.Location = new System.Drawing.Point(16, 193);
            this.lblEdifTelefono.Name = "lblEdifTelefono";
            this.lblEdifTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblEdifTelefono.TabIndex = 7;
            this.lblEdifTelefono.Text = "Telefono";
            // 
            // txtEdifCodigo
            // 
            this.txtEdifCodigo.Location = new System.Drawing.Point(89, 39);
            this.txtEdifCodigo.Name = "txtEdifCodigo";
            this.txtEdifCodigo.Size = new System.Drawing.Size(172, 20);
            this.txtEdifCodigo.TabIndex = 1;
            this.txtEdifCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdifCodigo_KeyPress);
            // 
            // txtEdifDireccion
            // 
            this.txtEdifDireccion.Location = new System.Drawing.Point(89, 109);
            this.txtEdifDireccion.Name = "txtEdifDireccion";
            this.txtEdifDireccion.Size = new System.Drawing.Size(172, 20);
            this.txtEdifDireccion.TabIndex = 3;
            // 
            // txtEdifAdminitrador
            // 
            this.txtEdifAdminitrador.Location = new System.Drawing.Point(89, 152);
            this.txtEdifAdminitrador.Name = "txtEdifAdminitrador";
            this.txtEdifAdminitrador.Size = new System.Drawing.Size(172, 20);
            this.txtEdifAdminitrador.TabIndex = 4;
            // 
            // txtEdifNombre
            // 
            this.txtEdifNombre.Location = new System.Drawing.Point(89, 73);
            this.txtEdifNombre.Name = "txtEdifNombre";
            this.txtEdifNombre.Size = new System.Drawing.Size(172, 20);
            this.txtEdifNombre.TabIndex = 2;
            // 
            // txtEdifTelefono
            // 
            this.txtEdifTelefono.Location = new System.Drawing.Point(89, 190);
            this.txtEdifTelefono.Name = "txtEdifTelefono";
            this.txtEdifTelefono.Size = new System.Drawing.Size(172, 20);
            this.txtEdifTelefono.TabIndex = 5;
            // 
            // btnEdifConfirmar
            // 
            this.btnEdifConfirmar.Location = new System.Drawing.Point(78, 236);
            this.btnEdifConfirmar.Name = "btnEdifConfirmar";
            this.btnEdifConfirmar.Size = new System.Drawing.Size(103, 23);
            this.btnEdifConfirmar.TabIndex = 6;
            this.btnEdifConfirmar.Text = "Confirmar Datos";
            this.btnEdifConfirmar.UseVisualStyleBackColor = true;
            this.btnEdifConfirmar.Click += new System.EventHandler(this.btnEdifConfirmar_Click);
            // 
            // FrmEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.btnEdifConfirmar);
            this.Controls.Add(this.txtEdifTelefono);
            this.Controls.Add(this.txtEdifNombre);
            this.Controls.Add(this.txtEdifAdminitrador);
            this.Controls.Add(this.txtEdifDireccion);
            this.Controls.Add(this.txtEdifCodigo);
            this.Controls.Add(this.lblEdifTelefono);
            this.Controls.Add(this.lblEdifAdministrador);
            this.Controls.Add(this.lblEdifDireccion);
            this.Controls.Add(this.lblEdifNombre);
            this.Controls.Add(this.lblEdifCodigo);
            this.MaximizeBox = false;
            this.Name = "FrmEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Edificio";
            this.Load += new System.EventHandler(this.FrmEdificio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdifCodigo;
        private System.Windows.Forms.Label lblEdifNombre;
        private System.Windows.Forms.Label lblEdifDireccion;
        private System.Windows.Forms.Label lblEdifAdministrador;
        private System.Windows.Forms.Label lblEdifTelefono;
        private System.Windows.Forms.TextBox txtEdifCodigo;
        private System.Windows.Forms.TextBox txtEdifDireccion;
        private System.Windows.Forms.TextBox txtEdifAdminitrador;
        private System.Windows.Forms.TextBox txtEdifNombre;
        private System.Windows.Forms.TextBox txtEdifTelefono;
        private System.Windows.Forms.Button btnEdifConfirmar;
    }
}