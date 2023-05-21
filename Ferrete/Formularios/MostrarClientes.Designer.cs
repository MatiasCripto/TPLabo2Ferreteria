namespace Vista.Formularios
{
    partial class MostrarClientes
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
            this.dgv_mostrarClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mostrarClientes
            // 
            this.dgv_mostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrarClientes.Location = new System.Drawing.Point(244, 49);
            this.dgv_mostrarClientes.Name = "dgv_mostrarClientes";
            this.dgv_mostrarClientes.RowTemplate.Height = 25;
            this.dgv_mostrarClientes.Size = new System.Drawing.Size(240, 360);
            this.dgv_mostrarClientes.TabIndex = 0;
            // 
            // MostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_mostrarClientes);
            this.Name = "MostrarClientes";
            this.Text = "MostrarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_mostrarClientes;
    }
}