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
            load_combo_edificios();
            load_combo_tipo_departamento();
        }

        private void load_combo_edificios()
        {
            cmbEdifList.ValueMember = "Edif_Codigo";
            cmbEdifList.DisplayMember = "Edif_Nombre";
            cmbEdifList.DataSource = ListAlquiler.list_edificios();
        }

        private void load_combo_tipo_departamento()
        {
            cmbAlqTipoDpto.ValueMember = "TipoD_Codigo";
            cmbAlqTipoDpto.DisplayMember = "TipoD_Descripcion";
            cmbAlqTipoDpto.DataSource = TrabajarAlquiler.list_tipoDepartamento();
        }

        private void btnAlqBuscar_Click(object sender, EventArgs e)
        {
            dgvAlquileres.DataSource = ListAlquiler.list_alquileresP(cmbEdifList.Text, dtpDesde.Value, dtpHasta.Value, cmbAlqTipoDpto.Text);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value) dtpHasta.Value = dtpDesde.Value.AddDays(1);
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value) dtpDesde.Value = dtpHasta.Value.AddDays(-1);
        }

    }
}
