namespace Vista.Formularios
{
    partial class FrmModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProducto));
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.txb_Precio = new System.Windows.Forms.TextBox();
            this.txb_Stock = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Nombre.Location = new System.Drawing.Point(65, 89);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(87, 15);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nuevo nombre";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(200, 81);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 2;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Precio.Location = new System.Drawing.Point(65, 137);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(78, 15);
            this.lbl_Precio.TabIndex = 3;
            this.lbl_Precio.Text = "Nuevo precio";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Stock.Location = new System.Drawing.Point(65, 191);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(73, 15);
            this.lbl_Stock.TabIndex = 4;
            this.lbl_Stock.Text = "Nuevo stock";
            // 
            // txb_Precio
            // 
            this.txb_Precio.Location = new System.Drawing.Point(200, 137);
            this.txb_Precio.Name = "txb_Precio";
            this.txb_Precio.Size = new System.Drawing.Size(100, 23);
            this.txb_Precio.TabIndex = 5;
            // 
            // txb_Stock
            // 
            this.txb_Stock.Location = new System.Drawing.Point(200, 191);
            this.txb_Stock.Name = "txb_Stock";
            this.txb_Stock.Size = new System.Drawing.Size(100, 23);
            this.txb_Stock.TabIndex = 6;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Guardar.FlatAppearance.BorderSize = 2;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.Location = new System.Drawing.Point(65, 276);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Guardar.Size = new System.Drawing.Size(94, 43);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Agrergar_Click);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(206, 276);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 43);
            this.btn_Cancelar.TabIndex = 25;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(384, 375);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txb_Stock);
            this.Controls.Add(this.txb_Precio);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarProducto";
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.FrmModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Nombre;
        private TextBox txb_Nombre;
        private Label lbl_Precio;
        private Label lbl_Stock;
        private TextBox txb_Precio;
        private TextBox txb_Stock;
        private Button btn_Guardar;
        private Button btn_Cancelar;
    }
}