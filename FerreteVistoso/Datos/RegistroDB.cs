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
        public RegistroDB(string connectionString) : base(connectionString)
        {
        }

        public RegistroDB()
        {

        }

        public void Agregar(Registro entidad)
        {
            string fechaHora = entidad.FechaHora.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"insert into registro (FechaHora, Usuario, Accion) values ('{fechaHora}', '{entidad.Usuario}', '{entidad.Accion}')";
            this.EjecutarConsulta(query);
        }


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

        public void Eliminar(int id)
        {
            string query = $"delete from registro where Id = {id}";
            this.EjecutarConsulta(query);
        }

        public void Modificar(Registro entidad)
        {
            string query = $"update registro set FechaHora ={entidad.Id},'{entidad.FechaHora}', Usuario = '{entidad.Usuario}', Accion = '{entidad.Accion}' where Id = {entidad.Id}";
            this.EjecutarConsulta(query);
        }

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

