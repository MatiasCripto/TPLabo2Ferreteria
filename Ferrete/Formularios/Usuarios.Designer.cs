namespace Vista
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Agrergar = new System.Windows.Forms.Button();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txb_contrasenia = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_contrasenia = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.cbx_role = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(299, 62);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowTemplate.Height = 25;
            this.dgv_usuarios.Size = new System.Drawing.Size(280, 324);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.btn_Agrergar.Location = new System.Drawing.Point(599, 245);
            this.btn_Agrergar.Name = "btn_Agrergar";
            this.btn_Agrergar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Agrergar.Size = new System.Drawing.Size(94, 43);
            this.btn_Agrergar.TabIndex = 24;
            this.btn_Agrergar.Text = "Agregar";
            this.btn_Agrergar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agrergar.UseVisualStyleBackColor = false;
            this.btn_Agrergar.Click += new System.EventHandler(this.btn_Agrergar_Click);
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(127, 106);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_nombre.TabIndex = 25;
            // 
            // txb_nombreUsuario
            // 
            this.txb_nombreUsuario.Location = new System.Drawing.Point(127, 149);
            this.txb_nombreUsuario.Name = "txb_nombreUsuario";
            this.txb_nombreUsuario.Size = new System.Drawing.Size(100, 23);
            this.txb_nombreUsuario.TabIndex = 26;
            // 
            // txb_contrasenia
            // 
            this.txb_contrasenia.Location = new System.Drawing.Point(127, 205);
            this.txb_contrasenia.Name = "txb_contrasenia";
            this.txb_contrasenia.Size = new System.Drawing.Size(100, 23);
            this.txb_contrasenia.TabIndex = 27;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(12, 114);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 28;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(12, 157);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(109, 15);
            this.lbl_nombreUsuario.TabIndex = 29;
            this.lbl_nombreUsuario.Text = "Nombre de usuario";
            // 
            // lbl_contrasenia
            // 
            this.lbl_contrasenia.AutoSize = true;
            this.lbl_contrasenia.Location = new System.Drawing.Point(12, 213);
            this.lbl_contrasenia.Name = "lbl_contrasenia";
            this.lbl_contrasenia.Size = new System.Drawing.Size(67, 15);
            this.lbl_contrasenia.TabIndex = 30;
            this.lbl_contrasenia.Text = "Contraseña";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(12, 259);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(30, 15);
            this.lbl_role.TabIndex = 31;
            this.lbl_role.Text = "Role";
            // 
            // cbx_role
            // 
            this.cbx_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_role.FormattingEnabled = true;
            this.cbx_role.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Cliente"});
            this.cbx_role.Location = new System.Drawing.Point(115, 256);
            this.cbx_role.Name = "cbx_role";
            this.cbx_role.Size = new System.Drawing.Size(121, 23);
            this.cbx_role.TabIndex = 32;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_contrasenia);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txb_contrasenia);
            this.Controls.Add(this.txb_nombreUsuario);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_Agrergar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_usuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_usuarios;
        private Button button1;
        private Button btn_Agrergar;
        private TextBox txb_nombre;
        private TextBox txb_nombreUsuario;
        private TextBox txb_contrasenia;
        private Label lbl_nombre;
        private Label lbl_nombreUsuario;
        private Label lbl_contrasenia;
        private Label lbl_role;
        private ComboBox cbx_role;
    }
}