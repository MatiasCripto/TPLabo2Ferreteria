using Logica.Enumerados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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
        public PersonalInterno()
        {

        }
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

