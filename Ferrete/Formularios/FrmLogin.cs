using Ferrete.Herramientas;
using Logica.Datos;
using Logica.Enumerados;
using Logica.Usuarios;
using Vista;

namespace Ferrete
{
    public partial class FrmLogin : Form
    {
        List<Persona> personaList;
        public FrmLogin()
        {
            InitializeComponent();
            personaList = ParserUsuarios.LeerUsuario();
        }



        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txb_UsuarioInput.Text;
            string pass = txb_ContraseniaInput.Text;

            //if (user != null)
            //{
            //    if (!ValidarCamposLogin(user, pass))
            //    {
            //        MessageBox.Show("Usuario o contraseña incorrecto");
            //    }
            //}




            if (ValidarCamposLogin(user, pass))
            {
                Persona usuario = BaseDeDatos.ObtenerUsuario(user, pass);

                if (usuario != null)
                {
                    if (usuario.GetType() == typeof(PersonalInterno))
                    {
                        FrmPersonalInterno formPersInt = new FrmPersonalInterno((PersonalInterno)usuario);
                        formPersInt.Show();
                    }
                    else
                    {
                        // ABRIR EL FORM CLIENTE
                    }
                }
            }
        }

        public bool VerificarIngreso(string usuario, string contrasenia)
        {
            foreach (PersonalInterno p in ParserUsuarios.LeerUsuario())
            {
                if (p.Nombre == usuario && p.Contrasenia == contrasenia)
                {
                    AbrirAcceso(p.Role);
                    return true;
                }
            }
            return false;
        }
        private void AbrirAcceso(Role role)
        {

            if (role == Role.Administrador || role == Role.Empleado)
            {

               // FrmPersonalInterno formPersInt = new FrmPersonalInterno();
                //formPersInt.Show();

            }
        }

        private static bool ValidarCamposLogin(string user, string pass)
        {
            if (Herramientas.Herramientas.StringEsInvalido(user) || Herramientas.Herramientas.StringEsInvalido(pass))
            {
                MessageBox.Show("Uno de los datos es invalido");

                return false;
            }
            return true;
        }

        private void btn_Rellenar_Click(object sender, EventArgs e)
        {
            txb_UsuarioInput.Text = "Johnny87";
            txb_ContraseniaInput.Text = "1234";
        }

        private void btn_RellenarVendedor_Click(object sender, EventArgs e)
        {
            txb_UsuarioInput.Text = "Ale22";
            txb_ContraseniaInput.Text = "1234";
        }
    }
}