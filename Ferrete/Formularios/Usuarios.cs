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
    public partial class Usuarios : Form
    {
        string nombreInput;
        string nombreUsuarioInput;
        string contraseniaInput;
        private const string vacio = "";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void ActualizarDgv()
        {
            dgv_usuarios.DataSource = null;
            dgv_usuarios.DataSource = BaseDeDatos.BaseDatosPersonas;
        }
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            nombreInput = txb_nombre.Text;
            nombreUsuarioInput = txb_nombreUsuario.Text;
            contraseniaInput = txb_contrasenia.Text;


            if (nombreInput != vacio && nombreUsuarioInput != vacio && contraseniaInput != vacio)
            {
                try
                {
                   // Logica.Usuarios.PersonalInterno nuevoUsuario = new Logica.Usuarios.PersonalInterno(nombreInput, nombreUsuarioInput, contraseniaInput, cbx_role.Text );
                    //Sistema.AltaUsuario(nuevoUsuario);
                    //Sistema.GuardarProducto(nuevoArticulo);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
                }
                ActualizarDgv();
            }

        }
    }
}
