using Datos.SQL;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class UsuarioDB<T> : ConsultasSQL, IRepositorio<Persona>
    {
        public void Agregar(Persona entidad)
        {
            string query = $"insert into usuarios (Nombre, Usuario, Contraseña, Role) values ('{entidad.Nombre}', {entidad.Usuario}, {entidad.Role})";
            this.EjecutarConsulta(query);
        }

        public void Eliminar(int id)
        {
            string query = $"delete from usuarios where Id = {id}";
            this.EjecutarConsulta(query);

        }

        public void Modificar(Persona entidad)
        {
            string query = $"update usuarios set Nombre = '{entidad.Nombre}', Usuario = {entidad.Usuario}, Contraseña = {entidad.Contrasenia}, Role = {entidad.Role} where Id = {entidad.Id}";
            this.EjecutarConsulta(query);
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
                   Enum.Parse<Role>((string)row["Role"])
                );
                return persona;
            }

            return null;
        }

        public List<Persona> ObtenerTodos()
        {
            List<Persona> Lista = new List<Persona>();
            var dt = this.EjecutarConsulta("select * from usuarios");
            foreach (DataRow item in dt.Rows)
            {
                Persona persona = new PersonalInterno(Convert.ToInt32(item["Id"]), item["Usuario"].ToString(), item["Nombre"].ToString(), item["Contraseña"].ToString(), Enum.Parse<Role>(item["Role"].ToString()));
                Lista.Add(persona);
            }
            return Lista;
        }
    }
}
