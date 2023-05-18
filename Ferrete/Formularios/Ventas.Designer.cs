namespace Vista.Formularios
{
    partial class Ventas
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
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_buscar = new System.Windows.Forms.TextBox();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_buscar
            // 
            this.txb_buscar.Location = new System.Drawing.Point(264, 62);
            this.txb_buscar.Name = "txb_buscar";
            this.txb_buscar.Size = new System.Drawing.Size(100, 23);
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
            this.dgv_venta.Size = new System.Drawing.Size(375, 250);
            this.dgv_venta.TabIndex = 3;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_venta);
            this.Controls.Add(this.txb_buscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_stock);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_stock;
        private Button button1;
        private TextBox txb_buscar;
        private DataGridView dgv_venta;
    }
}