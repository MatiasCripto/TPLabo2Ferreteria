using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Logica.Enumerados;
using Logica.Usuarios;

namespace Datos.SQL
{
    public class ConsultasSQL : ConexionDB
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        public ConsultasSQL(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con una cadena de conexión predeterminada.
        /// </summary>
        public ConsultasSQL() : base(@"Server=DESKTOP-P2A4VQD;Database=Parcial2;Trusted_Connection=True;Encrypt=False;")
        {
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un DataTable.
        /// </summary>
        /// <param name="consulta">Consulta SQL a ejecutar.</param>
        /// <returns>DataTable con los resultados de la consulta.</returns>
        protected DataTable EjecutarConsulta(string consulta)
        {
            Abrir();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteReader();

            var dataTable = new DataTable();

            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }

        /// <summary>
        /// Obtiene un objeto Persona por su ID.
        /// </summary>
        /// <param name="id">ID de la persona.</param>
        /// <returns>Objeto Persona correspondiente al ID especificado, o null si no se encuentra.</returns>
        public Persona? ObtenerPorId(int id)
        {
            string query = $"SELECT * FROM usuarios WHERE Id = {id}";
            var dt = this.EjecutarConsulta(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Persona persona = new PersonalInterno(
                    Convert.ToInt32(row["Id"]),
                    row["Nombre"].ToString(),
                    row["Usuario"].ToString(),
                    row["Contraseña"].ToString(),
                    Enum.Parse<Role>(row["Role"].ToString())
                );
                return persona;
            }

            return null;
        }
    }
}

