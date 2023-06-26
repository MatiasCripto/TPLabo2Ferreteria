using Ferrete2.Formularios;

namespace Ferrete2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cambia el ancho del panel vertical del menú.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pnl_menuVertical.Width == 250)
            {
                pnl_menuVertical.Width = 70;
            }
            else
            {
                pnl_menuVertical.Width = 250;
            }
        }

        /// <summary>
        /// Cierra el formulario principal.
        /// </summary>
        private void picbx_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Restaura el formulario al tamaño normal.
        /// </summary>
        private void picbx_achicar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Normal;
                picbx_achicar.Visible = false;
                picbx_agrandar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar el tamaño del formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maximiza el formulario.
        /// </summary>
        private void picbx_agrandar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                picbx_achicar.Visible = true;
                picbx_agrandar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al maximizar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Minimiza el formulario.
        /// </summary>
        private void picbx_minimizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al minimizar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int posY = 0;
        int posX = 0;

        /// <summary>
        /// Permite arrastrar el formulario al hacer clic en la barra de título.
        /// </summary>
        private void pnl_barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Left)
                {
                    posX = e.X;
                    posY = e.Y;
                }
                else
                {
                    Left += (e.X - posX);
                    Top += (e.Y - posY);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mover el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre un formulario hijo y lo muestra en el panel contenedor.
        /// </summary>
        private void AbrirFormEnPanel(object FormHijo)
        {
            try
            {
                int largo = pnl_contenedor.Controls.Count;

                for (int i = largo - 1; i >= 0; i--)
                {
                    if (pnl_contenedor.Controls[i] is Form form)
                    {
                        this.pnl_contenedor.Controls.RemoveAt(i);
                        this.pictureBox3.Visible = true;
                    }
                }

                Form fh = FormHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnl_contenedor.Controls.Add(fh);
                this.pnl_contenedor.Tag = fh;
                this.pictureBox3.SendToBack();
                fh.Show();
                fh.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario hijo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el formulario de productos.
        /// </summary>
        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormProductos());
        }

        /// <summary>
        /// Actualiza la hora y fecha mostradas en el formulario.
        /// </summary>
        private void fechaHora_Tick(object sender, EventArgs e)
        {
            try
            {
                lbl_Hora.Text = DateTime.Now.ToLongTimeString();
                lbl_Fecha.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la hora y fecha actual: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el formulario de ventas.
        /// </summary>
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVenta());
        }

        /// <summary>
        /// Abre el formulario de usuarios.
        /// </summary>
        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormUsuario());
        }

        /// <summary>
        /// Abre el formulario de clientes.
        /// </summary>
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCliente());
        }

        /// <summary>
        /// Abre el formulario de logs.
        /// </summary>
        private void btn_Logs_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormLogs());
        }
    }
}
