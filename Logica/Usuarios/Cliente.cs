using Logica.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Usuarios
{
    /// <summary>
    /// Clase que representa a un cliente.
    /// </summary>
    public class Cliente : Persona
    {
        int id;
        static int nexId = 1;
        string nombre;
        string usuario;
        string contrasenia;

        public string NumeroCliente { get; set; }

        public override string Saludar(string mensaje)
        {
            return mensaje;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Cliente.
        /// </summary>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <param name="usuario">El nombre de usuario del cliente.</param>
        /// <param name="contrasenia">La contraseña del cliente.</param>
        /// <param name="role">El rol del cliente.</param>
        public Cliente(string nombre, string usuario, string contrasenia, Enumerados.Role role) : base(nombre, usuario, contrasenia, role)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Cliente con un ID específico.
        /// </summary>
        /// <param name="id">El ID del cliente.</param>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <param name="usuario">El nombre de usuario del cliente.</param>
        /// <param name="contrasenia">La contraseña del cliente.</param>
        /// <param name="role">El rol del cliente.</param>
        public Cliente(int id, string nombre, string usuario, string contrasenia, Role role) : base(id, nombre, usuario, contrasenia, role)
        {
            this.id = id;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }
    }
}
