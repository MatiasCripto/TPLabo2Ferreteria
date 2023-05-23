using Logica.Enumerados;

namespace Logica.Usuarios
{
    /// <summary>
    /// Clase abstracta que representa a una persona.
    /// </summary>
    public abstract class Persona
    {
        private int _id;
        static int nexId = 1;
        private string _nombre;
        private string _usuario;
        private string _contrasenia;
        Role role;

        /// <summary>
        /// Obtiene o establece el ID de la persona.
        /// </summary>
        public int Id { get => _id; set => _id = value; }

        /// <summary>
        /// Obtiene el nombre de la persona.
        /// </summary>
        public string Nombre { get => _nombre; }

        /// <summary>
        /// Obtiene el nombre de usuario de la persona.
        /// </summary>
        public string Usuario { get => _usuario; }

        /// <summary>
        /// Obtiene la contraseña de la persona.
        /// </summary>
        public string Contrasenia { get => _contrasenia; }

        /// <summary>
        /// Obtiene o establece el siguiente ID disponible para una nueva persona.
        /// </summary>
        public static int NexId { get => ++nexId; set => nexId = value; }

        /// <summary>
        /// Obtiene o establece el rol de la persona.
        /// </summary>
        public Role Role { get => role; set => role = value; }

        /// <summary>
        /// Crea una nueva instancia de la clase Persona.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="usuario">El nombre de usuario de la persona.</param>
        /// <param name="contrasenia">La contraseña de la persona.</param>
        /// <param name="role">El rol de la persona.</param>
        protected Persona(string nombre, string usuario, string contrasenia, Role role)
        {
            this._nombre = nombre;
            this._usuario = usuario;
            this._contrasenia = contrasenia;
            this.Role = role;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Persona con un ID específico.
        /// </summary>
        /// <param name="id">El ID de la persona.</param>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="usuario">El nombre de usuario de la persona.</param>
        /// <param name="contrasenia">La contraseña de la persona.</param>
        /// <param name="role">El rol de la persona.</param>
        protected Persona(int id, string nombre, string usuario, string contrasenia, Role role) : this(nombre, usuario, contrasenia, role)
        {
            this._id = id;
        }

        /// <summary>
        /// Comprueba si el usuario y la contraseña coinciden con los de la persona.
        /// </summary>
        /// <param name="usuario">El nombre de usuario a comprobar.</param>
        /// <param name="contrasenia">La contraseña a comprobar.</param>
        /// <returns>True si el usuario y la contraseña coinciden, False en caso contrario.</returns>
        public bool ComprobarUsuario(string usuario, string contrasenia)
        {
            return (this._usuario == usuario && this._contrasenia == contrasenia);
        }

        /// <summary>
        /// Constructor por defecto de la clase Persona.
        /// </summary>
        public Persona()
        {

        }
    }

    //OLIMORFISMO
    /*
     * public abstract class Persona
{
public string Nombre { get; set; }

public abstract void Saludar();
}

public class PersonalInterno : Persona
{
public string Departamento { get; set; }

public override void Saludar()
{
    Console.WriteLine($"¡Hola! Soy {Nombre} y trabajo en el departamento de {Departamento}.");
}
}

public class Cliente : Persona
{
public string NumeroCliente { get; set; }

public override void Saludar()
{
    Console.WriteLine($"¡Hola! Soy {Nombre} y soy cliente con número {NumeroCliente}.");
}
}

     */
}
