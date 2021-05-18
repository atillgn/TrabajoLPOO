namespace Vistas
{
    partial class FrmUsuario
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
            this.cmbRol_Id = new System.Windows.Forms.ComboBox();
            this.lblRol_Id = new System.Windows.Forms.Label();
            this.lblUsuario_ApellidoNombre = new System.Windows.Forms.Label();
            this.txtUsuario_ApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario_NombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario_NombreUsuario = new System.Windows.Forms.Label();
            this.txtUsuario_Contrasenia = new System.Windows.Forms.TextBox();
            this.lblUsuario_Contrasenia = new System.Windows.Forms.Label();
            this.btnUsuarioConfirmar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnUsuarioEditar = new System.Windows.Forms.Button();
            this.btnUsuarioEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol_Id
            // 
            this.cmbRol_Id.FormattingEnabled = true;
            this.cmbRol_Id.Location = new System.Drawing.Point(702, 39);
            this.cmbRol_Id.Name = "cmbRol_Id";
            this.cmbRol_Id.Size = new System.Drawing.Size(134, 21);
            this.cmbRol_Id.TabIndex = 1;
            // 
            // lblRol_Id
            // 
            this.lblRol_Id.AutoSize = true;
            this.lblRol_Id.Location = new System.Drawing.Point(590, 42);
            this.lblRol_Id.Name = "lblRol_Id";
            this.lblRol_Id.Size = new System.Drawing.Size(23, 13);
            this.lblRol_Id.TabIndex = 1;
            this.lblRol_Id.Text = "Rol";
            // 
            // lblUsuario_ApellidoNombre
            // 
            this.lblUsuario_ApellidoNombre.AutoSize = true;
            this.lblUsuario_ApellidoNombre.Location = new System.Drawing.Point(590, 204);
            this.lblUsuario_ApellidoNombre.Name = "lblUsuario_ApellidoNombre";
            this.lblUsuario_ApellidoNombre.Size = new System.Drawing.Size(92, 13);
            this.lblUsuario_ApellidoNombre.TabIndex = 2;
            this.lblUsuario_ApellidoNombre.Text = "Apellido y Nombre";
            // 
            // txtUsuario_ApellidoNombre
            // 
            this.txtUsuario_ApellidoNombre.Location = new System.Drawing.Point(702, 201);
            this.txtUsuario_ApellidoNombre.Name = "txtUsuario_ApellidoNombre";
            this.txtUsuario_ApellidoNombre.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario_ApellidoNombre.TabIndex = 4;
            // 
            // txtUsuario_NombreUsuario
            // 
            this.txtUsuario_NombreUsuario.Location = new System.Drawing.Point(702, 92);
            this.txtUsuario_NombreUsuario.Name = "txtUsuario_NombreUsuario";
            this.txtUsuario_NombreUsuario.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario_NombreUsuario.TabIndex = 2;
            // 
            // lblUsuario_NombreUsuario
            // 
            this.lblUsuario_NombreUsuario.AutoSize = true;
            this.lblUsuario_NombreUsuario.Location = new System.Drawing.Point(590, 95);
            this.lblUsuario_NombreUsuario.Name = "lblUsuario_NombreUsuario";
            this.lblUsuario_NombreUsuario.Size = new System.Drawing.Size(96, 13);
            this.lblUsuario_NombreUsuario.TabIndex = 8;
            this.lblUsuario_NombreUsuario.Text = "Nombre de usuario";
            // 
            // txtUsuario_Contrasenia
            // 
            this.txtUsuario_Contrasenia.Location = new System.Drawing.Point(702, 146);
            this.txtUsuario_Contrasenia.Name = "txtUsuario_Contrasenia";
            this.txtUsuario_Contrasenia.Size = new System.Drawing.Size(134, 20);
            this.txtUsuario_Contrasenia.TabIndex = 3;
            // 
            // lblUsuario_Contrasenia
            // 
            this.lblUsuario_Contrasenia.AutoSize = true;
            this.lblUsuario_Contrasenia.Location = new System.Drawing.Point(590, 149);
            this.lblUsuario_Contrasenia.Name = "lblUsuario_Contrasenia";
            this.lblUsuario_Contrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblUsuario_Contrasenia.TabIndex = 10;
            this.lblUsuario_Contrasenia.Text = "Contraseña";
            // 
            // btnUsuarioConfirmar
            // 
            this.btnUsuarioConfirmar.Location = new System.Drawing.Point(669, 245);
            this.btnUsuarioConfirmar.Name = "btnUsuarioConfirmar";
            this.btnUsuarioConfirmar.Size = new System.Drawing.Size(96, 23);
            this.btnUsuarioConfirmar.TabIndex = 5;
            this.btnUsuarioConfirmar.Text = "Guardar usuario";
            this.btnUsuarioConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioConfirmar.UseVisualStyleBackColor = true;
            this.btnUsuarioConfirmar.Click += new System.EventHandler(this.btnUsuarioConfirmar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 39);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(556, 218);
            this.dgvUsuarios.TabIndex = 10;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(457, 20);
            this.txtBusqueda.TabIndex = 8;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(475, 10);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(93, 23);
            this.btnBusqueda.TabIndex = 9;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnUsuarioEditar
            // 
            this.btnUsuarioEditar.Location = new System.Drawing.Point(12, 263);
            this.btnUsuarioEditar.Name = "btnUsuarioEditar";
            this.btnUsuarioEditar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioEditar.TabIndex = 6;
            this.btnUsuarioEditar.Text = "Editar";
            this.btnUsuarioEditar.UseVisualStyleBackColor = true;
            this.btnUsuarioEditar.Click += new System.EventHandler(this.btnUsuarioEditar_Click);
            // 
            // btnUsuarioEliminar
            // 
            this.btnUsuarioEliminar.Location = new System.Drawing.Point(140, 263);
            this.btnUsuarioEliminar.Name = "btnUsuarioEliminar";
            this.btnUsuarioEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioEliminar.TabIndex = 7;
            this.btnUsuarioEliminar.Text = "Eliminar";
            this.btnUsuarioEliminar.UseVisualStyleBackColor = true;
            this.btnUsuarioEliminar.Click += new System.EventHandler(this.btnUsuarioEliminar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 298);
            this.Controls.Add(this.btnUsuarioEliminar);
            this.Controls.Add(this.btnUsuarioEditar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnUsuarioConfirmar);
            this.Controls.Add(this.txtUsuario_Contrasenia);
            this.Controls.Add(this.lblUsuario_Contrasenia);
            this.Controls.Add(this.txtUsuario_NombreUsuario);
            this.Controls.Add(this.lblUsuario_NombreUsuario);
            this.Controls.Add(this.txtUsuario_ApellidoNombre);
            this.Controls.Add(this.lblUsuario_ApellidoNombre);
            this.Controls.Add(this.lblRol_Id);
            this.Controls.Add(this.cmbRol_Id);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol_Id;
        private System.Windows.Forms.Label lblRol_Id;
        private System.Windows.Forms.Label lblUsuario_ApellidoNombre;
        private System.Windows.Forms.TextBox txtUsuario_ApellidoNombre;
        private System.Windows.Forms.TextBox txtUsuario_NombreUsuario;
        private System.Windows.Forms.Label lblUsuario_NombreUsuario;
        private System.Windows.Forms.TextBox txtUsuario_Contrasenia;
        private System.Windows.Forms.Label lblUsuario_Contrasenia;
        private System.Windows.Forms.Button btnUsuarioConfirmar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnUsuarioEditar;
        private System.Windows.Forms.Button btnUsuarioEliminar;
    }
}