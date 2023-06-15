namespace Ferrete2.Formularios
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_TituloProductos = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_menuVertical = new System.Windows.Forms.Panel();
            this.dgv_Principal = new System.Windows.Forms.DataGridView();
            this.grpbx_AgregarProducto = new System.Windows.Forms.GroupBox();
            this.btn_CancelarGb = new System.Windows.Forms.Button();
            this.btn_GuardarGb = new System.Windows.Forms.Button();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.txb_Stock = new System.Windows.Forms.TextBox();
            this.txb_Precio = new System.Windows.Forms.TextBox();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.gpbx_modificarProducto = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_productoAModificar = new System.Windows.Forms.TextBox();
            this.btn_CancelarModificado = new System.Windows.Forms.Button();
            this.btn_GuardarModificado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_stockAModificar = new System.Windows.Forms.TextBox();
            this.txb_precioAModificar = new System.Windows.Forms.TextBox();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.lbl_PrecioDolar = new System.Windows.Forms.Label();
            this.lbl_ValorDolar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnl_menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).BeginInit();
            this.grpbx_AgregarProducto.SuspendLayout();
            this.gpbx_modificarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TituloProductos
            // 
            this.lbl_TituloProductos.AutoSize = true;
            this.lbl_TituloProductos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TituloProductos.Location = new System.Drawing.Point(414, 9);
            this.lbl_TituloProductos.Name = "lbl_TituloProductos";
            this.lbl_TituloProductos.Size = new System.Drawing.Size(223, 41);
            this.lbl_TituloProductos.TabIndex = 0;
            this.lbl_TituloProductos.Text = "PRODUCTOS";
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cerrar.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cerrar.Location = new System.Drawing.Point(982, 9);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(18, 20);
            this.lbl_cerrar.TabIndex = 3;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(0, 262);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(250, 49);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 206);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(250, 49);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(0, 150);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(250, 49);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(0, 94);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(250, 49);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 60);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnl_menuVertical
            // 
            this.pnl_menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnl_menuVertical.Controls.Add(this.btn_Guardar);
            this.pnl_menuVertical.Controls.Add(this.btn_Eliminar);
            this.pnl_menuVertical.Controls.Add(this.btn_Modificar);
            this.pnl_menuVertical.Controls.Add(this.btn_agregar);
            this.pnl_menuVertical.Controls.Add(this.pictureBox2);
            this.pnl_menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnl_menuVertical.Name = "pnl_menuVertical";
            this.pnl_menuVertical.Size = new System.Drawing.Size(250, 450);
            this.pnl_menuVertical.TabIndex = 4;
            // 
            // dgv_Principal
            // 
            this.dgv_Principal.AllowUserToAddRows = false;
            this.dgv_Principal.AllowUserToDeleteRows = false;
            this.dgv_Principal.AllowUserToOrderColumns = true;
            this.dgv_Principal.AllowUserToResizeColumns = false;
            this.dgv_Principal.AllowUserToResizeRows = false;
            this.dgv_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_Principal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Principal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Principal.EnableHeadersVisualStyles = false;
            this.dgv_Principal.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Principal.Location = new System.Drawing.Point(283, 57);
            this.dgv_Principal.Name = "dgv_Principal";
            this.dgv_Principal.ReadOnly = true;
            this.dgv_Principal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Principal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Principal.RowHeadersVisible = false;
            this.dgv_Principal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.dgv_Principal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Principal.RowTemplate.Height = 25;
            this.dgv_Principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Principal.Size = new System.Drawing.Size(381, 381);
            this.dgv_Principal.TabIndex = 5;
            // 
            // grpbx_AgregarProducto
            // 
            this.grpbx_AgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_AgregarProducto.Controls.Add(this.btn_CancelarGb);
            this.grpbx_AgregarProducto.Controls.Add(this.btn_GuardarGb);
            this.grpbx_AgregarProducto.Controls.Add(this.lbl_Stock);
            this.grpbx_AgregarProducto.Controls.Add(this.lbl_Precio);
            this.grpbx_AgregarProducto.Controls.Add(this.lbl_Producto);
            this.grpbx_AgregarProducto.Controls.Add(this.txb_Stock);
            this.grpbx_AgregarProducto.Controls.Add(this.txb_Precio);
            this.grpbx_AgregarProducto.Controls.Add(this.txb_Descripcion);
            this.grpbx_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbx_AgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbx_AgregarProducto.Location = new System.Drawing.Point(734, 94);
            this.grpbx_AgregarProducto.Name = "grpbx_AgregarProducto";
            this.grpbx_AgregarProducto.Size = new System.Drawing.Size(277, 217);
            this.grpbx_AgregarProducto.TabIndex = 6;
            this.grpbx_AgregarProducto.TabStop = false;
            this.grpbx_AgregarProducto.Text = "Agregar producto";
            // 
            // btn_CancelarGb
            // 
            this.btn_CancelarGb.FlatAppearance.BorderSize = 0;
            this.btn_CancelarGb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_CancelarGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarGb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarGb.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarGb.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarGb.Image")));
            this.btn_CancelarGb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarGb.Location = new System.Drawing.Point(144, 152);
            this.btn_CancelarGb.Name = "btn_CancelarGb";
            this.btn_CancelarGb.Size = new System.Drawing.Size(124, 49);
            this.btn_CancelarGb.TabIndex = 7;
            this.btn_CancelarGb.Text = "Cancelar";
            this.btn_CancelarGb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarGb.UseVisualStyleBackColor = true;
            this.btn_CancelarGb.Click += new System.EventHandler(this.btn_CancelarGb_Click);
            // 
            // btn_GuardarGb
            // 
            this.btn_GuardarGb.FlatAppearance.BorderSize = 0;
            this.btn_GuardarGb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_GuardarGb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarGb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarGb.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarGb.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarGb.Image")));
            this.btn_GuardarGb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarGb.Location = new System.Drawing.Point(6, 152);
            this.btn_GuardarGb.Name = "btn_GuardarGb";
            this.btn_GuardarGb.Size = new System.Drawing.Size(124, 49);
            this.btn_GuardarGb.TabIndex = 6;
            this.btn_GuardarGb.Text = "Guardar";
            this.btn_GuardarGb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarGb.UseVisualStyleBackColor = true;
            this.btn_GuardarGb.Click += new System.EventHandler(this.btn_GuardarGb_Click);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(20, 120);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(42, 17);
            this.lbl_Stock.TabIndex = 5;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(20, 75);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(46, 17);
            this.lbl_Precio.TabIndex = 4;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(20, 30);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(63, 17);
            this.lbl_Producto.TabIndex = 3;
            this.lbl_Producto.Text = "Producto";
            // 
            // txb_Stock
            // 
            this.txb_Stock.Location = new System.Drawing.Point(89, 112);
            this.txb_Stock.Name = "txb_Stock";
            this.txb_Stock.Size = new System.Drawing.Size(160, 22);
            this.txb_Stock.TabIndex = 2;
            // 
            // txb_Precio
            // 
            this.txb_Precio.Location = new System.Drawing.Point(89, 67);
            this.txb_Precio.Name = "txb_Precio";
            this.txb_Precio.Size = new System.Drawing.Size(160, 22);
            this.txb_Precio.TabIndex = 1;
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(89, 22);
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(160, 22);
            this.txb_Descripcion.TabIndex = 0;
            // 
            // gpbx_modificarProducto
            // 
            this.gpbx_modificarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbx_modificarProducto.Controls.Add(this.label3);
            this.gpbx_modificarProducto.Controls.Add(this.txb_productoAModificar);
            this.gpbx_modificarProducto.Controls.Add(this.btn_CancelarModificado);
            this.gpbx_modificarProducto.Controls.Add(this.btn_GuardarModificado);
            this.gpbx_modificarProducto.Controls.Add(this.label1);
            this.gpbx_modificarProducto.Controls.Add(this.label2);
            this.gpbx_modificarProducto.Controls.Add(this.txb_stockAModificar);
            this.gpbx_modificarProducto.Controls.Add(this.txb_precioAModificar);
            this.gpbx_modificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbx_modificarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbx_modificarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbx_modificarProducto.Location = new System.Drawing.Point(728, 94);
            this.gpbx_modificarProducto.Name = "gpbx_modificarProducto";
            this.gpbx_modificarProducto.Size = new System.Drawing.Size(277, 217);
            this.gpbx_modificarProducto.TabIndex = 8;
            this.gpbx_modificarProducto.TabStop = false;
            this.gpbx_modificarProducto.Text = "Modificar producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Producto";
            // 
            // txb_productoAModificar
            // 
            this.txb_productoAModificar.Location = new System.Drawing.Point(89, 21);
            this.txb_productoAModificar.Name = "txb_productoAModificar";
            this.txb_productoAModificar.Size = new System.Drawing.Size(160, 22);
            this.txb_productoAModificar.TabIndex = 8;
            // 
            // btn_CancelarModificado
            // 
            this.btn_CancelarModificado.FlatAppearance.BorderSize = 0;
            this.btn_CancelarModificado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_CancelarModificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarModificado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CancelarModificado.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarModificado.Image = ((System.Drawing.Image)(resources.GetObject("btn_CancelarModificado.Image")));
            this.btn_CancelarModificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelarModificado.Location = new System.Drawing.Point(144, 149);
            this.btn_CancelarModificado.Name = "btn_CancelarModificado";
            this.btn_CancelarModificado.Size = new System.Drawing.Size(124, 49);
            this.btn_CancelarModificado.TabIndex = 7;
            this.btn_CancelarModificado.Text = "Cancelar";
            this.btn_CancelarModificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelarModificado.UseVisualStyleBackColor = true;
            this.btn_CancelarModificado.Click += new System.EventHandler(this.btn_CancelarModificado_Click);
            // 
            // btn_GuardarModificado
            // 
            this.btn_GuardarModificado.FlatAppearance.BorderSize = 0;
            this.btn_GuardarModificado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_GuardarModificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarModificado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarModificado.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarModificado.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarModificado.Image")));
            this.btn_GuardarModificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarModificado.Location = new System.Drawing.Point(6, 149);
            this.btn_GuardarModificado.Name = "btn_GuardarModificado";
            this.btn_GuardarModificado.Size = new System.Drawing.Size(124, 49);
            this.btn_GuardarModificado.TabIndex = 6;
            this.btn_GuardarModificado.Text = "Guardar";
            this.btn_GuardarModificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarModificado.UseVisualStyleBackColor = true;
            this.btn_GuardarModificado.Click += new System.EventHandler(this.btn_GuardarModificado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txb_stockAModificar
            // 
            this.txb_stockAModificar.Location = new System.Drawing.Point(89, 109);
            this.txb_stockAModificar.Name = "txb_stockAModificar";
            this.txb_stockAModificar.Size = new System.Drawing.Size(160, 22);
            this.txb_stockAModificar.TabIndex = 2;
            // 
            // txb_precioAModificar
            // 
            this.txb_precioAModificar.Location = new System.Drawing.Point(89, 64);
            this.txb_precioAModificar.Name = "txb_precioAModificar";
            this.txb_precioAModificar.Size = new System.Drawing.Size(160, 22);
            this.txb_precioAModificar.TabIndex = 1;
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Buscar.Location = new System.Drawing.Point(734, 29);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(249, 23);
            this.txb_Buscar.TabIndex = 8;
            this.txb_Buscar.TextChanged += new System.EventHandler(this.txb_Buscar_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Buscar.Location = new System.Drawing.Point(673, 35);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(49, 17);
            this.lbl_Buscar.TabIndex = 7;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // lbl_PrecioDolar
            // 
            this.lbl_PrecioDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrecioDolar.AutoSize = true;
            this.lbl_PrecioDolar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioDolar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_PrecioDolar.Location = new System.Drawing.Point(871, 72);
            this.lbl_PrecioDolar.Name = "lbl_PrecioDolar";
            this.lbl_PrecioDolar.Size = new System.Drawing.Size(0, 19);
            this.lbl_PrecioDolar.TabIndex = 9;
            // 
            // lbl_ValorDolar
            // 
            this.lbl_ValorDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValorDolar.AutoSize = true;
            this.lbl_ValorDolar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorDolar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ValorDolar.Location = new System.Drawing.Point(704, 72);
            this.lbl_ValorDolar.Name = "lbl_ValorDolar";
            this.lbl_ValorDolar.Size = new System.Drawing.Size(147, 19);
            this.lbl_ValorDolar.TabIndex = 10;
            this.lbl_ValorDolar.Text = "Cambio del dolar";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.lbl_ValorDolar);
            this.Controls.Add(this.lbl_PrecioDolar);
            this.Controls.Add(this.gpbx_modificarProducto);
            this.Controls.Add(this.txb_Buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.grpbx_AgregarProducto);
            this.Controls.Add(this.dgv_Principal);
            this.Controls.Add(this.pnl_menuVertical);
            this.Controls.Add(this.lbl_cerrar);
            this.Controls.Add(this.lbl_TituloProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnl_menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Principal)).EndInit();
            this.grpbx_AgregarProducto.ResumeLayout(false);
            this.grpbx_AgregarProducto.PerformLayout();
            this.gpbx_modificarProducto.ResumeLayout(false);
            this.gpbx_modificarProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_TituloProductos;
        private Label lbl_cerrar;
        private Button btn_Guardar;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_agregar;
        private PictureBox pictureBox2;
        private Panel pnl_menuVertical;
        private DataGridView dgv_Principal;
        private GroupBox grpbx_AgregarProducto;
        private Label lbl_Stock;
        private Label lbl_Precio;
        private Label lbl_Producto;
        private TextBox txb_Stock;
        private TextBox txb_Precio;
        private TextBox txb_Descripcion;
        private Button btn_CancelarGb;
        private Button btn_GuardarGb;
        private TextBox txb_Buscar;
        private Label lbl_Buscar;
        private GroupBox gpbx_modificarProducto;
        private Button btn_CancelarModificado;
        private Button btn_GuardarModificado;
        private Label label1;
        private Label label2;
        private TextBox txb_stockAModificar;
        private TextBox txb_precioAModificar;
        private Label label3;
        private TextBox txb_productoAModificar;
        private Label lbl_PrecioDolar;
        private Label lbl_ValorDolar;
    }
}