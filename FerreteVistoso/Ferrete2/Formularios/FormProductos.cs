
using Logica.Productos;
using Logica.Sistema;
using System.Data;
using Logica.Enumerados;
using static Logica.Sistema.Sistema;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;



namespace Ferrete2.Formularios
{
    public partial class FormProductos : Form
    {

        private const string vacio = "";
        private string articuloInput = string.Empty;
        private string precioInput = string.Empty;
        private string stockInput = string.Empty;
        private Task _tarea;
        private Sistema _sistema;
        private DataTable _dt;

        /// <summary>
        /// Constructor de la clase FormProductos.
        /// </summary>
        public FormProductos()
        {
            InitializeComponent();
            ActualizarProductosDgv();

            _sistema = new Sistema();
            _tarea = new Task(_sistema.Comenzar);
            _tarea.Start();
            _sistema.PrecioDolarCambio += ActualizarPrecioDolar;
            _sistema.PrecioActual += MostrarDolarBlue;

        }

        /// <summary>
        /// Actualiza el precio de los productos en el DataTable utilizando el valor del dólar recibido.
        /// </summary>
        /// <param name="valorDolar">Valor del dólar a utilizar en la conversión.</param>
        private void ActualizarPrecioDolar(decimal valorDolar)
        {
            if (InvokeRequired)
            {
                Invoke(ActualizarPrecioDolar, valorDolar);
            }
            else
            {
                foreach (DataRow fila in _dt.Rows)
                {
                    fila["Precio pesos"] = Convert.ToDecimal(fila["Precio"]) * valorDolar;
                }
            }
        }

        /// <summary>
        /// Muestra el valor del dólar actual en el formulario.
        /// </summary>
        /// <param name="valorActual">Valor actual del dólar.</param>
        /// <returns>Valor actual del dólar en formato de cadena.</returns>
        private string MostrarDolarBlue(decimal valorActual)
        {
            if (InvokeRequired)
            {
                Invoke(MostrarDolarBlue, valorActual);
            }
            this.lbl_PrecioDolar.Text = valorActual.ToString();
            return valorActual.ToString();
        }

