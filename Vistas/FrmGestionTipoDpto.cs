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
    public partial class FrmGestionTipoDpto : Form
    {
        public FrmGestionTipoDpto()
        {
            InitializeComponent();
        }
        private void FrmGestionTipoDpto_Load(object sender, EventArgs e)
        {
            load_TipoDpto();  
        }
        private void load_TipoDpto() 
        { 
            dgvTipoDpto.DataSource = TrabajarTipoDepartamento.list_tipoDpto();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool edit = false;
        private void btnTipoDptoGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Datos", "¿Confirmar Datos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (validarTipoDpto())
                {
                    TipoDepartamento oTipoDpto = new TipoDepartamento();
                    oTipoDpto.tipoD_Descripcion = txtTipoDptoDescripcion.Text;
                    if (edit)
                    {
                        try
                        {
                            oTipoDpto.tipoD_Codigo = (int) dgvTipoDpto.CurrentRow.Cells["TipoD_Codigo"].Value;
                            TrabajarTipoDepartamento.edit_tipoDpto(oTipoDpto);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Los Tipos de Departamento no pueden tener datos repetidos");
                        }
                        edit = false;
                    }
                    else
                    {
                        try
                        {
                            TrabajarTipoDepartamento.insert_tipoDpto(oTipoDpto);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Los Tipos de Departamento no pueden tener datos repetidos");
                        }
                    }
                    txtTipoDptoDescripcion.Text = "";
                    load_TipoDpto();
                }
                else
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
        }
        private void btnTipoDptoEditar_Click(object sender, EventArgs e)
        {
            if (dgvTipoDpto.SelectedRows.Count == 1)
            {
                edit = true;
                txtTipoDptoDescripcion.Text = dgvTipoDpto.CurrentRow.Cells["TipoD_Descripcion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private void btnTipoDptoEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipoDpto.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("¿Desea eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        TrabajarTipoDepartamento.delete_tipoDpto((int)dgvTipoDpto.CurrentRow.Cells["TipoD_Codigo"].Value);
                        load_TipoDpto();
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("No puede eliminar un Tipo de Departamento que esta en uso");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        private bool validarTipoDpto()
        {
            return txtTipoDptoDescripcion.Text != String.Empty;
        }
    }
}
