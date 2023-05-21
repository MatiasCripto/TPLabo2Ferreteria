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
    public partial class FrmMostrarUsuarios : Form
    {
        public FrmMostrarUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
            LeerUsuarios();
        }
        public void CargarUsuarios()
        {
            dgv_mostrarUsuarios.DataSource = null;
            List<Logica.Usuarios.Persona> usuarios = ParserUsuarios.LeerUsuario();
            dgv_mostrarUsuarios.DataSource = usuarios;
            dgv_mostrarUsuarios.Refresh();
        }
        public void LeerUsuarios()
        {
            dgv_mostrarUsuarios.DataSource = null;
            List<Persona> usuarios = ParserUsuarios.LeerUsuario();
            List<Persona> usuariosFiltrados = usuarios.Where(u => u.Role != Role.Cliente ).ToList();
            dgv_mostrarUsuarios.DataSource = usuariosFiltrados;
            dgv_mostrarUsuarios.Refresh();

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario frmModificarUser = new FrmModificarUsuario();
            var resultado = frmModificarUser.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                LeerUsuarios();
            }
        }        
    }
}
