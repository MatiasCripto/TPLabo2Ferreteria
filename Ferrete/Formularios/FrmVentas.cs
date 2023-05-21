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
    public partial class FrmVentas : Form
    {
        List<Articulo> Carrito;        

        public FrmVentas()
        {
            InitializeComponent();
            ActualizarProductosDgv();
            Carrito= new List<Articulo>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = dgv_stock.SelectedRows[0].DataBoundItem as DataRowView;
            /*try*/var producto = new Articulo((int) itemSeleccionado[0],(string) itemSeleccionado[1], (decimal)itemSeleccionado[2],(int) itemSeleccionado[3], (bool) itemSeleccionado[4]);
            
            Carrito.Add(producto);
            ActualizarDgvVentas();
        }
        private void ActualizarDgvVentas()
        {
           dgv_venta.DataSource = null;
           dgv_venta.DataSource = Carrito;
        }
       

        private void ActualizarProductosDgv()
        {           

            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Articulo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));          
            dt.Columns.Add("Baja", typeof(bool));          

            foreach (var item in Sistema.ObtenerProductos())
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Articulo"] = item.Nombre;
                row["Precio"] = item.Precio ;
                row["Stock"] = item.Stock;                
                row["Baja"] = item.Baja;                

                dt.Rows.Add(row);
            }

            dgv_stock.DataSource = dt;

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
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgv_venta.Rows)
            {
                // Obtener el valor de la columna que contiene el precio
                decimal precio = (decimal)row.Cells["Precio"].Value;

                // Sumar el precio al total
                total += precio;
            }

            return total;
        }

        private void btn_ImporteTotal_Click(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();
            lbl_total.Text = "Total: $" + total.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_venta.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgv_venta.SelectedRows[0].Index;

                // Eliminar el artículo del carrito
                Carrito.RemoveAt(rowIndex);

                // Actualizar el DataGridView "dgv_venta"
                ActualizarDgvVentas();
            }
        }



        //private void TotalPrecio()
        //{
        //    lbl_total.Text = "Total";
        //    decimal total = 0;

        //    foreach (DataGridViewRow row in dgv_venta.Rows)
        //    {
        //        if (row.Selected)
        //        {
        //            // Obtener el valor de la columna que contiene el precio
        //            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);

        //            // Sumar el precio al total
        //            total += precio;
        //        }
        //    }

        //    lbl_total.Text = total.ToString();

        //    // Ahora, la variable 'total' contiene la suma de los precios de los artículos seleccionados

        //}
    }
}
