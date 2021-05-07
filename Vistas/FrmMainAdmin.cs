using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMainAdmin : Form
    {
        public FrmMainAdmin()
        {
            InitializeComponent();
        }
        
        private void FrmMainAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
                Program.oFrmLogin.Show();
            }
        }

        private void mnuAbmUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuarios = new FrmUsuario();
            oFrmUsuarios.Show();
        }

        private void mnuAbmEdificios_Click(object sender, EventArgs e)
        {
            FrmEdificio oFrmEdificios = new FrmEdificio();
            oFrmEdificios.Show();
        }

        private void mnuAbmDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamento oFrmDepartamentos = new FrmDepartamento();
            oFrmDepartamentos.Show();
        }

        
    }
}
