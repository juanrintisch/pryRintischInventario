using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRintischInventario
{
    public partial class FrmPrincipal : Form
    {
        // Variables Globales
        int varCodigo = 0;
        string varNombre = "";
        string varDescripcion = "";
        int varPrecio = 0;
        int varCantidad = 0;
        string varCategoria = "";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void GrpTodo_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mskCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (mskCodigo.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese el Codigo del Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCodigo.Focus();
                return;
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese el Nombre del Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese la Descripcion del Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return;
            }
            else if (mskPrecio.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese el Precio del Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskPrecio.Focus();
                return;
            }
            else if (mskCantidad.Text == "")
            {
                MessageBox.Show("Por Favor Ingrese la Cantidad del Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCantidad.Focus();
                return;
            }
            else if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por Favor Seleccione una Categoria para el Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategoria.Focus();
                return;
            }
                        
            dtaDatos.Rows.Add(mskCodigo.Text, txtNombre.Text, txtDescripcion.Text, mskPrecio.Text, mskCantidad.Text, cmbCategoria.SelectedItem.ToString());

            mskCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            mskPrecio.Clear();
            mskCantidad.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Producto Agregado Correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            mskCodigo.Focus();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            var Resultado = MessageBox.Show("¿Está Seguro que Desea Eliminar el Producto?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Resultado == DialogResult.Yes)
            {
                dtaDatos.Rows.RemoveAt(dtaDatos.CurrentRow.Index);
                MessageBox.Show("Producto Eliminado Correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                mskPrecio.Clear();
                mskCantidad.Clear();
                cmbCategoria.SelectedIndex = -1;
                mskCodigo.Focus();
            }
            else
            {
                MessageBox.Show("El Producto No Fue Eliminado", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
            
        

        private void lblRegistroFinal_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Sistema de Inventario de Mercado Libre", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
            mskCodigo.Text = dtaDatos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtaDatos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtaDatos.CurrentRow.Cells[2].Value.ToString();
            mskPrecio.Text = dtaDatos.CurrentRow.Cells[3].Value.ToString();
            mskCantidad.Text = dtaDatos.CurrentRow.Cells[4].Value.ToString();
            cmbCategoria.SelectedItem = dtaDatos.CurrentRow.Cells[5].Value.ToString();
            
            btnModificarDos.Enabled = true;

        }

        private void btnModificarDos_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Está Seguro que Desea Modificar el Producto?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (Resultado == DialogResult.Yes)
            {
                dtaDatos.CurrentRow.Cells[0].Value = mskCodigo.Text;
                dtaDatos.CurrentRow.Cells[1].Value = txtNombre.Text;
                dtaDatos.CurrentRow.Cells[2].Value = txtDescripcion.Text;
                dtaDatos.CurrentRow.Cells[3].Value = mskPrecio.Text;
                dtaDatos.CurrentRow.Cells[4].Value = mskCantidad.Text;
                dtaDatos.CurrentRow.Cells[5].Value = cmbCategoria.SelectedItem.ToString();

                MessageBox.Show("Producto Modificado Correctamente", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mskCodigo.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                mskPrecio.Clear();
                mskCantidad.Clear();
                cmbCategoria.SelectedIndex = -1;

                mskCodigo.Focus();

                btnModificarDos.Enabled = false;

            }
            else
            {
                MessageBox.Show("No Se Modifico el Producto", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
