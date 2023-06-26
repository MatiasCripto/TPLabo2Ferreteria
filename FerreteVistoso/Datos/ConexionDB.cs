using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SQL
{
    public abstract class ConexionDB
    {
        protected SqlConnection _connection;
        private string _connectionString;

        /// <summary>
        /// Inicializa una nueva instancia de la clase ConexionDB con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        public ConexionDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Abre la conexión con la base de datos.
        /// </summary>
        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        /// <summary>
        /// Cierra la conexión con la base de datos.
        /// </summary>
        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
