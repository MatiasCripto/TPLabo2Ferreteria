using Ferreteria.Herramientas;
using Logica.Datos;
using Logica.Usuarios;

namespace Ferreteria
{
    public partial class Login : Form
    {        
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txb_UsuarioInput.Text;
            string pass = txb_ContraseniaInput.Text;

            if(ValidarCamposLogin(user, pass))
            {
                Persona usuario = BaseDeDatosUsuarios.ObtenerUsuario(user, pass);

                if (usuario != null)
                {
                    if (usuario.GetType() == typeof(PersonalInterno))
                    {
                        // ABRIR EL FORM DE PERSONAL INTERNO    
                    }
                    else
                    {
                        // ABRIR EL FORM CLIENTE
                    }
                }
            }
        }

        private static bool ValidarCamposLogin(string user, string pass)
        {
            if (Validador.StringEsInvalido(user) || Validador.StringEsInvalido(pass))
            {
                MessageBox.Show("Uno de los datos es invalido");

                return false;
            }
            return true;
        }
    }
}