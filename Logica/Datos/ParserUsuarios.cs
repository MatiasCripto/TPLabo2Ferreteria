using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Datos
{
    public class ParserUsuarios
    {
        /// <summary>
        /// Escribe los datos de un usuario en el archivo de usuarios.
        /// </summary>
        /// <param name="usuario">Objeto Persona que representa al usuario a escribir.</param>
        public static void EscribirUsuario(Persona usuario)
        {
            try
            {
                // Obtiene la ruta completa del archivo de usuarios
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");

                // Verifica si el directorio del archivo existe, de lo contrario, lo crea
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Escribe los datos del usuario en el archivo
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4}", usuario.Id, usuario.Nombre, usuario.Usuario, usuario.Contrasenia, usuario.Role);
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

        /// <summary>
        /// Escribe los datos de un cliente en el archivo de clientes.
        /// </summary>
        /// <param name="cliente">Objeto Persona que representa al cliente a escribir.</param>
        public static void EscribirCliente(Persona cliente)
        {
            try
            {
                // Obtiene la ruta completa del archivo de clientes
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.txt");

                // Verifica si el directorio del archivo existe, de lo contrario, lo crea
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Escribe los datos del cliente en el archivo
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("{0},{1},{2},{3},{4}", cliente.Id, cliente.Nombre, cliente.Usuario, cliente.Contrasenia, cliente.Role);
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de archivo al guardar el cliente: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception($"Acceso no autorizado al archivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error desconocido al guardar el cliente: {ex.Message}");
            }
        }

        /// <summary>
        /// Lee los usuarios almacenados en el archivo de usuarios.
        /// </summary>
        /// <returns>Una lista de objetos Persona que representa a los usuarios leídos.</returns>
        public static List<Persona> LeerUsuario()
        {
            List<Persona> usuarios = new List<Persona>();

            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines("usuarios.txt");

                // Recorre cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Divide la línea en campos utilizando la coma como separador
                    string[] campos = linea.Split(',');

                    // Verifica que la línea tenga exactamente 5 campos
                    if (campos.Length == 5)
                    {
                        // Crea un objeto Persona con los campos leídos y lo agrega a la lista de usuarios
                        Usuarios.Persona usuario = new Usuarios.PersonalInterno(int.Parse(campos[0]), campos[1], campos[2], campos[3], Enum.Parse<Role>(campos[4]));
                        usuarios.Add(usuario);
                    }
                }
                Persona.NexId = usuarios[usuarios.Count - 1].Id;
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, lanza una excepción
                throw new Exception("Error al leer el archivo de usuarios: " + error.Message);
            }

            // Retorna la lista de usuarios leída desde el archivo
            return usuarios;
        }

        /// <summary>
        /// Lee los clientes almacenados en el archivo de clientes.
        /// </summary>
        /// <returns>Una lista de objetos Persona que representa a los clientes leídos.</returns>
        public static List<Persona> LeerCliente()
        {
            List<Persona> clientes = new List<Persona>();

            try
            {
                // Verifica si el archivo de clientes existe
                if (File.Exists("clientes.txt"))
                {
                    // Lee todas las líneas del archivo
                    string[] lineas = File.ReadAllLines("clientes.txt");

                    // Recorre cada línea del archivo
                    foreach (string linea in lineas)
                    {
                        // Divide la línea en campos utilizando la coma como separador
                        string[] campos = linea.Split(',');

                        // Verifica que la línea tenga exactamente 5 campos
                        if (campos.Length == 5)
                        {
                            // Crea un objeto Persona con los campos leídos y lo agrega a la lista de clientes
                            Usuarios.Persona cliente = new Usuarios.Cliente(int.Parse(campos[0]), campos[1], campos[2], campos[3], Enum.Parse<Role>(campos[4]));
                            clientes.Add(cliente);
                        }
                    }
                    Persona.NexId = clientes[clientes.Count - 1].Id;
                }
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, lanza una excepción
                throw new Exception("Error al leer el archivo de clientes: " + error.Message);
            }

            // Retorna la lista de clientes leída desde el archivo
            return clientes;
        }

        /// <summary>
        /// Elimina un usuario del archivo de usuarios.
        /// </summary>
        /// <param name="usuario">Objeto Persona que representa al usuario a eliminar.</param>
        public static void EliminarUsuario(Persona usuario)
        {
            try
            {
                // Obtiene la ruta completa del archivo de usuarios
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");

                // Lee todas las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                // Escribe las líneas excluyendo el usuario a eliminar
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');

                        if (campos.Length == 5 && campos[2] == usuario.Usuario) // Verifica el campo de usuario para eliminar la línea
                            continue; // Salta la línea a eliminar

                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al eliminar el usuario del archivo: " + error.Message);
            }
        }

        /// <summary>
        /// Elimina un cliente del archivo de clientes.
        /// </summary>
        /// <param name="cliente">Objeto Persona que representa al cliente a eliminar.</param>
        public static void EliminarCliente(Persona cliente)
        {
            try
            {
                // Obtiene la ruta completa del archivo de clientes
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.txt");

                // Verifica si el archivo de clientes existe
                if (File.Exists(filePath))
                {
                    // Lee todas las líneas del archivo
                    string[] lines = File.ReadAllLines(filePath);

                    // Escribe las líneas excluyendo el cliente a eliminar
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        foreach (string line in lines)
                        {
                            string[] campos = line.Split(',');

                            if (campos.Length == 5 && campos[2] == cliente.Usuario) // Verifica el campo de usuario para eliminar la línea
                                continue; // Salta la línea a eliminar

                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al eliminar el cliente del archivo: " + error.Message);
            }
        }

    }
}
