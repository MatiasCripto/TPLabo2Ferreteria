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
        string roleInput;
        string nombreInput;
        string nombreClienteInput;
        string contraseniaInput;       
        private const string vacio = "";        
        public FrmAgregarClientes()
        {
            InitializeComponent();
        }       
        public void LeerClientes()
        {
            dgv_cliente.DataSource = null;
            List<Persona> usuarios = ParserUsuarios.LeerUsuario();
            List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role != Role.Cliente).ToList();
            dgv_cliente.DataSource = usuariosFiltrados;
            dgv_cliente.Refresh();

        }       

        private void btn_Agrergar_Click_1(object sender, EventArgs e)
        {
            nombreInput = txb_nombreCliente.Text;
            nombreClienteInput = txb_nombreUsuario.Text;
            if (txb_contrasenia.Text == txb_confirmarContra.Text)
            {
                contraseniaInput = txb_contrasenia.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }



            if (nombreInput != vacio && nombreClienteInput != vacio && contraseniaInput != vacio)
            {
                roleInput = "Cliente";
                try
                {
                    Logica.Usuarios.Cliente nuevoUsuario = new Logica.Usuarios.Cliente(nombreInput, nombreClienteInput, contraseniaInput, Enum.Parse<Role>(roleInput));
                    Sistema.AltaUsuario(nuevoUsuario);
                    Sistema.GuardarUsuario(nuevoUsuario);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
                }
                LeerClientes();
            }
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            if (dgv_cliente.SelectedRows.Count > 0)
            {
                // Obtener el objeto Usuario seleccionado en la fila
                Persona usuario = dgv_cliente.SelectedRows[0].DataBoundItem as Persona;

                // Eliminar el usuario del archivo
                ParserUsuarios.EliminarUsuario(usuario);

                // Actualizar el DataGridView
                LeerClientes();
            }
        }
    }
}
