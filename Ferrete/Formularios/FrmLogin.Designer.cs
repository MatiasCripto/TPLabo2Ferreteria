namespace Ferrete
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_UsuarioInput = new System.Windows.Forms.TextBox();
            this.txb_ContraseniaInput = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.btn_Rellenar = new System.Windows.Forms.Button();
            this.btn_RellenarVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Login.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(61, 202);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(214, 51);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_UsuarioInput
            // 
            this.txb_UsuarioInput.Location = new System.Drawing.Point(61, 84);
            this.txb_UsuarioInput.Name = "txb_UsuarioInput";
            this.txb_UsuarioInput.PlaceholderText = "Nombre de usuario";
            this.txb_UsuarioInput.Size = new System.Drawing.Size(215, 23);
            this.txb_UsuarioInput.TabIndex = 2;
            // 
            // txb_ContraseniaInput
            // 
            this.txb_ContraseniaInput.Location = new System.Drawing.Point(61, 130);
            this.txb_ContraseniaInput.Name = "txb_ContraseniaInput";
            this.txb_ContraseniaInput.PasswordChar = '*';
            this.txb_ContraseniaInput.PlaceholderText = "Contraseña";
            this.txb_ContraseniaInput.Size = new System.Drawing.Size(215, 23);
            this.txb_ContraseniaInput.TabIndex = 3;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Login.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Login.Location = new System.Drawing.Point(61, 9);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(214, 62);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Ingrese los datos";
            // 
            // btn_Rellenar
            // 
            this.btn_Rellenar.Location = new System.Drawing.Point(61, 173);
            this.btn_Rellenar.Name = "btn_Rellenar";
            this.btn_Rellenar.Size = new System.Drawing.Size(100, 23);
            this.btn_Rellenar.TabIndex = 5;
            this.btn_Rellenar.Text = "Administrador";
            this.btn_Rellenar.UseVisualStyleBackColor = true;
            this.btn_Rellenar.Click += new System.EventHandler(this.btn_Rellenar_Click);
            // 
            // btn_RellenarVendedor
            // 
            this.btn_RellenarVendedor.Location = new System.Drawing.Point(200, 173);
            this.btn_RellenarVendedor.Name = "btn_RellenarVendedor";
            this.btn_RellenarVendedor.Size = new System.Drawing.Size(75, 23);
            this.btn_RellenarVendedor.TabIndex = 6;
            this.btn_RellenarVendedor.Text = "Vendedor";
            this.btn_RellenarVendedor.UseVisualStyleBackColor = true;
            this.btn_RellenarVendedor.Click += new System.EventHandler(this.btn_RellenarVendedor_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(335, 280);
            this.Controls.Add(this.btn_RellenarVendedor);
            this.Controls.Add(this.btn_Rellenar);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.txb_ContraseniaInput);
            this.Controls.Add(this.txb_UsuarioInput);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private TextBox txb_UsuarioInput;
        private TextBox txb_ContraseniaInput;
        private Label lbl_Login;
        private Button btn_Rellenar;
        private Button btn_RellenarVendedor;
    }
}