﻿namespace Vistas
{
    partial class FrmMenuOperador
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInquilino = new System.Windows.Forms.RadioButton();
            this.btnAlquiler = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInqOrdenar = new System.Windows.Forms.Button();
            this.txtInqTelefono = new System.Windows.Forms.TextBox();
            this.txtInqApellido = new System.Windows.Forms.TextBox();
            this.txtInqNombre = new System.Windows.Forms.TextBox();
            this.lblInqTelefono = new System.Windows.Forms.Label();
            this.lblInqApellido = new System.Windows.Forms.Label();
            this.lblInqNombre = new System.Windows.Forms.Label();
            this.btnInqConfirmar = new System.Windows.Forms.Button();
            this.btnInqEliminar = new System.Windows.Forms.Button();
            this.btnInqEditar = new System.Windows.Forms.Button();
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAlqPreciofinal = new System.Windows.Forms.TextBox();
            this.btnAlqRegistro = new System.Windows.Forms.Button();
            this.btnAlqRegistrar = new System.Windows.Forms.Button();
            this.dtpAlqHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpAlqDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbAlqInquilino = new System.Windows.Forms.ComboBox();
            this.cmbAlqDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbAlqEdificio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAlqInquilino = new System.Windows.Forms.Label();
            this.lblAlqDepartamento = new System.Windows.Forms.Label();
            this.lblAlqEdificio = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1021, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1021, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(172)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAlquiler);
            this.panel1.Controls.Add(this.btnInquilino);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 23);
            this.panel1.TabIndex = 1;
            // 
            // btnInquilino
            // 
            this.btnInquilino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInquilino.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInquilino.AutoSize = true;
            this.btnInquilino.FlatAppearance.BorderSize = 0;
            this.btnInquilino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInquilino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInquilino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquilino.Location = new System.Drawing.Point(56, 0);
            this.btnInquilino.Name = "btnInquilino";
            this.btnInquilino.Size = new System.Drawing.Size(61, 23);
            this.btnInquilino.TabIndex = 1;
            this.btnInquilino.TabStop = true;
            this.btnInquilino.Text = "Inquilinos";
            this.btnInquilino.UseVisualStyleBackColor = true;
            this.btnInquilino.CheckedChanged += new System.EventHandler(this.btnInquilino_CheckedChanged);
            // 
            // btnAlquiler
            // 
            this.btnAlquiler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlquiler.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAlquiler.AutoSize = true;
            this.btnAlquiler.FlatAppearance.BorderSize = 0;
            this.btnAlquiler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlquiler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlquiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlquiler.Location = new System.Drawing.Point(230, 0);
            this.btnAlquiler.Name = "btnAlquiler";
            this.btnAlquiler.Size = new System.Drawing.Size(62, 23);
            this.btnAlquiler.TabIndex = 2;
            this.btnAlquiler.TabStop = true;
            this.btnAlquiler.Text = "Alquileres";
            this.btnAlquiler.UseVisualStyleBackColor = true;
            this.btnAlquiler.CheckedChanged += new System.EventHandler(this.btnAlquiler_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(954, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInqOrdenar);
            this.panel2.Controls.Add(this.txtInqTelefono);
            this.panel2.Controls.Add(this.txtInqApellido);
            this.panel2.Controls.Add(this.txtInqNombre);
            this.panel2.Controls.Add(this.lblInqTelefono);
            this.panel2.Controls.Add(this.lblInqApellido);
            this.panel2.Controls.Add(this.lblInqNombre);
            this.panel2.Controls.Add(this.btnInqConfirmar);
            this.panel2.Controls.Add(this.btnInqEliminar);
            this.panel2.Controls.Add(this.btnInqEditar);
            this.panel2.Controls.Add(this.dgvInquilinos);
            this.panel2.Controls.Add(this.txtBusqueda);
            this.panel2.Controls.Add(this.btnBusqueda);
            this.panel2.Location = new System.Drawing.Point(125, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 323);
            this.panel2.TabIndex = 14;
            // 
            // btnInqOrdenar
            // 
            this.btnInqOrdenar.Location = new System.Drawing.Point(353, 281);
            this.btnInqOrdenar.Name = "btnInqOrdenar";
            this.btnInqOrdenar.Size = new System.Drawing.Size(118, 23);
            this.btnInqOrdenar.TabIndex = 9;
            this.btnInqOrdenar.Text = "Ordenar por Apellido";
            this.btnInqOrdenar.UseVisualStyleBackColor = true;
            this.btnInqOrdenar.Click += new System.EventHandler(this.btnInqOrdenar_Click);
            // 
            // txtInqTelefono
            // 
            this.txtInqTelefono.Location = new System.Drawing.Point(598, 221);
            this.txtInqTelefono.Name = "txtInqTelefono";
            this.txtInqTelefono.Size = new System.Drawing.Size(129, 20);
            this.txtInqTelefono.TabIndex = 3;
            // 
            // txtInqApellido
            // 
            this.txtInqApellido.Location = new System.Drawing.Point(598, 142);
            this.txtInqApellido.Name = "txtInqApellido";
            this.txtInqApellido.Size = new System.Drawing.Size(129, 20);
            this.txtInqApellido.TabIndex = 2;
            // 
            // txtInqNombre
            // 
            this.txtInqNombre.Location = new System.Drawing.Point(598, 59);
            this.txtInqNombre.Name = "txtInqNombre";
            this.txtInqNombre.Size = new System.Drawing.Size(129, 20);
            this.txtInqNombre.TabIndex = 1;
            // 
            // lblInqTelefono
            // 
            this.lblInqTelefono.AutoSize = true;
            this.lblInqTelefono.Location = new System.Drawing.Point(510, 224);
            this.lblInqTelefono.Name = "lblInqTelefono";
            this.lblInqTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblInqTelefono.TabIndex = 8;
            this.lblInqTelefono.Text = "Telefono:";
            // 
            // lblInqApellido
            // 
            this.lblInqApellido.AutoSize = true;
            this.lblInqApellido.Location = new System.Drawing.Point(510, 145);
            this.lblInqApellido.Name = "lblInqApellido";
            this.lblInqApellido.Size = new System.Drawing.Size(47, 13);
            this.lblInqApellido.TabIndex = 7;
            this.lblInqApellido.Text = "Apellido:";
            // 
            // lblInqNombre
            // 
            this.lblInqNombre.AutoSize = true;
            this.lblInqNombre.Location = new System.Drawing.Point(510, 62);
            this.lblInqNombre.Name = "lblInqNombre";
            this.lblInqNombre.Size = new System.Drawing.Size(47, 13);
            this.lblInqNombre.TabIndex = 6;
            this.lblInqNombre.Text = "Nombre:";
            // 
            // btnInqConfirmar
            // 
            this.btnInqConfirmar.Location = new System.Drawing.Point(598, 281);
            this.btnInqConfirmar.Name = "btnInqConfirmar";
            this.btnInqConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnInqConfirmar.TabIndex = 4;
            this.btnInqConfirmar.Text = "Confirmar";
            this.btnInqConfirmar.UseVisualStyleBackColor = true;
            this.btnInqConfirmar.Click += new System.EventHandler(this.btnInqConfirmar_Click);
            // 
            // btnInqEliminar
            // 
            this.btnInqEliminar.Location = new System.Drawing.Point(130, 281);
            this.btnInqEliminar.Name = "btnInqEliminar";
            this.btnInqEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnInqEliminar.TabIndex = 6;
            this.btnInqEliminar.Text = "Eliminar";
            this.btnInqEliminar.UseVisualStyleBackColor = true;
            this.btnInqEliminar.Click += new System.EventHandler(this.btnInqEliminar_Click);
            // 
            // btnInqEditar
            // 
            this.btnInqEditar.Location = new System.Drawing.Point(26, 281);
            this.btnInqEditar.Name = "btnInqEditar";
            this.btnInqEditar.Size = new System.Drawing.Size(75, 23);
            this.btnInqEditar.TabIndex = 5;
            this.btnInqEditar.Text = "Editar";
            this.btnInqEditar.UseVisualStyleBackColor = true;
            this.btnInqEditar.Click += new System.EventHandler(this.btnInqEditar_Click);
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Location = new System.Drawing.Point(26, 45);
            this.dgvInquilinos.Name = "dgvInquilinos";
            this.dgvInquilinos.Size = new System.Drawing.Size(445, 230);
            this.dgvInquilinos.TabIndex = 10;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(26, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(364, 20);
            this.txtBusqueda.TabIndex = 7;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(396, 18);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtAlqPreciofinal);
            this.panel3.Controls.Add(this.btnAlqRegistro);
            this.panel3.Controls.Add(this.btnAlqRegistrar);
            this.panel3.Controls.Add(this.dtpAlqHasta);
            this.panel3.Controls.Add(this.dtpAlqDesde);
            this.panel3.Controls.Add(this.cmbAlqInquilino);
            this.panel3.Controls.Add(this.cmbAlqDepartamento);
            this.panel3.Controls.Add(this.cmbAlqEdificio);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblAlqInquilino);
            this.panel3.Controls.Add(this.lblAlqDepartamento);
            this.panel3.Controls.Add(this.lblAlqEdificio);
            this.panel3.Location = new System.Drawing.Point(264, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 296);
            this.panel3.TabIndex = 15;
            // 
            // txtAlqPreciofinal
            // 
            this.txtAlqPreciofinal.Location = new System.Drawing.Point(211, 216);
            this.txtAlqPreciofinal.Name = "txtAlqPreciofinal";
            this.txtAlqPreciofinal.Size = new System.Drawing.Size(217, 20);
            this.txtAlqPreciofinal.TabIndex = 11;
            // 
            // btnAlqRegistro
            // 
            this.btnAlqRegistro.Location = new System.Drawing.Point(61, 256);
            this.btnAlqRegistro.Name = "btnAlqRegistro";
            this.btnAlqRegistro.Size = new System.Drawing.Size(122, 23);
            this.btnAlqRegistro.TabIndex = 12;
            this.btnAlqRegistro.Text = "Registro de Alquileres";
            this.btnAlqRegistro.UseVisualStyleBackColor = true;
            this.btnAlqRegistro.Click += new System.EventHandler(this.btnAlqRegistro_Click);
            // 
            // btnAlqRegistrar
            // 
            this.btnAlqRegistrar.Location = new System.Drawing.Point(353, 256);
            this.btnAlqRegistrar.Name = "btnAlqRegistrar";
            this.btnAlqRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnAlqRegistrar.TabIndex = 13;
            this.btnAlqRegistrar.Text = "Registrar";
            this.btnAlqRegistrar.UseVisualStyleBackColor = true;
            this.btnAlqRegistrar.Click += new System.EventHandler(this.btnAlqRegistrar_Click);
            // 
            // dtpAlqHasta
            // 
            this.dtpAlqHasta.Location = new System.Drawing.Point(211, 177);
            this.dtpAlqHasta.Name = "dtpAlqHasta";
            this.dtpAlqHasta.Size = new System.Drawing.Size(217, 20);
            this.dtpAlqHasta.TabIndex = 10;
            this.dtpAlqHasta.ValueChanged += new System.EventHandler(this.dtpAlqHasta_ValueChanged);
            // 
            // dtpAlqDesde
            // 
            this.dtpAlqDesde.Location = new System.Drawing.Point(211, 138);
            this.dtpAlqDesde.Name = "dtpAlqDesde";
            this.dtpAlqDesde.Size = new System.Drawing.Size(217, 20);
            this.dtpAlqDesde.TabIndex = 9;
            this.dtpAlqDesde.ValueChanged += new System.EventHandler(this.dtpAlqDesde_ValueChanged);
            // 
            // cmbAlqInquilino
            // 
            this.cmbAlqInquilino.FormattingEnabled = true;
            this.cmbAlqInquilino.Location = new System.Drawing.Point(211, 98);
            this.cmbAlqInquilino.Name = "cmbAlqInquilino";
            this.cmbAlqInquilino.Size = new System.Drawing.Size(217, 21);
            this.cmbAlqInquilino.TabIndex = 8;
            // 
            // cmbAlqDepartamento
            // 
            this.cmbAlqDepartamento.FormattingEnabled = true;
            this.cmbAlqDepartamento.Location = new System.Drawing.Point(211, 58);
            this.cmbAlqDepartamento.Name = "cmbAlqDepartamento";
            this.cmbAlqDepartamento.Size = new System.Drawing.Size(217, 21);
            this.cmbAlqDepartamento.TabIndex = 7;
            this.cmbAlqDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbAlqDepartamento_SelectedIndexChanged);
            // 
            // cmbAlqEdificio
            // 
            this.cmbAlqEdificio.FormattingEnabled = true;
            this.cmbAlqEdificio.Location = new System.Drawing.Point(211, 17);
            this.cmbAlqEdificio.Name = "cmbAlqEdificio";
            this.cmbAlqEdificio.Size = new System.Drawing.Size(217, 21);
            this.cmbAlqEdificio.TabIndex = 6;
            this.cmbAlqEdificio.SelectedIndexChanged += new System.EventHandler(this.cmbAlqEdificio_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Precio final:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Desde:";
            // 
            // lblAlqInquilino
            // 
            this.lblAlqInquilino.AutoSize = true;
            this.lblAlqInquilino.Location = new System.Drawing.Point(84, 101);
            this.lblAlqInquilino.Name = "lblAlqInquilino";
            this.lblAlqInquilino.Size = new System.Drawing.Size(49, 13);
            this.lblAlqInquilino.TabIndex = 2;
            this.lblAlqInquilino.Text = "Inquilino:";
            // 
            // lblAlqDepartamento
            // 
            this.lblAlqDepartamento.AutoSize = true;
            this.lblAlqDepartamento.Location = new System.Drawing.Point(84, 61);
            this.lblAlqDepartamento.Name = "lblAlqDepartamento";
            this.lblAlqDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblAlqDepartamento.TabIndex = 1;
            this.lblAlqDepartamento.Text = "Departamento:";
            // 
            // lblAlqEdificio
            // 
            this.lblAlqEdificio.AutoSize = true;
            this.lblAlqEdificio.Location = new System.Drawing.Point(84, 20);
            this.lblAlqEdificio.Name = "lblAlqEdificio";
            this.lblAlqEdificio.Size = new System.Drawing.Size(44, 13);
            this.lblAlqEdificio.TabIndex = 0;
            this.lblAlqEdificio.Text = "Edificio:";
            // 
            // FrmMenuOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1029, 429);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMenuOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Operador";
            this.Load += new System.EventHandler(this.FrmMenuOperador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnInquilino;
        private System.Windows.Forms.RadioButton btnAlquiler;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInqOrdenar;
        private System.Windows.Forms.TextBox txtInqTelefono;
        private System.Windows.Forms.TextBox txtInqApellido;
        private System.Windows.Forms.TextBox txtInqNombre;
        private System.Windows.Forms.Label lblInqTelefono;
        private System.Windows.Forms.Label lblInqApellido;
        private System.Windows.Forms.Label lblInqNombre;
        private System.Windows.Forms.Button btnInqConfirmar;
        private System.Windows.Forms.Button btnInqEliminar;
        private System.Windows.Forms.Button btnInqEditar;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAlqPreciofinal;
        private System.Windows.Forms.Button btnAlqRegistro;
        private System.Windows.Forms.Button btnAlqRegistrar;
        private System.Windows.Forms.DateTimePicker dtpAlqHasta;
        private System.Windows.Forms.DateTimePicker dtpAlqDesde;
        private System.Windows.Forms.ComboBox cmbAlqInquilino;
        private System.Windows.Forms.ComboBox cmbAlqDepartamento;
        private System.Windows.Forms.ComboBox cmbAlqEdificio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAlqInquilino;
        private System.Windows.Forms.Label lblAlqDepartamento;
        private System.Windows.Forms.Label lblAlqEdificio;
    }
}