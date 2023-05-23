namespace Vista.Formularios
{
    partial class FrmMostrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarUsuarios));
            this.dgv_mostrarUsuarios = new System.Windows.Forms.DataGridView();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mostrarUsuarios
            // 
            this.dgv_mostrarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrarUsuarios.Location = new System.Drawing.Point(266, 64);
            this.dgv_mostrarUsuarios.Name = "dgv_mostrarUsuarios";
            this.dgv_mostrarUsuarios.RowTemplate.Height = 25;
            this.dgv_mostrarUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mostrarUsuarios.Size = new System.Drawing.Size(255, 338);
            this.dgv_mostrarUsuarios.TabIndex = 0;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Actualizar.FlatAppearance.BorderSize = 2;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.Image")));
            this.btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Actualizar.Location = new System.Drawing.Point(30, 189);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(110, 58);
            this.btn_Actualizar.TabIndex = 28;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_Finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Finalizar.FlatAppearance.BorderSize = 2;
            this.btn_Finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_Finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Finalizar.Image")));
            this.btn_Finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Finalizar.Location = new System.Drawing.Point(30, 275);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Finalizar.Size = new System.Drawing.Size(110, 58);
            this.btn_Finalizar.TabIndex = 29;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // FrmMostrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.dgv_mostrarUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarUsuarios";
            this.Text = "Mostrar usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_mostrarUsuarios;
        private Button btn_Actualizar;
        private Button btn_Finalizar;
    }
}