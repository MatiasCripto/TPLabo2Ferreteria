using Datos;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Sistema;
using Logica.Usuarios;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Ferrete2.Formularios
{
    public partial class FormUsuario : Form
    {
        private string nombre;
        private string usuario;
        private string contra;
        private string newContra;
        string roleInput;        
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
        private void ActualizarUsuariosDgv()
        {
            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Usuario", typeof(string)); 
            dt.Columns.Add("Contraseña", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            foreach (var item in Sistema.ObtenerUsuarios())
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
            nombre = txb_Nombre.Text;
            usuario = txb_Usuario.Text;
            //contra = txb_Cointrasenia.Text;
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
                    Sistema.RegistrarMovimientos("Agrego un usuario");
                    // Crear un nuevo objeto de usuario
                    //Sistema.AsignarRole(roleInput);
                    Persona nuevoUsuario = new PersonalInterno(nombre, usuario, contra, (Role)Enum.Parse(typeof(Role), roleInput));
                    MessageBox.Show($"{nuevoUsuario.Nombre}, {nuevoUsuario.Usuario}, {nuevoUsuario.Contrasenia}, {nuevoUsuario.Role}");
                    Sistema.GuardarUsuarioEnDB(nuevoUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}");
            }

           ActualizarDgv(); // Actualizar la

            //string mensajeError = Sistema.ValidarCamposUsuario(nombre, usuario, contra);
            //if (mensajeError == null)
            //{
            //    if (contra == newContra)
            //    {
            //        try
            //        {
            //            Persona nuevoUsuario = new PersonalInterno(nombre, usuario, contra, role);
            //            Sistema.GuardarUsuarioEnDB(nuevoUsuario);
            //        }
            //        catch (Exception ex)
            //        {
            //            throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
            //        }
            //        ActualizarDgv();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Las contraseñas no coinciden");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show(mensajeError);
            //}
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Usuarios.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["id"].Value.ToString();

                // Obtener el índice de la fila seleccionada
                int rowIndex = dgv_Usuarios.CurrentRow.Index;

                // Obtener el nombre del producto en la primera columna
                string nombreUsuario = dgv_Usuarios.Rows[rowIndex].Cells[0].Value.ToString();

                // Mostrar un mensaje de advertencia antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el usuario " + nombreUsuario + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    Sistema.RegistrarMovimientos("Elimino un usuario");
                    // Sobrescribir el archivo con el contenido actualizado
                    //File.WriteAllText("productos.txt", sb.ToString());
                    Sistema.EliminarUsuario(int.Parse(valorId));

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

        private void btn_GuardarModificado_Click(object sender, EventArgs e)
        {
            if (dgv_Usuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Usuarios.SelectedRows[0];
                string valorId = filaSeleccionada.Cells["Id"].Value.ToString();

                string roleModificado = cbx_ModificarRole.Text;

                try
                {
                    
                    // Obtener el usuario a modificar de la base de datos
                    Persona usuarioAModificar = Sistema.ObtenerUsuarioPorId(int.Parse(valorId));
                    if (usuarioAModificar != null)
                    {
                        
                        // Actualizar los campos del usuario
                        usuarioAModificar.Role = usuarioAModificar.Role = (Role)Enum.Parse(typeof(Role), roleModificado);

                        // Convertir a entero antes de asignar

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
                MessageBox.Show("No se ha seleccionado ningún usuario para modificar.");
            }
          
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            List<Persona> listaPersonas = Sistema.ObtenerUsuarios(); // Obtienes la lista de personas desde tu lógica
           
            string jsonFilePath = "C:\\Users\\Pablo\\Desktop\\formLindo\\FerreteVistoso\\Entidades\\Archivos\\archivo.json";
            
            Sistema.ExportarListaPersonas(listaPersonas, jsonFilePath);

            string jsonData = JsonSerializer.Serialize(listaPersonas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, jsonData);

        }

        private void btn_ExportarCsv_Click(object sender, EventArgs e)
        {
            List<Persona> listaPersonas = Sistema.ObtenerUsuarios(); // Obtienes la lista de personas desde tu lógica
            string filePathCsv = "C:\\Users\\Pablo\\Desktop\\formLindo\\FerreteVistoso\\Entidades\\Archivos\\archivo.csv"; // Ruta de archivo deseada
            Sistema.ExportarListaPersonas(listaPersonas, filePathCsv);
        }
    }
}
