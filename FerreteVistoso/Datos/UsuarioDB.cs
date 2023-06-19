using Datos;
using Datos.SQL;
using Logica.Enumerados;
using Logica.Productos;
using Logica.Usuarios;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string query = $"insert into usuarios (Nombre, Usuario, Contraseña, Role) values ('{entidad.Nombre}', '{entidad.Usuario}', '{entidad.Contrasenia}',{(int)entidad.Role})";
            this.EjecutarConsulta(query);
        }

        public void Eliminar(int id)
        {
            string query = $"delete from usuarios where Id = {id}";
            this.EjecutarConsulta(query);

        }

        public void Modificar(Persona entidad)
        {
            string query = $"update usuarios set Nombre ='{entidad.Nombre}', Usuario = '{entidad.Usuario}', Contraseña = '{entidad.Contrasenia}', Role = {(int)entidad.Role} where Id = {entidad.Id}";
            this.EjecutarConsulta(query);
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



