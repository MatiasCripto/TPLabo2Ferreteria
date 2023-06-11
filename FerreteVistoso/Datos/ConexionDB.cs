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
        //private  SqlCommand _command;
        private string _connectionString;

        public ConexionDB(string connectionString) { 
            _connectionString = connectionString;
            //_connection = new SqlConnection(connectionString);
        }

        protected void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        protected void Cerrar()
        {
            _connection.Close();
        }
    }
}
