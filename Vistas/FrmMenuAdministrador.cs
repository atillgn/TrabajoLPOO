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
    public partial class FrmMenuAdministrador : Form
    {
        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }
        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            load_everything();
        }
        private void load_everything()
        {
            //usuario
            load_combo_roles();
            load_usuarios();
            //edificio
            load_edificio();
            load_combo_Admin();
            //departamentos
            load_combo_TipoDpto();
            load_combo_edif();
            load_combo_disposicon();
            load_departamento();
        }

        //Botones del menu
        private void btnUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void btnEdif_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnDpto_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
                Program.oFrmLogin.Show();
            }
        }

        //Usuarios
        private bool editUser = false;
        private void load_combo_roles()
        {
            cmbUserRol.DisplayMember = "Rol_Descripcion";
            cmbUserRol.ValueMember = "Rol_Codigo";
            cmbUserRol.DataSource = TrabajarUsuario.list_roles();
        }
        private void load_usuarios(String pattern = "")
        {
            dgvUsuarios.DataSource = TrabajarUsuario.list_usuarios(pattern);
        }
        private void btnUserRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validarUser())
                {
                    Usuario oUser = new Usuario();
                    oUser.Rol_id = (int)cmbUserRol.SelectedValue;
                    oUser.Usr_NombreUsuario = txtUserNombreUsuario.Text;
                    oUser.Usr_Contrasenia = txtUserContra.Text;
                    oUser.Usr_ApellidoNombre = txtUserNombreApellido.Text;
                    if (editUser)
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
                        editUser = false;
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
                    cmbUserRol.SelectedValue = 1;
                    txtUserNombreUsuario.Text = "";
                    txtUserContra.Text = "";
                    txtUserNombreApellido.Text = "";
                    load_usuarios();
                }
                else
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
            load_everything();
        }
        private void btnUserBuscar_Click(object sender, EventArgs e)
        {
            String pattern = txtUserBuscar.Text;
            load_usuarios(pattern);
        }
        private void btnUserEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                editUser = true;
                txtUserNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells["Nombre_de_usuario"].Value.ToString();
                txtUserContra.Text = dgvUsuarios.CurrentRow.Cells["Contrasenia"].Value.ToString();
                txtUserNombreApellido.Text = dgvUsuarios.CurrentRow.Cells["Apellido_y_Nombre"].Value.ToString();
                cmbUserRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["Rol_ID"].Value;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private void btnUserEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        TrabajarUsuario.delete_usuario((int)dgvUsuarios.CurrentRow.Cells["ID"].Value);
                        load_usuarios();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No puede eliminar un Usuario que Administra un Edificio");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            load_everything();
        }
        private bool validarUser()
        {
            return txtUserContra.Text != String.Empty && txtUserNombreApellido.Text != String.Empty && txtUserNombreUsuario.Text != String.Empty;
        }

        //Edificios
        private bool editEdif = false;
        private void load_combo_Admin()
        {
            cmbEdifAdministrador.ValueMember = "Nombre_de_usuario";
            cmbEdifAdministrador.DisplayMember = "Apellido_y_Nombre";
            cmbEdifAdministrador.DataSource = TrabajarEdificios.list_admin();
        }
        private void load_edificio()
        {
            dgvEdificio.DataSource = TrabajarEdificios.list_edificios();
        }
        private void btnEdifAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validarEdif())
                {
                    Edificio oEdif = new Edificio();
                    oEdif.Edif_Nombre = txtEdifNombre.Text;
                    oEdif.Edif_Direccion = txtEdifDireccion.Text;
                    oEdif.Edif_Admnistrador = cmbEdifAdministrador.SelectedValue.ToString();
                    oEdif.Edif_Telefono = txtEdifTelefono.Text;
                    if (editEdif)
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
                        editEdif = false;
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
                    txtEdifNombre.Text = "";
                    txtEdifDireccion.Text = "";
                    txtEdifTelefono.Text = "";
                    cmbEdifAdministrador.SelectedValue = 1;
                    load_edificio();
                }
                else
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos.");
            }
            load_everything();
        }
        private void btnEdifEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEdificio.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        TrabajarEdificios.delete_edificio((int)dgvEdificio.CurrentRow.Cells["Edif_Codigo"].Value);
                        load_edificio();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No puede eliminar un Edificio que esta siendo alquilado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            load_everything();
        }
        private void btnEdifEditar_Click(object sender, EventArgs e)
        {
            if (dgvEdificio.SelectedRows.Count == 1)
            {
                editEdif = true;
                txtEdifNombre.Text = dgvEdificio.CurrentRow.Cells["Edif_Nombre"].Value.ToString();
                txtEdifDireccion.Text = dgvEdificio.CurrentRow.Cells["Edif_Direccion"].Value.ToString();
                txtEdifTelefono.Text = dgvEdificio.CurrentRow.Cells["Edif_Telefono"].Value.ToString();
                cmbEdifAdministrador.SelectedValue = dgvEdificio.CurrentRow.Cells["Edif_Administrador"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private bool validarEdif()
        {
            return txtEdifDireccion.Text != String.Empty && txtEdifNombre.Text != String.Empty && txtEdifTelefono.Text != String.Empty;
        }

        //Departamentos
        private bool editDpto = false;
        private void load_combo_TipoDpto()
        {
            cmbDptoTipo.ValueMember = "TipoD_Codigo";
            cmbDptoTipo.DisplayMember = "TipoD_Descripcion";
            cmbDptoTipo.DataSource = TrabajarDepartamento.list_tipo_departamento();
        }
        private void load_combo_edif()
        {
            cmbDptoEdificio.ValueMember = "Edif_Codigo";
            cmbDptoEdificio.DisplayMember = "Edif_Nombre";
            cmbDptoEdificio.DataSource = TrabajarDepartamento.list_edificios();
        }
        private void load_combo_disposicon()
        {
            cmbDptoDisposicion.ValueMember = "Disp_Codigo";
            cmbDptoDisposicion.DisplayMember = "Disp_Descripcion";
            cmbDptoDisposicion.DataSource = TrabajarDepartamento.list_disposicion();
        }
        private void load_departamento()
        {
            dgvDepartamentos.DataSource = TrabajarDepartamento.list_dpto();
        }
        private void btnDptoRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validarDpto())
                {
                    Departamento oDpto = new Departamento();
                    oDpto.Edif_Codigo = (int)cmbDptoEdificio.SelectedValue;
                    oDpto.Dpto_Tipo = (int)cmbDptoTipo.SelectedValue;
                    oDpto.Dpto_Numero = Convert.ToInt32(txtDptoNumero.Text);
                    oDpto.Dpto_Piso = Convert.ToInt32(txtDptoPiso.Text);
                    oDpto.Dpto_Ambientes = Convert.ToInt32(txtDptoAmbientes.Text);
                    oDpto.Dpto_Dormitorios = Convert.ToInt32(txtDptoDormitorios.Text);
                    oDpto.Dpto_Baños = Convert.ToInt32(txtDptoBaños.Text);
                    oDpto.Dpto_Disposicion = (int)cmbDptoDisposicion.SelectedValue;
                    oDpto.Dpto_Precio = Convert.ToDouble(txtDptoPrecio.Text);
                    if (editDpto)
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
                        editDpto = false;
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
                    cmbDptoEdificio.SelectedValue = 1;
                    txtDptoNumero.Text = "";
                    txtDptoPiso.Text = "";
                    txtDptoDormitorios.Text = "";
                    txtDptoBaños.Text = "";
                    txtDptoPrecio.Text = "";
                    txtDptoAmbientes.Text = "";
                    load_departamento();
                }
                else
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
            load_everything();
        }
        private void btnDptoEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        TrabajarDepartamento.delete_depto((int)dgvDepartamentos.CurrentRow.Cells["Codigo"].Value);
                        load_departamento();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No puede eliminar un Departamento que esta siendo alquilado");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            load_everything();
        }
        private void btnDptoEditar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count == 1)
            {
                editDpto = true;
                cmbDptoEdificio.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Codigo_Edificio"].Value;
                txtDptoNumero.Text = dgvDepartamentos.CurrentRow.Cells["Numero"].Value.ToString();
                txtDptoDormitorios.Text = dgvDepartamentos.CurrentRow.Cells["Dormitorios"].Value.ToString();
                txtDptoBaños.Text = dgvDepartamentos.CurrentRow.Cells["Banios"].Value.ToString();
                txtDptoPiso.Text = dgvDepartamentos.CurrentRow.Cells["Piso"].Value.ToString();
                txtDptoAmbientes.Text = dgvDepartamentos.CurrentRow.Cells["Ambientes"].Value.ToString();
                txtDptoPrecio.Text = dgvDepartamentos.CurrentRow.Cells["Precio"].Value.ToString();
                cmbDptoDisposicion.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Disposicion"].Value;
                cmbDptoTipo.SelectedValue = dgvDepartamentos.CurrentRow.Cells["Tipo"].Value;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
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
        private void txtDptoAmbientes_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool validarDpto()
        {
            return txtDptoAmbientes.Text != String.Empty && txtDptoBaños.Text != String.Empty && txtDptoDormitorios.Text != String.Empty && txtDptoNumero.Text != String.Empty && txtDptoPiso.Text != String.Empty && txtDptoPrecio.Text != String.Empty;
        }
        private void btnTipoDepartamento_Click(object sender, EventArgs e)
        {
            FrmGestionTipoDpto oFormGestionTipoDpto = new FrmGestionTipoDpto();
            oFormGestionTipoDpto.Show();
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