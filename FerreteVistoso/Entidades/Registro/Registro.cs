using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Registro
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }

        // Constructor por defecto
        public Registro()
        {
        }

        // Constructor con parámetros para inicializar todas las propiedades
        public Registro(int id, DateTime fechaHora, string usuario, string accion)
        {
            Id = id;
            FechaHora = fechaHora;
            Usuario = usuario;
            Accion = accion;
        }

        // Constructor adicional para facilitar la creación del objeto con la fecha y hora actual
        public Registro(int id, string usuario, string accion)
        {
            Id =  id;
            FechaHora = DateTime.Now;
            Usuario = usuario;
            Accion = accion;
        }
    }
}
