using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades.Registro
{
    public class Registro
    {
        /// <summary>
        /// Obtiene o establece el ID del registro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha y hora del registro.
        /// </summary>
        public DateTime FechaHora { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre de usuario asociado al registro.
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Obtiene o establece la acción realizada en el registro.
        /// </summary>
        public string Accion { get; set; }

        /// <summary>
        /// Constructor por defecto de la clase Registro.
        /// </summary>
        public Registro()
        {
        }

        /// <summary>
        /// Constructor de la clase Registro que inicializa todas las propiedades.
        /// </summary>
        /// <param name="id">ID del registro.</param>
        /// <param name="fechaHora">Fecha y hora del registro.</param>
        /// <param name="usuario">Nombre de usuario asociado al registro.</param>
        /// <param name="accion">Acción realizada en el registro.</param>
        public Registro(int id, DateTime fechaHora, string usuario, string accion)
        {
            Id = id;
            FechaHora = fechaHora;
            Usuario = usuario;
            Accion = accion;
        }

        /// <summary>
        /// Constructor adicional de la clase Registro que facilita la creación del objeto con la fecha y hora actual.
        /// </summary>
        /// <param name="id">ID del registro.</param>
        /// <param name="usuario">Nombre de usuario asociado al registro.</param>
        /// <param name="accion">Acción realizada en el registro.</param>
        public Registro(int id, string usuario, string accion)
        {
            Id = id;
            FechaHora = DateTime.Now;
            Usuario = usuario;
            Accion = accion;
        }
    }
}
