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
    public partial class FrmListAlquiler : Form
    {
        public FrmListAlquiler()
        {
            InitializeComponent();
        }

        private void FrmListAlquiler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datosDataSet1.Alquiler' table. You can move, or remove it, as needed.
            dgvAlquileres.DataSource = ListAlquiler.list_alquileres();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
