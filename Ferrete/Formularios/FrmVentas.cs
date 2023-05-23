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
            Carrito = new List<Articulo>();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar al carrito".
        /// Agrega un artículo seleccionado al carrito y disminuye su stock en uno.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var itemSeleccionado = dgv_stock.SelectedRows[0].DataBoundItem as DataRowView;
            var producto = new Articulo((int)itemSeleccionado[0], (string)itemSeleccionado[1], (decimal)itemSeleccionado[2], (int)itemSeleccionado[3], (bool)itemSeleccionado[4]);

            if (producto.Stock > 0)
            {
                // Disminuir el stock del artículo
                producto.Stock--;
                ParserProductos.ActualizarStock(producto);

                // Agregar el artículo al carrito
                Carrito.Add(producto);
                ActualizarDgvVentas();
                ActualizarProductosDgv();

            }
            else
            {
                MessageBox.Show("No hay stock disponible para este artículo.", "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Actualiza el DataGridView "dgv_venta" con los artículos en el carrito.
        /// </summary>
        private void ActualizarDgvVentas()
        {
            dgv_venta.DataSource = null;
            dgv_venta.DataSource = Carrito;
        }

        /// <summary>
        /// Actualiza el DataGridView "dgv_stock" con la lista de productos disponibles.
        /// </summary>
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
                row["Precio"] = item.Precio;
                row["Stock"] = item.Stock;
                row["Baja"] = item.Baja;

                dt.Rows.Add(row);
            }

            // Mantener la selección actual en el DataGridView de stock
            int selectedIndex = dgv_stock.SelectedRows.Count > 0 ? dgv_stock.SelectedRows[0].Index : -1;

            dgv_stock.DataSource = dt;

            // Restaurar la selección anterior si existe
            if (selectedIndex >= 0 && selectedIndex < dgv_stock.Rows.Count)
            {
                dgv_stock.Rows[selectedIndex].Selected = true;
            }
        }

        /// <summary>
        /// Filtra los productos en el DataGridView "dgv_stock" según el texto ingresado en el cuadro de búsqueda.
        /// </summary>
        private void txb_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_stock.DataSource).DefaultView.RowFilter = string.Format("Articulo like '%{0}%'", txb_buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Calcula el total de la venta sumando los precios de los artículos en el carrito.
        /// </summary>
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

        /// <summary>
        /// Muestra el importe total de la venta en el cuadro de texto "lbl_total".
        /// </summary>
        private void btn_ImporteTotal_Click(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();
            lbl_total.Text = "Total: $" + total.ToString();
        }

        /// <summary>
        /// Elimina el artículo seleccionado del carrito.
        /// </summary>
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

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Finalizar venta".
        /// Cierra el formulario y devuelve DialogResult.OK.
        /// </summary>
       
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

