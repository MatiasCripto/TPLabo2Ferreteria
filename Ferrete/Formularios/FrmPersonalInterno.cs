using Logica.Datos;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Logica.Sistema;
using Vista.Formularios;

namespace Vista
{
    public partial class FrmPersonalInterno : Form
    {
        private const string vacio = "";
        private string articuloInput;
        private string precioInput;
        private string stockInput;

        private PersonalInterno usuarioLogeado;
        private string userLog;

        

        /// <summary>
        /// Constructor de la clase FrmPersonalInterno.
        /// </summary>
        /// <param name="usuario">Objeto PersonalInterno que representa al usuario logeado.</param>
        public FrmPersonalInterno(PersonalInterno usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
            ActualizarDgv();
        }

        /// <summary>
        /// Evento de carga del formulario FrmPersonalInterno.
        /// </summary>
        private void FrmPersonalInterno_Load(object sender, EventArgs e)
        { 
            dgv_principal.DataSource = ParserProductos.LeerProductos();

            if (usuarioLogeado.Role != Logica.Enumerados.Role.Administrador)
            {
                // Ocultar elementos de la interfaz para usuarios no administradores
                personalInternoToolStripMenuItem.Visible = false;
                btn_Actualizar.Enabled = false;
                btn_Agrergar.Enabled = false;
                btn_Buscar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Informe.Enabled = false;
                btn_Nuevo.Enabled = false;
                txb_Descripcion.Enabled = false;
                txb_Precio.Enabled = false;
                txb_stock.Enabled = false;
                txb_PrecioDolar.Enabled = false;
            }
            else
            {
                // Mostrar elementos de la interfaz para usuarios administradores
                
                btn_Actualizar.Enabled = false;
                btn_Agrergar.Enabled = false;
                btn_Buscar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Informe.Enabled = false;
                btn_Nuevo.Enabled = true;
                txb_Descripcion.Enabled = false;
                txb_Precio.Enabled = false;
                txb_stock.Enabled = false;
                txb_PrecioDolar.Enabled = false;
            }
        }

        /// <summary>
        /// Actualiza el DataGridView con la lista de productos.
        /// </summary>
        private void ActualizarDgv()
        {
            dgv_principal.DataSource = null;
            dgv_principal.DataSource = Sistema.ObtenerProductos();
        }

        /// <summary>
        /// Evento del botón "Agregar" para agregar un nuevo producto.
        /// </summary>
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            articuloInput = txb_Descripcion.Text;
            precioInput = txb_Precio.Text;
            stockInput = txb_stock.Text;

            string mensajeError = Sistema.ValidarCamposAgregar(articuloInput, precioInput, stockInput);
            if (mensajeError == null)
            {
                try
                {
                    Articulo nuevoArticulo = new Articulo(Articulo.NexId, articuloInput, decimal.Parse(precioInput), int.Parse(stockInput), false);
                    ParserProductos.EscribirProducto(nuevoArticulo);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
                }
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show(mensajeError);
            }
        }

        /// <summary>
        /// Evento del botón "Eliminar" para eliminar un producto seleccionado.
        /// </summary>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_principal.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_principal.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                // Eliminar el artículo del archivo
                string[] lineas = File.ReadAllLines("productos.txt");
                StringBuilder sb = new StringBuilder();

                foreach (var linea in lineas)
                {
                    string[] campos = linea.Split(',');

                    if (campos[0] != valorId)
                    {
                        sb.AppendLine(linea);
                    }
                }

                // Sobrescribir el archivo con el contenido actualizado
                File.WriteAllText("productos.txt", sb.ToString());

                // Eliminar el artículo del origen de datos
                List<Articulo> productos = ParserProductos.LeerProductos();
                Articulo articuloAEliminar = productos.FirstOrDefault(a => a.Id == int.Parse(valorId));

                if (articuloAEliminar != null)
                {
                    productos.Remove(articuloAEliminar);
                    ParserProductos.EscribirArchivo(productos); // Guardar los productos actualizados en el archivo
                }
                // Eliminar la fila del DataGridView                
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún artículo para eliminar.");
            }
        }        

        /// <summary>
        /// Evento del botón "Nuevo" para habilitar los campos de ingreso de datos.
        /// </summary>
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Actualizar.Enabled = true;
            btn_Agrergar.Enabled = true;
            btn_Buscar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Informe.Enabled = true;
            btn_Nuevo.Enabled = true;
            txb_Descripcion.Enabled = true;
            txb_Precio.Enabled = true;
            txb_stock.Enabled = true;
            txb_PrecioDolar.Enabled = true;
        }

        /// <summary>
        /// Evento del botón "Ventas" para mostrar el formulario de ventas.
        /// </summary>
        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas();
            var resultado = frmVentas.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ActualizarDgv();
            }
        }

        /// <summary>
        /// Evento del menú "Nuevo Empleado" para mostrar el formulario de agregar usuarios.
        /// </summary>
        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios frmusuario = new FrmAgregarUsuarios();
            frmusuario.Show();
        }

        /// <summary>
        /// Evento del menú "Nuevo Cliente" para mostrar el formulario de agregar clientes.
        /// </summary>
        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes nuevoCliene = new FrmAgregarClientes();
            nuevoCliene.Show();
        }

        /// <summary>
        /// Evento del menú "Ver Clientes" para mostrar el formulario de mostrar clientes.
        /// </summary>
        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarClientes frmClientes = new FrmMostrarClientes();
            frmClientes.Show();
        }

        /// <summary>
        /// Evento del botón "Actualizar" para modificar un producto seleccionado.
        /// </summary>
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (dgv_principal.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_principal.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                FrmModificarProducto frmModificar = new FrmModificarProducto(valorId);
                DialogResult resultado = frmModificar.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    // Actualizar el artículo en el archivo
                    List<Articulo> productos = ParserProductos.LeerProductos();
                    Articulo articuloAModificar = productos.FirstOrDefault(a => a.Id == int.Parse(valorId));

                    if (articuloAModificar != null)
                    {
                        articuloAModificar.Nombre = frmModificar.NombreModificado;
                        articuloAModificar.Precio = frmModificar.PrecioModificado;
                        articuloAModificar.Stock = frmModificar.StockModificado;

                        ParserProductos.EscribirProducto(articuloAModificar); // Guardar los productos actualizados en el archivo
                        ActualizarDgv();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún artículo para modificar.");
            }
        }

        /// <summary>
        /// Evento del menú "Ver Empleados" para mostrar el formulario de mostrar usuarios.
        /// </summary>
        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarUsuarios frmMostrarUsuarios = new FrmMostrarUsuarios();
            frmMostrarUsuarios.ShowDialog();
        }

        /// <summary>
        /// Evento del botón "Aumento Masivo" para aplicar un aumento a todos los productos.
        /// </summary>
        private void btn_aumentoMasivo_Click(object sender, EventArgs e)
        {
            List<Articulo> listaProductos = ParserProductos.LeerProductos(); // Obtener la lista de productos desde algún lugar
            decimal factorAumento = decimal.Parse(txb_PrecioDolar.Text); // Obtener el factor de aumento desde un TextBox

            Sistema.AplicarAumentoMasivo(listaProductos, factorAumento); // Llamar al método para aplicar el aumento a la lista de productos
        }
    }

}


