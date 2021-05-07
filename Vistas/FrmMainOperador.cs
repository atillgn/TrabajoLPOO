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
    public partial class FrmMainOperador : Form
    {
        public FrmMainOperador()
        {
            InitializeComponent();
        }

        private void FrmMainOperador_Load(object sender, EventArgs e)
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

        private void mnuAbmInquilinos_Click(object sender, EventArgs e)
        {
            FrmInquilino oFrmInquilinos = new FrmInquilino();
            oFrmInquilinos.Show();
        }

        private void mnuMostrarAlquileres_Click(object sender, EventArgs e)
        {
            FrmListAlquiler oFrmListAlquiler = new FrmListAlquiler();
            oFrmListAlquiler.Show();
        }

        private void altaDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlquiler oFrmAlquiler = new FrmAlquiler();
            oFrmAlquiler.Show();
        }

        
    }
}
