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
            txtNombre.Enabled = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
