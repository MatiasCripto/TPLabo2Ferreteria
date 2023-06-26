using Datos.SQL;
using Logica.Productos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ArticuloDB : ConsultasSQL, IRepositorio<Articulo>
    {
        /// <summary>
        /// Crea una nueva instancia de la clase ArticuloDB.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="v1">Valor 1.</param>
        /// <param name="v2">Valor 2.</param>
        /// <param name="v3">Valor 3.</param>
        public ArticuloDB(string connectionString, decimal v1, int v2, int v3) : base(connectionString)
        {
        }

        /// <summary>
        /// Crea una nueva instancia de la clase ArticuloDB.
        /// </summary>
        public ArticuloDB()
        {
        }

        /// <summary>
        /// Verifica si un producto existe en la base de datos por su nombre.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <returns>true si el producto existe, de lo contrario, false.</returns>
        public bool VerificarExistenciaProductoEnDB(string nombre)
        {
            string query = $"SELECT COUNT(*) FROM productos WHERE Articulo = '{nombre}'";
            var dt = this.EjecutarConsulta(query);

            if (dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }

            return false;
        }

        /// <summary>
        /// Obtiene todos los artículos almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Articulo que representan a los artículos obtenidos.</returns>
        public List<Articulo> ObtenerTodos()
        {
            List<Articulo> Lista = new List<Articulo>();
            var dt = this.EjecutarConsulta("select * from productos");
            foreach (DataRow item in dt.Rows)
            {
                Articulo producto = new Articulo(
                    Convert.ToInt32(item["Id"]),
                    item["Articulo"].ToString(),
                    Convert.ToDecimal(item["Precio"]),
                    Convert.ToInt32(item["Stock"]),
                    Convert.ToInt32(item["Baja"])
                );
                Lista.Add(producto);
            }
            return Lista;
        }

        /// <summary>
        /// Modifica los datos de un artículo existente en la base de datos.
        /// </summary>
        /// <param name="articulo">Objeto Articulo que representa al artículo a modificar.</param>
        public void Modificar(Articulo articulo)
        {
            string query = $"update productos set Articulo = '{articulo.Nombre}', Precio = {articulo.Precio}, Stock = {articulo.Stock}, Baja = {articulo.Baja} where Id = {articulo.Id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Agrega un nuevo artículo a la base de datos.
        /// </summary>
        /// <param name="articulo">Objeto Articulo que representa al artículo a agregar.</param>
        public void Agregar(Articulo articulo)
        {
            string query = $"insert into productos (Articulo, Precio, Stock, Baja) values ('{articulo.Nombre}', {articulo.Precio}, {articulo.Stock}, {articulo.Baja})";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Elimina un artículo de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del artículo a eliminar.</param>
        public void Eliminar(int id)
        {
            string query = $"delete from productos where Id = {id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Obtiene un artículo de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del artículo a obtener.</param>
        /// <returns>Objeto Articulo que representa al artículo obtenido, o null si no se encontró.</returns>
        public Articulo ObtenerPorId(int id)
        {
            string query = $"SELECT * FROM productos WHERE Id = {id}";
            var dt = this.EjecutarConsulta(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Articulo producto = new Articulo(
                    Convert.ToInt32(row["Id"]),
                    row["Articulo"].ToString(),
                    Convert.ToDecimal(row["Precio"]),
                    Convert.ToInt32(row["Stock"]),
                    Convert.ToInt32(row["Baja"])
                );
                return producto;
            }

            return null;
        }
    }
}

