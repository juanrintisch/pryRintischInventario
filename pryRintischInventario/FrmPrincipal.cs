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

                                  
            if (mskCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || mskPrecio.Text == "" || mskCantidad.Text == "" || cmbCategoria.SelectedIndex == -1)
            {
              mskCodigo.Focus();
              txtNombre.Focus();
              txtDescripcion.Focus();
              mskPrecio.Focus();
              mskCantidad.Focus();
              cmbCategoria.Focus();

              MessageBox.Show("Por favor, complete todos los campos.");
              return;
                
            }

            lblRegistroFinal.Text= mskCodigo.Text 
                + '/' + txtNombre.Text 
                + '/' + txtDescripcion.Text 
                + '/' + mskPrecio.Text 
                + '/' + mskCantidad.Text
                + '/' + cmbCategoria.Text;

            varCodigo =int.Parse(mskCodigo.Text);
            varNombre = txtNombre.Text;
            varDescripcion = txtDescripcion.Text;
            varPrecio =int.Parse(mskPrecio.Text);
            varCantidad = int.Parse(mskCantidad.Text);
            varCategoria = cmbCategoria.Text;

            lblVariables.Text = varCodigo.ToString()
                + "/" + varNombre 
                + "/" + varDescripcion 
                + "/" + varPrecio.ToString() 
                + "/" + varCantidad.ToString() 
                + "/" + varCategoria;

            mskCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            mskPrecio.Clear();
            mskCantidad.Clear();
            cmbCategoria.SelectedIndex = -1;

            MessageBox.Show("Producto Agregado");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lblRegistroFinal.Text = "";
            lblVariables.Text = "";
        }

        private void lblRegistroFinal_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
