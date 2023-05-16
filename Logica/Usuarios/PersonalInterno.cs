using Logica.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Usuarios
{
    public class PersonalInterno : Persona
    {
        Role role;
        public PersonalInterno(int id, string nombre, string usuario,
                               string contrasenia, Role role = Role.Empleado) : base(id, nombre, usuario, contrasenia)

        {
            this.role = role;
        }
        
        public Role Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
