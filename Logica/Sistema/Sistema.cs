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

        public static List<Articulo> ObtenerProductos()
        {            
            return ParserProductos.LeerProductos();
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
