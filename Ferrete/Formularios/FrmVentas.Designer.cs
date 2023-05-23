namespace Vista.Formularios
{
    partial class FrmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.btn_AgregarArticulo = new System.Windows.Forms.Button();
            this.txb_buscar = new System.Windows.Forms.TextBox();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_ImporteTotal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_stock
            // 
            this.dgv_stock.AllowUserToAddRows = false;
            this.dgv_stock.AllowUserToDeleteRows = false;
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(22, 120);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.ReadOnly = true;
            this.dgv_stock.RowTemplate.Height = 25;
            this.dgv_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stock.Size = new System.Drawing.Size(374, 250);
            this.dgv_stock.TabIndex = 0;
            // 
            // btn_AgregarArticulo
            // 
            this.btn_AgregarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_AgregarArticulo.FlatAppearance.BorderSize = 2;
            this.btn_AgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarArticulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_AgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarArticulo.Image")));
            this.btn_AgregarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AgregarArticulo.Location = new System.Drawing.Point(413, 42);
            this.btn_AgregarArticulo.Name = "btn_AgregarArticulo";
            this.btn_AgregarArticulo.Size = new System.Drawing.Size(147, 58);
            this.btn_AgregarArticulo.TabIndex = 1;
            this.btn_AgregarArticulo.Text = "Agregar articulo";
            this.btn_AgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarArticulo.UseVisualStyleBackColor = true;
            this.btn_AgregarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_buscar
            // 
            this.txb_buscar.Location = new System.Drawing.Point(94, 61);
            this.txb_buscar.Name = "txb_buscar";
            this.txb_buscar.Size = new System.Drawing.Size(129, 23);
            this.txb_buscar.TabIndex = 2;
            this.txb_buscar.TextChanged += new System.EventHandler(this.txb_buscar_TextChanged);
            // 
            // dgv_venta
            // 
            this.dgv_venta.AllowUserToAddRows = false;
            this.dgv_venta.AllowUserToDeleteRows = false;
            this.dgv_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venta.Location = new System.Drawing.Point(413, 120);
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.ReadOnly = true;
            this.dgv_venta.RowTemplate.Height = 25;
            this.dgv_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_venta.Size = new System.Drawing.Size(375, 250);
            this.dgv_venta.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.lbl_total.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_total.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_total.Location = new System.Drawing.Point(566, 380);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 37);
            this.lbl_total.TabIndex = 4;
            // 
            // btn_ImporteTotal
            // 
            this.btn_ImporteTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_ImporteTotal.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ImporteTotal.FlatAppearance.BorderSize = 2;
            this.btn_ImporteTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImporteTotal.ForeColor = System.Drawing.Color.White;
            this.btn_ImporteTotal.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImporteTotal.Image")));
            this.btn_ImporteTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImporteTotal.Location = new System.Drawing.Point(413, 380);
            this.btn_ImporteTotal.Name = "btn_ImporteTotal";
            this.btn_ImporteTotal.Padding = new System.Windows.Forms.Padding(1);
            this.btn_ImporteTotal.Size = new System.Drawing.Size(147, 43);
            this.btn_ImporteTotal.TabIndex = 25;
            this.btn_ImporteTotal.Text = "Importe Total";
            this.btn_ImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImporteTotal.UseVisualStyleBackColor = false;
            this.btn_ImporteTotal.Click += new System.EventHandler(this.btn_ImporteTotal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Buscar";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.Location = new System.Drawing.Point(604, 42);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Eliminar.Size = new System.Drawing.Size(151, 56);
            this.btn_Eliminar.TabIndex = 28;
            this.btn_Eliminar.Text = "Eliminar articulo";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_confirmar.FlatAppearance.BorderSize = 2;
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirmar.Image")));
            this.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirmar.Location = new System.Drawing.Point(413, 429);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_confirmar.Size = new System.Drawing.Size(147, 43);
            this.btn_confirmar.TabIndex = 30;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_salir.FlatAppearance.BorderSize = 2;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.Location = new System.Drawing.Point(588, 429);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Padding = new System.Windows.Forms.Padding(1);
            this.btn_salir.Size = new System.Drawing.Size(79, 43);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ImporteTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_venta);
            this.Controls.Add(this.txb_buscar);
            this.Controls.Add(this.btn_AgregarArticulo);
            this.Controls.Add(this.dgv_stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_stock;
        private Button btn_AgregarArticulo;
        private TextBox txb_buscar;
        private DataGridView dgv_venta;
        private Label lbl_total;
        private Button btn_ImporteTotal;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_Eliminar;
        private Button btn_confirmar;
        private Button btn_salir;
    }
}