using Logica.Datos;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Sistema
{
    public class Sistema
    {
        // private static List<Articulo> _productos = new List<Articulo>();
        /// <summary>
        /// Obtiene la lista de productos.
        /// </summary>
        /// <returns>La lista de productos.</returns>
        public static List<Articulo> ObtenerProductos()
        {
            ArticuloDB articulos = new ArticuloDB();
            return articulos.ObtenerTodos();

        }
        public static List<Persona> ObtenerUsuarios()
        {
            UsuarioDB<Persona> usuarios = new UsuarioDB<Persona>();
            return usuarios.ObtenerTodos();

        }

        public static void AgregarProducto(string nombre, decimal precio, int stock, int baja)
        {
            
            ArticuloDB articulos = new ArticuloDB();
            Articulo articulo = new Articulo(nombre, precio, stock, baja);
           
            articulos.Agregar(articulo);
        }

        public static void ModificarProducto(Articulo articulo)
        {
            var db = new ArticuloDB();
            db.Modificar(articulo);
        }


        public static void EliminarProducto(int id)
        {
            ArticuloDB articulos = new ArticuloDB();
            articulos.Eliminar(id);
        }

        public static void GuardarProductosEnDB(List<Articulo> productos)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
               

                foreach (var producto in productos)
                {                   
                    articulos.Agregar(producto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los productos en la base de datos: {ex.Message}");
            }
        }
        public static void GuardarProductoEnDB(Articulo producto)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                
                articulos.Agregar(producto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el producto en la base de datos: {ex.Message}");
            }
        }
        public static void ActualizarStock(Articulo articulo)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                
                articulos.Modificar(articulo);
            }
            catch (Exception error)
            {
                throw new Exception("Error al actualizar el stock del artículo en la base de datos: " + error.Message);
            }
        }
        public static Articulo ObtenerProductoPorId(int id)
        {
            var db = new ArticuloDB();
            return db.ObtenerPorId(id);
        }






        /// <summary>
        /// Valida los campos ingresados al agregar un artículo.
        /// </summary>
        /// <param name="articuloInput">El nombre del artículo ingresado.</param>
        /// <param name="precioInput">El precio del artículo ingresado.</param>
        /// <param name="stockInput">El stock del artículo ingresado.</param>
        /// <returns>Un mensaje de error si los campos no son válidos, o null si no hay errores.</returns>
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
        /// <summary>
        /// Aplica un aumento masivo de precios a una lista de productos.
        /// </summary>
        /// <param name="listaProductos">La lista de productos a los que se aplicará el aumento de precios.</param>
        /// <param name="factorAumento">El factor de aumento que se multiplicará por el precio actual de cada producto.</param>
        public static void AplicarAumentoMasivo(List<Articulo> listaProductos, decimal factorAumento)
        {
            foreach (Articulo producto in listaProductos)
            {
                decimal nuevoPrecio = producto.Precio * factorAumento;
                producto.Precio = nuevoPrecio;
            }
        }
        /// <summary>
        /// Obtiene el objeto PersonalInterno del usuario logueado, si existe,
        /// comparando el nombre de usuario y contraseña con los datos de la lista de personas.
        /// </summary>
        /// <param name="user">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <param name="arrayPersona">Lista de personas</param>
        /// <returns>Objeto PersonalInterno del usuario logueado o null si no se encuentra</returns>
        public static PersonalInterno ObtenerUsuarioLogueado(string user, string pass, List<Persona> arrayPersona)
        {
            PersonalInterno personaLogueada = null;
            foreach (PersonalInterno personaUno in arrayPersona)
            {
                if (personaUno.Nombre == user && personaUno.Contrasenia == pass)
                {
                    personaLogueada = personaUno;
                    break;
                }
            }
            return personaLogueada;
        }
        public static bool StringEsInvalido(string auxDato)
        {
            auxDato = auxDato.Trim();
            return string.IsNullOrEmpty(auxDato);
        }

        /// <summary>
        /// Valida los campos de usuario y contraseña.
        /// Muestra un mensaje de error si alguno de los campos es inválido.
        /// </summary>
        /// <param name="user">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <returns>true si los campos son válidos, false de lo contrario</returns>
        public static bool ValidarCamposLogin(string user, string pass)
        {
            if (StringEsInvalido(user) || StringEsInvalido(pass))
            {                
                return false;
            }
                     
            return true;
        }
        /// <summary>
        /// Verifica el ingreso del usuario comparando el nombre de usuario y contraseña
        /// con los datos almacenados en la lista de personas.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contrasenia">Contraseña</param>
        /// <returns>true si el ingreso es válido, false de lo contrario</returns>
        public static bool VerificarIngreso(string usuario, string contrasenia)
        {
            foreach (PersonalInterno p in Sistema.ObtenerUsuarios())
            {
                if (p.Nombre == usuario || p.Contrasenia == contrasenia)
                {
                    return true;                    
                }               
            }
            return false;
        }

        


    }
}
