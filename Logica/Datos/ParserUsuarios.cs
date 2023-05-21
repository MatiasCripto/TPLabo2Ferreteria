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
        public static void EscribirUsuario(Persona usuario)
        {

            try
            {
                //Para obtener el directorio actual del programa, debes usar la propiedad AppDomain.CurrentDomain.BaseDirectory. Esta propiedad devuelve una cadena que representa el directorio base de la aplicación.
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");

                //valido si el directorio esta creado o no.(Es decir si es valida).
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Escribir los datos del usuario en el archivo.
                using (StreamWriter sw = new StreamWriter("usuarios.txt", true))
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
        public static void EscribirCliente(Persona cliente)
        {

            try
            {
                //Para obtener el directorio actual del programa, debes usar la propiedad AppDomain.CurrentDomain.BaseDirectory. Esta propiedad devuelve una cadena que representa el directorio base de la aplicación.
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.txt");

                //valido si el directorio esta creado o no.(Es decir si es valida).
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Escribir los datos del usuario en el archivo.
                using (StreamWriter sw = new StreamWriter("clientes.txt", true))
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

        public static List<Usuarios.Persona> LeerUsuario()
        {
            List<Persona> usuarios = new List<Persona>();

            try
            {
                // Leemos todas las líneas del archivo
                string[] lineas = File.ReadAllLines("usuarios.txt");

                // Recorremos cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Dividimos la línea en campos utilizando la coma como separador
                    string[] campos = linea.Split(',');
                    // Verifica que la línea tenga exactamente 3 campos
                    if (campos.Length == 5)
                    {
                        // Creamos un objeto Usuario con los campos leídos y lo agrega a la lista de usuarios
                        Usuarios.Persona usuario = new Usuarios.PersonalInterno(int.Parse(campos[0]), campos[1], campos[2], campos[3], Enum.Parse<Role>(campos[4]));
                        usuarios.Add(usuario);
                    }
                }
                Persona.NexId = usuarios[usuarios.Count - 1].Id;
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, se lanza una excepción
                throw new Exception("Error al leer el archivo de usuarios: " + error.Message);
            }
            // Retornamos la lista de usuarios leída desde el archivo

            return usuarios;
        }

        public static List<Persona> LeerCliente()
        {
            List<Persona> clientes = new List<Persona>();

            // Verificar si el archivo existe
            try
            {
                // Leemos todas las líneas del archivo
                string[] lineas = File.ReadAllLines("clientes.txt");

                // Recorremos cada línea del archivo
                foreach (string linea in lineas)
                {
                    // Dividimos la línea en campos utilizando la coma como separador
                    string[] campos = linea.Split(',');
                    // Verifica que la línea tenga exactamente 3 campos
                    if (campos.Length == 5)
                    {
                        // Creamos un objeto Usuario con los campos leídos y lo agrega a la lista de usuarios
                        Usuarios.Persona cliente = new Usuarios.Cliente(int.Parse(campos[0]), campos[1], campos[2], campos[3], Enum.Parse<Role>(campos[4]));
                        clientes.Add(cliente);
                    }
                }
                Persona.NexId = clientes[clientes.Count - 1].Id;
            }
            catch (Exception error)
            {
                // Si ocurre algún error al leer el archivo, se lanza una excepción
                throw new Exception("Error al leer el archivo de usuarios: " + error.Message);
            }
            // Retornamos la lista de usuarios leída desde el archivo

            return clientes;
        }       
        public static void EliminarUsuario(Persona usuario)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");
                string[] lines = File.ReadAllLines(filePath);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');

                        if (campos.Length == 5 && campos[2] == usuario.Usuario) // Verificar el campo de usuario para eliminar la línea
                            continue; // Saltar la línea a eliminar

                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al eliminar el usuario del archivo: " + error.Message);
            }
        } public static void EliminarCliente(Persona usuario)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.txt");
                string[] lines = File.ReadAllLines(filePath);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                        string[] campos = line.Split(',');

                        if (campos.Length == 5 && campos[2] == usuario.Usuario) // Verificar el campo de usuario para eliminar la línea
                            continue; // Saltar la línea a eliminar

                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                throw new Exception("Error al eliminar el usuario del archivo: " + error.Message);
            }
        }

        public static void EscribirCliente(Cliente cliente)
        {
            // Validar el cliente antes de escribirlo en el archivo
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new ArgumentException("El nombre del cliente no puede estar vacío o contener solo espacios en blanco.", nameof(cliente.Nombre));
            }

            if (string.IsNullOrWhiteSpace(cliente.Usuario))
            {
                throw new ArgumentException("El usuario del cliente no puede estar vacío o contener solo espacios en blanco.", nameof(cliente.Usuario));
            }

            if (string.IsNullOrWhiteSpace(cliente.Contrasenia))
            {
                throw new ArgumentException("La contraseña del cliente no puede estar vacía o contener solo espacios en blanco.", nameof(cliente.Contrasenia));
            }

            // Obtener la lista de clientes existentes
            List<Persona> clientesExistentes = LeerCliente();

            // Asignar el siguiente ID al cliente
            cliente.Id = Cliente.NexId;

            // Agregar el cliente a la lista
           // clientesExistentes.Add(cliente);

            // Escribir la lista actualizada en el archivo
            EscribirArchivoCliente(clientesExistentes);
        }

        private static void EscribirArchivoCliente(List<Persona> clientes)
        {
            // Crear un StringBuilder para construir el contenido del archivo
            StringBuilder sb = new StringBuilder();

            foreach (Cliente cliente in clientes)
            {
                // Concatenar los datos del cliente en una línea
                string linea = $"{cliente.Id},{cliente.Nombre},{cliente.Usuario},{cliente.Contrasenia},{cliente.Role}";

                // Agregar la línea al StringBuilder
                sb.AppendLine(linea);
            }

            // Escribir el contenido en el archivo
            File.WriteAllText("clientes.txt", sb.ToString());
        }
    }
}
