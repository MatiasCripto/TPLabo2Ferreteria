using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using Datos;
using System.Text;
using Entidades.Registro;
using System.Text.Json;
using Logica.Movimientos;

namespace Logica.Sistema
{
    public class Sistema
    {
       /// <summary>
        /// Obtiene o establece el usuario actualmente logueado en el sistema.
        /// </summary>
        public static string UsuarioLogueado { get; set; }

        /// <summary>
        /// Evento que se dispara cuando el precio del dólar cambia.
        /// </summary>
        public event Action<decimal> PrecioDolarCambio;

        /// <summary>
        /// Evento que se dispara cuando se actualizan los últimos valores.
        /// </summary>
        public event Action<decimal[]> UltimosValores;

        /// <summary>
        /// Evento que se dispara para obtener el precio actual.
        /// </summary>
        public event Func<decimal, string> PrecioActual;

        private static PersonalInterno usuarioLogueado;

        private List<decimal> ultimosValores = new List<decimal>();

        private UsuarioDB<Persona> usuarioDB;
        private PersonalInterno usuarioLogueado1;

        public Sistema()
        {
            usuarioDB = new UsuarioDB<Persona>();
        }

        public Sistema(PersonalInterno usuarioLogueado1)
        {
            this.usuarioLogueado1 = usuarioLogueado1;
        }

        /// <summary>
        /// Establece el usuario actualmente logueado en el sistema.
        /// </summary>
        /// <param name="usuario">Usuario actual</param>
        public static void UsuarioActual(PersonalInterno usuario)
        {
            // Realizar la lógica de inicio de sesión y asignar el usuario logueado
            usuarioLogueado = usuario;
        }

        /// <summary>
        /// Obtiene el usuario actualmente logueado en el sistema.
        /// </summary>
        /// <returns>Usuario actual</returns>
        public static PersonalInterno ObtenerUsuarioLogueado()
        {
            return usuarioLogueado;
        }

