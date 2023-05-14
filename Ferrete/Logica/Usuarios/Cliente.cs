using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Usuarios
{
    public class Cliente : Persona
    {
        public Cliente(int id, string nombre, string usuario, string contrasenia) : base(id, nombre, usuario, contrasenia)
        {
        }
    }
}