        /// <summary>
        /// Evento del botón "Cerrar" para cerrar el formulario.
        /// </summary>
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Actualiza el DataGridView con la lista de productos.
        /// </summary>
        private void ActualizarProductosDgv()
        {
            try
            {
                _dt = new DataTable();

                _dt.Columns.Add("Id", typeof(int));
                _dt.Columns.Add("Articulo", typeof(string));
                _dt.Columns.Add("Precio pesos", typeof(decimal));
                _dt.Columns.Add("Precio", typeof(decimal));
                _dt.Columns.Add("Stock", typeof(int));

                foreach (var item in Sistema.ObtenerProductos())
                {
                    var row = _dt.NewRow();

                    row["Id"] = item.Id;
                    row["Articulo"] = item.Nombre;
                    row["Precio"] = item.Precio;
                    row["Stock"] = item.Stock;

                    _dt.Rows.Add(row);
                }

                // Mantener la selección actual en el DataGridView de stock
                int selectedIndex = dgv_Principal.SelectedRows.Count > 0 ? dgv_Principal.SelectedRows[0].Index : -1;

                dgv_Principal.DataSource = _dt;

                // Restaurar la selección anterior si existe
                if (selectedIndex >= 0 && selectedIndex < dgv_Principal.Rows.Count)
                {
                    dgv_Principal.Rows[selectedIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                // Manejar el error de forma apropiada (mostrar mensaje, registrar el error, etc.)
                MessageBox.Show("Error al actualizar el DataGridView de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Actualiza el DataGridView con la lista de productos.
        /// </summary>
        private void ActualizarDgv()
        {
            try
            {
                dgv_Principal.DataSource = null;
                dgv_Principal.DataSource = Sistema.ObtenerProductos();
            }
            catch (Exception ex)
            {
                // Manejar el error de forma apropiada (mostrar mensaje, registrar el error, etc.)
                MessageBox.Show("Error al actualizar el DataGridView de productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento del botón "Eliminar" para eliminar un producto seleccionado.
        /// </summary>
        /// <summary>
        /// Evento del botón "Eliminar" para eliminar un producto seleccionado.
        /// </summary>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Principal.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgv_Principal.SelectedRows[0];
                    string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                    int rowIndex = dgv_Principal.CurrentRow.Index;
                    string nombreProducto = dgv_Principal.Rows[rowIndex].Cells[0].Value.ToString();

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el producto " + nombreProducto + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            Sistema.RegistrarMovimientos("Eliminó un producto");
                            Sistema.EliminarProducto(int.Parse(valorId));

                            List<Articulo> productos = Sistema.ObtenerProductos();
                            Articulo articuloAEliminar = productos.FirstOrDefault(a => a.Id == int.Parse(valorId));

                            if (articuloAEliminar != null)
                            {
                                productos.Remove(articuloAEliminar);
                                Sistema.GuardarProductosEnDB(productos);
                            }

                            ActualizarDgv();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos del producto seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún artículo para eliminar.");
            }
        }

        /// <summary>
        /// Evento del botón "Agregar" para agregar un nuevo producto.
        /// </summary>
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarProducto.Visible = true;
            gpbx_modificarProducto.Visible = false;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
        }

        /// <summary>
        /// Guarda un nuevo producto en la base de datos.
        /// </summary>
        private void btn_GuardarGb_Click(object sender, EventArgs e)
        {
            articuloInput = txb_Descripcion.Text;
            precioInput = txb_Precio.Text;
            stockInput = txb_Stock.Text;

            string mensajeError = Sistema.ValidarCamposProducto(articuloInput, precioInput, stockInput);

            if (mensajeError == null)
            {
                try
                {
                    Sistema.RegistrarMovimientos("Agregó un producto");
                    Articulo nuevoArticulo = new Articulo(articuloInput, decimal.Parse(precioInput), int.Parse(stockInput), 0);
                    Sistema.GuardarProductoEnDB(nuevoArticulo);

                    ActualizarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(mensajeError);
            }
        }

        /// <summary>
        /// Evento de carga del formulario FormProductos.
        /// </summary>
        private void FormProductos_Load(object sender, EventArgs e)
        {
            grpbx_AgregarProducto.Visible = false;
            gpbx_modificarProducto.Visible = false;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;

            if (Sistema.ObtenerUsuarioLogueado().Role == Role.Administrador)
            {
                btn_agregar.Visible = true;
                btn_Modificar.Visible = true;
                btn_Eliminar.Visible = true;
                btn_Guardar.Visible = true;
            }
            else
            {
                btn_agregar.Visible = false;
                btn_Modificar.Visible = false;
                btn_Eliminar.Visible = false;
                btn_Guardar.Visible = false;
            }
        }

        /// <summary>
        /// Evento del botón "Cancelar" en el formulario de agregar producto.
        /// </summary>
        private void btn_CancelarGb_Click(object sender, EventArgs e)
        {
            grpbx_AgregarProducto.Visible = false;
        }
        /// <summary>
        /// Filtra los productos en el DataGridView "dgv_stock" según el texto ingresado en el cuadro de búsqueda.
        /// </summary>
        private void txb_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_Principal.DataSource).DefaultView.RowFilter = string.Format("Articulo like '%{0}%'", txb_Buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Guardar Modificado".
        /// Guarda los cambios realizados en un producto seleccionado en el DataGridView.
        /// </summary>
        private void btn_GuardarModificado_Click(object sender, EventArgs e)
        {
            if (dgv_Principal.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Principal.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["Id"].Value.ToString();

                string articuloInput = txb_productoAModificar.Text;
                string precioInput = txb_precioAModificar.Text;
                string stockInput = txb_stockAModificar.Text;

                // Validar campos del producto
                string mensajeError = Sistema.ValidarCamposProducto(articuloInput, precioInput, stockInput);
                if (mensajeError == null)
                {
                    try
                    {
                        Sistema.RegistrarMovimientos("Modifico un producto");
                        // Obtener el producto a modificar de la base de datos
                        Articulo articuloAModificar = Sistema.ObtenerProductoPorId(int.Parse(valorId));
                        if (articuloAModificar != null)
                        {
                            // Actualizar los campos del producto
                            articuloAModificar.Nombre = articuloInput;
                            articuloAModificar.Precio = decimal.Parse(precioInput);
                            articuloAModificar.Stock = int.Parse(stockInput);

                            // Guardar el producto modificado en la base de datos
                            Sistema.ModificarProducto(articuloAModificar);

                            // Actualizar el DataGridView
                            ActualizarDgv();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error desconocido al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensajeError);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto para modificar.");
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Cancelar Modificado".
        /// Oculta el grupo de elementos relacionados con la modificación de un producto.
        /// </summary>
        private void btn_CancelarModificado_Click(object sender, EventArgs e)
        {
            gpbx_modificarProducto.Visible = false;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Modificar".
        /// Muestra el grupo de elementos relacionados con la modificación de un producto y oculta los botones de exportación.
        /// </summary>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarProducto.Visible = false;
            gpbx_modificarProducto.Visible = true;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Exportar JSON".
        /// Exporta la lista de productos en formato JSON y guarda el archivo seleccionado por el usuario.
        /// </summary>
        private void btn_ExportarJson_Click(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = Sistema.ObtenerProductos();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos JSON (*.json)|*.json";
                dialog.Title = "Guardar archivo JSON";
                dialog.InitialDirectory = @"C:\Ruta\Inicial";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                dialog.FileName = $"productos_{fechaHoraActual}.json";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    try
                    {
                        ExportarListaArticulos(listaArticulos, filePath, ExportFormat.JSON);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Exportar CSV".
        /// Exporta la lista de productos en formato CSV y guarda el archivo seleccionado por el usuario.
        /// </summary>
        private void btn_ExportarCsv_Click(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = Sistema.ObtenerProductos();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos CSV (*.csv)|*.csv";
                dialog.Title = "Guardar archivo CSV";
                dialog.InitialDirectory = @"C:\Ruta\Inicial";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                dialog.FileName = $"productos_{fechaHoraActual}.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    try
                    {
                        ExportarListaArticulos(listaArticulos, filePath, ExportFormat.CSV);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Guardar".
        /// Muestra los botones de exportación en la interfaz.
        /// </summary>
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_ExportarCsv.Visible = true;
            btn_ExportarJson.Visible = true;
            btn_ExportarPDF.Visible = true;
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón "Exportar PDF".
        /// Exporta la lista de productos en formato PDF y guarda el archivo seleccionado por el usuario.
        /// </summary>
       
        private void btn_ExportarPDF_Click(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = ObtenerProductos();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                dialog.Title = "Guardar archivo PDF";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                dialog.FileName = $"productos_{fechaHoraActual}.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4, 5, 5, 5, 5);
                        PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                        doc.Open();

                        // Título y Autor
                        doc.AddAuthor("Jonatan Scarone");
                        doc.AddTitle("Productos de Ferreteria");

                        // Definir la fuente
                        iTextSharp.text.Font standarFont = new iTextSharp.text.Font(
                            iTextSharp.text.Font.FontFamily.HELVETICA, 8,
                            iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        // Definir la fuente para los encabezados
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(
                            iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        // Encabezado de columnas
                        PdfPTable tabla = new PdfPTable(3);
                        tabla.WidthPercentage = 100;

                        // Configurar el título de las columnas con la fuente personalizada
                        PdfPCell colId = new PdfPCell(new Phrase("Id", headerFont));
                        colId.BorderWidth = 0.75f;
                        colId.BorderColor = BaseColor.ORANGE;

                        PdfPCell colNombre = new PdfPCell(new Phrase("Nombre", headerFont));
                        colNombre.BorderWidth = 0.75f;
                        colNombre.BorderColor = BaseColor.ORANGE;

                        PdfPCell colStock = new PdfPCell(new Phrase("Stock", headerFont));
                        colStock.BorderWidth = 0.75f;
                        colStock.BorderColor = BaseColor.ORANGE;

                        tabla.AddCell(colId);
                        tabla.AddCell(colNombre);
                        tabla.AddCell(colStock);

                        // Agregar datos
                        foreach (var producto in listaArticulos)
                        {
                            colId = new PdfPCell(new Phrase(producto.Id.ToString(), standarFont));
                            colId.BorderWidth = 0.75f;
                            colId.BorderColor = BaseColor.ORANGE;

                            colNombre = new PdfPCell(new Phrase(producto.Nombre, standarFont));
                            colNombre.BorderWidth = 0.75f;
                            colNombre.BorderColor = BaseColor.ORANGE;

                            colStock = new PdfPCell(new Phrase(producto.Stock.ToString(), standarFont));
                            colStock.BorderWidth = 0.75f;
                            colStock.BorderColor = BaseColor.ORANGE;

                            tabla.AddCell(colId);
                            tabla.AddCell(colNombre);
                            tabla.AddCell(colStock);
                        }

                        doc.Add(tabla);
                        doc.Close();
                        pw.Close();
                    }

                    MessageBox.Show("Documento exportado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
