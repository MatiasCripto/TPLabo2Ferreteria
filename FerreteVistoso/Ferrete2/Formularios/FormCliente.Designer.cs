namespace Ferrete2.Formularios
{
    partial class FormCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.pnl_menuVertical = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txb_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.grpbx_AgregarCliente = new System.Windows.Forms.GroupBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cbx_AsignarRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_NombreNuevoCliente = new System.Windows.Forms.TextBox();
            this.btn_CancelarGb = new System.Windows.Forms.Button();
            this.btn_GuardarGb = new System.Windows.Forms.Button();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_ConfirmarPass = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txb_Confirmar = new System.Windows.Forms.TextBox();
            this.txb_Cointrasenia = new System.Windows.Forms.TextBox();
            this.dgv_Clientes = new System.Windows.Forms.DataGridView();
            this.lbl_TituloUsuario = new System.Windows.Forms.Label();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.pnl_menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpbx_AgregarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menuVertical
            // 
            this.pnl_menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.pnl_menuVertical.Controls.Add(this.btn_Guardar);
            this.pnl_menuVertical.Controls.Add(this.btn_Eliminar);
            this.pnl_menuVertical.Controls.Add(this.btn_agregar);
            this.pnl_menuVertical.Controls.Add(this.pictureBox2);
            this.pnl_menuVertical.Location = new System.Drawing.Point(0, 0);
            this.pnl_menuVertical.Name = "pnl_menuVertical";
            this.pnl_menuVertical.Size = new System.Drawing.Size(250, 621);
            this.pnl_menuVertical.TabIndex = 6;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 149);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(250, 49);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
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
            // txb_Buscar
            // 
            this.txb_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Buscar.Location = new System.Drawing.Point(719, 41);
            this.txb_Buscar.Name = "txb_Buscar";
            this.txb_Buscar.Size = new System.Drawing.Size(249, 23);
            this.txb_Buscar.TabIndex = 32;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Buscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Buscar.Location = new System.Drawing.Point(658, 47);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(49, 17);
            this.lbl_Buscar.TabIndex = 31;
            this.lbl_Buscar.Text = "Buscar";
            // 
            // grpbx_AgregarCliente
            // 
            this.grpbx_AgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbx_AgregarCliente.Controls.Add(this.lbl_Usuario);
            this.grpbx_AgregarCliente.Controls.Add(this.cbx_AsignarRole);
            this.grpbx_AgregarCliente.Controls.Add(this.label4);
            this.grpbx_AgregarCliente.Controls.Add(this.lbl_Nombre);
            this.grpbx_AgregarCliente.Controls.Add(this.txb_Usuario);
            this.grpbx_AgregarCliente.Controls.Add(this.txb_NombreNuevoCliente);
            this.grpbx_AgregarCliente.Controls.Add(this.btn_CancelarGb);
            this.grpbx_AgregarCliente.Controls.Add(this.btn_GuardarGb);
            this.grpbx_AgregarCliente.Controls.Add(this.lbl_Role);
            this.grpbx_AgregarCliente.Controls.Add(this.lbl_ConfirmarPass);
            this.grpbx_AgregarCliente.Controls.Add(this.lbl_Pass);
            this.grpbx_AgregarCliente.Controls.Add(this.txb_Confirmar);
            this.grpbx_AgregarCliente.Controls.Add(this.txb_Cointrasenia);
            this.grpbx_AgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbx_AgregarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbx_AgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbx_AgregarCliente.Location = new System.Drawing.Point(702, 106);
            this.grpbx_AgregarCliente.Name = "grpbx_AgregarCliente";
            this.grpbx_AgregarCliente.Size = new System.Drawing.Size(277, 292);
            this.grpbx_AgregarCliente.TabIndex = 30;
            this.grpbx_AgregarCliente.TabStop = false;
            this.grpbx_AgregarCliente.Text = "Agregar cliente";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(6, 64);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(51, 17);
            this.lbl_Usuario.TabIndex = 13;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // cbx_AsignarRole
            // 
            this.cbx_AsignarRole.FormattingEnabled = true;
            this.cbx_AsignarRole.Items.AddRange(new object[] {
            "Cliente"});
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
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 11;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 24);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(56, 17);
            this.lbl_Nombre.TabIndex = 10;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(89, 59);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(160, 22);
            this.txb_Usuario.TabIndex = 9;
            // 
            // txb_NombreNuevoCliente
            // 
            this.txb_NombreNuevoCliente.Location = new System.Drawing.Point(89, 17);
            this.txb_NombreNuevoCliente.Name = "txb_NombreNuevoCliente";
            this.txb_NombreNuevoCliente.Size = new System.Drawing.Size(160, 22);
            this.txb_NombreNuevoCliente.TabIndex = 8;
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
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(6, 200);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(34, 17);
            this.lbl_Role.TabIndex = 5;
            this.lbl_Role.Text = "Role";
            // 
            // lbl_ConfirmarPass
            // 
            this.lbl_ConfirmarPass.AutoSize = true;
            this.lbl_ConfirmarPass.Location = new System.Drawing.Point(6, 158);
            this.lbl_ConfirmarPass.Name = "lbl_ConfirmarPass";
            this.lbl_ConfirmarPass.Size = new System.Drawing.Size(66, 17);
            this.lbl_ConfirmarPass.TabIndex = 4;
            this.lbl_ConfirmarPass.Text = "Confirmar";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(6, 115);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(77, 17);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Contraseña";
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
            // dgv_Clientes
            // 
            this.dgv_Clientes.AllowUserToAddRows = false;
            this.dgv_Clientes.AllowUserToDeleteRows = false;
            this.dgv_Clientes.AllowUserToOrderColumns = true;
            this.dgv_Clientes.AllowUserToResizeColumns = false;
            this.dgv_Clientes.AllowUserToResizeRows = false;
            this.dgv_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Clientes.EnableHeadersVisualStyles = false;
            this.dgv_Clientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Clientes.Location = new System.Drawing.Point(268, 69);
            this.dgv_Clientes.Name = "dgv_Clientes";
            this.dgv_Clientes.ReadOnly = true;
            this.dgv_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Clientes.RowHeadersVisible = false;
            this.dgv_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.dgv_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Clientes.RowTemplate.Height = 25;
            this.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clientes.Size = new System.Drawing.Size(381, 522);
            this.dgv_Clientes.TabIndex = 29;
            // 
            // lbl_TituloUsuario
            // 
            this.lbl_TituloUsuario.AutoSize = true;
            this.lbl_TituloUsuario.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_TituloUsuario.Location = new System.Drawing.Point(399, 21);
            this.lbl_TituloUsuario.Name = "lbl_TituloUsuario";
            this.lbl_TituloUsuario.Size = new System.Drawing.Size(165, 41);
            this.lbl_TituloUsuario.TabIndex = 28;
            this.lbl_TituloUsuario.Text = "CLIENTES";
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
            this.lbl_cerrar.TabIndex = 33;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click_1);
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
            this.btn_Guardar.Location = new System.Drawing.Point(0, 204);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(250, 49);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Informes";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1012, 603);
            this.Controls.Add(this.lbl_cerrar);
            this.Controls.Add(this.txb_Buscar);
            this.Controls.Add(this.lbl_Buscar);
            this.Controls.Add(this.grpbx_AgregarCliente);
            this.Controls.Add(this.dgv_Clientes);
            this.Controls.Add(this.lbl_TituloUsuario);
            this.Controls.Add(this.pnl_menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.pnl_menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpbx_AgregarCliente.ResumeLayout(false);
            this.grpbx_AgregarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_menuVertical;
        private Button btn_Eliminar;
        private Button btn_agregar;
        private PictureBox pictureBox2;
        private TextBox txb_Buscar;
        private Label lbl_Buscar;
        private GroupBox grpbx_AgregarCliente;
        private Label lbl_Usuario;
        private ComboBox cbx_AsignarRole;
        private Label label4;
        private Label lbl_Nombre;
        private TextBox txb_Usuario;
        private TextBox txb_NombreNuevoCliente;
        private Button btn_CancelarGb;
        private Button btn_GuardarGb;
        private Label lbl_Role;
        private Label lbl_ConfirmarPass;
        private Label lbl_Pass;
        private TextBox txb_Confirmar;
        private TextBox txb_Cointrasenia;
        private DataGridView dgv_Clientes;
        private Label lbl_TituloUsuario;
        private Label lbl_cerrar;
        private Button btn_Guardar;
    }
}