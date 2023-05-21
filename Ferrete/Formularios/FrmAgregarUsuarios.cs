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

        // Evento que se ejecuta al hacer clic en el botón "Agregar"
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
                    // Llamar a métodos para dar de alta y guardar el nuevo usuario
                    //Sistema.AltaUsuario(nuevoUsuario);
                    //Sistema.GuardarUsuario(nuevoUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido al guardar el usuario: {ex.Message}");
            }

            LeerUsuarios(); // Actualizar la lista de usuarios mostrada en el DataGridView
        }

        // Método para leer y mostrar los usuarios en el DataGridView
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

        // Evento que se ejecuta al hacer clic en el botón "Eliminar"
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
    //public partial class FrmAgregarUsuarios : Form
    //{        
    //    string nombreInput;
    //    string nombreUsuarioInput;
    //    string contraseniaInput;
    //    string roleInput;
    //    private const string vacio = "";

    //    public FrmAgregarUsuarios()
    //    {
    //        InitializeComponent();
    //        LeerUsuarios();
    //    }

    //    private void btn_Agrergar_Click(object sender, EventArgs e)
    //    {
    //        nombreInput = txb_nombre.Text;
    //        nombreUsuarioInput = txb_nombreUsuario.Text;
    //        if(txb_contrasenia.Text == txb_confirmarContra.Text)
    //        {
    //            contraseniaInput = txb_contrasenia.Text;
    //        }
    //        else
    //        {
    //            MessageBox.Show("Las contraseñas no coinciden");
    //        }
    //        roleInput = cbx_role.Text;


    //        if (nombreInput != vacio && nombreUsuarioInput != vacio && contraseniaInput != vacio)
    //        {
    //            try
    //            {
    //                Logica.Usuarios.Persona nuevoUsuario = new Logica.Usuarios.PersonalInterno(nombreInput, nombreUsuarioInput, contraseniaInput, Enum.Parse<Role>(roleInput));
    //                Sistema.AltaUsuario(nuevoUsuario);
    //                Sistema.GuardarUsuario(nuevoUsuario);
    //            }
    //            catch (Exception ex)
    //            {
    //                throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
    //            }
    //            LeerUsuarios();
    //        }

    //    }
    //    public void LeerUsuarios()
    //    {
    //        dgv_usuarios.DataSource = null;
    //        List<Persona> usuarios = ParserUsuarios.LeerUsuario();
    //        List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role != Role.Cliente).ToList();
    //        dgv_usuarios.DataSource = usuariosFiltrados;
    //        dgv_usuarios.Refresh();

    //    }

    //    private void btn_Eliminar_Click(object sender, EventArgs e)
    //    {
    //        if (dgv_usuarios.SelectedRows.Count > 0)
    //        {
    //            // Obtener el objeto Usuario seleccionado en la fila
    //            Persona usuario = dgv_usuarios.SelectedRows[0].DataBoundItem as Persona;

    //            // Eliminar el usuario del archivo
    //            ParserUsuarios.EliminarUsuario(usuario);

    //            // Actualizar el DataGridView
    //            LeerUsuarios();
    //        }
    //    }

    //}
}
