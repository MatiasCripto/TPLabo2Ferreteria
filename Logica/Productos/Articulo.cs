using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Productos
{
    public class Articulo
    {
        int id;
        static int nexId = 1;
        string nombre;
        decimal precio;
        int stock;
        bool baja;

        public Articulo(string nombre, decimal precio, int stock, bool baja)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.baja = baja;
        }
        public Articulo(int id, string nombre, decimal precio, int stock, bool baja) : this (nombre, precio, stock, baja)
        {
            this.id = id;            
        }


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public static int NexId { get => ++nexId; set => nexId = value; }
        public bool Baja { get => baja; set => baja = value; }
    }
  


}