        /// <summary>
        /// Inicia sesión en el sistema con el nombre de usuario y la contraseña proporcionados.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contraseña">Contraseña</param>
        /// <returns>true si el inicio de sesión es exitoso, false de lo contrario</returns>
        public static bool IniciarSesion(string usuario, string contraseña)
        {
            try
            {
                List<Persona> usuarios = Sistema.ObtenerUsuarios();

                Persona usuarioEncontrado = usuarios.FirstOrDefault(u => u.Usuario == usuario && u.Contrasenia == contraseña);

                if (usuarioEncontrado != null)
                {
                    Console.WriteLine("Inicio de sesión exitoso");
                    return true;
                }

                Console.WriteLine("Nombre de usuario o contraseña incorrectos");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar sesión: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Registra los movimientos realizados en el sistema.
        /// </summary>
        /// <param name="accion">Acción realizada</param>
        public static void RegistrarMovimientos(string accion)
        {
            try
            {
                IRegistradorMovimiento registrar = new RegistrarMovimiento();
                registrar.RegistrarMovimientos(accion, ObtenerUsuarioLogueado());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar los movimientos: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene la lista de productos.
        /// </summary>
        /// <returns>La lista de productos</returns>
        public static List<Articulo> ObtenerProductos()
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                return articulos.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los productos: {ex.Message}");
                return new List<Articulo>();
            }
        }

        /// <summary>
        /// Obtiene la lista de usuarios.
        /// </summary>
        /// <returns>La lista de usuarios</returns>
        public static List<Persona> ObtenerUsuarios()
        {
            try
            {
                UsuarioDB<Persona> usuarios = new UsuarioDB<Persona>();
                return usuarios.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los usuarios: {ex.Message}");
                return new List<Persona>();
            }
        }

        /// <summary>
        /// Obtiene la lista de clientes.
        /// </summary>
        /// <returns>La lista de clientes</returns>
        public static List<Persona> ObtenerClientes()
        {
            try
            {
                ClienteDB usuarios = new ClienteDB();
                return usuarios.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los clientes: {ex.Message}");
                return new List<Persona>();
            }
        }

        /// <summary>
        /// Obtiene la lista de registros.
        /// </summary>
        /// <returns>La lista de registros</returns>
        public static List<Registro> ObtenerRegistros()
        {
            try
            {
                RegistroDB registros = new RegistroDB();
                return registros.ObtenerTodos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los registros: {ex.Message}");
                return new List<Registro>();
            }
        }

        /// <summary>
        /// Exporta una lista de personas en el formato especificado.
        /// </summary>
        /// <param name="listaPersonas">Lista de personas</param>
        /// <param name="filePath">Ruta del archivo de destino</param>
        /// <param name="formato">Formato de exportación (JSON o CSV)</param>
        public static void ExportarListaPersonas(List<Persona> listaPersonas, string filePath, ExportFormat formato)
        {
            try
            {
                if (formato == ExportFormat.JSON)
                {
                    string jsonData = JsonSerializer.Serialize(listaPersonas, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, jsonData);
                }
                else if (formato == ExportFormat.CSV)
                {
                    StringBuilder sb = new StringBuilder();

                    // Agregar encabezados de columna al archivo CSV
                    sb.AppendLine("Id,Nombre,Usuario,Role");

                    foreach (var persona in listaPersonas)
                    {
                        // Agregar datos de cada persona al archivo CSV
                        sb.AppendLine($"{persona.Id},{persona.Nombre},{persona.Usuario},{persona.Role}");
                    }

                    File.WriteAllText(filePath, sb.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar la lista de personas: {ex.Message}");
            }
        }

        /// <summary>
        /// Exporta una lista de artículos en el formato especificado.
        /// </summary>
        /// <param name="listaArticulos">Lista de artículos</param>
        /// <param name="filePath">Ruta del archivo de destino</param>
        /// <param name="formato">Formato de exportación (JSON o CSV)</param>
        public static void ExportarListaArticulos(List<Articulo> listaArticulos, string filePath, ExportFormat formato)
        {
            try
            {
                if (formato == ExportFormat.JSON)
                {
                    string jsonData = JsonSerializer.Serialize(listaArticulos, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, jsonData);
                }
                else if (formato == ExportFormat.CSV)
                {
                    StringBuilder sb = new StringBuilder();

                    // Agregar encabezados de columna al archivo CSV
                    sb.AppendLine("Id,Articulo,Precio,Stock");

                    foreach (var articulo in listaArticulos)
                    {
                        // Agregar datos de cada artículo al archivo CSV
                        sb.AppendLine($"{articulo.Id},{articulo.Nombre},{articulo.Precio},{articulo.Stock}");
                    }

                    File.WriteAllText(filePath, sb.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar la lista de artículos: {ex.Message}");
            }
        }

        /// <summary>
        /// Inicia la ejecución del sistema.
        /// </summary>
        public void Comenzar()
        {
            try
            {
                while (true)
                {
                    Thread.Sleep(2000); // Esperar 2 segundos
                    decimal cambio = new Random().Next(500, 1000);

                    if (ultimosValores.Count < 20)
                    {
                        ultimosValores.Add(cambio);
                    }
                    else
                    {
                        ultimosValores.RemoveAt(0); // Eliminar el primer valor
                        ultimosValores.Add(cambio);
                    }

                    // Invocar el evento UltimosValores con los valores actualizados
                    UltimosValores?.Invoke(ultimosValores.ToArray());

                    PrecioDolarCambio?.Invoke(cambio);
                    PrecioActual?.Invoke(cambio);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar el sistema: {ex.Message}");
            }
        }

        public enum ExportFormat
        {
            JSON,
            CSV
        }


        /// <summary>
        /// Agrega un nuevo producto a la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="stock">Stock del producto</param>
        /// <param name="baja">Indicador de baja del producto</param>
        public static void AgregarProducto(string nombre, decimal precio, int stock, int baja)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                Articulo articulo = new Articulo(nombre, precio, stock, baja);

                articulos.Agregar(articulo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el producto a la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Modifica un producto existente en la base de datos.
        /// </summary>
        /// <param name="articulo">Producto a modificar</param>
        public static void ModificarProducto(Articulo articulo)
        {
            try
            {
                var db = new ArticuloDB();
                db.Modificar(articulo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el producto en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Modifica un usuario existente en la base de datos.
        /// </summary>
        /// <param name="usuario">Usuario a modificar</param>
        public static void ModificarUsuario(Persona usuario)
        {
            try
            {
                var db = new UsuarioDB<Persona>();
                db.Modificar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el usuario en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Modifica un cliente existente en la base de datos.
        /// </summary>
        /// <param name="usuario">Cliente a modificar</param>
        public static void ModificarCliente(Persona usuario)
        {
            try
            {
                var db = new ClienteDB();
                db.Modificar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el cliente en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina un producto de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del producto a eliminar</param>
        public static void EliminarProducto(int id)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                articulos.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el producto de la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina un cliente de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del cliente a eliminar</param>
        public static void EliminarCliente(int id)
        {
            try
            {
                ClienteDB clientes = new ClienteDB();
                clientes.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el cliente de la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina un usuario de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del usuario a eliminar</param>
        public static void EliminarUsuario(int id)
        {
            try
            {
                UsuarioDB<Persona> usuario = new UsuarioDB<Persona>();
                usuario.Eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el usuario de la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda una lista de productos en la base de datos.
        /// </summary>
        /// <param name="productos">Lista de productos a guardar</param>
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

        /// <summary>
        /// Guarda una lista de clientes en la base de datos.
        /// </summary>
        /// <param name="clientes">Lista de clientes a guardar</param>
        public static void GuardarClientesEnDB(List<Persona> clientes)
        {
            try
            {
                ClienteDB personas = new ClienteDB();

                foreach (var cliente in clientes)
                {
                    personas.Agregar(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los clientes en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda una lista de usuarios en la base de datos.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios a guardar</param>
        public static void GuardarUsuariosEnDB(List<Persona> usuarios)
        {
            try
            {
                UsuarioDB<Persona> personas = new UsuarioDB<Persona>();

                foreach (var usuario in usuarios)
                {
                    personas.Agregar(usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los usuarios en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda una lista de registros en la base de datos.
        /// </summary>
        /// <param name="registros">Lista de registros a guardar</param>
        public static void GuardarRegistroEnDB(List<Registro> registros)
        {
            try
            {
                RegistroDB reg = new RegistroDB();

                foreach (var registro in registros)
                {
                    reg.Agregar(registro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los registros en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda un producto en la base de datos.
        /// </summary>
        /// <param name="producto">Producto a guardar</param>
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

        /// <summary>
        /// Guarda un cliente en la base de datos.
        /// </summary>
        /// <param name="cliente">Cliente a guardar</param>
        public static void GuardarClienteEnDB(Persona cliente)
        {
            try
            {
                ClienteDB clientes = new ClienteDB();
                clientes.Agregar(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el cliente en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Guarda un usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Usuario a guardar</param>
        public static void GuardarUsuarioEnDB(Persona usuario)
        {
            try
            {
                UsuarioDB<Persona> personas = new UsuarioDB<Persona>();
                personas.Agregar(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar el usuario en la base de datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza el stock de un producto en la base de datos.
        /// </summary>
        /// <param name="articulo">Producto a actualizar</param>
        public static void ActualizarStock(Articulo articulo)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                articulos.Modificar(articulo);
            }
            catch (Exception error)
            {
                throw new Exception($"Error al actualizar el stock del artículo en la base de datos: {error.Message}");
            }
        }

        /// <summary>
        /// Obtiene un producto de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <returns>El producto encontrado o null si no se encuentra</returns>
        public static Articulo ObtenerProductoPorId(int id)
        {
            var db = new ArticuloDB();
            return db.ObtenerPorId(id);
        }

        /// <summary>
        /// Obtiene un usuario de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del usuario</param>
        /// <returns>El usuario encontrado o null si no se encuentra</returns>
        public static Persona? ObtenerUsuarioPorId(int id)
        {
            var db = new UsuarioDB<Persona>();
            return db.ObtenerPorId(id);
        }

        /// <summary>
        /// Obtiene un cliente de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del cliente</param>
        /// <returns>El cliente encontrado o null si no se encuentra</returns>
        public static Persona? ObtenerClientePorId(int id)
        {
            var db = new ClienteDB();
            return db.ObtenerPorId(id);
        }

        /// <summary>
        /// Asigna un valor numérico a un role específico.
        /// </summary>
        /// <param name="roleInput">Role a asignar</param>
        /// <returns>El valor numérico asignado al role</returns>
        public static int AsignarRole(string roleInput)
        {
            if (roleInput.Equals(Role.Administrador))
            {
                return 0;
            }
            else if (roleInput.Equals(Role.Empleado))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }





        /// <summary>
        /// Valida los campos ingresados al agregar un artículo.
        /// </summary>
        /// <param name="articuloInput">El nombre del artículo ingresado.</param>
        /// <param name="precioInput">El precio del artículo ingresado.</param>
        /// <param name="stockInput">El stock del artículo ingresado.</param>
        /// <returns>Un mensaje de error si los campos no son válidos, o null si no hay errores.</returns>
        public static string ValidarCamposProducto(string articuloInput, string precioInput, string stockInput)
        {
            try
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
            catch (Exception ex)
            {
                throw new Exception($"Error al validar los campos del producto: {ex.Message}");
            }
        }

        /// <summary>
        /// Valida los campos ingresados al agregar un usuario.
        /// </summary>
        /// <param name="usuarioInput">El nombre de usuario ingresado.</param>
        /// <param name="contraseniaInput">La contraseña ingresada.</param>
        /// <returns>Un mensaje de error si los campos no son válidos, o null si no hay errores.</returns>
        public static string ValidarCamposUsuario(string usuarioInput, string contraseniaInput)
        {
            try
            {
                if (string.IsNullOrEmpty(usuarioInput) || string.IsNullOrEmpty(contraseniaInput))
                {
                    return "Todos los campos deben ser completados.";
                }

                return null; // No hay errores de validación
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al validar los campos del usuario: {ex.Message}");
            }
        }

        /// <summary>
        /// Aplica un aumento masivo de precios a una lista de productos.
        /// </summary>
        /// <param name="listaProductos">La lista de productos a los que se aplicará el aumento de precios.</param>
        /// <param name="factorAumento">El factor de aumento que se multiplicará por el precio actual de cada producto.</param>
        public static void AplicarAumentoMasivo(List<Articulo> listaProductos, decimal factorAumento)
        {
            try
            {
                foreach (Articulo producto in listaProductos)
                {
                    decimal nuevoPrecio = producto.Precio * factorAumento;
                    producto.Precio = nuevoPrecio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al aplicar el aumento masivo de precios: {ex.Message}");
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
        public static PersonalInterno ValidarUsuarioLogueado(string user, string pass, List<Persona> arrayPersona)
        {
            try
            {
                PersonalInterno personaLogueada = null;
                foreach (PersonalInterno personaUno in arrayPersona.OfType<PersonalInterno>())
                {
                    if (personaUno.Nombre == user && personaUno.Contrasenia == pass)
                    {
                        personaLogueada = personaUno;
                        break;
                    }
                }
                return personaLogueada;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al validar el usuario logueado: {ex.Message}");
            }
        }

        /// <summary>
        /// Valida si un campo de texto es inválido (vacío o nulo).
        /// </summary>
        /// <param name="auxDato">Campo de texto a validar</param>
        /// <returns>true si el campo es inválido, false si es válido</returns>
        public static bool StringEsInvalido(string auxDato)
        {
            auxDato = auxDato?.Trim();
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
            try
            {
                if (StringEsInvalido(user) || StringEsInvalido(pass))
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al validar los campos de login: {ex.Message}");
            }
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
            try
            {
                foreach (PersonalInterno p in ObtenerUsuarios().OfType<PersonalInterno>())
                {
                    if (p.Nombre == usuario && p.Contrasenia == contrasenia)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al verificar el ingreso del usuario: {ex.Message}");
            }
        }





    }
}
