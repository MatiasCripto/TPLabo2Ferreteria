using Datos;
using Entidades.Registro;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Movimientos
{
    public interface IRegistradorMovimiento
    { /// <summary>
      /// Registra los movimientos de una acción realizada por un usuario interno.
      /// </summary>
      /// <param name="accion">Acción realizada.</param>
      /// <param name="usuario">Usuario interno que realizó la acción.</param>
        void RegistrarMovimientos(string accion, PersonalInterno usuario);
    }
}
