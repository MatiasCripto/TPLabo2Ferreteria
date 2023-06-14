using Logica.Productos;
using Logica.Sistema;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrete2.Formularios
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
            ActualizarProductosDgv();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            gpbx_modificarUsuario.Visible = false;
            grpbx_AgregarUsuario.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarUsuario.Visible = true;
            gpbx_modificarUsuario.Visible = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            grpbx_AgregarUsuario.Visible = false;
            gpbx_modificarUsuario.Visible = true;
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
        private void ActualizarProductosDgv()
        {
            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            foreach (var item in Sistema.ObtenerUsuarios())
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Usuario"] = item.Nombre;
                row["Nombre"] = item.Usuario;
                row["Role"] = item.Role;

                dt.Rows.Add(row);
            }

            // Mantener la selección actual en el DataGridView de stock
            int selectedIndex = dgv_Usuarios.SelectedRows.Count > 0 ? dgv_Usuarios.SelectedRows[0].Index : -1;

            dgv_Usuarios.DataSource = dt;

            // Restaurar la selección anterior si existe
            if (selectedIndex >= 0 && selectedIndex < dgv_Usuarios.Rows.Count)
            {
                dgv_Usuarios.Rows[selectedIndex].Selected = true;
            }
        }


        /// <summary>
        /// Actualiza el DataGridView con la lista de productos.
        /// </summary>
        private void ActualizarDgv()
        {
            dgv_Usuarios.DataSource = null;
            dgv_Usuarios.DataSource = Sistema.ObtenerUsuarios();
                
        }

        private void btn_GuardarGb_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Usuarios.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                // Obtener el índice de la fila seleccionada
                int rowIndex = dgv_Usuarios.CurrentRow.Index;

                // Obtener el nombre del producto en la primera columna
                string nombreProducto = dgv_Usuarios.Rows[rowIndex].Cells[0].Value.ToString();

                // Mostrar un mensaje de advertencia antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario " + nombreProducto + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {

                    // Sobrescribir el archivo con el contenido actualizado
                    //File.WriteAllText("productos.txt", sb.ToString());
                    Sistema.EliminarProducto(int.Parse(valorId));

                    // Eliminar el artículo del origen de datos
                    List<Persona> usuarios = Sistema.ObtenerUsuarios();
                    Persona UsuarioAEliminar = usuarios.FirstOrDefault(a => a.Id == int.Parse(valorId));

                    if (UsuarioAEliminar != null)
                    {
                        usuarios.Remove(UsuarioAEliminar);
                        Sistema.GuardarUsuariosEnDB(usuarios); // Guardar los productos actualizados en el archivo
                    }
                    // Eliminar la fila del DataGridView                
                    ActualizarDgv();
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún usuario para eliminar.");
            }

        }
    }
}
