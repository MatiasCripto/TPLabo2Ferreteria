using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Datos
{
    public static class BaseDeDatos
    {
        private static List<Persona> _baseDatosPersonas;
        private static List<Articulo> _baseDatosProductos;

        public static List<Articulo> BaseDatosProductos { get => _baseDatosProductos; set => _baseDatosProductos = value; }
        public static List<Persona> BaseDatosPersonas { get => _baseDatosPersonas; set => _baseDatosPersonas = value; }

        static BaseDeDatos()
        {
            _baseDatosPersonas = new List<Persona>();
            _baseDatosProductos = new List<Articulo>();
            HarcodeoPersonas();


        }


        private static void HarcodeoPersonas()
        {
            _baseDatosPersonas.Add(new Cliente(Persona.NexId, "Ana", "nava12", "1234"));
            _baseDatosPersonas.Add(new Cliente(Persona.NexId, "Kiara", "kiara22", "1234"));
            _baseDatosPersonas.Add(new PersonalInterno(Persona.NexId, "Jonatan", "Johnny87", "1234", Enumerados.Role.Administrador));
            _baseDatosPersonas.Add(new PersonalInterno(Persona.NexId, "Alejandro", "Ale22", "1234", Enumerados.Role.Empleado));
        }

        public static Persona ObtenerUsuario(string usuario, string contrasenia)
        {
            foreach (Persona item in _baseDatosPersonas)
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
