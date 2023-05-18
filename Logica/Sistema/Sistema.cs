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
       

        public static void AltaProducto(Articulo producto, PersonalInterno usuario)
        {
            //validaciones
            if (usuario.Role != Enumerados.Role.Administrador)
            {
                throw new Exception("No tiene permiso suficiente");
            }
            GuardarProducto(producto);
        }
        public static void GuardarProducto(Articulo producto)
        {
            producto.Id = Articulo.NexId;
            ParserProductos.CrearProducto(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
        }

        public static void AltaUsuario(Usuarios.PersonalInterno usuario)
        {
            //validaciones
          
            BaseDeDatos.BaseDatosPersonas.Add(usuario);
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
    }
}
