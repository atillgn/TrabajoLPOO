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
    public partial class FrmBuscarDepartamento : Form
    {
        private int aux;
        public FrmBuscarDepartamento(int a)
        {
            InitializeComponent();
            aux = a;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere volver?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (aux == 1)
                {
                    FrmMenuAuditor oFrmMenuAuditor = new FrmMenuAuditor();
                    oFrmMenuAuditor.tabControl1.SelectedIndex = 1;
                    oFrmMenuAuditor.Show();
                }
                else
                {
                    FrmMenuOperador oFrmMenuOperador = new FrmMenuOperador();
                    oFrmMenuOperador.tabControl1.SelectedIndex = 1;
                    oFrmMenuOperador.Show();
                }
                this.Close();
            }
        }

        private void FrmBuscarDepartamento_Load(object sender, EventArgs e)
        {
            dgvDpto.DataSource = TrabajarDepartamento.list_dpto();
            load_Disposicion();
            load_TipoDpto();
            load_Ambientes();
            load_Banios();
            cmbAmbientes.SelectedText = "1";
            cmbBaños.SelectedText = "1";
        }
        private void load_Disposicion() 
        {
            cmbDisposicion.ValueMember = "Disp_Codigo";
            cmbDisposicion.DisplayMember = "Disp_Descripcion";
            cmbDisposicion.DataSource = TrabajarDepartamento.list_disposicion();
        }
        private void load_TipoDpto() 
        {
            cmbTipoDpto.ValueMember = "TipoD_Codigo";
            cmbTipoDpto.DisplayMember = "TipoD_Descripcion";
            cmbTipoDpto.DataSource = TrabajarAlquiler.list_tipoDepartamento();
        }
        private void load_Banios()
        {
            cmbBaños.Items.Add(1);
            cmbBaños.Items.Add(2);
            cmbBaños.Items.Add(3);
            cmbBaños.Items.Add(4);
            cmbBaños.Items.Add(5);
            cmbBaños.Items.Add(6);
            cmbBaños.Items.Add(7);
            cmbBaños.Items.Add(8);
            cmbBaños.Items.Add(9);
            cmbBaños.Items.Add(10);
        }
        private void load_Ambientes()
        {
            cmbAmbientes.Items.Add(1);
            cmbAmbientes.Items.Add(2);
            cmbAmbientes.Items.Add(3);
            cmbAmbientes.Items.Add(4);
            cmbAmbientes.Items.Add(5);
            cmbAmbientes.Items.Add(6);
            cmbAmbientes.Items.Add(7);
            cmbAmbientes.Items.Add(8);
            cmbAmbientes.Items.Add(9);
            cmbAmbientes.Items.Add(10);
        }
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value) dtpHasta.Value = dtpDesde.Value;
            if (dtpDesde.Value <= DateTime.Now) dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = dtpHasta.Value.AddSeconds(59 - dtpHasta.Value.Second);
            dtpHasta.Value = dtpHasta.Value.AddHours(23 - dtpHasta.Value.Hour);
            dtpHasta.Value = dtpHasta.Value.AddMinutes(59 - dtpHasta.Value.Minute);
        }
        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value >= dtpHasta.Value) dtpDesde.Value = dtpHasta.Value;
            if (dtpHasta.Value <= DateTime.Now) dtpHasta.Value = DateTime.Now;
            dtpHasta.Value = dtpHasta.Value.AddSeconds(59 - dtpHasta.Value.Second);
            dtpHasta.Value = dtpHasta.Value.AddHours(23 - dtpHasta.Value.Hour);
            dtpHasta.Value = dtpHasta.Value.AddMinutes(59 - dtpHasta.Value.Minute);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarBusqueda())
            {
                try
                {
                    dgvDpto.DataSource = ListAlquiler.list_dptoParaAlquilar(dtpDesde.Value.Date, dtpHasta.Value, cmbTipoDpto.Text, Int32.Parse(cmbAmbientes.Text), Int32.Parse(txtPrecio.Text), cmbDisposicion.Text, Int32.Parse(cmbBaños.Text));
                }
                catch (Exception a) 
                {
                    MessageBox.Show("No ingrese numeros tan grandes");
                }
            }
            else 
            {
                MessageBox.Show("Complete el formulario");
            }
        }
        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            if(dgvDpto.SelectedRows.Count == 1)
            {
                if (aux == 1)
                {
                    FrmMenuAuditor oFrmMenuAuditor = new FrmMenuAuditor();
                    oFrmMenuAuditor.tabControl1.SelectedIndex = 1;
                    oFrmMenuAuditor.Show();
                    oFrmMenuAuditor.cmbAlqEdificio.SelectedValue = dgvDpto.CurrentRow.Cells["Codigo_Edificio"].Value;
                    oFrmMenuAuditor.cmbAlqDepartamento.SelectedValue = dgvDpto.CurrentRow.Cells["Codigo"].Value;
                    oFrmMenuAuditor.dtpAlqDesde.Value = dtpDesde.Value;
                    oFrmMenuAuditor.dtpAlqHasta.Value = dtpHasta.Value;
                }
                else
                {
                    FrmMenuOperador oFrmMenuOperador = new FrmMenuOperador();
                    oFrmMenuOperador.tabControl1.SelectedIndex = 1;
                    oFrmMenuOperador.Show();
                    oFrmMenuOperador.cmbAlqEdificio.SelectedValue = dgvDpto.CurrentRow.Cells["Codigo_Edificio"].Value;
                    oFrmMenuOperador.cmbAlqDepartamento.SelectedValue = dgvDpto.CurrentRow.Cells["Codigo"].Value;
                    oFrmMenuOperador.dtpAlqDesde.Value = dtpDesde.Value;
                    oFrmMenuOperador.dtpAlqHasta.Value = dtpHasta.Value;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private bool validarBusqueda() 
        {
            return txtPrecio.Text != String.Empty;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void rdbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            dgvDpto.Sort(dgvDpto.Columns["Precio"], ListSortDirection.Ascending);
        }
        private void rdbAmbientes_CheckedChanged(object sender, EventArgs e)
        {
            dgvDpto.Sort(dgvDpto.Columns["Ambientes"], ListSortDirection.Ascending);
        }
        private void rdbBanios_CheckedChanged(object sender, EventArgs e)
        {
            dgvDpto.Sort(dgvDpto.Columns["Banios"], ListSortDirection.Ascending);
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
