using Logica.Datos;
using Logica.Enumerados;
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

namespace Vista.Formularios
{
    public partial class FrmAgregarClientes : Form
    {
        string nombreInput;
        string nombreUsuarioInput;
        string contraseniaInput;
        string roleInput;
        private const string vacio = "";

        public FrmAgregarClientes()
        {
            InitializeComponent();
            LeerClientes();
        }
        // Evento que se ejecuta al hacer clic en el botón "Agregar"
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            nombreInput = txb_nombreCliente.Text;
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

            roleInput = "Cliente";

            try
            {
                // Verificar que los campos no estén vacíos
                if (nombreInput != vacio && nombreUsuarioInput != vacio && contraseniaInput != vacio)
                {
                    // Crear un nuevo objeto de usuario
                    Logica.Usuarios.Persona nuevoUsuario = new Logica.Usuarios.Cliente(Persona.NexId, nombreInput, nombreUsuarioInput, contraseniaInput, Enum.Parse<Role>(roleInput));
                    ParserUsuarios.EscribirCliente(nuevoUsuario);
                    // Llamar a métodos para dar de alta y guardar el nuevo usuario
                    //Sistema.AltaUsuario(nuevoUsuario);
                    //Sistema.GuardarUsuario(nuevoUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}");
            }

            LeerClientes(); // Actualizar la lista de usuarios mostrada en el DataGridView
        }

        // Método para leer y mostrar los usuarios en el DataGridView
        public void LeerClientes()
        {
            try
            {
                dgv_cliente.DataSource = null;

                // Leer la lista de usuarios desde el archivo
                List<Persona> usuarios = ParserUsuarios.LeerCliente();

                // Filtrar la lista para mostrar solo los usuarios que no son clientes
                List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role == Role.Cliente).ToList();

                // Asignar la lista filtrada como origen de datos para el DataGridView
                dgv_cliente.DataSource = usuariosFiltrados;
                dgv_cliente.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los usuarios: {ex.Message}");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Eliminar"
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dgv_cliente.SelectedRows.Count > 0)
                {
                    // Obtener el objeto Usuario seleccionado en la fila
                    Persona usuario = dgv_cliente.SelectedRows[0].DataBoundItem as Persona;

                    // Eliminar el usuario del archivo
                    ParserUsuarios.EliminarCliente(usuario);

                    ParserUsuarios.LeerCliente(); // Actualizar la lista de clientes mostrada en el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
            }
        }



    }
}