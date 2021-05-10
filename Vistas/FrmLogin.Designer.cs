namespace Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.AutoSize = true;
            this.btn_Ingresar.BackColor = System.Drawing.Color.Cyan;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Location = new System.Drawing.Point(250, 205);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(101, 37);
            this.btn_Ingresar.TabIndex = 3;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            this.btn_Ingresar.MouseLeave += new System.EventHandler(this.btn_Ingresar_MouseLeave);
            this.btn_Ingresar.MouseHover += new System.EventHandler(this.btn_Ingresar_MouseHover);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AutoSize = true;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Cyan;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(51, 205);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(92, 37);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            this.btn_Cancelar.MouseLeave += new System.EventHandler(this.btn_Cancelar_MouseLeave);
            this.btn_Cancelar.MouseHover += new System.EventHandler(this.btn_Cancelar_MouseHover);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(68, 40);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(68, 20);
            this.lbl_User.TabIndex = 2;
            this.lbl_User.Text = "Usuario:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Password.Location = new System.Drawing.Point(68, 121);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(96, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Contraseña:";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.LightCyan;
            this.txt_User.Location = new System.Drawing.Point(205, 37);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(154, 20);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Password.Location = new System.Drawing.Point(205, 119);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(154, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.MediumTurquoise;
            this.imgUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(12, 28);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(50, 48);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 6;
            this.imgUser.TabStop = false;
            // 
            // imgPassword
            // 
            this.imgPassword.BackColor = System.Drawing.Color.MediumTurquoise;
            this.imgPassword.Image = ((System.Drawing.Image)(resources.GetObject("imgPassword.Image")));
            this.imgPassword.Location = new System.Drawing.Point(12, 108);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(50, 47);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPassword.TabIndex = 7;
            this.imgPassword.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(385, 282);
            this.ControlBox = false;
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al Sistema";
            this.TransparencyKey = System.Drawing.Color.OrangeRed;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgPassword;

    }
}