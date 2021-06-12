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
        private int aux;
        public FrmListAlquiler(int a)
        {
            aux = a;
            InitializeComponent();
        }
        bool a = false, b = false, c = false;
        private void FrmListAlquiler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datosDataSet1.Alquiler' table. You can move, or remove it, as needed.
            dgvAlquileres.DataSource = ListAlquiler.list_alquileres();
            load_combo_edificios();
            load_combo_tipo_departamento();
            cmbEdifList.Enabled = a;
            cmbAlqTipoDpto.Enabled = c;
            dtpDesde.Enabled = b;
            dtpHasta.Enabled = b;
            txtAlqCantidad.Enabled = false;
            display_cantidad();
            if (dgvAlquileres.RowCount == 1)
            {
                btnAlqEliminar.Enabled = false;
            }
            else
            {
                btnAlqEliminar.Enabled = true;
            }
        }

        private void load_combo_edificios()
        {
            cmbEdifList.ValueMember = "Edif_Codigo";
            cmbEdifList.DisplayMember = "Edif_Nombre";
            DataTable dt = new DataTable();
            dt = ListAlquiler.list_edificios();
            if (dt.Rows.Count >= 1)
            {
                cmbEdifList.DataSource = dt;
                btnAlqBuscar.Enabled = true;
            }
            else
            {
                btnAlqBuscar.Enabled = false;
            }
        }

        private void load_combo_tipo_departamento()
        {
            cmbAlqTipoDpto.ValueMember = "TipoD_Codigo";
            cmbAlqTipoDpto.DisplayMember = "TipoD_Descripcion";
            DataTable dt = new DataTable();
            dt = TrabajarAlquiler.list_tipoDepartamento();
            if (dt.Rows.Count >= 1)
            {
                cmbAlqTipoDpto.DataSource = dt;
                btnAlqBuscar.Enabled = true;
            }
            else
            {
                btnAlqBuscar.Enabled = false;
            }
        }

        private void btnAlqBuscar_Click(object sender, EventArgs e)
        {
            dgvAlquileres.DataSource = ListAlquiler.list_alquileresP(cmbEdifList.Text, dtpDesde.Value.Date, dtpHasta.Value, cmbAlqTipoDpto.Text,a,b,c);
            display_cantidad();
        }

        private void display_cantidad() 
        {
            txtAlqCantidad.Text = (dgvAlquileres.RowCount-1).ToString();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value) dtpHasta.Value = dtpDesde.Value;
            dtpHasta.Value=dtpHasta.Value.AddSeconds(59-dtpHasta.Value.Second);
            dtpHasta.Value=dtpHasta.Value.AddHours(23-dtpHasta.Value.Hour);
            dtpHasta.Value=dtpHasta.Value.AddMinutes(59-dtpHasta.Value.Minute);
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value) dtpDesde.Value = dtpHasta.Value;
            dtpHasta.Value = dtpHasta.Value.AddSeconds(59 - dtpHasta.Value.Second);
            dtpHasta.Value = dtpHasta.Value.AddHours(23 - dtpHasta.Value.Hour);
            dtpHasta.Value = dtpHasta.Value.AddMinutes(59 - dtpHasta.Value.Minute);
        }

        private void ckbAlqEdif_CheckedChanged(object sender, EventArgs e)
        {
            if (!a)
            {
                a = true;
                cmbEdifList.Enabled = a;
            }
            else 
            {
                a = false;
                cmbEdifList.Enabled = a;
            }
            
        }

        private void ckbAlqRango_CheckedChanged(object sender, EventArgs e)
        {
            if (!b)
            {
                b = true;
                dtpDesde.Enabled = b;
                dtpHasta.Enabled = b;
            }
            else 
            {
                b = false;
                dtpDesde.Enabled = b;
                dtpHasta.Enabled = b;
            }
            
        }

        private void ckbAlqDpto_CheckedChanged(object sender, EventArgs e)
        {
            if (!c)
            {
                c = true;
                cmbAlqTipoDpto.Enabled = c;
            }
            else 
            {
                c = false;
                cmbAlqTipoDpto.Enabled = c;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere volver?", "Volver", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (aux == 1)
                {
                    FrmMenuAuditor oFrmMenuAuditor = new FrmMenuAuditor();
                    oFrmMenuAuditor.load_everything();
                    oFrmMenuAuditor.tabControl1.SelectedIndex = 1;
                    oFrmMenuAuditor.Show();
                }
                else
                {
                    FrmMenuOperador oFrmMenuOperador = new FrmMenuOperador();
                    oFrmMenuOperador.load_everything();
                    oFrmMenuOperador.tabControl1.SelectedIndex = 1;
                    oFrmMenuOperador.Show();
                }
                this.Close();
            }
        }
        private void btnAlqEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count == 1 && dgvAlquileres.RowCount > 1)
            {
                DateTime d = DateTime.Now, a = new DateTime(), b = new DateTime();
                a = (DateTime)dgvAlquileres.CurrentRow.Cells["Fecha_desde"].Value;
                b = (DateTime)dgvAlquileres.CurrentRow.Cells["Fecha_hasta"].Value;
                if (d < a || d > b)
                {
                    if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        ListAlquiler.delete_alquiler((int)dgvAlquileres.CurrentRow.Cells["Codigo"].Value);
                        dgvAlquileres.DataSource = ListAlquiler.list_alquileres();
                        MessageBox.Show("Alquiler eliminado con exito");
                    }
                }
                else
                {
                    MessageBox.Show("No puede eliminar una alquiler en curso");
                }
            }
            else 
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
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
