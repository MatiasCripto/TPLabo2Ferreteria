using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Productos
{
    /// <summary>
    /// Clase que representa un artículo.
    /// </summary>
    public class Articulo
    {
        private int id;        
        private string nombre;
        private decimal precio;
        private int stock;
        private int baja;

        public Articulo()
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Articulo.
        /// </summary>
        /// <param name="nombre">El nombre del artículo.</param>
        /// <param name="precio">El precio del artículo.</param>
        /// <param name="stock">La cantidad en stock del artículo.</param>
        /// <param name="baja">Indica si el artículo está dado de baja.</param>
        public Articulo(string nombre, decimal precio, int stock, int baja)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.baja = baja;
        }

        /// <summary>
        /// Crea una nueva instancia de la clase Articulo con un ID específico.
        /// </summary>
        /// <param name="id">El ID del artículo.</param>
        /// <param name="nombre">El nombre del artículo.</param>
        /// <param name="precio">El precio del artículo.</param>
        /// <param name="stock">La cantidad en stock del artículo.</param>
        /// <param name="baja">Indica si el artículo está dado de baja.</param>
        public Articulo(int id, string nombre, decimal precio, int stock, int baja) : this(nombre, precio, stock, baja)
        {
            this.id = id;
        }

        /// <summary>
        /// Obtiene o establece el ID del artículo.
        /// </summary>
        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Obtiene o establece el nombre del artículo.
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }

        /// <summary>
        /// Obtiene o establece el precio del artículo.
        /// </summary>
        public decimal Precio { get => precio; set => precio = value; }

        /// <summary>
        /// Obtiene o establece la cantidad en stock del artículo.
        /// </summary>
        public int Stock { get => stock; set => stock = value; }

        /// <summary>
        /// Obtiene o establece el indicador de baja del artículo.
        /// </summary>
        public int Baja { get => baja; set => baja = value; }

        /// <summary>
        /// Obtiene o establece el siguiente ID disponible para un nuevo artículo.
        /// </summary>
        
    }



}
