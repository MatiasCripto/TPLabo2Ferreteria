using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Datos
{
    public static class BaseDeDatosUsuarios
    {

        static List<Persona> BaseDatosPersonas;

        static BaseDeDatosUsuarios()
        {
            BaseDatosPersonas = new List<Persona>();
            HarcodeoPersonas();
        }

        private static void HarcodeoPersonas()
        {
            BaseDatosPersonas.Add(new PersonalInterno(2, "Jonatan", "Johnny87", "1234"));
            BaseDatosPersonas.Add(new PersonalInterno(4, "Alejandro", "Ale22", "1234"));
            BaseDatosPersonas.Add(new Cliente(1, "Ana", "nava12", "1234"));
            BaseDatosPersonas.Add(new Cliente(3, "Kiara", "kiara22", "1234"));
        }
       
        public static Persona? ObtenerUsuario(string usuario, string contrasenia)
        {
            foreach (Persona item in BaseDatosPersonas)
            {
                if (item.ComprobarUsuario(usuario, contrasenia))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
