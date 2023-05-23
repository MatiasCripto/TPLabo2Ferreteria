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
    public partial class FrmModificarUsuario : Form
    {

        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón "Agregar"
        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario con el resultado DialogResult.OK
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
