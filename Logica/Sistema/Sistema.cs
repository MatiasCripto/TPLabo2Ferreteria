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
        // private static List<Articulo> _productos = new List<Articulo>();
        /// <summary>
        /// Obtiene la lista de productos.
        /// </summary>
        /// <returns>La lista de productos.</returns>
        public static List<Articulo> ObtenerProductos()
        {
            return ParserProductos.LeerProductos();
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


    }
}
