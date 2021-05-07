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
    public partial class FrmUsuario : Form
    {
        private bool edit = false;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        private void load_combo_roles() {
            cmbRol_Id.DisplayMember = "Rol_Descripcion";
            cmbRol_Id.ValueMember = "Rol_Codigo";
            cmbRol_Id.DataSource = TrabajarUsuario.list_roles();
        }

        private void load_usuarios(String pattern = "")
        {
            dgvUsuarios.DataSource = TrabajarUsuario.list_usuarios(pattern);
        }

        private void btnUsuarioConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Usuario oUser = new Usuario();
                oUser.Rol_id = (int)cmbRol_Id.SelectedValue;
                oUser.Usr_NombreUsuario = txtUsuario_NombreUsuario.Text;
                oUser.Usr_Contrasenia = txtUsuario_Contrasenia.Text;
                oUser.Usr_ApellidoNombre = txtUsuario_ApellidoNombre.Text;
                if (edit)
                {
                    try
                    {
                        oUser.Usr_Id = (int)dgvUsuarios.CurrentRow.Cells["ID"].Value;
                        TrabajarUsuario.edit_usuario(oUser);
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
                        TrabajarUsuario.insert_usuario(oUser);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Los usuarios no pueden tener datos repetidos");
                    }
                }
                cmbRol_Id.SelectedValue = 1;
                txtUsuario_NombreUsuario.Text = "";
                txtUsuario_Contrasenia.Text = "";
                txtUsuario_ApellidoNombre.Text = "";
                load_usuarios();
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            String pattern = txtBusqueda.Text;
            load_usuarios(pattern);
        }

        private void btnUsuarioEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                edit = true;
                txtUsuario_NombreUsuario.Text = dgvUsuarios.CurrentRow.Cells["Nombre de usuario"].Value.ToString();
                txtUsuario_Contrasenia.Text = dgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtUsuario_ApellidoNombre.Text = dgvUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                cmbRol_Id.SelectedValue = dgvUsuarios.CurrentRow.Cells["ID Rol"].Value;
            }
            else 
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    TrabajarUsuario.delete_usuario((int)dgvUsuarios.CurrentRow.Cells["ID"].Value);
                    load_usuarios();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
