using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.Herramientas
{
    public static class Validador
    {
        public static bool StringEsInvalido(string auxDato)
        {
            auxDato = auxDato.Trim();
            return string.IsNullOrEmpty(auxDato);
        }
    }
}
