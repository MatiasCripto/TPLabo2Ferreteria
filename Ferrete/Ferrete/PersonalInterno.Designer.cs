namespace Vista
{
    partial class PersonalInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInterno));
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.colum_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.lbl_MensajeAdmin = new System.Windows.Forms.Label();
            this.tbx_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Informe = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agrergar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_principal
            // 
            this.dgv_principal.AllowUserToAddRows = false;
            this.dgv_principal.AllowUserToDeleteRows = false;
            this.dgv_principal.AllowUserToOrderColumns = true;
            this.dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_principal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_ID,
            this.colum_articulo,
            this.PrecioNeto,
            this.PrecioDescuento,
            this.Iva,
            this.precioFinal});
            this.dgv_principal.Location = new System.Drawing.Point(414, 65);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.ReadOnly = true;
            this.dgv_principal.RowTemplate.Height = 25;
            this.dgv_principal.Size = new System.Drawing.Size(449, 506);
            this.dgv_principal.TabIndex = 40;
            // 
            // colum_ID
            // 
            this.colum_ID.HeaderText = "ID";
            this.colum_ID.Name = "colum_ID";
            this.colum_ID.ReadOnly = true;
            this.colum_ID.Width = 45;
            // 
            // colum_articulo
            // 
            this.colum_articulo.HeaderText = "Articulo";
            this.colum_articulo.Name = "colum_articulo";
            this.colum_articulo.ReadOnly = true;
            // 
            // PrecioNeto
            // 
            this.PrecioNeto.HeaderText = "Precio neto";
            this.PrecioNeto.Name = "PrecioNeto";
            this.PrecioNeto.ReadOnly = true;
            this.PrecioNeto.Width = 60;
            // 
            // PrecioDescuento
            // 
            this.PrecioDescuento.HeaderText = "Precio C/ Desc.";
            this.PrecioDescuento.Name = "PrecioDescuento";
            this.PrecioDescuento.ReadOnly = true;
            this.PrecioDescuento.Width = 60;
            // 
            // Iva
            // 
            this.Iva.HeaderText = "IVA";
            this.Iva.Name = "Iva";
            this.Iva.ReadOnly = true;
            this.Iva.Width = 60;
            // 
            // precioFinal
            // 
            this.precioFinal.HeaderText = "Precio Final";
            this.precioFinal.Name = "precioFinal";
            this.precioFinal.ReadOnly = true;
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Ventas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Ventas.FlatAppearance.BorderSize = 2;
            this.btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ventas.ForeColor = System.Drawing.Color.White;
            this.btn_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ventas.Image")));
            this.btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ventas.Location = new System.Drawing.Point(21, 380);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Ventas.Size = new System.Drawing.Size(119, 58);
            this.btn_Ventas.TabIndex = 39;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ventas.UseVisualStyleBackColor = false;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Usuarios.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Usuarios.FlatAppearance.BorderSize = 2;
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usuarios.Image")));
            this.btn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Usuarios.Location = new System.Drawing.Point(21, 268);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Usuarios.Size = new System.Drawing.Size(119, 58);
            this.btn_Usuarios.TabIndex = 38;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            // 
            // lbl_MensajeAdmin
            // 
            this.lbl_MensajeAdmin.AutoSize = true;
            this.lbl_MensajeAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.lbl_MensajeAdmin.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MensajeAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_MensajeAdmin.Location = new System.Drawing.Point(54, 21);
            this.lbl_MensajeAdmin.Name = "lbl_MensajeAdmin";
            this.lbl_MensajeAdmin.Size = new System.Drawing.Size(272, 38);
            this.lbl_MensajeAdmin.TabIndex = 37;
            this.lbl_MensajeAdmin.Text = "ADMINISTRADOR";
            // 
            // tbx_Precio
            // 
            this.tbx_Precio.Location = new System.Drawing.Point(152, 146);
            this.tbx_Precio.Name = "tbx_Precio";
            this.tbx_Precio.Size = new System.Drawing.Size(222, 23);
            this.tbx_Precio.TabIndex = 36;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.ForeColor = System.Drawing.Color.White;
            this.lbl_Precio.Location = new System.Drawing.Point(54, 146);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_Precio.TabIndex = 35;
            this.lbl_Precio.Text = "Precio";
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Location = new System.Drawing.Point(584, 31);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(222, 23);
            this.txb_Buscar.TabIndex = 34;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_Buscar.Location = new System.Drawing.Point(524, 31);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(42, 15);
            this.lbl_Buscar.TabIndex = 33;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(152, 83);
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(222, 23);
            this.txb_Descripcion.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Producto";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.ForeColor = System.Drawing.Color.Black;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.Location = new System.Drawing.Point(812, 23);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(42, 36);
            this.btn_Buscar.TabIndex = 30;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Salir.FlatAppearance.BorderSize = 2;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.Location = new System.Drawing.Point(325, 513);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(73, 58);
            this.btn_Salir.TabIndex = 29;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // btn_Informe
            // 
            this.btn_Informe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Informe.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Informe.FlatAppearance.BorderSize = 2;
            this.btn_Informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Informe.ForeColor = System.Drawing.Color.White;
            this.btn_Informe.Image = ((System.Drawing.Image)(resources.GetObject("btn_Informe.Image")));
            this.btn_Informe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Informe.Location = new System.Drawing.Point(249, 513);
            this.btn_Informe.Name = "btn_Informe";
            this.btn_Informe.Size = new System.Drawing.Size(73, 58);
            this.btn_Informe.TabIndex = 28;
            this.btn_Informe.Text = "Informe";
            this.btn_Informe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Informe.UseVisualStyleBackColor = false;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Actualizar.FlatAppearance.BorderSize = 2;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.Image")));
            this.btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Actualizar.Location = new System.Drawing.Point(173, 513);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(73, 58);
            this.btn_Actualizar.TabIndex = 27;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.Location = new System.Drawing.Point(97, 513);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(73, 58);
            this.btn_Eliminar.TabIndex = 26;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Nuevo.FlatAppearance.BorderSize = 2;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Nuevo.Location = new System.Drawing.Point(21, 513);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(73, 58);
            this.btn_Nuevo.TabIndex = 25;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.Location = new System.Drawing.Point(152, 191);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 43);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_Agrergar
            // 
            this.btn_Agrergar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Agrergar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Agrergar.FlatAppearance.BorderSize = 2;
            this.btn_Agrergar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agrergar.ForeColor = System.Drawing.Color.White;
            this.btn_Agrergar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agrergar.Image")));
            this.btn_Agrergar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Agrergar.Location = new System.Drawing.Point(280, 191);
            this.btn_Agrergar.Name = "btn_Agrergar";
            this.btn_Agrergar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Agrergar.Size = new System.Drawing.Size(94, 43);
            this.btn_Agrergar.TabIndex = 23;
            this.btn_Agrergar.Text = "Agregar";
            this.btn_Agrergar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agrergar.UseVisualStyleBackColor = false;
            // 
            // PersonalInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1170, 585);
            this.Controls.Add(this.dgv_principal);
            this.Controls.Add(this.btn_Ventas);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.lbl_MensajeAdmin);
            this.Controls.Add(this.tbx_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txb_Buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.txb_Descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Informe);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agrergar);
            this.Name = "PersonalInterno";
            this.Text = "PersonalInterno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_principal;
        private DataGridViewTextBoxColumn colum_ID;
        private DataGridViewTextBoxColumn colum_articulo;
        private DataGridViewTextBoxColumn PrecioNeto;
        private DataGridViewTextBoxColumn PrecioDescuento;
        private DataGridViewTextBoxColumn Iva;
        private DataGridViewTextBoxColumn precioFinal;
        private Button btn_Ventas;
        private Button btn_Usuarios;
        private Label lbl_MensajeAdmin;
        private TextBox tbx_Precio;
        private Label lbl_Precio;
        private TextBox txb_Buscar;
        private Label lbl_Buscar;
        private TextBox txb_Descripcion;
        private Label label1;
        private Button btn_Buscar;
        private Button btn_Salir;
        private Button btn_Informe;
        private Button btn_Actualizar;
        private Button btn_Eliminar;
        private Button btn_Nuevo;
        private Button btn_Cancelar;
        private Button btn_Agrergar;
    }
}