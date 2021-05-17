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
    public partial class FrmDepartamento : Form
    {
        Boolean edit =false;
        public FrmDepartamento()
        {
            InitializeComponent();

        }
        private bool validar(FrmDepartamento formulario)
        {
            bool vacio = false;
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true;
                }
            }
            return vacio;

        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            cmbDptoTipo.ValueMember = "TipoD_Codigo";
            cmbDptoTipo.DisplayMember = "TipoD_Descripcion";
            cmbDptoTipo.DataSource = TrabajarDepartamento.list_tipo_departamento();

            cmbEdifico.ValueMember = "Edif_Codigo";
            cmbEdifico.DisplayMember = "Edif_Nombre";
            cmbEdifico.DataSource = TrabajarDepartamento.list_edificios();

            cmbDptoDisposicion.Items.Add(1);
            cmbDptoDisposicion.Items.Add(2);
            cmbDptoDisposicion.Items.Add(3);
            cmbDptoDisposicion.Items.Add(4);

            load_departamento();
        }


        private void btnDptoConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Departamento oDpto = new Departamento();

                
                oDpto.Edif_Codigo = (int)cmbEdifico.SelectedValue;
                oDpto.Dpto_Tipo = (int)cmbDptoTipo.SelectedValue;
                oDpto.Dpto_Numero = Convert.ToInt32(txtDptoNumero.Text);
                oDpto.Dpto_Piso = Convert.ToInt32(txtDptoPiso.Text);
                oDpto.Dpto_Ambientes = Convert.ToInt32(txtDptoAmbiente.Text);
                oDpto.Dpto_Dormitorios = Convert.ToInt32(txtDptoDormitorios.Text);
                oDpto.Dpto_Baños = Convert.ToInt32(txtDptoBaños.Text);
                oDpto.Dpto_Disposicion = Convert.ToInt32(cmbDptoDisposicion.Text);
                oDpto.Dpto_Precio = Convert.ToDouble(txtDptoPrecio.Text);
                

                //oDpto.Edif_Codigo = txtDptoEdifCodigo.Text;
                //oDpto.Dpto_Tipo = (int)cmbDptoTipo.SelectedValue();
                //oDpto.Dpto_Numero = (int)txtDptoNumero.Text();

                //oDpto.Dpto_Piso = (int)txtDptoPiso.Text();
                //oDpto.Dpto_Ambientes = (int)txtDptoAmbiente.Text();
                //oDpto.Dpto_Dormitorios = (int)txtDptoDormitorios.Text();
                //oDpto.Dpto_Baños = (int)txtDptoBaños.Text();
                //oDpto.Dpto_Precio = (int)txtDptoPrecio.Text();
                //oDpto.Dpto_Disposicion = (int)cmbDptoDisposicion.SelectedValue();
                if (edit)
                {
                    try
                    {
                        oDpto.Dpto_Codigo = (int)dgvDepartamentos.CurrentRow.Cells["Codigo"].Value;
                        TrabajarDepartamento.edit_depto(oDpto);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Los departamentos no pueden tener datos repetidos");
                    }
                    edit = false;
                }
                else
                {
                    try
                    {
                        TrabajarDepartamento.insert_depto(oDpto);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Los departamentos no pueden tener datos repetidos");
                    }
                }
                cmbDptoDisposicion.SelectedValue = 1;
                cmbDptoTipo.SelectedValue = 1;
                txtDptoNumero.Text = "";
                txtDptoPiso.Text = "";
                txtDptoDormitorios.Text = "";
                txtDptoBaños.Text = "";
                txtDptoPrecio.Text = "";
                txtDptoAmbiente.Text = "";
                

                load_departamento();
            }

        }

        private void txtDptoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void txtDptoEdifCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoAmbiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoDormitorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoBaños_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDptoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void optAmbiente_CheckedChanged(object sender, EventArgs e)
        {
            dgvDepartamentos.DataSource = TrabajarDepartamento.ConsultarAmbiente();
        }

        private void optDisposicion_CheckedChanged(object sender, EventArgs e)
        {
            dgvDepartamentos.DataSource = TrabajarDepartamento.ConsultarDisposicion();
        }

        private void btnDptoEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    TrabajarDepartamento.delete_depto((int)dgvDepartamentos.CurrentRow.Cells["Codigo"].Value);
                    load_departamento();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnDptoeditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count == 1)
            {
                edit = true;
                cmbEdifico.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Codigo_Edificio"].Value;
                txtDptoNumero.Text = dgvDepartamentos.CurrentRow.Cells["Numero"].Value.ToString();
                txtDptoDormitorios.Text = dgvDepartamentos.CurrentRow.Cells["Dormitorios"].Value.ToString();
                txtDptoBaños.Text = dgvDepartamentos.CurrentRow.Cells["Banios"].Value.ToString();
                txtDptoPiso.Text = dgvDepartamentos.CurrentRow.Cells["Piso"].Value.ToString();
                txtDptoAmbiente.Text = dgvDepartamentos.CurrentRow.Cells["Ambientes"].Value.ToString();
                txtDptoPrecio.Text = dgvDepartamentos.CurrentRow.Cells["Precio"].Value.ToString();
                cmbDptoDisposicion.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Disposicion"].Value;
                cmbDptoTipo.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Tipo"].Value;
            }
            else 
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void load_departamento()
        {
            dgvDepartamentos.DataSource = TrabajarDepartamento.ConsultarAmbiente();
        }

    }
}
