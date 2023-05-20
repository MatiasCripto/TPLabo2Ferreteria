using Logica.Datos;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Sistema
{
    public class Sistema
    {
        private static List<Articulo> _productos = new List<Articulo>();


        //public static void AltaProducto(Articulo producto, PersonalInterno usuario)
        //{
        //    //validaciones
        //    if (usuario.Role != Enumerados.Role.Administrador)
        //    {
        //        throw new Exception("No tiene permiso suficiente");
        //    }
        //    GuardarProducto(producto);
        //}
        //public static void GuardarProducto(Articulo producto)
        //{
        //    producto.Id = Articulo.NexId;
        //    ParserProductos.EscribirProducto(producto.Id, producto.Nombre, producto.Precio, producto.Stock, producto.Baja);
        //}

        public static void AltaUsuario(Usuarios.PersonalInterno usuario)
        {
            //validaciones
            AltaUsuario(usuario);
           
        }

        public static List<Articulo> ObtenerProductos()
        {
            
            return ParserProductos.LeerProductos();
        }

        public static void GuardarUsuario(PersonalInterno usuario)
        {
            usuario.Id = PersonalInterno.NexId;
            ParserUsuarios.CrearUsuario(usuario.Id, usuario.Nombre, usuario.Usuario, usuario.Contrasenia, usuario.Role);
        }

        public static Persona ObtenerUsuario(string usuario, string contrasenia)
        {
            foreach (Persona item in ParserUsuarios.LeerUsuario())
            {
                if (item.ComprobarUsuario(usuario, contrasenia))
                {
                    return item;
                }
            }
            return null;
        }

        public static void BajaProducto(List<Articulo> producto, string id)
        {
            foreach (var articulo in producto)
            {
                if (articulo.Id == int.Parse(id))
                {
                    articulo.Baja = true;
                    break;
                }
            }
        }

        public static string ValidarCamposAgregar(string articuloInput, string precioInput, string stockInput)
        {
            if (string.IsNullOrEmpty(articuloInput) || string.IsNullOrEmpty(precioInput) || string.IsNullOrEmpty(stockInput))
            {
                return "Todos los campos deben ser completados.";
            }

            decimal precio;
            if (!decimal.TryParse(precioInput, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out precio))
            {
                return "El valor ingresado para el precio no es válido. Debe ser un número decimal.";
            }

            int stock;
            if (!int.TryParse(stockInput, out stock))
            {
                return "El valor ingresado para el stock no es válido. Debe ser un número entero.";
            }

            return null; // No hay errores de validación
        }
    }
}
