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
    public partial class FrmEdificio : Form
    {
        private bool edit = false;
        public FrmEdificio()
        {
            InitializeComponent();
        }

        private void btnEdifConfirmar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validar(this) == false)
                {
                    Edificio oEdif = new Edificio();
                    oEdif.Edif_Nombre = txtEdifNombre.Text;
                    oEdif.Edif_Direccion = txtEdifDireccion.Text;
                    oEdif.Edif_Admnistrador = cmbEdifAdmin.SelectedValue.ToString();
                    oEdif.Edif_Telefono = txtEdifTelefono.Text;
                    if (edit)
                    {
                        try
                        {
                            oEdif.Edif_Codigo = (int)dgvEdificio.CurrentRow.Cells["Edif_Codigo"].Value;
                            TrabajarEdificios.edit_edificio(oEdif);
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
                            TrabajarEdificios.insert_edificio(oEdif);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Los usuarios no pueden tener datos repetidos");
                        }
                    }
                    oEdif.Edif_Nombre = "";
                    oEdif.Edif_Direccion = "";
                    oEdif.Edif_Admnistrador = "";
                    oEdif.Edif_Telefono = "";
                    load_edificio();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos.");
                }

            }

        }

        private void FrmEdificio_Load(object sender, EventArgs e)
        {
            load_edificio();
            load_combo_Admin();
        }

        private void load_combo_Admin() 
        {
            cmbEdifAdmin.ValueMember = "Nombre_de_usuario";
            cmbEdifAdmin.DisplayMember = "Apellido_y_Nombre";
            cmbEdifAdmin.DataSource = TrabajarEdificios.list_admin();
        }

        private void load_edificio() 
        {
            dgvEdificio.DataSource = TrabajarEdificios.list_edificios();
        }

        private bool validar(FrmEdificio formulario)
        {
            bool vacio = false;
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio= true; 
                }
            }
            return vacio;
       
        }

        private void txtEdifCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEdificio.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    TrabajarEdificios.delete_edificio((int)dgvEdificio.CurrentRow.Cells["Edif_Codigo"].Value);
                    load_edificio();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEdificio.SelectedRows.Count == 1)
            {
                edit = true;
                txtEdifNombre.Text = dgvEdificio.CurrentRow.Cells["Edif_Nombre"].Value.ToString();
                txtEdifDireccion.Text = dgvEdificio.CurrentRow.Cells["Edif_Direccion"].Value.ToString();
                txtEdifTelefono.Text = dgvEdificio.CurrentRow.Cells["Edif_Telefono"].Value.ToString();
                cmbEdifAdmin.SelectedValue = dgvEdificio.CurrentRow.Cells["Edif_Administrador"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

    }
}
