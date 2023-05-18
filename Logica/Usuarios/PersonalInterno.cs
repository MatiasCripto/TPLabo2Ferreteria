using Logica.Enumerados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Usuarios
{
    public class PersonalInterno : Persona
    {
        int id;
        static int nexId = 1;
        string nombre;
        string usuario;
        string contrasenia;
        Role role;
        public PersonalInterno(int id, string nombre, string usuario,
                               string contrasenia, Role role = Role.Empleado) : base(id, nombre, usuario, contrasenia)

        {
            this.id = id;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.Role1 = role;
        }
        public PersonalInterno( string nombre, string usuario,
                               string contrasenia, Role role = Role.Empleado) : base(nombre, usuario, contrasenia)

        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.Role1 = role;
        }

        public PersonalInterno(int id, string nombre, string usuario, string contrasenia, string v) : base(id, nombre, usuario, contrasenia)
        {
        }

        public Role Role
        {
            get { return Role1; }
            set { Role1 = value; }
        }

        public new int Id { get => id; set => id = value; }
        public static new int NexId { get => ++nexId; set => nexId = value; }
        public new string Nombre { get => nombre; }
        public new string Usuario { get => usuario; }
        public new string Contrasenia { get => contrasenia; }
        public Role Role1 { get => role; set => role = value; }
    }
}
