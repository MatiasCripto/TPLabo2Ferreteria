using Datos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Sistema;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.Sistema.Sistema;

namespace Ferrete2.Formularios
{
    public partial class FormCliente : Form
    {
        private string nombre;
        private string usuario;
        private string contra;
        string newContra;
        string roleInput;
        private const string vacio = "";

        public FormCliente()
        {
            InitializeComponent();
            ActualizarClientesDgv();
            this.Load += FormCliente_Load;
        }

        private void FormCliente_Load(object? sender, EventArgs e)
        {
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
            grpbx_AgregarCliente.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarCliente.Visible = true;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
        }    
      
        private void ActualizarClientesDgv()
        {
            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Contraseña", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            foreach (var item in Sistema.ObtenerClientes())
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Usuario"] = item.Nombre;
                row["Nombre"] = item.Usuario;
                row["Contraseña"] = item.Contrasenia;
                row["Role"] = item.Role;

                dt.Rows.Add(row);
            }

            // Mantener la selección actual en el DataGridView de stock
            int selectedIndex = dgv_Clientes.SelectedRows.Count > 0 ? dgv_Clientes.SelectedRows[0].Index : -1;

            dgv_Clientes.DataSource = dt;

            // Restaurar la selección anterior si existe
            if (selectedIndex >= 0 && selectedIndex < dgv_Clientes.Rows.Count)
            {
                dgv_Clientes.Rows[selectedIndex].Selected = true;
            }
        }

        private void ActualizarDgv()
        {
            dgv_Clientes.DataSource = null;
            dgv_Clientes.DataSource = Sistema.ObtenerClientes();
        }

        private void btn_GuardarGb_Click(object sender, EventArgs e)
        {
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;

            nombre = txb_NombreNuevoCliente.Text;
            usuario = txb_Usuario.Text;
            newContra = txb_Confirmar.Text;

            if (txb_Cointrasenia.Text == txb_Confirmar.Text)
            {
                contra = txb_Cointrasenia.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return; // Salir del método si las contraseñas no coinciden
            }

            roleInput = cbx_AsignarRole.Text;

            try
            {
                // Verificar que los campos no estén vacíos
                if (nombre != vacio && usuario != vacio && contra != vacio)
                {
                    Sistema.RegistrarMovimientos("Agrego un cliente");
                    // Crear un nuevo objeto de usuario
                    Persona nuevoUsuario = new Cliente(nombre, usuario, contra, (Role)Enum.Parse(typeof(Role), roleInput));
                    MessageBox.Show($"{nuevoUsuario.Nombre}, {nuevoUsuario.Usuario}, {nuevoUsuario.Contrasenia}, {nuevoUsuario.Role}");
                    Sistema.GuardarClienteEnDB(nuevoUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el cliente: {ex.Message}");
            }

            ActualizarDgv();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
            if (dgv_Clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Clientes.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                // Obtener el índice de la fila seleccionada
                int rowIndex = dgv_Clientes.CurrentRow.Index;

                // Obtener el nombre del producto en la primera columna
                string nombreUsuario = dgv_Clientes.Rows[rowIndex].Cells[0].Value.ToString();

                // Mostrar un mensaje de advertencia antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el cliente " + nombreUsuario + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    Sistema.RegistrarMovimientos("Elimino un cliente");
                    Sistema.EliminarCliente(int.Parse(valorId));

                    // Eliminar el artículo del origen de datos
                    List<Persona> usuarios = Sistema.ObtenerClientes();
                    Persona UsuarioAEliminar = usuarios.FirstOrDefault(a => a.Id == int.Parse(valorId));

                    if (UsuarioAEliminar != null)
                    {
                        usuarios.Remove(UsuarioAEliminar);
                        Sistema.GuardarClientesEnDB(usuarios); // Guardar los productos actualizados en el archivo
                    }

                    // Eliminar la fila del DataGridView
                    ActualizarDgv();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún cliente para eliminar.");
            }
        }

        private void lbl_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_ExportarCsv.Visible = true;
            btn_ExportarJson.Visible = true;
            btn_ExportarPDF.Visible = true;
        }

        private void txb_Buscar_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                // Filtrar los clientes según el texto ingresado en el TextBox de búsqueda
                ((DataTable)dgv_Clientes.DataSource).DefaultView.RowFilter = string.Format("Usuario like '%{0}%'", txb_Buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarJson_Click(object sender, EventArgs e)
        {
            List<Persona> listaClientes = Sistema.ObtenerClientes();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos JSON (*.json)|*.json";
                dialog.Title = "Guardar archivo JSON";
                dialog.InitialDirectory = @"C:\Ruta\Inicial";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                dialog.FileName = $"clientes_{fechaHoraActual}.json";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    try
                    {
                        ExportarListaPersonas(listaClientes, filePath, ExportFormat.JSON);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_ExportarCsv_Click(object sender, EventArgs e)
        {
            List<Persona> listaClientes = Sistema.ObtenerClientes();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos CSV (*.csv)|*.csv";
                dialog.Title = "Guardar archivo CSV";
                dialog.InitialDirectory = @"C:\Ruta\Inicial";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                dialog.FileName = $"clientes_{fechaHoraActual}.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = dialog.FileName;

                    try
                    {
                        ExportarListaPersonas(listaClientes, filePath, ExportFormat.CSV);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al exportar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_ExportarPDF_Click(object sender, EventArgs e)
        {

            List<Persona> listaClientes = ObtenerClientes();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                dialog.Title = "Guardar archivo PDF";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                dialog.FileName = $"clientes_{fechaHoraActual}.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4, 5, 5, 5, 5);
                        PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                        doc.Open();

                        // Título y Autor
                        doc.AddAuthor("Jonatan Scarone");
                        doc.AddTitle("Clientes de la Ferreteria");

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

                        PdfPCell colRole = new PdfPCell(new Phrase("Role", headerFont));
                        colRole.BorderWidth = 0.75f;
                        colRole.BorderColor = BaseColor.ORANGE;

                        tabla.AddCell(colId);
                        tabla.AddCell(colNombre);
                        tabla.AddCell(colRole);

                        // Agregar datos
                        foreach (var cliente in listaClientes)
                        {
                            colId = new PdfPCell(new Phrase(cliente.Id.ToString(), standarFont));
                            colId.BorderWidth = 0.75f;
                            colId.BorderColor = BaseColor.ORANGE;

                            colNombre = new PdfPCell(new Phrase(cliente.Nombre, standarFont));
                            colNombre.BorderWidth = 0.75f;
                            colNombre.BorderColor = BaseColor.ORANGE;

                            colRole = new PdfPCell(new Phrase(cliente.Role.ToString(), standarFont));
                            colRole.BorderWidth = 0.75f;
                            colRole.BorderColor = BaseColor.ORANGE;

                            tabla.AddCell(colId);
                            tabla.AddCell(colNombre);
                            tabla.AddCell(colRole);
                        }

                        doc.Add(tabla);
                        doc.Close();
                        pw.Close();
                    }

                    MessageBox.Show("Documento exportado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_CancelarGb_Click(object sender, EventArgs e)
        {
            grpbx_AgregarCliente.Visible = false;
        }
    }
}
