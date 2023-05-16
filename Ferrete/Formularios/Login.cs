using Ferrete.Herramientas;
using Logica.Datos;
using Logica.Usuarios;
using Vista;

namespace Ferrete
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