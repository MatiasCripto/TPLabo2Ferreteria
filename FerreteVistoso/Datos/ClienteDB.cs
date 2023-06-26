using Datos.SQL;
using Logica.Enumerados;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDB : ConsultasSQL, IRepositorio<Persona>
    {
        /// <summary>
        /// Agrega un nuevo cliente a la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto Persona que representa al cliente a agregar.</param>
        public void Agregar(Persona entidad)
        {
            string query = $"insert into clientes (Nombre, Usuario, Contraseña, Role) values ('{entidad.Nombre}', '{entidad.Usuario}', '{entidad.Contrasenia}', {(int)entidad.Role})";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Elimina un cliente de la base de datos por su ID.
        /// </summary>
        /// <param name="id">ID del cliente a eliminar.</param>
        public void Eliminar(int id)
        {
            string query = $"delete from clientes where Id = {id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Modifica los datos de un cliente existente en la base de datos.
        /// </summary>
        /// <param name="entidad">Objeto Persona que representa al cliente a modificar.</param>
        public void Modificar(Persona entidad)
        {
            string query = $"update clientes set Nombre = '{entidad.Nombre}', Usuario = '{entidad.Usuario}', Contraseña = '{entidad.Contrasenia}', Role = {(int)entidad.Role} where Id = {entidad.Id}";
            this.EjecutarConsulta(query);
        }

        /// <summary>
        /// Obtiene todos los clientes almacenados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos Persona que representan a los clientes obtenidos.</returns>
        public List<Persona> ObtenerTodos()
        {
            List<Persona> Lista = new List<Persona>();
            var dt = this.EjecutarConsulta("select * from clientes");
            foreach (DataRow item in dt.Rows)
            {
                Persona persona = new Cliente(
                    Convert.ToInt32(item["Id"]),
                    item["Usuario"].ToString(),
                    item["Nombre"].ToString(),
                    item["Contraseña"].ToString(),
                    Enum.Parse<Role>(item["Role"].ToString())
                );
                Lista.Add(persona);
            }
            return Lista;
        }
    }
}
