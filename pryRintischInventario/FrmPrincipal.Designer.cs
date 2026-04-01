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
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpTodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTodo
            // 
            this.grpTodo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpTodo.BackgroundImage = global::pryRintischInventario.Properties.Resources.inside_view_of_an_empty_cardboard_box_free_photo;
            this.grpTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTodo.Controls.Add(this.btnEliminar);
            this.grpTodo.Controls.Add(this.btnModificar);
            this.grpTodo.Controls.Add(this.btnAgregar);
            this.grpTodo.Controls.Add(this.mskCodigo);
            this.grpTodo.Controls.Add(this.mskPrecio);
            this.grpTodo.Controls.Add(this.mskCantidad);
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
            this.grpTodo.Location = new System.Drawing.Point(134, 76);
            this.grpTodo.Name = "grpTodo";
            this.grpTodo.Size = new System.Drawing.Size(486, 391);
            this.grpTodo.TabIndex = 0;
            this.grpTodo.TabStop = false;
            this.grpTodo.Enter += new System.EventHandler(this.GrpTodo_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(217, 104);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 62);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Tan;
            this.lblCategoria.Location = new System.Drawing.Point(6, 267);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(169, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria Del Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Tan;
            this.lblStock.Location = new System.Drawing.Point(6, 223);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(148, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Cantidad Disponible";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Tan;
            this.lblPrecio.Location = new System.Drawing.Point(6, 179);
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
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alimento",
            "Hogar",
            "Tecnologia",
            "Exterior",
            "Decoracion",
            " "});
            this.cmbCategoria.Location = new System.Drawing.Point(217, 264);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.BackColor = System.Drawing.Color.Tan;
            this.lblSignoPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoPesos.Location = new System.Drawing.Point(192, 178);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(19, 20);
            this.lblSignoPesos.TabIndex = 12;
            this.lblSignoPesos.Text = "$";
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(217, 220);
            this.mskCantidad.Mask = "99999";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(79, 22);
            this.mskCantidad.TabIndex = 4;
            this.mskCantidad.ValidatingType = typeof(int);
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(217, 178);
            this.mskPrecio.Mask = "99999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(79, 22);
            this.mskPrecio.TabIndex = 3;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(217, 15);
            this.mskCodigo.Mask = "99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(79, 22);
            this.mskCodigo.TabIndex = 0;
            this.mskCodigo.ValidatingType = typeof(int);
            this.mskCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigo_MaskInputRejected);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Location = new System.Drawing.Point(42, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.Location = new System.Drawing.Point(196, 318);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 40);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(347, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.MaskedTextBox mskCantidad;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

