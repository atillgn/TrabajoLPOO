namespace Vistas
{
    partial class FrmGestionTipoDpto
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTipoDptoEliminar = new System.Windows.Forms.Button();
            this.btnTipoDptoEditar = new System.Windows.Forms.Button();
            this.btnTipoDptoGuardar = new System.Windows.Forms.Button();
            this.txtTipoDptoDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipoDptoDescripcion = new System.Windows.Forms.Label();
            this.dgvTipoDpto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 22);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Alta de Tipo de Departamentos";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(305, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 22);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "<--- Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 16);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnTipoDptoEliminar);
            this.panel5.Controls.Add(this.btnTipoDptoEditar);
            this.panel5.Controls.Add(this.btnTipoDptoGuardar);
            this.panel5.Controls.Add(this.txtTipoDptoDescripcion);
            this.panel5.Controls.Add(this.lblTipoDptoDescripcion);
            this.panel5.Controls.Add(this.dgvTipoDpto);
            this.panel5.Location = new System.Drawing.Point(44, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 299);
            this.panel5.TabIndex = 4;
            // 
            // btnTipoDptoEliminar
            // 
            this.btnTipoDptoEliminar.Location = new System.Drawing.Point(193, 261);
            this.btnTipoDptoEliminar.Name = "btnTipoDptoEliminar";
            this.btnTipoDptoEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnTipoDptoEliminar.TabIndex = 5;
            this.btnTipoDptoEliminar.Text = "Eliminar";
            this.btnTipoDptoEliminar.UseVisualStyleBackColor = true;
            this.btnTipoDptoEliminar.Click += new System.EventHandler(this.btnTipoDptoEliminar_Click);
            // 
            // btnTipoDptoEditar
            // 
            this.btnTipoDptoEditar.Location = new System.Drawing.Point(23, 261);
            this.btnTipoDptoEditar.Name = "btnTipoDptoEditar";
            this.btnTipoDptoEditar.Size = new System.Drawing.Size(75, 23);
            this.btnTipoDptoEditar.TabIndex = 4;
            this.btnTipoDptoEditar.Text = "Editar";
            this.btnTipoDptoEditar.UseVisualStyleBackColor = true;
            this.btnTipoDptoEditar.Click += new System.EventHandler(this.btnTipoDptoEditar_Click);
            // 
            // btnTipoDptoGuardar
            // 
            this.btnTipoDptoGuardar.Location = new System.Drawing.Point(81, 43);
            this.btnTipoDptoGuardar.Name = "btnTipoDptoGuardar";
            this.btnTipoDptoGuardar.Size = new System.Drawing.Size(142, 23);
            this.btnTipoDptoGuardar.TabIndex = 3;
            this.btnTipoDptoGuardar.Text = "Guardar";
            this.btnTipoDptoGuardar.UseVisualStyleBackColor = true;
            this.btnTipoDptoGuardar.Click += new System.EventHandler(this.btnTipoDptoGuardar_Click);
            // 
            // txtTipoDptoDescripcion
            // 
            this.txtTipoDptoDescripcion.Location = new System.Drawing.Point(142, 18);
            this.txtTipoDptoDescripcion.Name = "txtTipoDptoDescripcion";
            this.txtTipoDptoDescripcion.Size = new System.Drawing.Size(126, 20);
            this.txtTipoDptoDescripcion.TabIndex = 2;
            // 
            // lblTipoDptoDescripcion
            // 
            this.lblTipoDptoDescripcion.AutoSize = true;
            this.lblTipoDptoDescripcion.Location = new System.Drawing.Point(20, 21);
            this.lblTipoDptoDescripcion.Name = "lblTipoDptoDescripcion";
            this.lblTipoDptoDescripcion.Size = new System.Drawing.Size(116, 13);
            this.lblTipoDptoDescripcion.TabIndex = 1;
            this.lblTipoDptoDescripcion.Text = "Tipo de Departamento:";
            // 
            // dgvTipoDpto
            // 
            this.dgvTipoDpto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
            this.dgvTipoDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDpto.Location = new System.Drawing.Point(23, 72);
            this.dgvTipoDpto.Name = "dgvTipoDpto";
            this.dgvTipoDpto.Size = new System.Drawing.Size(245, 183);
            this.dgvTipoDpto.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 332);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(366, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 332);
            this.panel2.TabIndex = 6;
            // 
            // FrmGestionTipoDpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(186)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGestionTipoDpto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionTipoDpto";
            this.Load += new System.EventHandler(this.FrmGestionTipoDpto_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDpto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvTipoDpto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTipoDptoEliminar;
        private System.Windows.Forms.Button btnTipoDptoEditar;
        private System.Windows.Forms.Button btnTipoDptoGuardar;
        private System.Windows.Forms.TextBox txtTipoDptoDescripcion;
        private System.Windows.Forms.Label lblTipoDptoDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}