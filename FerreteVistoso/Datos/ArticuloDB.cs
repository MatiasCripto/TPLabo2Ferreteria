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
        
       public List<Articulo> ObtenerTodos()
        {
            List<Articulo> Lista = new List<Articulo>();
            var dt = this.EjecutarConsulta("select * from productos");
            foreach (DataRow item in dt.Rows)
            {
                Articulo producto = new Articulo(Convert.ToInt32( item["Id"]),item["Articulo"].ToString(), Convert.ToDecimal(item["Precio"]), Convert.ToInt32(item["Stock"]), Convert.ToInt32(item["Baja"]));
                Lista.Add(producto);
            }
            return Lista;
        }
        public void Modificar(Articulo articulo)
        {
            
            string query = $"update productos set Articulo = '{articulo.Nombre}', Precio = {articulo.Precio}, Stock = {articulo.Stock}, Baja = {articulo.Baja} where Id = {articulo.Id}";
            this.EjecutarConsulta(query);
        }
       
        public void Agregar(Articulo articulo)
        {
            
            string query = $"insert into productos (Articulo, Precio, Stock, Baja) values ('{articulo.Nombre}', {articulo.Precio}, {articulo.Stock}, {articulo.Baja})";
            this.EjecutarConsulta(query);
        }

        public void Eliminar(int id)
        {
            string query = $"delete from productos where Id = {id}";
            this.EjecutarConsulta(query);
        }
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
