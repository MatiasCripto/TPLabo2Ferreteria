using Logica.Productos;
using Logica.Sistema;
using System.Data;

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Ferrete2.Formularios
{
    public partial class FormVenta : Form
    {
        List<Articulo> Carrito;

        public FormVenta()
        {
            InitializeComponent();
            ActualizarProductosDgv();
            Carrito = new List<Articulo>();
        }

        /// <summary>
        /// Maneja el evento click del botón "Nueva Venta".
        /// Muestra los elementos necesarios para realizar una venta.
        /// </summary>
        private void btn_nuevaVenta_Click(object sender, EventArgs e)
        {
            grpbx_AgregarProducto.Visible = true;
            dgv_venta.Visible = true;
            btn_ImporteTotal.Visible = true;
            btn_Salir.Visible = true;
            lbl_total.Visible = true;
        }

        /// <summary>
        /// Maneja el evento click del botón "Guardar Artículo".
        /// Agrega un artículo al carrito y actualiza el stock.
        /// </summary>
        private void btn_GuardarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_stock.SelectedRows.Count > 0)
                {
                    var itemSeleccionado = dgv_stock.SelectedRows[0].DataBoundItem as DataRowView;
                    var producto = new Articulo((int)itemSeleccionado[0], (string)itemSeleccionado[1], (decimal)itemSeleccionado[2], (int)itemSeleccionado[3], (int)itemSeleccionado[4]);

                    if (producto.Stock > 0)
                    {
                        // Disminuir el stock del artículo
                        producto.Stock--;
                        Sistema.ActualizarStock(producto);

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
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún artículo para agregar al carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo al carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                var dt = new DataTable();

                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Articulo", typeof(string));
                dt.Columns.Add("Precio", typeof(decimal));
                dt.Columns.Add("Stock", typeof(int));
                dt.Columns.Add("Baja", typeof(int));

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el listado de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento TextChanged del TextBox "txb_Descripcion".
        /// Filtra los productos en el DataGridView "dgv_stock" según la descripción ingresada.
        /// </summary>
        private void txb_Descripcion_TextChanged(object sender, EventArgs e)
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
        /// Maneja el evento click del botón "Importe Total".
        /// Calcula el total de la venta y lo muestra en el label "lbl_total".
        /// </summary>
        private void btn_ImporteTotal_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = CalcularTotal();
                lbl_total.Text = "Total: $" + total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el importe total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento click del botón "Eliminar Artículo".
        /// Elimina un artículo del carrito.
        /// </summary>
        private void btn_EliminarArticulo_Click(object sender, EventArgs e)
        {
            try
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
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún artículo para eliminar del carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el artículo del carrito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento click del botón "Salir".
        /// Cierra el formulario actual.
        /// </summary>
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            lbl_fechaActual.Text = DateTime.Today.Date.ToString("d");
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
