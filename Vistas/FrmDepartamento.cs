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
            cmbDptoTipo.Items.Add("Duplex");
            cmbDptoTipo.Items.Add("Estudio");
            cmbDptoTipo.Items.Add("Comercial");
            cmbDptoTipo.Items.Add("Cocina");
            cmbDptoDisposicion.Items.Add("Frente");
            cmbDptoDisposicion.Items.Add("Contrarente");
            cmbDptoDisposicion.Items.Add("Interior");
            cmbDptoDisposicion.Items.Add("Exterior");

            cmbDptoDisposicion.Items.Add("Frente");
            cmbDptoDisposicion.Items.Add("Frente");
            
        }

        private void btnDptoConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Departamento oDpto = new Departamento();
                if (validar(this) == false)
                {
                    oDpto.Dpto_Codigo = Convert.ToInt32(txtDptoCodigo.Text);
                    oDpto.Edif_Codigo = Convert.ToInt32(txtDptoEdifCodigo.Text);
                    oDpto.Dpto_Tipo = Int32.Parse(cmbDptoTipo.Text);
                    oDpto.Dpto_Numero = Convert.ToInt32(txtDptoNumero.Text);
                    oDpto.Dpto_Piso = Convert.ToInt32(txtDptoPiso.Text);
                    oDpto.Dpto_Ambientes = Convert.ToInt32(txtDptoAmbiente.Text);
                    oDpto.Dpto_Dormitorios = Convert.ToInt32(txtDptoDormitorios.Text);
                    oDpto.Dpto_Baños = Convert.ToInt32(txtDptoBaños.Text);
                    oDpto.Dpto_Precio = Convert.ToDouble(txtDptoPrecio.Text);
                    oDpto.Dpto_Disposicion = Int32.Parse(cmbDptoDisposicion.Text);
                    MessageBox.Show(" Codigo: " + oDpto.Dpto_Codigo + "\n Codigo edifico: " + oDpto.Edif_Codigo + "\n Tipo: " + oDpto.Dpto_Tipo +
                        "\n Numero: " + oDpto.Dpto_Numero + "\n Piso: " + oDpto.Dpto_Piso + "\n Ambientes: " + oDpto.Dpto_Ambientes + "\n Dormitorios: " + oDpto.Dpto_Dormitorios
                        + "\n Baños: " + oDpto.Dpto_Baños + "\n Disposicion: " + oDpto.Dpto_Disposicion + "\n Precio: " + oDpto.Dpto_Precio, "\n Datos Departamento");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos.");
                }
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

    }
}
