namespace Vistas
{
    partial class FrmInquilino
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
            this.txtInqNombre = new System.Windows.Forms.TextBox();
            this.txtInqApellido = new System.Windows.Forms.TextBox();
            this.txtInqTelefono = new System.Windows.Forms.TextBox();
            this.lblInqTelefono = new System.Windows.Forms.Label();
            this.lblInqApellido = new System.Windows.Forms.Label();
            this.lblInqNombre = new System.Windows.Forms.Label();
            this.btnInqConfirmar = new System.Windows.Forms.Button();
            this.btnInqEliminar = new System.Windows.Forms.Button();
            this.btnInqEditar = new System.Windows.Forms.Button();
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnInqOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInqNombre
            // 
            this.txtInqNombre.Location = new System.Drawing.Point(527, 46);
            this.txtInqNombre.Name = "txtInqNombre";
            this.txtInqNombre.Size = new System.Drawing.Size(115, 20);
            this.txtInqNombre.TabIndex = 2;
            // 
            // txtInqApellido
            // 
            this.txtInqApellido.Location = new System.Drawing.Point(527, 100);
            this.txtInqApellido.Name = "txtInqApellido";
            this.txtInqApellido.Size = new System.Drawing.Size(115, 20);
            this.txtInqApellido.TabIndex = 3;
            // 
            // txtInqTelefono
            // 
            this.txtInqTelefono.Location = new System.Drawing.Point(527, 155);
            this.txtInqTelefono.Name = "txtInqTelefono";
            this.txtInqTelefono.Size = new System.Drawing.Size(115, 20);
            this.txtInqTelefono.TabIndex = 4;
            // 
            // lblInqTelefono
            // 
            this.lblInqTelefono.AutoSize = true;
            this.lblInqTelefono.Location = new System.Drawing.Point(473, 158);
            this.lblInqTelefono.Name = "lblInqTelefono";
            this.lblInqTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblInqTelefono.TabIndex = 5;
            this.lblInqTelefono.Text = "Telefono: ";
            // 
            // lblInqApellido
            // 
            this.lblInqApellido.AutoSize = true;
            this.lblInqApellido.Location = new System.Drawing.Point(473, 103);
            this.lblInqApellido.Name = "lblInqApellido";
            this.lblInqApellido.Size = new System.Drawing.Size(50, 13);
            this.lblInqApellido.TabIndex = 6;
            this.lblInqApellido.Text = "Apellido: ";
            // 
            // lblInqNombre
            // 
            this.lblInqNombre.AutoSize = true;
            this.lblInqNombre.Location = new System.Drawing.Point(473, 49);
            this.lblInqNombre.Name = "lblInqNombre";
            this.lblInqNombre.Size = new System.Drawing.Size(50, 13);
            this.lblInqNombre.TabIndex = 7;
            this.lblInqNombre.Text = "Nombre: ";
            // 
            // btnInqConfirmar
            // 
            this.btnInqConfirmar.Location = new System.Drawing.Point(513, 200);
            this.btnInqConfirmar.Name = "btnInqConfirmar";
            this.btnInqConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnInqConfirmar.TabIndex = 5;
            this.btnInqConfirmar.Text = "Confirmar ";
            this.btnInqConfirmar.UseVisualStyleBackColor = true;
            this.btnInqConfirmar.Click += new System.EventHandler(this.btnInqConfirmar_Click);
            // 
            // btnInqEliminar
            // 
            this.btnInqEliminar.Location = new System.Drawing.Point(140, 229);
            this.btnInqEliminar.Name = "btnInqEliminar";
            this.btnInqEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnInqEliminar.TabIndex = 8;
            this.btnInqEliminar.Text = "Eliminar";
            this.btnInqEliminar.UseVisualStyleBackColor = true;
            this.btnInqEliminar.Click += new System.EventHandler(this.btnInqEliminar_Click);
            // 
            // btnInqEditar
            // 
            this.btnInqEditar.Location = new System.Drawing.Point(12, 229);
            this.btnInqEditar.Name = "btnInqEditar";
            this.btnInqEditar.Size = new System.Drawing.Size(75, 23);
            this.btnInqEditar.TabIndex = 9;
            this.btnInqEditar.Text = "Editar";
            this.btnInqEditar.UseVisualStyleBackColor = true;
            this.btnInqEditar.Click += new System.EventHandler(this.btnInqEditar_Click);
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Location = new System.Drawing.Point(12, 39);
            this.dgvInquilinos.Name = "dgvInquilinos";
            this.dgvInquilinos.Size = new System.Drawing.Size(442, 184);
            this.dgvInquilinos.TabIndex = 10;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(12, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(356, 20);
            this.txtBusqueda.TabIndex = 11;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(379, 10);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 12;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnInqOrdenar
            // 
            this.btnInqOrdenar.Location = new System.Drawing.Point(379, 229);
            this.btnInqOrdenar.Name = "btnInqOrdenar";
            this.btnInqOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnInqOrdenar.TabIndex = 13;
            this.btnInqOrdenar.Text = "Ordenar";
            this.btnInqOrdenar.UseVisualStyleBackColor = true;
            this.btnInqOrdenar.Click += new System.EventHandler(this.btnInqOrdenar_Click);
            // 
            // FrmInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 259);
            this.Controls.Add(this.btnInqOrdenar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvInquilinos);
            this.Controls.Add(this.btnInqEditar);
            this.Controls.Add(this.btnInqEliminar);
            this.Controls.Add(this.btnInqConfirmar);
            this.Controls.Add(this.lblInqNombre);
            this.Controls.Add(this.lblInqApellido);
            this.Controls.Add(this.lblInqTelefono);
            this.Controls.Add(this.txtInqTelefono);
            this.Controls.Add(this.txtInqApellido);
            this.Controls.Add(this.txtInqNombre);
            this.MaximizeBox = false;
            this.Name = "FrmInquilino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Inquilino";
            this.Load += new System.EventHandler(this.FrmInquilino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInqNombre;
        private System.Windows.Forms.TextBox txtInqApellido;
        private System.Windows.Forms.TextBox txtInqTelefono;
        private System.Windows.Forms.Label lblInqTelefono;
        private System.Windows.Forms.Label lblInqApellido;
        private System.Windows.Forms.Label lblInqNombre;
        private System.Windows.Forms.Button btnInqConfirmar;
        private System.Windows.Forms.Button btnInqEliminar;
        private System.Windows.Forms.Button btnInqEditar;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnInqOrdenar;
    }
}