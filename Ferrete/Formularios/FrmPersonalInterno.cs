using Logica.Datos;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Logica.Sistema;
using Vista.Formularios;

namespace Vista
{
    public partial class FrmPersonalInterno : Form
    {
        private const string vacio = "";        
        string articuloInput;
        string precioInput;

        PersonalInterno usuarioLogeado;
        // probando con pasar  de un data a otro 
        private DataGridView dgv_ventas;

        public FrmPersonalInterno(PersonalInterno usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;            
        }
        // de un data a otro
        public FrmPersonalInterno(DataGridView dgv_ventas)
        {
            this.dgv_ventas = dgv_ventas;
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPersonalInterno_Load(object sender, EventArgs e)
        {
            BaseDeDatos.BaseDatosProductos = ParserProductos.LeerProductos();
            this.dgv_principal.DataSource = BaseDeDatos.BaseDatosProductos;

            if(usuarioLogeado.Role != Logica.Enumerados.Role.Administrador)
            {
                personalInternoToolStripMenuItem.Visible = false;
                btn_Actualizar.Enabled = false;
                btn_Agrergar.Enabled = false;
                btn_Buscar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Informe.Enabled = false;
                btn_Nuevo.Enabled = false;
            }
            else
            {
                btn_Actualizar.Enabled = false;
                btn_Agrergar.Enabled = false;
                btn_Buscar.Enabled = false;
                btn_Cancelar.Enabled = false;
                btn_Eliminar.Enabled = false;
                btn_Informe.Enabled = false;
                btn_Nuevo.Enabled = true;
            }
        }


        private void ActualizarDgv()
        {
            dgv_principal.DataSource = null;            
            dgv_principal.DataSource = BaseDeDatos.BaseDatosProductos;
        }
        

        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            articuloInput = txb_Descripcion.Text;
            precioInput = txb_Precio.Text;
            

            if (articuloInput != vacio && precioInput != vacio)
            {
                try
                {
                    Articulo nuevoArticulo = new Articulo( articuloInput, decimal.Parse(precioInput), 
                                            Convert.ToInt16(txb_stock.Text));
                    Sistema.AltaProducto(nuevoArticulo, usuarioLogeado);
                    Sistema.GuardarProducto(nuevoArticulo);
                }
                catch(Exception ex)
                {
                    throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
                }
                ActualizarDgv();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            btn_Actualizar.Enabled = true;
            btn_Agrergar.Enabled = true;
            btn_Buscar.Enabled = true;
            btn_Cancelar.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Informe.Enabled = true;
            btn_Nuevo.Enabled = true;
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Ventas frmVentas = new Ventas();
            frmVentas.Show();
        }
        
    }  
    
}
