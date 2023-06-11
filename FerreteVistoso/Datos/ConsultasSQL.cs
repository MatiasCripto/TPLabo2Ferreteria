using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos.SQL
{
    public class ConsultasSQL : ConexionDB
    {
        public ConsultasSQL(string connectionString) : base(connectionString)
        {
        }

        public ConsultasSQL() : base(@"Server=DESKTOP-P2A4VQD;Database=Parcial2;Trusted_Connection=True;Encrypt=False;") { }

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
    }
}
