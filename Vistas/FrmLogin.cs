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
                MessageBox.Show("Bienvenido/a: " + txt_User.Text);
                txt_User.Clear();
                txt_Password.Clear();
                this.Hide();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    FrmMenuAdministrador oFrmAdmin = new FrmMenuAdministrador();
                    oFrmAdmin.Show();
                }
                else if (dt.Rows[0][0].ToString() == "2")
                {
                    FrmMenuOperador oFrmOperador = new FrmMenuOperador();
                    oFrmOperador.Show();
                }
                else
                {
                    FrmMenuAuditor oFrmAuditor = new FrmMenuAuditor();
                    oFrmAuditor.Show();
                }
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //permite mover el formulario
        int m, mx, my;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
