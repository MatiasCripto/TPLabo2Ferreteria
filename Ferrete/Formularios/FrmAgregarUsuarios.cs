using Logica.Datos;
using Logica.Productos;
using Logica.Sistema;
using Logica.Usuarios;
using Logica.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAgregarUsuarios : Form
    {
        string nombreInput;
        string nombreUsuarioInput;
        string contraseniaInput;
        string roleInput;
        private const string vacio = "";

        public FrmAgregarUsuarios()
        {
            InitializeComponent();
            LeerUsuarios();
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Agregar".
        /// Agrega un nuevo usuario con los datos ingresados por el usuario.
        /// </summary>
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            nombreInput = txb_nombre.Text;
            nombreUsuarioInput = txb_nombreUsuario.Text;

            // Verificar si las contraseñas coinciden
            if (txb_contrasenia.Text == txb_confirmarContra.Text)
            {
                contraseniaInput = txb_contrasenia.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return; // Salir del método si las contraseñas no coinciden
            }

            roleInput = cbx_role.Text;

            try
            {
                // Verificar que los campos no estén vacíos
                if (nombreInput != vacio && nombreUsuarioInput != vacio && contraseniaInput != vacio)
                {
                    // Crear un nuevo objeto de usuario
                    Logica.Usuarios.Persona nuevoUsuario = new Logica.Usuarios.PersonalInterno(Persona.NexId, nombreInput, nombreUsuarioInput, contraseniaInput, Enum.Parse<Role>(roleInput));
                    ParserUsuarios.EscribirUsuario(nuevoUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}");
            }

            LeerUsuarios(); // Actualizar la lista de usuarios mostrada en el DataGridView
        }

        /// <summary>
        /// Método para leer y mostrar los usuarios en el DataGridView.
        /// </summary>
        public void LeerUsuarios()
        {
            try
            {
                dgv_usuarios.DataSource = null;

                // Leer la lista de usuarios desde el archivo
                List<Persona> usuarios = ParserUsuarios.LeerUsuario();

                // Filtrar la lista para mostrar solo los usuarios que no son clientes
                List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role != Role.Cliente).ToList();

                // Asignar la lista filtrada como origen de datos para el DataGridView
                dgv_usuarios.DataSource = usuariosFiltrados;
                dgv_usuarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los usuarios: {ex.Message}");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón "Eliminar".
        /// Elimina el usuario seleccionado en el DataGridView.
        /// </summary>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgv_usuarios.SelectedRows.Count > 0)
                {
                    // Obtener el objeto Usuario seleccionado en la fila
                    Persona usuario = dgv_usuarios.SelectedRows[0].DataBoundItem as Persona;

                    // Eliminar el usuario del archivo
                    ParserUsuarios.EliminarUsuario(usuario);

                    LeerUsuarios(); // Actualizar la lista de usuarios mostrada en el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
            }
        }
    }

}
   

