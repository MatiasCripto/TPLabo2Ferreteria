namespace Vista.Formularios
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.btn_Agrergar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(45, 115);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 15);
            this.lbl_nombre.TabIndex = 39;
            this.lbl_nombre.Text = "Nombre cliente";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(160, 107);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_nombre.TabIndex = 36;
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
            this.btn_Agrergar.Location = new System.Drawing.Point(632, 246);
            this.btn_Agrergar.Name = "btn_Agrergar";
            this.btn_Agrergar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Agrergar.Size = new System.Drawing.Size(94, 43);
            this.btn_Agrergar.TabIndex = 35;
            this.btn_Agrergar.Text = "Agregar";
            this.btn_Agrergar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agrergar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 56);
            this.button1.TabIndex = 34;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(332, 63);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.RowTemplate.Height = 25;
            this.dgv_cliente.Size = new System.Drawing.Size(280, 324);
            this.dgv_cliente.TabIndex = 33;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.btn_Agrergar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_cliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nombre;
        private TextBox txb_nombre;
        private Button btn_Agrergar;
        private Button button1;
        private DataGridView dgv_cliente;
    }
}