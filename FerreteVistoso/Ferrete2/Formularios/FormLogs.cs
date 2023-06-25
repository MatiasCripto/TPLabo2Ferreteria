using Logica.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Logica.Sistema.Sistema;

namespace Ferrete2.Formularios
{
    public partial class FormLogs : Form
    {
        private Sistema _sistema;
        private Task _tarea;
        private decimal[] ultimosValores;
        public FormLogs()
        {
            InitializeComponent();
            ActualizarRegistrosDgv();

            _sistema = new Sistema();
            _tarea = new Task(_sistema.Comenzar);
            _tarea.Start();
            _sistema.UltimosValores += ManejarUltimosValores;

        }
        private void FormLogs_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }
        private void ActualizarRegistrosDgv()
        {
            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Fecha y hora", typeof(DateTime));
            dt.Columns.Add("Usuario", typeof(string));
            dt.Columns.Add("Accion", typeof(string));

            foreach (var item in Sistema.ObtenerRegistros())
            {
                var row = dt.NewRow();

                row["Id"] = item.Id;
                row["Fecha y hora"] = item.FechaHora;
                row["Usuario"] = item.Usuario;
                row["Accion"] = item.Accion;


                dt.Rows.Add(row);
            }

            // Mantener la selección actual en el DataGridView de stock
            int selectedIndex = dgv_Movimientos.SelectedRows.Count > 0 ? dgv_Movimientos.SelectedRows[0].Index : -1;

            dgv_Movimientos.DataSource = dt;

            // Restaurar la selección anterior si existe
            if (selectedIndex >= 0 && selectedIndex < dgv_Movimientos.Rows.Count)
            {
                dgv_Movimientos.Rows[selectedIndex].Selected = true;
            }
        }


        /// <summary>
        /// Actualiza el DataGridView con la lista de productos.
        /// </summary>
        private void ActualizarDgv()
        {
            dgv_Movimientos.DataSource = null;
            dgv_Movimientos.DataSource = Sistema.ObtenerUsuarios();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgv_Movimientos.DataSource).DefaultView.RowFilter = string.Format("Usuario like '%{0}%'", txb_Buscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManejarUltimosValores(decimal[] valores)
        {
            ultimosValores = valores;
            panel1.Invalidate(); // Vuelve a dibujar el panel para reflejar los cambios en la interfaz gráfica
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int barHeight = (panel1.Height - 40) / 20; // Altura de las barras (ajustada para incluir los valores)

            // Añadir verificación de null para ultimosValores
            if (ultimosValores == null) return;

            // Definir valores mínimo y máximo del dólar
            decimal minDolar = 500;
            decimal maxDolar = 1000;

            Color[] colors = new Color[]
            {
                Color.FromArgb(255, 255, 128, 128),
                Color.FromArgb(255, 128, 255, 128),
                Color.FromArgb(255, 128, 128, 255),
                Color.FromArgb(255, 255, 255, 128),
                Color.FromArgb(255, 255, 128, 255),
                Color.FromArgb(255, 128, 255, 255),
                Color.FromArgb(255, 192, 192, 192),
                Color.FromArgb(255, 128, 0, 0),
                Color.FromArgb(255, 0, 128, 0),
                Color.FromArgb(255, 0, 0, 128),
                Color.FromArgb(255, 128, 128, 0),
                Color.FromArgb(255, 128, 0, 128),
                Color.FromArgb(255, 0, 128, 128),
                Color.FromArgb(255, 255, 0, 0),
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 128, 128, 255),
                Color.FromArgb(255, 255, 128, 128),
                Color.FromArgb(255, 128, 255, 128),
                Color.FromArgb(255, 128, 128, 128)// colores omitidos por brevedad
            };

            using (SolidBrush headerBrush = new SolidBrush(Color.White))
            {
                g.DrawString("Valor Dólar", Font, headerBrush, 0, 10);
            }

            // Dibuja las barras del gráfico con colores pastel
            for (int i = 0; i < ultimosValores.Length; i++)
            {
                // Calcular el valor proporcional de la barra
                decimal valor = ultimosValores[i];
                decimal porcentaje = (valor - minDolar) / (maxDolar - minDolar);
                int barWidth = (int)(porcentaje * (panel1.Width - 100)); // Ancho de las barras (ajustado para incluir los valores)
                int barX = 80;
                int barY = ((ultimosValores.Length - i - 1) * (barHeight + 10));

                using (SolidBrush brush = new SolidBrush(colors[i % colors.Length]))
                {
                    g.FillRectangle(brush, barX, barY, barWidth, barHeight);
                }
            }

            // Dibuja el eje Y
            using (Pen axisPen = new Pen(Color.White))
            {
                g.DrawLine(axisPen, 80, 20, 80, panel1.Height - 20);
            }

            // Dibuja el eje X
            using (Pen axisPen = new Pen(Color.White))
            {
                g.DrawLine(axisPen, 80, panel1.Height - 20, panel1.Width - 20, panel1.Height - 20);
            }

            // Ajustar la longitud del eje X
            int ejeXLength = panel1.Width - 120;

            // Ajustar la longitud del eje Y
            int ejeYLength = panel1.Height - 60;

            // Dibuja etiquetas en el eje X
            int[] etiquetas = new int[] { 500, 600, 700, 800, 900, 1000 };
            for (int i = 0; i < etiquetas.Length; i++)
            {
                decimal valorEtiqueta = etiquetas[i];
                decimal porcentaje = (valorEtiqueta - minDolar) / (maxDolar - minDolar);
                int x = 80 + (int)(porcentaje * ejeXLength);
                int y = panel1.Height - 15;

                using (SolidBrush labelBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(valorEtiqueta.ToString(), Font, labelBrush, x, y);
                }
            }


            g.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                ((DataTable)dgv_Movimientos.DataSource).DefaultView.RowFilter = $"[Fecha y hora] >= '#{formattedDate} 00:00:00#' AND [Fecha y hora] <= '#{formattedDate} 23:59:59#'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
