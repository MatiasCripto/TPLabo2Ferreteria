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
        public static void CrearUsuario(int id, string nombre, string usuario, string contrasenia, Role role)
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
                    sw.WriteLine("{0},{1},{2},{3},{4}", id, nombre, usuario, contrasenia, role);
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

        public static List<Usuarios.Persona> LeerUsuario()
        {
            List<Usuarios.Persona> usuarios = new List<Usuarios.Persona>();

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

        public static List<Usuarios.Persona> LeerClientes()
        {
            List<Usuarios.Persona> clientes = new List<Usuarios.Persona>();

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
                throw new Exception("Error al leer el archivo de clientes: " + error.Message);
            }
            // Retornamos la lista de usuarios leída desde el archivo

            return clientes;
        }
    }
}
