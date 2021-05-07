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

        public FrmEdificio()
        {
            InitializeComponent();
        }

        private void btnEdifConfirmar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Edificio oEdif = new Edificio();
                if (validar(this) == false)
                {
                    oEdif.Edif_Codigo = Convert.ToInt32(txtEdifCodigo.Text);
                    oEdif.Edif_Nombre = txtEdifNombre.Text;
                    oEdif.Edif_Direccion = txtEdifDireccion.Text;
                    oEdif.Edif_Admnistrador = txtEdifAdminitrador.Text;
                    oEdif.Edif_Telefono = txtEdifTelefono.Text;
                    MessageBox.Show("Codigo: " + oEdif.Edif_Codigo + "\n Nombre: " + oEdif.Edif_Nombre + "\n Administrador: " + oEdif.Edif_Admnistrador +
                        "\n Direccion: " + oEdif.Edif_Direccion + "\n Telefono: " + oEdif.Edif_Telefono, "Datos Edificio");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos.");
                }

            }

        }

        private void FrmEdificio_Load(object sender, EventArgs e)
        {

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

    }
}
