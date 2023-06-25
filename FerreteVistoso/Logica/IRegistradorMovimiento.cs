using Datos;
using Entidades.Registro;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IRegistradorMovimiento
    {
        void RegistrarMovimientos(string accion, PersonalInterno usuario);
    }
}
