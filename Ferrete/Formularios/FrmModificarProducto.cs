using Logica.Datos;
using Logica.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios
{
    public partial class FrmModificarProducto : Form
    {
        string id;

        public FrmModificarProducto(string id)
        {
            InitializeComponent();
            this.id = id;
            CargarDatosArticulo(id);
        }

        private string nombreModificado;
        private decimal precioModificado;
        private int stockModificado;

        /// <summary>
        /// Obtiene el nombre modificado del artículo.
        /// </summary>
        public string NombreModificado
        {
            get { return nombreModificado; }
        }

        /// <summary>
        /// Obtiene el precio modificado del artículo.
        /// </summary>
        public decimal PrecioModificado
        {
            get { return precioModificado; }
        }

        /// <summary>
        /// Obtiene el stock modificado del artículo.
        /// </summary>
        public int StockModificado
        {
            get { return stockModificado; }
        }

        /// <summary>
        /// Carga los datos del artículo en el formulario.
        /// </summary>
        /// <param name="idArticulo">ID del artículo a modificar.</param>
        private void CargarDatosArticulo(string idArticulo)
        {
            List<Articulo> productos = ParserProductos.LeerProductos();
            Articulo articulo = productos.FirstOrDefault(a => a.Id == int.Parse(idArticulo));

            if (articulo != null)
            {
                nombreModificado = articulo.Nombre;
                precioModificado = articulo.Precio;
                stockModificado = articulo.Stock;
            }
        }

        /// <summary>
        /// Evento de carga del formulario FrmModificarProducto.
        /// </summary>
        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            // Cargar los datos del artículo en los campos correspondientes
            txb_Nombre.Text = nombreModificado;
            txb_Precio.Text = precioModificado.ToString();
            txb_Stock.Text = stockModificado.ToString();
        }

        /// <summary>
        /// Evento del botón "Agregar" para guardar los cambios realizados.
        /// </summary>
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            // Obtener los valores modificados de los campos de texto
            nombreModificado = txb_Nombre.Text;
            decimal.TryParse(txb_Precio.Text, out precioModificado);
            int.TryParse(txb_Stock.Text, out stockModificado);

            // Cerrar el formulario con el resultado DialogResult.OK
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Evento del botón "Cancelar" para descartar los cambios realizados.
        /// </summary>
        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario con el resultado DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

