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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.grpTabla = new System.Windows.Forms.GroupBox();
            this.dtaDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnModificarDos = new System.Windows.Forms.Button();
            this.grpTodo.SuspendLayout();
            this.grpTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTodo
            // 
            this.grpTodo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTodo.BackgroundImage = global::pryRintischInventario.Properties.Resources.inside_view_of_an_empty_cardboard_box_free_photo;
            this.grpTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTodo.Controls.Add(this.btnEliminar);
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
            this.grpTodo.Location = new System.Drawing.Point(12, 12);
            this.grpTodo.Name = "grpTodo";
            this.grpTodo.Size = new System.Drawing.Size(486, 374);
            this.grpTodo.TabIndex = 0;
            this.grpTodo.TabStop = false;
            this.grpTodo.Enter += new System.EventHandler(this.GrpTodo_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(296, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 39);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(90, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 39);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(217, 18);
            this.mskCodigo.Mask = "99999999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(121, 22);
            this.mskCodigo.TabIndex = 0;
            this.mskCodigo.ValidatingType = typeof(int);
            this.mskCodigo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigo_MaskInputRejected);
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(238, 178);
            this.mskPrecio.Mask = "99999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(79, 22);
            this.mskPrecio.TabIndex = 3;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // mskCantidad
            // 
            this.mskCantidad.Location = new System.Drawing.Point(217, 219);
            this.mskCantidad.Mask = "99999";
            this.mskCantidad.Name = "mskCantidad";
            this.mskCantidad.Size = new System.Drawing.Size(79, 22);
            this.mskCantidad.TabIndex = 4;
            this.mskCantidad.ValidatingType = typeof(int);
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.BackColor = System.Drawing.Color.Tan;
            this.lblSignoPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoPesos.Location = new System.Drawing.Point(213, 180);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(19, 20);
            this.lblSignoPesos.TabIndex = 12;
            this.lblSignoPesos.Text = "$";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Hogar",
            "Alimentos",
            "Decoracion",
            "Exterior",
            "Macotas",
            "Vehiculo",
            "Tecnologia"});
            this.cmbCategoria.Location = new System.Drawing.Point(217, 260);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(217, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(217, 97);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 62);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Tan;
            this.lblCategoria.Location = new System.Drawing.Point(6, 268);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(169, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria Del Producto";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Tan;
            this.lblStock.Location = new System.Drawing.Point(6, 222);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(148, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Cantidad Disponible";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Tan;
            this.lblPrecio.Location = new System.Drawing.Point(6, 182);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(146, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio Del Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Tan;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción Del Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Tan;
            this.lblCodigo.Location = new System.Drawing.Point(6, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(151, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código Del Producto";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Tan;
            this.lblNombres.Location = new System.Drawing.Point(6, 56);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(156, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombre Del Producto";
            // 
            // grpTabla
            // 
            this.grpTabla.BackgroundImage = global::pryRintischInventario.Properties.Resources.inside_view_of_an_empty_cardboard_box_free_photo;
            this.grpTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTabla.Controls.Add(this.btnModificarDos);
            this.grpTabla.Controls.Add(this.btnModificar);
            this.grpTabla.Controls.Add(this.dtaDatos);
            this.grpTabla.Location = new System.Drawing.Point(504, 12);
            this.grpTabla.Name = "grpTabla";
            this.grpTabla.Size = new System.Drawing.Size(684, 374);
            this.grpTabla.TabIndex = 1;
            this.grpTabla.TabStop = false;
            // 
            // dtaDatos
            // 
            this.dtaDatos.AllowUserToAddRows = false;
            this.dtaDatos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Categoria});
            this.dtaDatos.Location = new System.Drawing.Point(19, 18);
            this.dtaDatos.Name = "dtaDatos";
            this.dtaDatos.Size = new System.Drawing.Size(646, 295);
            this.dtaDatos.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Moccasin;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(19, 319);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 39);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.Text = "MODIFICAR DATOS";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModificarDos
            // 
            this.btnModificarDos.BackColor = System.Drawing.Color.Moccasin;
            this.btnModificarDos.Enabled = false;
            this.btnModificarDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDos.Location = new System.Drawing.Point(125, 319);
            this.btnModificarDos.Name = "btnModificarDos";
            this.btnModificarDos.Size = new System.Drawing.Size(100, 39);
            this.btnModificarDos.TabIndex = 1;
            this.btnModificarDos.Text = "CONFIRMAR";
            this.btnModificarDos.UseVisualStyleBackColor = false;
            this.btnModificarDos.Click += new System.EventHandler(this.btnModificarDos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryRintischInventario.Properties.Resources.como_poner_en_marcha_un_pequeno_almacen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 405);
            this.Controls.Add(this.grpTabla);
            this.Controls.Add(this.grpTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grpTodo.ResumeLayout(false);
            this.grpTodo.PerformLayout();
            this.grpTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grpTabla;
        private System.Windows.Forms.DataGridView dtaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Button btnModificarDos;
        private System.Windows.Forms.Button btnModificar;
    }
}

