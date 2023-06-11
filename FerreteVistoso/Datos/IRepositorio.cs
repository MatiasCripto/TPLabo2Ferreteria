using Datos.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);        
        void Modificar(T entidad);
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Eliminar(int id);
    }

}
