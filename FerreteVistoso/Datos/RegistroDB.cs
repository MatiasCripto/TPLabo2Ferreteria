using Datos.SQL;
using Entidades.Registro;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RegistroDB : ConsultasSQL, IRepositorio<Registro>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase RegistroDB con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        public RegistroDB(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase RegistroDB con una cadena de conexión predeterminada.
        /// </summary>
        public RegistroDB()
        {

        }

        /// <summary>
        /// Agrega un registro a la base de datos.
        /// </summary>
        /// <param name="entidad">Registro a agregar.</param>
        public void Agregar(Registro entidad)
        {
            string fechaHora = entidad.FechaHora.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"insert into registro (FechaHora, Usuario, Accion) values ('{fechaHora}', '{entidad.Usuario}', '{entidad.Accion}')";
            this.EjecutarConsulta(query);
        }


        /// <summary>
        /// Obtiene todos los registros de la base de datos.
        /// </summary>
        /// <returns>Lista de registros.</returns>
        public List<Registro> ObtenerTodos()
        {
            List<Registro> Lista = new List<Registro>();
            var dt = this.EjecutarConsulta("select * from registro");
            foreach (DataRow item in dt.Rows)
            {
                int id = Convert.ToInt32(item["Id"]);
                string fechaHoraString = item["FechaHora"].ToString();
                DateTime fechaHora = DateTime.Parse(fechaHoraString);
                string usuario = item["Usuario"].ToString();
                string accion = item["Accion"].ToString();

                Registro registro = new Registro(id, fechaHora, usuario, accion);
                Lista.Add(registro);
            }
            return Lista;
        }

        /// <summary>
        /// Elimina un registro de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del registro a eliminar.</param>
        public void Eliminar(int id)
        {
            string query = $"delete from registro where Id = {id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Modifica un registro de la base de datos.
        /// </summary>
        /// <param name="entidad">Registro modificado.</param>
        public void Modificar(Registro entidad)
        {
            string query = $"update registro set FechaHora ='{entidad.FechaHora}', Usuario = '{entidad.Usuario}', Accion = '{entidad.Accion}' where Id = {entidad.Id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Obtiene un registro de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del registro.</param>
        /// <returns>Registro correspondiente al ID especificado, o null si no se encuentra.</returns>
        public Registro ObtenerPorId(int id)
        {
            string query = $"SELECT * FROM registro WHERE Id = {id}";
            var dt = this.EjecutarConsulta(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int registroId = Convert.ToInt32(row["Id"]);
                string fechaHoraString = row["FechaHora"].ToString();
                DateTime fechaHora = DateTime.Parse(fechaHoraString);
                string usuario = row["Usuario"].ToString();
                string accion = row["Accion"].ToString();

                Registro registro = new Registro(registroId, fechaHora, usuario, accion);
                return registro;
            }

            return null;
        }
    }
}
