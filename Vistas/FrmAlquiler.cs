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
    public partial class FrmAlquiler : Form
    {
        public FrmAlquiler()
        {
            InitializeComponent();
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {
            txtPrecioFinal.Enabled = false;
            load_combo_edificios();
            load_combo_departamentos((int)cmbEdif_Codigo.SelectedValue);
            load_combo_inquilinos();
            dtpDesde.Value = DateTime.Now;
            display_precioFinal();
        }

        private void load_combo_edificios()
        {
            cmbEdif_Codigo.ValueMember = "Edif_Codigo";
            cmbEdif_Codigo.DisplayMember = "Edif_Nombre";
            cmbEdif_Codigo.DataSource = TrabajarAlquiler.list_edificios();
        }
        private void load_combo_departamentos(int Edif_Codigo)
        {
            cmbDpto_Codigo.ValueMember = "Dpto_Codigo";
            cmbDpto_Codigo.DisplayMember = "Info";
            cmbDpto_Codigo.DataSource = TrabajarAlquiler.list_departamentos(Edif_Codigo);
        }
        private void load_combo_inquilinos()
        {
            cmbInq_Codigo.ValueMember = "Inq_Codigo";
            cmbInq_Codigo.DisplayMember = "Inq_Apellido";
            cmbInq_Codigo.DataSource = TrabajarAlquiler.list_inquilinos(); 
        }
        private void cmbEdif_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_combo_departamentos((int)cmbEdif_Codigo.SelectedValue);
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value <= DateTime.Now) dtpDesde.Value = DateTime.Now;
            if (dtpDesde.Value > dtpHasta.Value) dtpHasta.Value = dtpDesde.Value.AddDays(1);
            display_precioFinal();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHasta.Value <= DateTime.Now) dtpHasta.Value = DateTime.Now;
            if (dtpDesde.Value > dtpHasta.Value) dtpDesde.Value = dtpHasta.Value.AddDays(-1);
            display_precioFinal();
        }

        private void display_precioFinal()
        {
            txtPrecioFinal.Text = "$" + precioFinal().ToString();
        }
        private double precioFinal()
        {
            Departamento dpto = TrabajarAlquiler.get_departamento((int)cmbDpto_Codigo.SelectedValue);
            int meses = 0;
            DateTime desde = dtpDesde.Value, hasta = dtpHasta.Value;
            while (desde.AddMonths(1) < hasta)
            {
                meses++;
                desde = desde.AddMonths(1);
            }
            int dias = 0;
            while (desde.AddDays(1) < hasta)
            {
                dias++;
                desde = desde.AddDays(1);
            }
            double ret = dpto.Dpto_Precio * meses;
            ret += dpto.Dpto_Precio * dias / 31;
            return Math.Round(ret, 2);
        }

        private void cmbDpto_Codigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_precioFinal();
        }

        private void btnAlquilerConfirmar_Click(object sender, EventArgs e)
        {
            Alquiler alq = new Alquiler();
            alq.Dpto_Codigo = (int)cmbDpto_Codigo.SelectedValue;
            alq.Inq_Codigo = (int)cmbInq_Codigo.SelectedValue;
            alq.Alq_FechaDesde = dtpDesde.Value;
            alq.Alq_FechaHasta = dtpHasta.Value;
            alq.Alq_Precio = precioFinal();
            if (MessageBox.Show("Confirmar datos", "¿Seguro que quieres registrar este alquiler?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                TrabajarAlquiler.insert_alquiler(alq);
                reset_formulario();
            }
        }
        private void reset_formulario()
        {
            load_combo_edificios();
            load_combo_departamentos((int)cmbEdif_Codigo.SelectedValue);
            load_combo_inquilinos();
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now.AddDays(1);
            display_precioFinal();
        }
    }
}
