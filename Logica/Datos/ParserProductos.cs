using Logica.Productos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Datos
{
    public static class ParserProductos
    {
        /// <summary>
        /// Lee los productos desde el archivo "productos.txt".
        /// </summary>
        /// <returns>Lista de productos leída desde el archivo.</returns>
        public static List<Articulo> LeerProductos()
        {
            List<Articulo> productos = new List<Articulo>();

            try
            {
                // Leemos todas las líneas del archivo
                string[] lineas = File.ReadAllLines("productos.txt");

                // Recorremos cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Dividimos la línea en campos utilizando la coma como separador
                    string[] campos = linea.Split(',');

                    // Verifica que la línea tenga exactamente 5 campos
                    if (campos.Length == 5)
                    {
                        bool auxBaja;
                        if (campos[4] == "False")
                        {
                            auxBaja = false;
                        }
                        else
                        {
                            auxBaja = true;
                        }

                        // Creamos un objeto Articulo con los campos leídos y lo agregamos a la lista de productos
                        Articulo producto = new Articulo(int.Parse(campos[0]), campos[1], decimal.Parse(campos[2],
                            System.Globalization.CultureInfo.InvariantCulture), int.Parse(campos[3]), auxBaja);
                        productos.Add(producto);
                    }
                }

                // Establecemos el próximo ID disponible para los productos
                Articulo.NexId = productos[productos.Count - 1].Id;
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, se lanza una excepción
                throw new Exception("Error al leer el archivo de productos: " + error.Message);
            }

            // Retornamos la lista de productos leída desde el archivo
            return productos;
        }

        /// <summary>
        /// Escribe la lista de productos en el archivo "productos.txt".
        /// </summary>
        /// <param name="productos">Lista de productos a escribir en el archivo.</param>
        public static void EscribirArchivo(List<Articulo> productos)
        {
            try
            {
                // Obtenemos el directorio actual del programa
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");

                // Validamos si el directorio está creado o no
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                foreach (var producto in productos)
                {
                    // Escribir los datos del producto en el archivo
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine("{0},{1},{2},{3},{4}", producto.Id, producto.Nombre, producto.Precio.ToString("0.00", CultureInfo.InvariantCulture), producto.Stock, producto.Baja);
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de archivo al guardar el archivo: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"Acceso no autorizado al archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido al guardar el producto: {ex.Message}");
            }
        }

        /// <summary>
        /// Escribe un producto en el archivo "productos.txt".
        /// </summary>
        /// <param name="producto">Producto a escribir en el archivo.</param>
        public static void EscribirProducto(Articulo producto)
        {
            try
            {
                // Obtenemos el directorio actual del programa
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");

                // Validamos si el directorio está creado o no
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Escribir los datos del producto en el archivo
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4}", producto.Id, producto.Nombre, producto.Precio.ToString("0.00", CultureInfo.InvariantCulture), producto.Stock, producto.Baja);
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de archivo al guardar el archivo: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"Acceso no autorizado al archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido al guardar el producto: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza los datos de un artículo en el archivo "productos.txt".
        /// </summary>
        /// <param name="articulo">Artículo con los datos actualizados.</param>
        public static void ActualizarArticulo(Articulo articulo)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");
                string[] lines = File.ReadAllLines(filePath);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');

                        if (campos.Length == 4 && campos[0] == articulo.Id.ToString()) // Verificar el campo de ID para actualizar la línea
                        {
                            sw.WriteLine($"{articulo.Id},{articulo.Nombre},{articulo.Precio},{articulo.Stock}");
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al actualizar el artículo en el archivo: " + error.Message);
            }
        }

        /// <summary>
        /// Actualiza el stock de un artículo en el archivo "productos.txt".
        /// </summary>
        /// <param name="articulo">Artículo con el stock actualizado.</param>
        public static void ActualizarStock(Articulo articulo)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] campos = lines[i].Split(',');

                    if (campos.Length == 5 && campos[0] == articulo.Id.ToString()) // Verificar el campo de ID para actualizar la línea
                    {
                        campos[3] = articulo.Stock.ToString(); // Actualizar el campo de stock
                        lines[i] = string.Join(",", campos); // Unir los campos actualizados
                        break; // No es necesario seguir recorriendo el archivo
                    }
                }

                File.WriteAllLines(filePath, lines); // Escribir las líneas actualizadas en el archivo
            }
            catch (Exception error)
            {
                throw new Exception("Error al actualizar el stock del artículo en el archivo: " + error.Message);
            }
        }
    }

}

