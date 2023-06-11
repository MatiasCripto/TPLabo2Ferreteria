namespace Ferrete2.Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_RellenarVendedor = new System.Windows.Forms.Button();
            this.btn_Rellenar = new System.Windows.Forms.Button();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_contrasenia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.picbx_minimizar = new System.Windows.Forms.PictureBox();
            this.picbx_cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_mensajeError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnl_Login.Controls.Add(this.pictureBox1);
            this.pnl_Login.Controls.Add(this.btn_RellenarVendedor);
            this.pnl_Login.Controls.Add(this.btn_Rellenar);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(250, 330);
            this.pnl_Login.TabIndex = 0;
            this.pnl_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Login_MouseMove);
            // 
            // btn_RellenarVendedor
            // 
            this.btn_RellenarVendedor.FlatAppearance.BorderSize = 0;
            this.btn_RellenarVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_RellenarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RellenarVendedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RellenarVendedor.ForeColor = System.Drawing.Color.White;
            this.btn_RellenarVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_RellenarVendedor.Image")));
            this.btn_RellenarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RellenarVendedor.Location = new System.Drawing.Point(0, 242);
            this.btn_RellenarVendedor.Name = "btn_RellenarVendedor";
            this.btn_RellenarVendedor.Size = new System.Drawing.Size(250, 49);
            this.btn_RellenarVendedor.TabIndex = 6;
            this.btn_RellenarVendedor.Text = "Vendedor";
            this.btn_RellenarVendedor.UseVisualStyleBackColor = true;
            this.btn_RellenarVendedor.Click += new System.EventHandler(this.btn_RellenarVendedor_Click);
            // 
            // btn_Rellenar
            // 
            this.btn_Rellenar.FlatAppearance.BorderSize = 0;
            this.btn_Rellenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Rellenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rellenar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Rellenar.ForeColor = System.Drawing.Color.White;
            this.btn_Rellenar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rellenar.Image")));
            this.btn_Rellenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rellenar.Location = new System.Drawing.Point(0, 181);
            this.btn_Rellenar.Name = "btn_Rellenar";
            this.btn_Rellenar.Size = new System.Drawing.Size(250, 49);
            this.btn_Rellenar.TabIndex = 5;
            this.btn_Rellenar.Text = "Administrador";
            this.btn_Rellenar.UseVisualStyleBackColor = true;
            this.btn_Rellenar.Click += new System.EventHandler(this.btn_Rellenar_Click);
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Usuario.Location = new System.Drawing.Point(324, 60);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(368, 20);
            this.txb_Usuario.TabIndex = 1;
            this.txb_Usuario.Text = "USUARIO";
            this.txb_Usuario.Enter += new System.EventHandler(this.txb_Usuario_Enter);
            this.txb_Usuario.Leave += new System.EventHandler(this.txb_Usuario_Leave);
            // 
            // txb_contrasenia
            // 
            this.txb_contrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txb_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_contrasenia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txb_contrasenia.Location = new System.Drawing.Point(324, 157);
            this.txb_contrasenia.Name = "txb_contrasenia";
            this.txb_contrasenia.Size = new System.Drawing.Size(368, 20);
            this.txb_contrasenia.TabIndex = 2;
            this.txb_contrasenia.Text = "CONTRASEÑA";
            this.txb_contrasenia.Enter += new System.EventHandler(this.txb_contrasenia_Enter);
            this.txb_contrasenia.Leave += new System.EventHandler(this.txb_contrasenia_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(324, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.ForeColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(324, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 2);
            this.panel2.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Login.Location = new System.Drawing.Point(324, 251);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(368, 40);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "ACCEDER";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbx_minimizar
            // 
            this.picbx_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbx_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbx_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("picbx_minimizar.Image")));
            this.picbx_minimizar.Location = new System.Drawing.Point(714, 0);
            this.picbx_minimizar.Name = "picbx_minimizar";
            this.picbx_minimizar.Size = new System.Drawing.Size(29, 32);
            this.picbx_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_minimizar.TabIndex = 7;
            this.picbx_minimizar.TabStop = false;
            this.picbx_minimizar.Click += new System.EventHandler(this.picbx_minimizar_Click);
            // 
            // picbx_cerrar
            // 
            this.picbx_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbx_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbx_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("picbx_cerrar.Image")));
            this.picbx_cerrar.Location = new System.Drawing.Point(749, 0);
            this.picbx_cerrar.Name = "picbx_cerrar";
            this.picbx_cerrar.Size = new System.Drawing.Size(29, 32);
            this.picbx_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_cerrar.TabIndex = 6;
            this.picbx_cerrar.TabStop = false;
            this.picbx_cerrar.Click += new System.EventHandler(this.picbx_cerrar_Click);
            // 
            // lbl_mensajeError
            // 
            this.lbl_mensajeError.AutoSize = true;
            this.lbl_mensajeError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeError.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_mensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lbl_mensajeError.Image")));
            this.lbl_mensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_mensajeError.Location = new System.Drawing.Point(324, 212);
            this.lbl_mensajeError.Name = "lbl_mensajeError";
            this.lbl_mensajeError.Size = new System.Drawing.Size(157, 18);
            this.lbl_mensajeError.TabIndex = 8;
            this.lbl_mensajeError.Text = "      Mensaje de error";
            this.lbl_mensajeError.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 151);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lbl_mensajeError);
            this.Controls.Add(this.picbx_minimizar);
            this.Controls.Add(this.picbx_cerrar);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txb_contrasenia);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.pnl_Login);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.pnl_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_Login;
        private TextBox txb_Usuario;
        private TextBox txb_contrasenia;
        private Panel panel1;
        private Panel panel2;
        private Button btn_Login;
        private PictureBox picbx_minimizar;
        private PictureBox picbx_cerrar;
        private Label lbl_mensajeError;
        private Button btn_Rellenar;
        private Button btn_RellenarVendedor;
        private PictureBox pictureBox1;
    }
}