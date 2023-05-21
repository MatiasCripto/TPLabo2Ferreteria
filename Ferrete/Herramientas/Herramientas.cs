using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrete.Herramientas
{
    public static class Herramientas
    {
        public static bool StringEsInvalido(string auxDato)
        {
            auxDato = auxDato.Trim();
            return string.IsNullOrEmpty(auxDato);
        }
    }      
  
}
