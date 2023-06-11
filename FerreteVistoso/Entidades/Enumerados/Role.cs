using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Enumerados
{
    /// <summary>
    /// Enumeración que define los roles disponibles para los usuarios.
    /// </summary>
    public enum Role
    {
        /// <summary>
        /// Rol de administrador.
        /// </summary>
        Administrador = 0,

        /// <summary>
        /// Rol de empleado.
        /// </summary>
        Empleado = 1,

        /// <summary>
        /// Rol de cliente.
        /// </summary>
        Cliente = 2
    }

}
