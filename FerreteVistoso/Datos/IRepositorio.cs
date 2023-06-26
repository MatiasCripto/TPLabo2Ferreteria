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
        /// <summary>
        /// Agrega una entidad al repositorio.
        /// </summary>
        /// <param name="entidad">Entidad a agregar.</param>
        void Agregar(T entidad);

        /// <summary>
        /// Modifica una entidad en el repositorio.
        /// </summary>
        /// <param name="entidad">Entidad a modificar.</param>
        void Modificar(T entidad);

        /// <summary>
        /// Obtiene una entidad del repositorio por su ID.
        /// </summary>
        /// <param name="id">ID de la entidad.</param>
        /// <returns>La entidad encontrada o null si no se encuentra.</returns>
        T ObtenerPorId(int id);

        /// <summary>
        /// Obtiene todas las entidades del repositorio.
        /// </summary>
        /// <returns>Una lista de todas las entidades.</returns>
        List<T> ObtenerTodos();

        /// <summary>
        /// Elimina una entidad del repositorio por su ID.
        /// </summary>
        /// <param name="id">ID de la entidad a eliminar.</param>
        void Eliminar(int id);
    }

}
