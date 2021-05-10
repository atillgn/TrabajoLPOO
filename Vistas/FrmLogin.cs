using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
   

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = VerificarLogin.search_user(txt_User.Text, txt_Password.Text);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bienvenido/a: " + txt_User.Text );
                txt_User.Clear();
                txt_Password.Clear();
                this.Hide();
                if (dt.Rows[0][0].ToString() == "1") {
                    FrmMainAdmin oFrmAdmin = new FrmMainAdmin();
                    oFrmAdmin.Show();
                }
                else if (dt.Rows[0][0].ToString() == "2")
                {
                    FrmMainOperador oFrmOperador = new FrmMainOperador();
                    oFrmOperador.Show();
                }
                else 
                {
                    FrmMainAuditor oFrmAuditor = new FrmMainAuditor();
                    oFrmAuditor.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

        //Diseño

        private void btn_Ingresar_MouseHover(object sender, EventArgs e)
        {
            btn_Ingresar.Font = new Font(" ", 8, FontStyle.Underline);
            btn_Ingresar.BackColor = Color.White;
        }

        private void btn_Ingresar_MouseLeave(object sender, EventArgs e)
        {
            btn_Ingresar.Font = new Font(" ", 8);
            btn_Ingresar.BackColor = Color.Cyan;
        }
        private void btn_Cancelar_MouseHover(object sender, EventArgs e)
        {
            btn_Cancelar.Font = new Font(" ", 8, FontStyle.Underline);
            btn_Cancelar.BackColor = Color.White;
        }

        private void btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            btn_Cancelar.Font = new Font(" ", 8);
            btn_Cancelar.BackColor = Color.Cyan;
        }
    }
}
