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

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Login".
        /// Realiza la validación de los campos de usuario y contraseña,
        /// verifica el ingreso del usuario y abre el formulario correspondiente.
        /// </summary>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txb_UsuarioInput.Text;
            string pass = txb_ContraseniaInput.Text;

            if (ValidarCamposLogin(user, pass))
            {
                PersonalInterno usuario = ObtenerUsuarioLogueado(user, pass, personaList);

                if (usuario != null)
                {
                    if (usuario.GetType() == typeof(PersonalInterno))
                    {
                        FrmPersonalInterno formPersInt = new FrmPersonalInterno((PersonalInterno)usuario);
                        formPersInt.Show();
                    }
                   
                }
            }
        }

        /// <summary>
        /// Verifica el ingreso del usuario comparando el nombre de usuario y contraseña
        /// con los datos almacenados en la lista de personas.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contrasenia">Contraseña</param>
        /// <returns>true si el ingreso es válido, false de lo contrario</returns>
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

        /// <summary>
        /// Abre el acceso correspondiente según el rol del usuario.
        /// </summary>
        /// <param name="role">Rol del usuario</param>
        private void AbrirAcceso(Role role)
        {
            if (role == Role.Administrador || role == Role.Empleado)
            {
                // FrmPersonalInterno formPersInt = new FrmPersonalInterno();
                // formPersInt.Show();
            }
        }

        /// <summary>
        /// Obtiene el objeto PersonalInterno del usuario logueado, si existe,
        /// comparando el nombre de usuario y contraseña con los datos de la lista de personas.
        /// </summary>
        /// <param name="user">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <param name="arrayPersona">Lista de personas</param>
        /// <returns>Objeto PersonalInterno del usuario logueado o null si no se encuentra</returns>
        private PersonalInterno ObtenerUsuarioLogueado(string user, string pass, List<Persona> arrayPersona)
        {
            PersonalInterno personaLogueada = null;
            foreach (PersonalInterno personaUno in arrayPersona)
            {
                if (personaUno.Nombre == user && personaUno.Contrasenia == pass)
                {
                    personaLogueada = personaUno;
                    break;
                }
            }
            return personaLogueada;
        }

        /// <summary>
        /// Valida los campos de usuario y contraseña.
        /// Muestra un mensaje de error si alguno de los campos es inválido.
        /// </summary>
        /// <param name="user">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>true si los campos son válidos, false de lo contrario</returns>
        private static bool ValidarCamposLogin(string user, string pass)
        {
            if (Herramientas.Herramientas.StringEsInvalido(user) || Herramientas.Herramientas.StringEsInvalido(pass))
            {
                MessageBox.Show("Uno de los datos es inválido");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "Rellenar".
        /// Rellena los campos de usuario y contraseña con valores predefinidos.
        /// </summary>
        private void btn_Rellenar_Click(object sender, EventArgs e)
        {
            txb_UsuarioInput.Text = "Johnny87";
            txb_ContraseniaInput.Text = "1234";
        }

        /// <summary>
        /// Método que se ejecuta al hacer clic en el botón "RellenarVendedor".
        /// Rellena los campos de usuario y contraseña con valores predefinidos para un vendedor.
        /// </summary>
        private void btn_RellenarVendedor_Click(object sender, EventArgs e)
        {
            txb_UsuarioInput.Text = "Ale22";
            txb_ContraseniaInput.Text = "1234";
        }
    }

}