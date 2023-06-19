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
