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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTipoDpto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDpto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 22);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(26, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Alta de Tipo de Departamentos";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(150)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(252, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 22);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 16);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel5.Controls.Add(this.btnTipoDptoEliminar);
            this.panel5.Controls.Add(this.btnTipoDptoEditar);
            this.panel5.Controls.Add(this.btnTipoDptoGuardar);
            this.panel5.Controls.Add(this.txtTipoDptoDescripcion);
            this.panel5.Controls.Add(this.lblTipoDptoDescripcion);
            this.panel5.Controls.Add(this.dgvTipoDpto);
            this.panel5.Location = new System.Drawing.Point(-7, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 310);
            this.panel5.TabIndex = 4;
            // 
            // btnTipoDptoEliminar
            // 
            this.btnTipoDptoEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTipoDptoEliminar.FlatAppearance.BorderSize = 2;
            this.btnTipoDptoEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTipoDptoEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTipoDptoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoDptoEliminar.ForeColor = System.Drawing.Color.White;
            this.btnTipoDptoEliminar.Location = new System.Drawing.Point(217, 266);
            this.btnTipoDptoEliminar.Name = "btnTipoDptoEliminar";
            this.btnTipoDptoEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnTipoDptoEliminar.TabIndex = 5;
            this.btnTipoDptoEliminar.Text = "Eliminar";
            this.btnTipoDptoEliminar.UseVisualStyleBackColor = true;
            this.btnTipoDptoEliminar.Click += new System.EventHandler(this.btnTipoDptoEliminar_Click);
            // 
            // btnTipoDptoEditar
            // 
            this.btnTipoDptoEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.btnTipoDptoEditar.FlatAppearance.BorderSize = 2;
            this.btnTipoDptoEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.btnTipoDptoEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.btnTipoDptoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoDptoEditar.ForeColor = System.Drawing.Color.White;
            this.btnTipoDptoEditar.Location = new System.Drawing.Point(51, 266);
            this.btnTipoDptoEditar.Name = "btnTipoDptoEditar";
            this.btnTipoDptoEditar.Size = new System.Drawing.Size(75, 27);
            this.btnTipoDptoEditar.TabIndex = 4;
            this.btnTipoDptoEditar.Text = "Editar";
            this.btnTipoDptoEditar.UseVisualStyleBackColor = true;
            this.btnTipoDptoEditar.Click += new System.EventHandler(this.btnTipoDptoEditar_Click);
            // 
            // btnTipoDptoGuardar
            // 
            this.btnTipoDptoGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnTipoDptoGuardar.FlatAppearance.BorderSize = 2;
            this.btnTipoDptoGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnTipoDptoGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnTipoDptoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoDptoGuardar.ForeColor = System.Drawing.Color.White;
            this.btnTipoDptoGuardar.Location = new System.Drawing.Point(98, 56);
            this.btnTipoDptoGuardar.Name = "btnTipoDptoGuardar";
            this.btnTipoDptoGuardar.Size = new System.Drawing.Size(142, 29);
            this.btnTipoDptoGuardar.TabIndex = 3;
            this.btnTipoDptoGuardar.Text = "Guardar";
            this.btnTipoDptoGuardar.UseVisualStyleBackColor = true;
            this.btnTipoDptoGuardar.Click += new System.EventHandler(this.btnTipoDptoGuardar_Click);
            // 
            // txtTipoDptoDescripcion
            // 
            this.txtTipoDptoDescripcion.Location = new System.Drawing.Point(201, 18);
            this.txtTipoDptoDescripcion.Name = "txtTipoDptoDescripcion";
            this.txtTipoDptoDescripcion.Size = new System.Drawing.Size(113, 20);
            this.txtTipoDptoDescripcion.TabIndex = 2;
            // 
            // lblTipoDptoDescripcion
            // 
            this.lblTipoDptoDescripcion.AutoSize = true;
            this.lblTipoDptoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDptoDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblTipoDptoDescripcion.Location = new System.Drawing.Point(27, 21);
            this.lblTipoDptoDescripcion.Name = "lblTipoDptoDescripcion";
            this.lblTipoDptoDescripcion.Size = new System.Drawing.Size(154, 17);
            this.lblTipoDptoDescripcion.TabIndex = 1;
            this.lblTipoDptoDescripcion.Text = "Tipo de Departamento:";
            // 
            // dgvTipoDpto
            // 
            this.dgvTipoDpto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.dgvTipoDpto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoDpto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTipoDpto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoDpto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoDpto.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoDpto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoDpto.EnableHeadersVisualStyles = false;
            this.dgvTipoDpto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvTipoDpto.Location = new System.Drawing.Point(51, 91);
            this.dgvTipoDpto.Name = "dgvTipoDpto";
            this.dgvTipoDpto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipoDpto.RowHeadersVisible = false;
            this.dgvTipoDpto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvTipoDpto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoDpto.Size = new System.Drawing.Size(241, 153);
            this.dgvTipoDpto.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 312);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(313, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 312);
            this.panel2.TabIndex = 6;
            // 
            // FrmGestionTipoDpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(327, 350);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}