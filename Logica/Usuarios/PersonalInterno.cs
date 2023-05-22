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
               
        public PersonalInterno( string nombre, string usuario,
                               string contrasenia, Role role ) : base(nombre, usuario, contrasenia, role)

        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasenia = contrasenia;           
        }

        public PersonalInterno(int id, string nombre, string usuario, string contrasenia, Role role) : base(id, nombre, usuario, contrasenia, role)
        {
        }
        public PersonalInterno()
        {

        }
    }
}
