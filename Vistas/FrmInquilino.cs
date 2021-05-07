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
    public partial class FrmInquilino : Form
    {
        private bool edit = false;
        public FrmInquilino()
        {
            InitializeComponent();
        }

        private bool validar(FrmInquilino formulario)
        {
            bool vacio = false;
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox && oControls.Text == String.Empty && oControls != txtBusqueda) // Verificamos que no este vacio.
                {
                    vacio = true;
                }
            }
            return vacio;
        }

        private void txtInqCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmInquilino_Load(object sender, EventArgs e)
        {
            load_inquilinos();
        }

        private void load_inquilinos(String pattern = "") 
        { 
            dgvInquilinos.DataSource=TrabajarInquilinos.list_inquilinos(pattern);
        }

        private void btnInqConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validar(this) == false)
                {
                    Inquilino oInq = new Inquilino();
                    oInq.Inq_Nombre = txtInqNombre.Text;
                    oInq.Inq_Apellido = txtInqApellido.Text;
                    oInq.Inq_Telefono = txtInqTelefono.Text;
                    if (edit)
                    {
                        try
                        {
                            oInq.Inq_Codigo = (int)dgvInquilinos.CurrentRow.Cells["Codigo"].Value;
                            TrabajarInquilinos.edit_inquilino(oInq);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Los usuarios no pueden tener datos repetidos");
                        }
                        edit = false;
                    }
                    else
                    {
                        try
                        {
                            TrabajarInquilinos.insert_inquilino(oInq);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Los usuarios no pueden tener datos repetidos");
                        }
                    }
                    txtInqApellido.Text = "";
                    txtInqNombre.Text = "";
                    txtInqTelefono.Text = "";
                    load_inquilinos();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos.");
                }
            }
        }

        private void btnInqEditar_Click(object sender, EventArgs e)
        {
            if (dgvInquilinos.SelectedRows.Count == 1)
            {
                edit = true;
                txtInqApellido.Text = dgvInquilinos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtInqNombre.Text = dgvInquilinos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtInqTelefono.Text = dgvInquilinos.CurrentRow.Cells["Telefono"].Value.ToString();
            }
            else 
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnInqEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInquilinos.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    TrabajarInquilinos.delete_inquilino((int)dgvInquilinos.CurrentRow.Cells["Codigo"].Value);
                    load_inquilinos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            String pattern = txtBusqueda.Text;
            load_inquilinos(pattern);
        }
    }
}
