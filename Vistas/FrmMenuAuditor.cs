﻿using System;
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
    public partial class FrmMenuAuditor : Form
    {
        public FrmMenuAuditor()
        {
            InitializeComponent();
        }
        private void FrmMenuAudito_Load(object sender, EventArgs e)
        {
            load_everything();
        }
        private void load_everything() 
        {
            //inquilino
            load_inquilinos();
            //alquiler
            txtAlqPreciofinal.Enabled = false;
            load_combo_edificios();
            load_combo_departamentos((int)cmbAlqEdificio.SelectedValue);
            load_combo_inquilinos();
            dtpAlqDesde.Value = DateTime.Now;
            display_precioFinal();
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
            cmbDptoDisposicion.Text = "1";
        }

        //Botones del menu
        private void btnInq_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void btnAlq_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void btnEdif_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void btnDpto_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
                Program.oFrmLogin.Show();
            }
        }

        //Inquilinos
        private bool editInq = false;
        private void load_inquilinos(String pattern = "")
        {
            dgvInquilinos.DataSource = TrabajarInquilinos.list_inquilinos(pattern);
        }
        private void btnInqConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validarInq())
                {
                    Inquilino oInq = new Inquilino();
                    oInq.Inq_Nombre = txtInqNombre.Text;
                    oInq.Inq_Apellido = txtInqApellido.Text;
                    oInq.Inq_Telefono = txtInqTelefono.Text;
                    if (editInq)
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
                        editInq = false;
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
                    MessageBox.Show("Llenar todos los campos");
                }
            }
            load_everything();
        }
        private void btnInqEditar_Click(object sender, EventArgs e)
        {
            if (dgvInquilinos.SelectedRows.Count == 1)
            {
                editInq = true;
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
                    try
                    {
                        TrabajarInquilinos.delete_inquilino((int)dgvInquilinos.CurrentRow.Cells["Codigo"].Value);
                        load_inquilinos();
                    }
                    catch (Exception a) 
                    {
                        MessageBox.Show("No puede eliminar un Inquilino que ya alquilo un departamento");
                    } 
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
            load_everything();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            String pattern = txtBusqueda.Text;
            load_inquilinos(pattern);
        }
        private void btnInqOrdenar_Click(object sender, EventArgs e)
        {
            //dgvInquilinos.Sort(dgvInquilinos.Columns[1], ListSortDirection.Ascending);
            dgvInquilinos.DataSource = TrabajarInquilinos.list_inquilinosord();
        }
        private bool validarInq() 
        {
            return txtInqNombre.Text!=String.Empty && txtInqApellido.Text!=String.Empty && txtInqTelefono.Text!=String.Empty;
        }

        //Alquileres
        private void load_combo_edificios()
        {
            cmbAlqEdificio.ValueMember = "Edif_Codigo";
            cmbAlqEdificio.DisplayMember = "Edif_Nombre";
            cmbAlqEdificio.DataSource = TrabajarAlquiler.list_edificios();
        }
        private void load_combo_departamentos(int Edif_Codigo)
        {
            cmbAlqDepartamento.ValueMember = "Dpto_Codigo";
            cmbAlqDepartamento.DisplayMember = "Info";
            cmbAlqDepartamento.DataSource = TrabajarAlquiler.list_departamentos(Edif_Codigo);
        }
        private void load_combo_inquilinos()
        {
            cmbAlqInquilino.ValueMember = "Inq_Codigo";
            cmbAlqInquilino.DisplayMember = "Inq_Apellido";
            cmbAlqInquilino.DataSource = TrabajarAlquiler.list_inquilinos();
        }
        private void display_precioFinal()
        {
            txtAlqPreciofinal.Text = "$" + precioFinal().ToString();
        }
        private double precioFinal()
        {
            Departamento dpto = TrabajarAlquiler.get_departamento((int)cmbAlqDepartamento.SelectedValue);
            int meses = 0;
            DateTime desde = dtpAlqDesde.Value, hasta = dtpAlqHasta.Value;
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
        private void cmbAlqEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_combo_departamentos((int)cmbAlqEdificio.SelectedValue);
        }
        private void dtpAlqDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAlqDesde.Value <= DateTime.Now) dtpAlqDesde.Value = DateTime.Now;
            if (dtpAlqDesde.Value > dtpAlqHasta.Value) dtpAlqHasta.Value = dtpAlqDesde.Value.AddDays(1);
            display_precioFinal();
        }
        private void dtpAlqHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAlqHasta.Value <= DateTime.Now) dtpAlqHasta.Value = DateTime.Now;
            if (dtpAlqDesde.Value > dtpAlqHasta.Value) dtpAlqDesde.Value = dtpAlqHasta.Value.AddDays(-1);
            display_precioFinal();
        }
        private void cmbAlqDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_precioFinal();
        }
        private void btnAlqRegistrar_Click(object sender, EventArgs e)
        {
            Alquiler alq = new Alquiler();
            alq.Dpto_Codigo = (int)cmbAlqDepartamento.SelectedValue;
            alq.Inq_Codigo = (int)cmbAlqInquilino.SelectedValue;
            alq.Alq_FechaDesde = dtpAlqDesde.Value;
            alq.Alq_FechaHasta = dtpAlqHasta.Value;
            alq.Alq_Precio = precioFinal();
            if (MessageBox.Show("Confirmar datos", "¿Seguro que quieres registrar este alquiler?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                TrabajarAlquiler.insert_alquiler(alq);
                load_combo_edificios();
                load_combo_departamentos((int)cmbAlqEdificio.SelectedValue);
                load_combo_inquilinos();
                dtpAlqDesde.Value = DateTime.Now;
                dtpAlqHasta.Value = DateTime.Now.AddDays(1);
                display_precioFinal();
            }
            load_everything();
        }
        private void btnAlqRegistro_Click(object sender, EventArgs e)
        {
            FrmListAlquiler oFrmListAlquiler = new FrmListAlquiler();
            oFrmListAlquiler.Show();
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
            return txtUserBuscar.Text != String.Empty && txtUserContra.Text != String.Empty && txtUserNombreApellido.Text != String.Empty && txtUserNombreUsuario.Text != String.Empty;
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
            cmbDptoDisposicion.Items.Add(1);
            cmbDptoDisposicion.Items.Add(2);
            cmbDptoDisposicion.Items.Add(3);
            cmbDptoDisposicion.Items.Add(4);
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
                    oDpto.Dpto_Disposicion = Convert.ToInt32(cmbDptoDisposicion.Text);
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
                    cmbDptoDisposicion.Text = "1";
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
                cmbDptoDisposicion.Text = dgvDepartamentos.CurrentRow.Cells["Disposicion"].Value.ToString();
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
    }
}