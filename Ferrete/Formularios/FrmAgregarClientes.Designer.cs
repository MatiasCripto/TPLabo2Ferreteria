namespace Vista.Formularios
{
    partial class FrmAgregarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarClientes));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txb_nombreCliente = new System.Windows.Forms.TextBox();
            this.btn_Agrergar = new System.Windows.Forms.Button();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.lbl_NombreUsuario = new System.Windows.Forms.Label();
            this.txb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_contrasenia = new System.Windows.Forms.TextBox();
            this.lbl_confirmarContra = new System.Windows.Forms.Label();
            this.txb_confirmarContra = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombre.Location = new System.Drawing.Point(45, 115);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 15);
            this.lbl_nombre.TabIndex = 39;
            this.lbl_nombre.Text = "Nombre cliente";
            // 
            // txb_nombreCliente
            // 
            this.txb_nombreCliente.Location = new System.Drawing.Point(174, 107);
            this.txb_nombreCliente.Name = "txb_nombreCliente";
            this.txb_nombreCliente.Size = new System.Drawing.Size(114, 23);
            this.txb_nombreCliente.TabIndex = 36;
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
            this.btn_Agrergar.Location = new System.Drawing.Point(314, 395);
            this.btn_Agrergar.Name = "btn_Agrergar";
            this.btn_Agrergar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Agrergar.Size = new System.Drawing.Size(94, 43);
            this.btn_Agrergar.TabIndex = 35;
            this.btn_Agrergar.Text = "Agregar";
            this.btn_Agrergar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agrergar.UseVisualStyleBackColor = false;
            this.btn_Agrergar.Click += new System.EventHandler(this.btn_Agrergar_Click);
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(314, 34);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.RowTemplate.Height = 25;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(280, 324);
            this.dgv_cliente.TabIndex = 33;
            // 
            // lbl_NombreUsuario
            // 
            this.lbl_NombreUsuario.AutoSize = true;
            this.lbl_NombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_NombreUsuario.Location = new System.Drawing.Point(45, 168);
            this.lbl_NombreUsuario.Name = "lbl_NombreUsuario";
            this.lbl_NombreUsuario.Size = new System.Drawing.Size(93, 15);
            this.lbl_NombreUsuario.TabIndex = 41;
            this.lbl_NombreUsuario.Text = "Nombre usuario";
            // 
            // txb_nombreUsuario
            // 
            this.txb_nombreUsuario.Location = new System.Drawing.Point(174, 160);
            this.txb_nombreUsuario.Name = "txb_nombreUsuario";
            this.txb_nombreUsuario.Size = new System.Drawing.Size(114, 23);
            this.txb_nombreUsuario.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Contraseña";
            // 
            // txb_contrasenia
            // 
            this.txb_contrasenia.Location = new System.Drawing.Point(174, 214);
            this.txb_contrasenia.Name = "txb_contrasenia";
            this.txb_contrasenia.PasswordChar = '*';
            this.txb_contrasenia.Size = new System.Drawing.Size(114, 23);
            this.txb_contrasenia.TabIndex = 42;
            // 
            // lbl_confirmarContra
            // 
            this.lbl_confirmarContra.AutoSize = true;
            this.lbl_confirmarContra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_confirmarContra.Location = new System.Drawing.Point(45, 273);
            this.lbl_confirmarContra.Name = "lbl_confirmarContra";
            this.lbl_confirmarContra.Size = new System.Drawing.Size(122, 15);
            this.lbl_confirmarContra.TabIndex = 46;
            this.lbl_confirmarContra.Text = "Confirmar contraseña";
            // 
            // txb_confirmarContra
            // 
            this.txb_confirmarContra.Location = new System.Drawing.Point(174, 265);
            this.txb_confirmarContra.Name = "txb_confirmarContra";
            this.txb_confirmarContra.PasswordChar = '*';
            this.txb_confirmarContra.Size = new System.Drawing.Size(114, 23);
            this.txb_confirmarContra.TabIndex = 45;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(500, 395);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 43);
            this.btn_Cancelar.TabIndex = 47;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FrmAgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_confirmarContra);
            this.Controls.Add(this.txb_confirmarContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_contrasenia);
            this.Controls.Add(this.lbl_NombreUsuario);
            this.Controls.Add(this.txb_nombreUsuario);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txb_nombreCliente);
            this.Controls.Add(this.btn_Agrergar);
            this.Controls.Add(this.dgv_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarClientes";
            this.Text = "Agregar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nombre;
        private TextBox txb_nombreCliente;
        private Button btn_Agrergar;
        private DataGridView dgv_cliente;
        private Label lbl_NombreUsuario;
        private TextBox txb_nombreUsuario;
        private Label label2;
        private TextBox txb_contrasenia;
        private Label lbl_confirmarContra;
        private TextBox txb_confirmarContra;
        private Label lbl_confirmarContraseña;
        private TextBox textBox1;
        private Label lbl_contrasenia;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txb_nombre;
        private Button button1;
        private Button button2;
        private DataGridView dgv_Clientes;
        private Button btn_Cancelar;
    }
}