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
    public class RegistrarMovimiento : IRegistradorMovimiento
    {
       
        public void RegistrarMovimientos(string accion, PersonalInterno usuario)
        {           

            Registro registro = new Registro();
            registro.FechaHora = DateTime.Now;
            registro.Usuario = usuario != null ? usuario.Nombre : "Desconocido"; ;
            registro.Accion = accion;

            // Agregas el registro a la base de datos
            RegistroDB registroDB = new RegistroDB();
            registroDB.Agregar(registro);
        }
    }
}

