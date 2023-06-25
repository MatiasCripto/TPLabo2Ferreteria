using Datos;
using Logica.Enumerados;
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
            grpbx_AgregarCliente.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            grpbx_AgregarCliente.Visible = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            grpbx_AgregarCliente.Visible = false;
        }

        private void txb_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_Clientes.DataSource).DefaultView.RowFilter = string.Format("Usuario like '%{0}%'", txb_Buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            nombre = txb_NombreNuevoCliente.Text;
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
                    Sistema.RegistrarMovimientos("Agrego un cliente");
                    // Crear un nuevo objeto de usuario
                    //Sistema.AsignarRole(roleInput);
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
                    // Sobrescribir el archivo con el contenido actualizado
                    //File.WriteAllText("productos.txt", sb.ToString());
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
    }
}
