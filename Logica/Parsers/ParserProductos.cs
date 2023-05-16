using Logica.Productos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Parsers
{
    public static class ParserProductos
    {

        public static void CrearProducto(int id, string nombre, decimal precio, int stock)
        {

            try
            {
                //Para obtener el directorio actual del programa, debes usar la propiedad AppDomain.CurrentDomain.BaseDirectory. Esta propiedad devuelve una cadena que representa el directorio base de la aplicación.
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos.txt");

                //valido si el directorio esta creado o no.(Es decir si es valida).
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }


                // Escribir los datos del usuario en el archivo.
                using (StreamWriter sw = new StreamWriter("productos.txt", true))
                {
                    sw.WriteLine("{0},{1},{2},{3}", id, nombre, precio, stock);
                }
            }

            catch (IOException ex)
            {
                throw new Exception($"Error de archivo al guardar el usuario: {ex.Message}");
            }

            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"Acceso no autorizado al archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
            }


        }

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
                    // Verifica que la línea tenga exactamente 3 campos
                    if (campos.Length == 4)
                    {
                        // Creamos un objeto Usuario con los campos leídos y lo agrega a la lista de usuarios
                        Articulo producto = new Articulo(int.Parse(campos[0]), campos[1], decimal.Parse(campos[2]), int.Parse(campos[3]));
                        productos.Add(producto);
                    }
                }
                Articulo.NexId = productos[productos.Count - 1].Id;
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, se lanza una excepción
                throw new Exception("Error al leer el archivo de usuarios: " + error.Message);
            }
            // Retornamos la lista de usuarios leída desde el archivo

            return productos;
        }
    }
}
