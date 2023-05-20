﻿using Logica.Datos;
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
        string stockInput;

        PersonalInterno usuarioLogeado;       

        public FrmPersonalInterno(PersonalInterno usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
        }        

        private void FrmPersonalInterno_Load(object sender, EventArgs e)
        {

            this.dgv_principal.DataSource = ParserProductos.LeerProductos();

            if (usuarioLogeado.Role != Logica.Enumerados.Role.Administrador)
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
            dgv_principal.DataSource = Sistema.ObtenerProductos();

        }


        private void btn_Agrergar_Click(object sender, EventArgs e)
        {
            articuloInput = txb_Descripcion.Text;
            precioInput = txb_Precio.Text;
            stockInput = txb_stock.Text;


            if (articuloInput != vacio && precioInput != vacio && stockInput != vacio)
            {
                try
                {
                    Articulo nuevoArticulo = new Articulo(Articulo.NexId ,articuloInput, decimal.Parse(precioInput, System.Globalization.CultureInfo.InvariantCulture),
                                            Convert.ToInt16(stockInput), false);
                    ParserProductos.EscribirProducto(nuevoArticulo);                  
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error desconocido al guardar el usuario: {ex.Message}");
                }
                ActualizarDgv();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            List<Articulo> productos = new List<Articulo>();
            var itemSeleccionado = dgv_principal.SelectedRows[0].DataBoundItem as DataRowView;
            DataGridViewRow filaSeleccionada = dgv_principal.SelectedRows[0];
            string valorNombre = filaSeleccionada.Cells["id"].Value.ToString();
            //productos = ParserProductos.LeerProductos();
            //Sistema.BajaProducto(productos, valorNombre);
            ////ParserProductos.EscribirProducto(itemSeleccionado);
            //ParserProductos.EscribirSrchivo(productos);


            string[] lineas = File.ReadAllLines("productos.txt");

            StringBuilder sb = new StringBuilder();

            foreach (var linea in lineas)
            {
                
                string[] campos = linea.Split(',');
                if (campos[0] == valorNombre)
                {                    
                    sb.Append(campos[0]);
                    sb.Append(",");
                    sb.Append(campos[1]);
                    sb.Append(",");
                    sb.Append(campos[2]);
                    sb.Append(",");
                    sb.Append(campos[3]);
                    sb.Append(",");
                    sb.Append("True\n");
                }
                else
                {
                    sb.AppendLine(linea);
                }

            }
            // Sobrescribir el archivo con el contenido actualizado
            File.WriteAllText("productos.txt", sb.ToString());
            ActualizarDgv();
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

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frmusuario = new Usuarios();
            frmusuario.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes nuevoCliene = new Clientes();
            nuevoCliene.Show();
        }
    }
}
