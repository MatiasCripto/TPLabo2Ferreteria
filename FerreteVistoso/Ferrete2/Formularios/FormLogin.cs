
using Datos;
using Entidades.Registro;
using Logica.Enumerados;
using Logica.Sistema;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrete2.Formularios
{
    public partial class FormLogin : Form
    {
        List<Persona> personaList;

        public FormLogin()
        {
            InitializeComponent();
            personaList = Sistema.ObtenerUsuarios();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Evento Load del formulario
        }

        private void picbx_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picbx_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txb_Usuario.Text;
            string pass = txb_contrasenia.Text;

            try
            {
                Sistema.IniciarSesion(user, pass);
                if (Sistema.ValidarCamposLogin(user, pass) == false || (Sistema.VerificarIngreso(user, pass) == false))
                {
                    MensajeError("Error, campos no coinciden o incompletos");
                }
                else
                {
                    PersonalInterno usuario = Sistema.ValidarUsuarioLogueado(user, pass, personaList);
                    Sistema.UsuarioActual(usuario);

                    if (usuario != null)
                    {
                        if (usuario.GetType() == typeof(PersonalInterno))
                        {
                            usuario = Sistema.ObtenerUsuarioLogueado();
                            Sistema.UsuarioLogueado = usuario.Nombre;
                            Sistema.RegistrarMovimientos("Inicio sesión");
                            FormPrincipal frmPrincipal = new FormPrincipal();
                            frmPrincipal.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeError("Error al iniciar sesión: " + ex.Message);
            }
        }

        /// <summary>
        /// Abre el acceso correspondiente según el rol del usuario.
        /// </summary>
        /// <param name="role">Rol del usuario</param>
        private void AbrirAcceso(Role role)
        {
            // Tu implementación actual del método
        }

        private void MensajeError(string mensaje)
        {
            lbl_mensajeError.Text = "    " + mensaje;
            lbl_mensajeError.Visible = true;
        }

        private void txb_Usuario_Enter(object sender, EventArgs e)
        {
            // Evento Enter del campo de usuario
            if (txb_Usuario.Text == "USUARIO")
            {
                txb_Usuario.Text = "";
                txb_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txb_Usuario_Leave(object sender, EventArgs e)
        {
            // Evento Leave del campo de usuario
            if (txb_Usuario.Text == "")
            {
                txb_Usuario.Text = "USUARIO";
                txb_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void txb_contrasenia_Enter(object sender, EventArgs e)
        {
            // Evento Enter del campo de contraseña
            if (txb_contrasenia.Text == "CONTRASEÑA")
            {
                txb_contrasenia.Text = "";
                txb_contrasenia.ForeColor = Color.LightGray;
                txb_contrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txb_contrasenia_Leave(object sender, EventArgs e)
        {
            // Evento Leave del campo de contraseña
            if (txb_contrasenia.Text == "")
            {
                txb_contrasenia.Text = "CONTRASEÑA";
                txb_contrasenia.ForeColor = Color.DimGray;
                txb_contrasenia.UseSystemPasswordChar = false;
            }
        }
        int posY = 0;
        int posX = 0;
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            // Evento MouseMove del formulario
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

        private void pnl_Login_MouseMove(object sender, MouseEventArgs e)
        {
            // Evento MouseMove del panel de login
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

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Rellenar".
        /// Rellena los campos de usuario y contraseña con valores predefinidos.
        /// </summary>
        private void btn_RellenarVendedor_Click(object sender, EventArgs e)
        {
            txb_Usuario.Text = "alejandro";
            txb_contrasenia.Text = "1234";
            txb_contrasenia.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Rellenar".
        /// Rellena los campos de usuario y contraseña con valores predefinidos para un vendedor.
        /// </summary>
        private void btn_Rellenar_Click(object sender, EventArgs e)
        {
            txb_Usuario.Text = "jonatan";
            txb_contrasenia.Text = "1234";
            txb_contrasenia.UseSystemPasswordChar = true;
        }
    }
}
