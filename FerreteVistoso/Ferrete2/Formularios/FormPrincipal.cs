using Ferrete2.Formularios;

namespace Ferrete2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

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

        private void picbx_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbx_achicar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            picbx_achicar.Visible = false;
            picbx_agrandar.Visible = true;
        }

        private void picbx_agrandar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picbx_achicar.Visible = true;
            picbx_agrandar.Visible = false;
        }

        private void picbx_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void pnl_barraTitulo_MouseMove(object sender, MouseEventArgs e)
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
        private void AbrirFormEnPanel(object FormHijo)
        {
            int largo = pnl_contenedor.Controls.Count;

            for (int i = largo - 1; i >= 0; i--)
            {
                if (pnl_contenedor.Controls[i] is Form form )
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
            this.pictureBox3.SendToBack() ;
            fh.Show();
            fh.Activate();
        }
        private void btn_productos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormProductos());
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormVenta());

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormUsuario());
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCliente());
        }

        private void btn_Logs_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormLogs());
        }
    }
}