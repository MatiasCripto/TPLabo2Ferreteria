using Logica.Datos;
using Logica.Enumerados;
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
    public partial class MostrarClientes : Form
    {
        public MostrarClientes()
        {
            InitializeComponent();
            LeerCliente();
            CargarClientes();
        }

        public void CargarClientes()
        {
            dgv_mostrarClientes.DataSource = null;
            List<Logica.Usuarios.Persona> clientes = ParserUsuarios.LeerCliente();
            dgv_mostrarClientes.DataSource = clientes;
            dgv_mostrarClientes.Refresh();
        }
        public void LeerCliente()
        {
            dgv_mostrarClientes.DataSource = null;
            List<Persona> usuarios = ParserUsuarios.LeerUsuario();
            List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role != Role.Cliente).ToList();
            dgv_mostrarClientes.DataSource = usuariosFiltrados;
            dgv_mostrarClientes.Refresh();

        }

    }
}
