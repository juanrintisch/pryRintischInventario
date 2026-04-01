namespace pryRintischInventario
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.grpTodo = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.grpTodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTodo
            // 
            this.grpTodo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpTodo.BackgroundImage = global::pryRintischInventario.Properties.Resources.inside_view_of_an_empty_cardboard_box_free_photo;
            this.grpTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTodo.Controls.Add(this.maskedTextBox3);
            this.grpTodo.Controls.Add(this.maskedTextBox2);
            this.grpTodo.Controls.Add(this.maskedTextBox1);
            this.grpTodo.Controls.Add(this.lblSignoPesos);
            this.grpTodo.Controls.Add(this.cmbCategoria);
            this.grpTodo.Controls.Add(this.txtNombre);
            this.grpTodo.Controls.Add(this.txtDescripcion);
            this.grpTodo.Controls.Add(this.lblCategoria);
            this.grpTodo.Controls.Add(this.lblStock);
            this.grpTodo.Controls.Add(this.lblPrecio);
            this.grpTodo.Controls.Add(this.lblDescripcion);
            this.grpTodo.Controls.Add(this.lblCodigo);
            this.grpTodo.Controls.Add(this.lblNombres);
            this.grpTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTodo.Location = new System.Drawing.Point(142, 76);
            this.grpTodo.Name = "grpTodo";
            this.grpTodo.Size = new System.Drawing.Size(452, 370);
            this.grpTodo.TabIndex = 0;
            this.grpTodo.TabStop = false;
            this.grpTodo.Enter += new System.EventHandler(this.GrpTodo_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(196, 101);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(173, 70);
            this.txtDescripcion.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Tan;
            this.lblCategoria.Location = new System.Drawing.Point(16, 267);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(169, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria Del Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Tan;
            this.lblStock.Location = new System.Drawing.Point(16, 223);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(148, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Cantidad Disponible";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Tan;
            this.lblPrecio.Location = new System.Drawing.Point(16, 179);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(146, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio Del Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Tan;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 107);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion Del Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Tan;
            this.lblCodigo.Location = new System.Drawing.Point(6, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(151, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo Del Producto";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Tan;
            this.lblNombres.Location = new System.Drawing.Point(6, 62);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(156, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombre Del Producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(196, 264);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 11;
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.BackColor = System.Drawing.Color.Tan;
            this.lblSignoPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoPesos.Location = new System.Drawing.Point(281, 179);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(19, 20);
            this.lblSignoPesos.TabIndex = 12;
            this.lblSignoPesos.Text = "$";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(196, 223);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(79, 22);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(196, 179);
            this.maskedTextBox2.Mask = "99999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(79, 22);
            this.maskedTextBox2.TabIndex = 14;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(196, 15);
            this.maskedTextBox3.Mask = "99999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(79, 22);
            this.maskedTextBox3.TabIndex = 15;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRintischInventario.Properties.Resources.como_poner_en_marcha_un_pequeno_almacen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 537);
            this.Controls.Add(this.grpTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.grpTodo.ResumeLayout(false);
            this.grpTodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTodo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
    }
}

