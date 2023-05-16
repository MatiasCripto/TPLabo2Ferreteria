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
        private static int nexId = 1;
        private static List<Persona> _baseDatosPersonas;
        private static List<Articulo> _baseDatosProductos;

        public static List<Articulo> BaseDatosProductos { get => _baseDatosProductos; set => _baseDatosProductos = value; }

        static BaseDeDatos()
        {
            _baseDatosPersonas = new List<Persona>();
            _baseDatosProductos = new List<Articulo>();
            HarcodeoPersonas();
            //HarcodeoProductos();
        }

        //agregar a lka base de datosd, que reciba un producto  y ahi debntro manejar el id autoincremental

        //private static void HarcodeoProductos()
        //{
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Pala", 123, 50));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Martillo", 321, 40));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Clavo", 654,30));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Pinza", 155,50));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Cupla", 646, 50));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Destornillador", 789, 50));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Alambre", 989, 50));
        //    _baseDatosProductos.Add(new Articulo(nexId++, "Fratacho", 725, 50));

        //}

        //public static void GuardarProductosBaseDatos()
        //{
        //    using (StreamWriter writer = new StreamWriter("productos.txt"))
        //    { 
        //        foreach (Articulo producto in _baseDatosProductos)
        //        { 
        //            writer.WriteLine($"{producto.Id},{producto.Nombre},{producto.Precio},{producto.Stock}");
        //        } 
        //    }
        //}

        private static void HarcodeoPersonas()
        {
            _baseDatosPersonas.Add(new Cliente(1, "Ana", "nava12", "1234"));
            _baseDatosPersonas.Add(new Cliente(2, "Kiara", "kiara22", "1234"));
            _baseDatosPersonas.Add(new PersonalInterno(3, "Jonatan", "Johnny87", "1234", Enumerados.Role.Administrador));
            _baseDatosPersonas.Add(new PersonalInterno(4, "Alejandro", "Ale22", "1234"));
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
