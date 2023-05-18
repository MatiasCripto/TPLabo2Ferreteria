using Logica.Datos;
using Logica.Productos;
using Logica.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            var itemSeleccionado = dgv_stock.SelectedRows[0].DataBoundItem as Articulo;
            MessageBox.Show(itemSeleccionado.Nombre.ToString());
        }
        public void LeerProductos()
        {
            dgv_stock.DataSource = null;
            stock = ParserProductos.LeerProductos();
            dgv_stock.DataSource = stock;
            dgv_stock.Refresh();
        }

        private void ActualizarProductosDgv()
        {
            // --------------------------------
            // CON DATATABLE

            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Articulo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));          

            foreach (var item in Sistema.ObtenerProductos())
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Articulo"] = item.Nombre;
                row["Precio"] = item.Precio ;
                row["Stock"] = item.Stock;
                

                dt.Rows.Add(row);
            }

            dgv_stock.DataSource = dt;

        }

        private void ActualizarDataGrid(List<Articulo> productos)
        {
            if (productos.Count > 0)
            {
                dgv_stock.DataSource = null;
                dgv_stock.DataSource = Sistema.ObtenerProductos();
            }
        }

        private void txb_buscar_TextChanged(object sender, EventArgs e)
        {            
            try
            {
                ((DataTable)dgv_stock.DataSource).DefaultView.RowFilter = string.Format("Articulo like '%{0}%'", txb_buscar.Text.Trim().Replace("'", "''")); ;
            }
            catch
            {

            }
        }
    }
}
