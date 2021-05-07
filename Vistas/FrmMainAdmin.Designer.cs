namespace Vistas
{
    partial class FrmMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdmin));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdificios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbmEdificios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbmDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuEdificios,
            this.mnuDepartamentos});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(859, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbmUsuarios});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // mnuAbmUsuarios
            // 
            this.mnuAbmUsuarios.Name = "mnuAbmUsuarios";
            this.mnuAbmUsuarios.Size = new System.Drawing.Size(148, 22);
            this.mnuAbmUsuarios.Text = "ABM Usuarios";
            this.mnuAbmUsuarios.Click += new System.EventHandler(this.mnuAbmUsuarios_Click);
            // 
            // mnuEdificios
            // 
            this.mnuEdificios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbmEdificios});
            this.mnuEdificios.Name = "mnuEdificios";
            this.mnuEdificios.Size = new System.Drawing.Size(63, 20);
            this.mnuEdificios.Text = "Edificios";
            // 
            // mnuAbmEdificios
            // 
            this.mnuAbmEdificios.Name = "mnuAbmEdificios";
            this.mnuAbmEdificios.Size = new System.Drawing.Size(147, 22);
            this.mnuAbmEdificios.Text = "ABM Edificios";
            this.mnuAbmEdificios.Click += new System.EventHandler(this.mnuAbmEdificios_Click);
            // 
            // mnuDepartamentos
            // 
            this.mnuDepartamentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbmDepartamentos});
            this.mnuDepartamentos.Name = "mnuDepartamentos";
            this.mnuDepartamentos.Size = new System.Drawing.Size(100, 20);
            this.mnuDepartamentos.Text = "Departamentos";
            // 
            // mnuAbmDepartamentos
            // 
            this.mnuAbmDepartamentos.Name = "mnuAbmDepartamentos";
            this.mnuAbmDepartamentos.Size = new System.Drawing.Size(184, 22);
            this.mnuAbmDepartamentos.Text = "ABM Departamentos";
            this.mnuAbmDepartamentos.Click += new System.EventHandler(this.mnuAbmDepartamentos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(698, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMainAdmin";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FrmMainAdmin_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuAbmDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuEdificios;
        private System.Windows.Forms.ToolStripMenuItem mnuAbmEdificios;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuAbmUsuarios;
    }
}