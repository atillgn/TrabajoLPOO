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
    public partial class FrmMenuOperador : Form
    {
        public FrmMenuOperador()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 2;
        }
        private void FrmMenuOperador_Load(object sender, EventArgs e)
        {
            load_everything();
        }
        public void load_everything()
        {
            //inquilino
            load_inquilinos();
            //alquiler
            txtAlqPreciofinal.Enabled = false;
            load_combo_edificios();
            if (cmbAlqEdificio.SelectedValue == null)
            {
                load_combo_departamentos(0);
            }
            else
            {
                load_combo_departamentos((int)cmbAlqEdificio.SelectedValue);
            }
            load_combo_inquilinos();
            dtpAlqDesde.Value = DateTime.Now;
            display_precioFinal();
        }
        //Boton activo
        private Button currentButton;

        private void activeButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    disableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(51, 51, 155);
                }
            }
        }

        private void disableButton()
        {
            foreach (Control previousBtn in panel4.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 50, 90);
                }
            }
        }

        //Botones del menu
        private void btnInq_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            activeButton(sender);
        }
        private void btnAlq_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            activeButton(sender);
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
                        btnInqEliminar.Enabled = true;
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
                if (dgvInquilinos.RowCount > 1)
                {
                    editInq = true;
                    txtInqApellido.Text = dgvInquilinos.CurrentRow.Cells["Apellido"].Value.ToString();
                    txtInqNombre.Text = dgvInquilinos.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtInqTelefono.Text = dgvInquilinos.CurrentRow.Cells["Telefono"].Value.ToString();
                    btnInqEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La tabla esta vacia");
                }
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
                        if (dgvInquilinos.RowCount > 1)
                        {
                            TrabajarInquilinos.delete_inquilino((int)dgvInquilinos.CurrentRow.Cells["Codigo"].Value);
                            load_inquilinos();
                        }
                        else
                        {
                            MessageBox.Show("La tabla esta vacia");
                        }
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
            dgvInquilinos.DataSource = TrabajarInquilinos.list_inquilinosord();
        }
        private bool validarInq()
        {
            return txtInqNombre.Text != String.Empty && txtInqApellido.Text != String.Empty && txtInqTelefono.Text != String.Empty;
        }

        //Alquileres
        private void load_combo_edificios()
        {
            cmbAlqEdificio.ValueMember = "Edif_Codigo";
            cmbAlqEdificio.DisplayMember = "Edif_Nombre";
            DataTable dt = new DataTable();
            dt = TrabajarAlquiler.list_edificios();
            if (dt.Rows.Count >= 1)
            {
                cmbAlqEdificio.DataSource = dt;
                cmbAlqEdificio.Enabled = true;
                cmbAlqDepartamento.Enabled = true;
                dtpAlqDesde.Enabled = true;
                dtpAlqHasta.Enabled = true;
                btnAlqRegistrar.Enabled = true;
            }
            else
            {
                cmbAlqEdificio.Enabled = false;
                cmbAlqDepartamento.Enabled = false;
                dtpAlqDesde.Enabled = false;
                dtpAlqHasta.Enabled = false;
                btnAlqRegistrar.Enabled = false;
            }
        }
        private void load_combo_departamentos(int Edif_Codigo)
        {
            cmbAlqDepartamento.ValueMember = "Dpto_Codigo";
            cmbAlqDepartamento.DisplayMember = "Info";
            DataTable dt = new DataTable();
            dt = TrabajarAlquiler.list_departamentos(Edif_Codigo);
            if (dt.Rows.Count >= 1)
            {
                cmbAlqDepartamento.DataSource = dt;
                cmbAlqDepartamento.Enabled = true;
                dtpAlqDesde.Enabled = true;
                dtpAlqHasta.Enabled = true;
                btnAlqRegistrar.Enabled = true;
            }
            else
            {
                cmbAlqDepartamento.Enabled = false;
                dtpAlqDesde.Enabled = false;
                dtpAlqHasta.Enabled = false;
                btnAlqRegistrar.Enabled = false;
            }
        }
        private void load_combo_inquilinos()
        {
            cmbAlqInquilino.ValueMember = "Inq_Codigo";
            cmbAlqInquilino.DisplayMember = "Inq_Apellido";
            DataTable dt = new DataTable();
            dt = TrabajarAlquiler.list_inquilinos();
            if (dt.Rows.Count >= 1)
            {
                cmbAlqInquilino.DataSource = dt;
                cmbAlqInquilino.Enabled = true;
                btnAlqRegistrar.Enabled = true;
            }
            else
            {
                cmbAlqInquilino.Enabled = false;
                btnAlqRegistrar.Enabled = false;
            }
        }
        private void display_precioFinal()
        {
            txtAlqPreciofinal.Text = "$" + precioFinal().ToString();
        }
        private double precioFinal()
        {
            Departamento dpto;
            try
            {
                dpto = TrabajarAlquiler.get_departamento((int)cmbAlqDepartamento.SelectedValue);
                int meses = 0;
                DateTime desde = dtpAlqDesde.Value, hasta = dtpAlqHasta.Value;
                while (desde.AddMonths(1) < hasta)
                {
                    meses++;
                    desde = desde.AddMonths(1);
                }
                int dias = 1;
                while (desde.AddDays(1) < hasta)
                {
                    dias++;
                    desde = desde.AddDays(1);
                }
                double ret = dpto.Dpto_Precio * meses;
                ret += dpto.Dpto_Precio * dias / 31;
                return Math.Round(ret, 2);
            }
            catch (Exception a)
            {
                return 0;
            }
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
            if (validarAlquiler())
            {
                DataTable dt = new DataTable();
                dt = TrabajarAlquiler.valid_fechas(dtpAlqDesde.Value, dtpAlqHasta.Value, (int)cmbAlqDepartamento.SelectedValue);
                if (dt.Rows.Count == 0)
                {
                    Alquiler alq = new Alquiler();
                    alq.Dpto_Codigo = (int)cmbAlqDepartamento.SelectedValue;
                    alq.Inq_Codigo = (int)cmbAlqInquilino.SelectedValue;
                    alq.Alq_FechaDesde = dtpAlqDesde.Value.Date;
                    dtpAlqHasta.Value = dtpAlqHasta.Value.AddSeconds(59 - dtpAlqHasta.Value.Second);
                    dtpAlqHasta.Value = dtpAlqHasta.Value.AddMinutes(59 - dtpAlqHasta.Value.Minute);
                    dtpAlqHasta.Value = dtpAlqHasta.Value.AddHours(23 - dtpAlqHasta.Value.Hour);
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
                else
                {
                    MessageBox.Show("Ya hay un alquiler en el rango de fechas ingresado");
                }
            }
            else
            {
                MessageBox.Show("Llenar todos los campos");
            }
        }
        private void btnAlqRegistro_Click(object sender, EventArgs e)
        {
            FrmListAlquiler oFrmListAlquiler = new FrmListAlquiler(2);
            oFrmListAlquiler.Show();
            this.Close();
        }
        private void btnBuscarDpto_Click(object sender, EventArgs e)
        {
            FrmBuscarDepartamento oFrmListAlquiler = new FrmBuscarDepartamento(2);
            oFrmListAlquiler.Show();
            this.Close();
        }
        private bool validarAlquiler()
        {
            return cmbAlqDepartamento.SelectedValue != null && cmbAlqEdificio.SelectedValue != null && cmbAlqInquilino.SelectedValue != null;
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
