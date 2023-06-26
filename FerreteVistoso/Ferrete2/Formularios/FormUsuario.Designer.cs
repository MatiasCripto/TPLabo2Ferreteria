namespace Ferrete2.Formularios
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_menuVertical = new System.Windows.Forms.Panel();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbx_modificarUsuario = new System.Windows.Forms.GroupBox();
            this.cbx_ModificarRole = new System.Windows.Forms.ComboBox();
            this.btn_CancelarModificado = new System.Windows.Forms.Button();
            this.btn_GuardarModificado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.grpbx_AgregarUsuario = new System.Windows.Forms.GroupBox();
            this.cbx_AsignarRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.btn_CancelarGb = new System.Windows.Forms.Button();
            this.btn_GuardarGb = new System.Windows.Forms.Button();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.txb_Confirmar = new System.Windows.Forms.TextBox();
            this.txb_Cointrasenia = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.lbl_TituloUsuario = new System.Windows.Forms.Label();
            this.btn_ExportarPDF = new System.Windows.Forms.Button();
            this.btn_ExportarCsv = new System.Windows.Forms.Button();
            this.btn_ExportarJson = new System.Windows.Forms.Button();
            this.pnl_menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbx_modificarUsuario.SuspendLayout();
            this.grpbx_AgregarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
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
            this.pnl_menuVertical.TabIndex = 5;
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
            this.btn_Guardar.Location = new System.Drawing.Point(-3, 261);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(250, 49);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Informes";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Informes_Click);
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
            // gpbx_modificarUsuario
            // 
            this.gpbx_modificarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbx_modificarUsuario.Controls.Add(this.cbx_ModificarRole);
            this.gpbx_modificarUsuario.Controls.Add(this.btn_CancelarModificado);
            this.gpbx_modificarUsuario.Controls.Add(this.btn_GuardarModificado);
            this.gpbx_modificarUsuario.Controls.Add(this.label1);
            this.gpbx_modificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbx_modificarUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpbx_modificarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbx_modificarUsuario.Location = new System.Drawing.Point(708, 58);
            this.gpbx_modificarUsuario.Name = "gpbx_modificarUsuario";
            this.gpbx_modificarUsuario.Size = new System.Drawing.Size(277, 120);
            this.gpbx_modificarUsuario.TabIndex = 14;
            this.gpbx_modificarUsuario.TabStop = false;
            this.gpbx_modificarUsuario.Text = "Modificar usuario";
            // 
            // cbx_ModificarRole
            // 
            this.cbx_ModificarRole.FormattingEnabled = true;
            this.cbx_ModificarRole.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbx_ModificarRole.Location = new System.Drawing.Point(89, 18);
            this.cbx_ModificarRole.Name = "cbx_ModificarRole";
            this.cbx_ModificarRole.Size = new System.Drawing.Size(160, 25);
            this.cbx_ModificarRole.TabIndex = 11;
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
            this.btn_CancelarModificado.Location = new System.Drawing.Point(144, 60);
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
            this.btn_GuardarModificado.Location = new System.Drawing.Point(6, 60);
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
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Role";
            // 
            // txb_Buscar
            // 
            this.txb_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Buscar.Location = new System.Drawing.Point(728, 29);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(249, 23);
            this.txb_Buscar.TabIndex = 15;
            this.txb_Buscar.TextChanged += new System.EventHandler(this.txb_Buscar_TextChanged);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Buscar.Location = new System.Drawing.Point(667, 35);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(49, 17);
            this.lbl_Buscar.TabIndex = 13;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // grpbx_AgregarUsuario
            // 
            this.grpbx_AgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_AgregarUsuario.Controls.Add(this.cbx_AsignarRole);
            this.grpbx_AgregarUsuario.Controls.Add(this.label4);
            this.grpbx_AgregarUsuario.Controls.Add(this.label5);
            this.grpbx_AgregarUsuario.Controls.Add(this.txb_Usuario);
            this.grpbx_AgregarUsuario.Controls.Add(this.txb_Nombre);
            this.grpbx_AgregarUsuario.Controls.Add(this.btn_CancelarGb);
            this.grpbx_AgregarUsuario.Controls.Add(this.btn_GuardarGb);
            this.grpbx_AgregarUsuario.Controls.Add(this.lbl_Stock);
            this.grpbx_AgregarUsuario.Controls.Add(this.lbl_Precio);
            this.grpbx_AgregarUsuario.Controls.Add(this.lbl_Producto);
            this.grpbx_AgregarUsuario.Controls.Add(this.txb_Confirmar);
            this.grpbx_AgregarUsuario.Controls.Add(this.txb_Cointrasenia);
            this.grpbx_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_AgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbx_AgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbx_AgregarUsuario.Location = new System.Drawing.Point(714, 94);
            this.grpbx_AgregarUsuario.Name = "grpbx_AgregarUsuario";
            this.grpbx_AgregarUsuario.Size = new System.Drawing.Size(277, 292);
            this.grpbx_AgregarUsuario.TabIndex = 12;
            this.grpbx_AgregarUsuario.TabStop = false;
            this.grpbx_AgregarUsuario.Text = "Agregar usuario";
            // 
            // cbx_AsignarRole
            // 
            this.cbx_AsignarRole.FormattingEnabled = true;
            this.cbx_AsignarRole.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbx_AsignarRole.Location = new System.Drawing.Point(89, 192);
            this.cbx_AsignarRole.Name = "cbx_AsignarRole";
            this.cbx_AsignarRole.Size = new System.Drawing.Size(160, 25);
            this.cbx_AsignarRole.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(89, 59);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(160, 22);
            this.txb_Usuario.TabIndex = 9;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(89, 17);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(160, 22);
            this.txb_Nombre.TabIndex = 8;
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
            this.btn_CancelarGb.Location = new System.Drawing.Point(144, 235);
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
            this.btn_GuardarGb.Location = new System.Drawing.Point(6, 235);
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
            this.lbl_Stock.Location = new System.Drawing.Point(6, 200);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(34, 17);
            this.lbl_Stock.TabIndex = 5;
            this.lbl_Stock.Text = "Role";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(6, 158);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(66, 17);
            this.lbl_Precio.TabIndex = 4;
            this.lbl_Precio.Text = "Confirmar";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(6, 115);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(77, 17);
            this.lbl_Producto.TabIndex = 3;
            this.lbl_Producto.Text = "Contraseña";
            // 
            // txb_Confirmar
            // 
            this.txb_Confirmar.Location = new System.Drawing.Point(89, 150);
            this.txb_Confirmar.Name = "txb_Confirmar";
            this.txb_Confirmar.Size = new System.Drawing.Size(160, 22);
            this.txb_Confirmar.TabIndex = 1;
            // 
            // txb_Cointrasenia
            // 
            this.txb_Cointrasenia.Location = new System.Drawing.Point(89, 105);
            this.txb_Cointrasenia.Name = "txb_Cointrasenia";
            this.txb_Cointrasenia.Size = new System.Drawing.Size(160, 22);
            this.txb_Cointrasenia.TabIndex = 0;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.AllowUserToOrderColumns = true;
            this.dgv_Usuarios.AllowUserToResizeColumns = false;
            this.dgv_Usuarios.AllowUserToResizeRows = false;
            this.dgv_Usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Usuarios.EnableHeadersVisualStyles = false;
            this.dgv_Usuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Usuarios.Location = new System.Drawing.Point(277, 57);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Usuarios.RowHeadersVisible = false;
            this.dgv_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.dgv_Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Usuarios.RowTemplate.Height = 25;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(381, 209);
            this.dgv_Usuarios.TabIndex = 11;
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cerrar.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cerrar.Location = new System.Drawing.Point(976, 9);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(18, 20);
            this.lbl_cerrar.TabIndex = 10;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // lbl_TituloUsuario
            // 
            this.lbl_TituloUsuario.AutoSize = true;
            this.lbl_TituloUsuario.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TituloUsuario.Location = new System.Drawing.Point(408, 9);
            this.lbl_TituloUsuario.Name = "lbl_TituloUsuario";
            this.lbl_TituloUsuario.Size = new System.Drawing.Size(183, 41);
            this.lbl_TituloUsuario.TabIndex = 9;
            this.lbl_TituloUsuario.Text = "USUARIOS";
            // 
            // btn_ExportarPDF
            // 
            this.btn_ExportarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportarPDF.FlatAppearance.BorderSize = 0;
            this.btn_ExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarPDF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btn_ExportarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportarPDF.Image")));
            this.btn_ExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportarPDF.Location = new System.Drawing.Point(693, 401);
            this.btn_ExportarPDF.Name = "btn_ExportarPDF";
            this.btn_ExportarPDF.Size = new System.Drawing.Size(250, 49);
            this.btn_ExportarPDF.TabIndex = 37;
            this.btn_ExportarPDF.Text = "Exportar PDF";
            this.btn_ExportarPDF.UseVisualStyleBackColor = true;
            this.btn_ExportarPDF.Click += new System.EventHandler(this.btn_ExportarPDF_Click_1);
            // 
            // btn_ExportarCsv
            // 
            this.btn_ExportarCsv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportarCsv.FlatAppearance.BorderSize = 0;
            this.btn_ExportarCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ExportarCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarCsv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarCsv.ForeColor = System.Drawing.Color.White;
            this.btn_ExportarCsv.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportarCsv.Image")));
            this.btn_ExportarCsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportarCsv.Location = new System.Drawing.Point(487, 401);
            this.btn_ExportarCsv.Name = "btn_ExportarCsv";
            this.btn_ExportarCsv.Size = new System.Drawing.Size(190, 49);
            this.btn_ExportarCsv.TabIndex = 39;
            this.btn_ExportarCsv.Text = "Exportar CSV";
            this.btn_ExportarCsv.UseVisualStyleBackColor = true;
            this.btn_ExportarCsv.Click += new System.EventHandler(this.btn_ExportarCsv_Click_1);
            // 
            // btn_ExportarJson
            // 
            this.btn_ExportarJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExportarJson.FlatAppearance.BorderSize = 0;
            this.btn_ExportarJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ExportarJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarJson.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarJson.ForeColor = System.Drawing.Color.White;
            this.btn_ExportarJson.Image = ((System.Drawing.Image)(resources.GetObject("btn_ExportarJson.Image")));
            this.btn_ExportarJson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExportarJson.Location = new System.Drawing.Point(256, 401);
            this.btn_ExportarJson.Name = "btn_ExportarJson";
            this.btn_ExportarJson.Size = new System.Drawing.Size(202, 49);
            this.btn_ExportarJson.TabIndex = 38;
            this.btn_ExportarJson.Text = "Exportar JSON";
            this.btn_ExportarJson.UseVisualStyleBackColor = true;
            this.btn_ExportarJson.Click += new System.EventHandler(this.btn_ExportarJson_Click_1);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.btn_ExportarPDF);
            this.Controls.Add(this.btn_ExportarCsv);
            this.Controls.Add(this.btn_ExportarJson);
            this.Controls.Add(this.gpbx_modificarUsuario);
            this.Controls.Add(this.txb_Buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.grpbx_AgregarUsuario);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.lbl_cerrar);
            this.Controls.Add(this.lbl_TituloUsuario);
            this.Controls.Add(this.pnl_menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.pnl_menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbx_modificarUsuario.ResumeLayout(false);
            this.gpbx_modificarUsuario.PerformLayout();
            this.grpbx_AgregarUsuario.ResumeLayout(false);
            this.grpbx_AgregarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_menuVertical;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Button btn_agregar;
        private PictureBox pictureBox2;
        private GroupBox gpbx_modificarUsuario;
        private Button btn_CancelarModificado;
        private Button btn_GuardarModificado;
        private Label label1;
        private TextBox txb_Buscar;
        private Label lbl_Buscar;
        private GroupBox grpbx_AgregarUsuario;
        private Button btn_CancelarGb;
        private Button btn_GuardarGb;
        private Label lbl_Stock;
        private Label lbl_Precio;
        private Label lbl_Producto;
        private TextBox txb_Confirmar;
        private TextBox txb_Cointrasenia;
        private DataGridView dgv_Usuarios;
        private Label lbl_cerrar;
        private Label lbl_TituloUsuario;
        private Label label4;
        private Label label5;
        private TextBox txb_Usuario;
        private TextBox txb_Nombre;
        private ComboBox cbx_ModificarRole;
        private ComboBox cbx_AsignarRole;
        private Button btn_Guardar;
        private Button btn_ExportarPDF;
        private Button btn_ExportarCsv;
        private Button btn_ExportarJson;
    }
}