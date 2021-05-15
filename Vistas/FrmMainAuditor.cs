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
    public partial class FrmMainAuditor : Form
    {
        public FrmMainAuditor()
        {
            InitializeComponent();
        }

        private void FrmMainAuditor_Load(object sender, EventArgs e)
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

        private void mnuAbmInquilino_Click(object sender, EventArgs e)
        {
            FrmInquilino oFrmInquilino = new FrmInquilino();
            oFrmInquilino.Show();
        }

        private void mnuAbmDepartamentos_Click(object sender, EventArgs e)
        {
            FrmDepartamento oFrmDepartamento = new FrmDepartamento();
            oFrmDepartamento.Show();
        }

        private void mnuAbmEdificios_Click(object sender, EventArgs e)
        {
            FrmEdificio oFrmEdificio = new FrmEdificio();
            oFrmEdificio.Show();
        }

        private void mnuAbmUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.Show();
        }

        private void mnuAltaAlquiler_Click(object sender, EventArgs e)
        {
            FrmAlquiler oFrmAlquiler = new FrmAlquiler();
            oFrmAlquiler.Show();
        }

    }
}
