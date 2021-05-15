namespace Vistas
{
    partial class FrmMainOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainOperador));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuInquilinos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbmInquilinos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlquileres = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAltaAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInquilinos,
            this.mnuAlquileres});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(859, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuInquilinos
            // 
            this.mnuInquilinos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbmInquilinos});
            this.mnuInquilinos.Name = "mnuInquilinos";
            this.mnuInquilinos.Size = new System.Drawing.Size(71, 20);
            this.mnuInquilinos.Text = "Inquilinos";
            // 
            // mnuAbmInquilinos
            // 
            this.mnuAbmInquilinos.Name = "mnuAbmInquilinos";
            this.mnuAbmInquilinos.Size = new System.Drawing.Size(150, 22);
            this.mnuAbmInquilinos.Text = "ABM Inquilino";
            this.mnuAbmInquilinos.Click += new System.EventHandler(this.mnuAbmInquilinos_Click);
            // 
            // mnuAlquileres
            // 
            this.mnuAlquileres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAltaAlquiler});
            this.mnuAlquileres.Name = "mnuAlquileres";
            this.mnuAlquileres.Size = new System.Drawing.Size(71, 20);
            this.mnuAlquileres.Text = "Alquileres";
            // 
            // mnuAltaAlquiler
            // 
            this.mnuAltaAlquiler.Name = "mnuAltaAlquiler";
            this.mnuAltaAlquiler.Size = new System.Drawing.Size(152, 22);
            this.mnuAltaAlquiler.Text = "Alta Alquiler";
            this.mnuAltaAlquiler.Click += new System.EventHandler(this.altaDeAlquilerToolStripMenuItem_Click);
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
            // FrmMainOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mnuMain);
            this.Name = "FrmMainOperador";
            this.Text = "Operador";
            this.Load += new System.EventHandler(this.FrmMainOperador_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAlquileres;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuInquilinos;
        private System.Windows.Forms.ToolStripMenuItem mnuAbmInquilinos;
        private System.Windows.Forms.ToolStripMenuItem mnuAltaAlquiler;
    }
}