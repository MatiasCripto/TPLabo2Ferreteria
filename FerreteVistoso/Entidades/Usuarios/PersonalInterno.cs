using Logica.Enumerados;

namespace Logica.Usuarios
{
    /// <summary>
    /// Clase que representa a un personal interno de la empresa.
    /// </summary>
    public class PersonalInterno : Persona
    {
        private int id;
        private string nombre;
        private string usuario;
        private string contrasenia;

        public string Funciones { get; set; }

        /// <summary>
        /// Saluda con un mensaje específico.
        /// </summary>
        /// <param name="mensaje">El mensaje de saludo.</param>
        /// <returns>El mensaje de saludo.</returns>
        public override string Saludar(string mensaje)
        {
            return mensaje;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase PersonalInterno.
        /// </summary>
        /// <param name="nombre">El nombre del personal interno.</param>
        /// <param name="usuario">El nombre de usuario del personal interno.</param>
        /// <param name="contrasenia">La contraseña del personal interno.</param>
        /// <param name="role">El rol del personal interno.</param>
        public PersonalInterno(string nombre, string usuario, string contrasenia, Role role) : base(nombre, usuario, contrasenia, role)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase PersonalInterno con un ID específico.
        /// </summary>
        /// <param name="id">El ID del personal interno.</param>
        /// <param name="nombre">El nombre del personal interno.</param>
        /// <param name="usuario">El nombre de usuario del personal interno.</param>
        /// <param name="contrasenia">La contraseña del personal interno.</param>
        /// <param name="role">El rol del personal interno.</param>
        public PersonalInterno(int id, string nombre, string usuario, string contrasenia, Role role) : base(id, nombre, usuario, contrasenia, role)
        {
        }

        /// <summary>
        /// Constructor por defecto de la clase PersonalInterno.
        /// </summary>
        public PersonalInterno(string v)
        {

        }

        /// <summary>
        /// Obtiene el descuento aplicable a una venta según el rol del personal interno.
        /// </summary>
        /// <param name="totalVenta">El total de la venta.</param>
        /// <returns>El descuento aplicable.</returns>
        public override decimal ObtenerDescuento(decimal totalVenta)
        {
            if (this.Role == Role.Administrador)
            {
                return totalVenta * 0.1m;
            }
            else
            {
                return totalVenta * 0.15m;
            }
        }
    }
}
