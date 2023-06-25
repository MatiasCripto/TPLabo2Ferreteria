using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using Datos;
using System.Text;
using Entidades.Registro;
using System.Text.Json;


namespace Logica.Sistema
{
    public class Sistema
    {
        public static string UsuarioLogeado { get; set; }

        public event Action<decimal> PrecioDolarCambio;

        public event Action<decimal[]> UltimosValores;

        public event Func<decimal, string> PrecioActual;

        private static PersonalInterno usuarioLogueado;

        private List<decimal> ultimosValores = new List<decimal>();

        // List <decimal> valoresVeinte = new List<decimal>();

        public static void UsuarioActual(PersonalInterno usuario)
        {
            // Realizar la lógica de inicio de sesión y asignar el usuario logueado
            usuarioLogueado = usuario;
        }

        public static PersonalInterno ObtenerUsuarioLogueado()
        {
            return usuarioLogueado;
        }


        public void Comenzar()
        {
            while (true)
            {
                Thread.Sleep(2000); // Esperar 2 segundo
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
        private UsuarioDB<Persona> usuarioDB;

        public Sistema()
        {
            usuarioDB = new UsuarioDB<Persona>();
        }

        public static bool IniciarSesion(string usuario, string contraseña)
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
        public static void RegistrarMovimientos(string accion)
        {
            IRegistradorMovimiento registrar = new RegistrarMovimiento();
            registrar.RegistrarMovimientos(accion, ObtenerUsuarioLogueado());
        }
        // private static List<Articulo> _productos = new List<Articulo>();
        /// <summary>
        /// Obtiene la lista de productos.
        /// </summary>
        /// <returns>La lista de productos.</returns>
        public static List<Articulo> ObtenerProductos()
        {
            ArticuloDB articulos = new ArticuloDB();
            return articulos.ObtenerTodos();

        }
        public static List<Persona> ObtenerUsuarios()
        {
            UsuarioDB<Persona> usuarios = new UsuarioDB<Persona>();
            return usuarios.ObtenerTodos();

        }
       
        

        public static List<Persona> ObtenerClientes()
        {
            ClienteDB usuarios = new ClienteDB();
            return usuarios.ObtenerTodos();

        }

        public static List<Registro> ObtenerRegistros()
        {
            RegistroDB registros = new RegistroDB();
            return registros.ObtenerTodos();

        }

        public enum ExportFormat
        {
            JSON,
            CSV
        }

        public static void ExportarListaPersonas(List<Persona> listaPersonas, string filePath, ExportFormat formato)
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
                    // Agregar datos de cada artículo al archivo CSV
                    sb.AppendLine($"{persona.Id},{persona.Nombre},{persona.Usuario},{persona.Role}");
                }

                File.WriteAllText(filePath, sb.ToString());
            }
        }

       
        public static void ExportarListaArticulos(List<Articulo> listaArticulos, string filePath, ExportFormat formato)
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



        public static void AgregarProducto(string nombre, decimal precio, int stock, int baja)
        {
            
            ArticuloDB articulos = new ArticuloDB();
            Articulo articulo = new Articulo(nombre, precio, stock, baja);
           
            articulos.Agregar(articulo);
        }

        public static void ModificarProducto(Articulo articulo)
        {
            var db = new ArticuloDB();
            db.Modificar(articulo);
        }
        
        public static void ModificarUsuario(Persona usuario)
        {
            var db = new UsuarioDB<Persona>();
            db.Modificar(usuario);
        }

        public static void ModificarCliente(Persona usuario)
        {
            var db = new ClienteDB();
            db.Modificar(usuario);
        }


        public static void EliminarProducto(int id)
        {
            ArticuloDB articulos = new ArticuloDB();
            articulos.Eliminar(id);
        }

        public static void EliminarCliente(int id)
        {
            ClienteDB clientes = new ClienteDB();
            clientes.Eliminar(id);
        }
        public static void EliminarUsuario(int id)
        {
            UsuarioDB<Persona> usuario = new UsuarioDB<Persona>();
            usuario.Eliminar(id);
        }

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
        public static void ActualizarStock(Articulo articulo)
        {
            try
            {
                ArticuloDB articulos = new ArticuloDB();
                
                articulos.Modificar(articulo);
            }
            catch (Exception error)
            {
                throw new Exception("Error al actualizar el stock del artículo en la base de datos: " + error.Message);
            }
        }
        public static Articulo ObtenerProductoPorId(int id)
        {
            var db = new ArticuloDB();
            return db.ObtenerPorId(id);
        }
        
        public static Persona? ObtenerUsuarioPorId(int id)
        {
            var db = new UsuarioDB<Persona>();
            return db.ObtenerPorId(id);
        }

        public static Persona? ObtenerClientePorId(int id)
        {
            var db = new ClienteDB();
            return db.ObtenerPorId(id);
        }
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
        public static string ValidarCamposUsuario(string articuloInput, string precioInput, string stockInput)
        {
            if (string.IsNullOrEmpty(articuloInput) || string.IsNullOrEmpty(precioInput) || string.IsNullOrEmpty(stockInput))
            {
                return "Todos los campos deben ser completados.";
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
        /// <summary>
        /// Obtiene el objeto PersonalInterno del usuario logueado, si existe,
        /// comparando el nombre de usuario y contraseña con los datos de la lista de personas.
        /// </summary>
        /// <param name="user">Nombre de usuario</param>
        /// <param name="pass">Contraseña</param>
        /// <param name="arrayPersona">Lista de personas</param>
        /// <returns>Objeto PersonalInterno del usuario logueado o null si no se encuentra</returns>
        public static PersonalInterno ValidadrUsuarioLogueado(string user, string pass,List<Persona> arrayPersona)
        {
            PersonalInterno personaLogueada = null;
            foreach (PersonalInterno personaUno in arrayPersona.Cast<PersonalInterno>())
            {
                if (personaUno.Nombre == user && personaUno.Contrasenia == pass)
                {
                    personaLogueada = personaUno;
                    break;
                }
            }
            return personaLogueada;
        }

       

        public static bool StringEsInvalido(string auxDato)
        {
            auxDato = auxDato.Trim();
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
            if (StringEsInvalido(user) || StringEsInvalido(pass))
            {                
                return false;
            }
                     
            return true;
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
            foreach (PersonalInterno p in ObtenerUsuarios().Cast<PersonalInterno>())
            {
                if (p.Nombre == usuario || p.Contrasenia == contrasenia)
                {
                    return true;                    
                }               
            }
            return false;
        }

        


    }
}
