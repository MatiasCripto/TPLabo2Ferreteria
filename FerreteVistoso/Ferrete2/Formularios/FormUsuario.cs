using Logica.Enumerados;
using Logica.Sistema;
using Logica.Usuarios;
using System.Data;
using static Logica.Sistema.Sistema;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Ferrete2.Formularios
{
    public partial class FormUsuario : Form
    {
        private string nombre;
        private string usuario;
        private string contra;
        private string newContra;
        private string roleInput;
        private const string vacio = "";

        public FormUsuario()
        {
            InitializeComponent();
            ActualizarUsuariosDgv();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            gpbx_modificarUsuario.Visible = false;
            grpbx_AgregarUsuario.Visible = false;
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarUsuario.Visible = true;
            gpbx_modificarUsuario.Visible = false;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarUsuario.Visible = false;
            gpbx_modificarUsuario.Visible = true;
            btn_ExportarCsv.Visible = false;
            btn_ExportarJson.Visible = false;
            btn_ExportarPDF.Visible = false;
        }

        private void txb_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_Usuarios.DataSource).DefaultView.RowFilter = string.Format("Usuario like '%{0}%'", txb_Buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Actualiza el DataGridView con la lista de usuarios.
        /// </summary>
        private void ActualizarUsuariosDgv()
        {
            try
            {
                var dt = new DataTable();

                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Usuario", typeof(string));
                dt.Columns.Add("Contraseña", typeof(string));
                dt.Columns.Add("Role", typeof(string));

                foreach (var item in ObtenerUsuarios())
                {
                    var row = dt.NewRow();

                    row["Id"] = item.Id;
                    row["Usuario"] = item.Nombre;
                    row["Nombre"] = item.Usuario;
                    row["Contraseña"] = item.Contrasenia;
                    row["Role"] = item.Role;

                    dt.Rows.Add(row);
                }

                // Mantener la selección actual en el DataGridView de usuarios
                int selectedIndex = dgv_Usuarios.SelectedRows.Count > 0 ? dgv_Usuarios.SelectedRows[0].Index : -1;

                dgv_Usuarios.DataSource = dt;

                // Restaurar la selección anterior si existe
                if (selectedIndex >= 0 && selectedIndex < dgv_Usuarios.Rows.Count)
                {
                    dgv_Usuarios.Rows[selectedIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene la lista de usuarios del sistema.
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        private List<Persona> ObtenerUsuarios()
        {
            try
            {
                return Sistema.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Persona>();
            }
        }

        private void btn_GuardarGb_Click(object sender, EventArgs e)
        {
            nombre = txb_Nombre.Text;
            usuario = txb_Usuario.Text;
            newContra = txb_Confirmar.Text;

            try
            {
                if (txb_Cointrasenia.Text == txb_Confirmar.Text)
                {
                    contra = txb_Cointrasenia.Text;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si las contraseñas no coinciden
                }

                roleInput = cbx_AsignarRole.Text;

                // Verificar que los campos no estén vacíos
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si algún campo está vacío
                }

                // Crear un nuevo objeto de usuario
                Persona nuevoUsuario = new PersonalInterno(nombre, usuario, contra, (Role)Enum.Parse(typeof(Role), roleInput));

                MessageBox.Show($"{nuevoUsuario.Nombre}, {nuevoUsuario.Usuario}, {nuevoUsuario.Contrasenia}, {nuevoUsuario.Role}");

                Sistema.RegistrarMovimientos("Agregó un usuario");
                Sistema.GuardarUsuarioEnDB(nuevoUsuario);

                ActualizarDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgv_Usuarios.SelectedRows[0];
                    string valorId = filaSeleccionada.Cells["Id"].Value.ToString();

                    // Obtener el índice de la fila seleccionada
                    int rowIndex = dgv_Usuarios.CurrentRow.Index;

                    // Obtener el nombre del usuario en la primera columna
                    string nombreUsuario = dgv_Usuarios.Rows[rowIndex].Cells[0].Value.ToString();

                    // Mostrar un mensaje de advertencia antes de eliminar
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario " + nombreUsuario + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        Sistema.RegistrarMovimientos("Eliminó un usuario");
                        Sistema.EliminarUsuario(int.Parse(valorId));

                        // Eliminar el usuario del origen de datos
                        List<Persona> usuarios = Sistema.ObtenerUsuarios();
                        Persona UsuarioAEliminar = usuarios.FirstOrDefault(a => a.Id == int.Parse(valorId));

                        if (UsuarioAEliminar != null)
                        {
                            usuarios.Remove(UsuarioAEliminar);
                            Sistema.GuardarUsuariosEnDB(usuarios); // Guardar los usuarios actualizados en la base de datos
                        }

                        // Eliminar la fila del DataGridView
                        ActualizarDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_GuardarModificado_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgv_Usuarios.SelectedRows[0];
                    string valorId = filaSeleccionada.Cells["Id"].Value.ToString();

                    string roleModificado = cbx_ModificarRole.Text;

                    // Obtener el usuario a modificar de la base de datos
                    Persona usuarioAModificar = Sistema.ObtenerUsuarioPorId(int.Parse(valorId));

                    if (usuarioAModificar != null)
                    {
                        // Actualizar los campos del usuario
                        usuarioAModificar.Role = usuarioAModificar.Role = (Role)Enum.Parse(typeof(Role), roleModificado);

                        // Guardar el usuario modificado en la base de datos
                        Sistema.ModificarUsuario(usuarioAModificar);

                        // Actualizar el DataGridView
                        ActualizarDgv();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Informes_Click(object sender, EventArgs e)
        {
            btn_ExportarJson.Visible = true;
            btn_ExportarCsv.Visible = true;
            btn_ExportarPDF.Visible = true;
        }
        private void ActualizarDgv()
        {
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.Rows.Clear();
            ActualizarUsuariosDgv();
        }       

        private void btn_ExportarJson_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Persona> listaPersonas = Sistema.ObtenerUsuarios();

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Archivos JSON (*.json)|*.json";
                    dialog.Title = "Guardar archivo JSON";
                    dialog.InitialDirectory = @"C:\Ruta\Inicial";

                    string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    dialog.FileName = $"usuarios_{fechaHoraActual}.json";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = dialog.FileName;

                        ExportarListaPersonas(listaPersonas, filePath, ExportFormat.JSON);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los usuarios como archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarCsv_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Persona> listaPersonas = Sistema.ObtenerUsuarios();

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Archivos CSV (*.csv)|*.csv";
                    dialog.Title = "Guardar archivo CSV";
                    dialog.InitialDirectory = @"C:\Ruta\Inicial";

                    string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                    dialog.FileName = $"usuarios_{fechaHoraActual}.csv";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = dialog.FileName;

                        ExportarListaPersonas(listaPersonas, filePath, ExportFormat.CSV);

                        MessageBox.Show("Datos exportados correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los usuarios como archivo CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ExportarPDF_Click_1(object sender, EventArgs e)
        {
            List<Persona> listaUsuarios = ObtenerUsuarios();

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                dialog.Title = "Guardar archivo PDF";

                string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                dialog.FileName = $"usuarios_{fechaHoraActual}.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4, 5, 5, 5, 5);
                        PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                        doc.Open();

                        // Título y Autor
                        doc.AddAuthor("Jonatan Scarone");
                        doc.AddTitle("Usuarios de la Ferreteria");

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
                        foreach (var cliente in listaUsuarios)
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
    }
}

