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

        public string NombreModificado
        {
            get { return nombreModificado; }
        }

        public decimal PrecioModificado
        {
            get { return precioModificado; }
        }

        public int StockModificado
        {
            get { return stockModificado; }
        }  
        private void CargarDatosArticulo(string idArticulo)
        {
            // Obtener los datos del artículo a partir del ID y asignarlos a las variables de clase
            // Aquí debes implementar la lógica para cargar los datos del artículo desde tu fuente de datos
            // Puedes utilizar el ID para buscar el artículo en tu lista o archivo de productos
            // Aquí se muestra un ejemplo de cómo podrías hacerlo utilizando una lista de productos
            List<Articulo> productos = ParserProductos.LeerProductos();
            Articulo articulo = productos.FirstOrDefault(a => a.Id == int.Parse(idArticulo));

            if (articulo != null)
            {
                nombreModificado = articulo.Nombre;
                precioModificado = articulo.Precio;
                stockModificado = articulo.Stock;
            }
        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            // Cargar los datos del artículo en los campos correspondientes
            txb_Nombre.Text = nombreModificado;
            txb_Precio.Text = precioModificado.ToString();
            txb_Stock.Text = stockModificado.ToString();
        }

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

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            // Cerrar el formulario con el resultado DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
