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
    public partial class Ventas : Form
    {
        List<Articulo> stock;
        public Ventas()
        {
            InitializeComponent();
            LeerProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParserProductos.LeerProductos();
        }
        public void LeerProductos()
        {
            dgv_stock.DataSource = null;
            stock = ParserProductos.LeerProductos();
            dgv_stock.DataSource = stock;
            dgv_stock.Refresh();
        }
        // crear un metodo que lea el archivo de productos (stock) y lo inyecte al datagrid

    }
}
