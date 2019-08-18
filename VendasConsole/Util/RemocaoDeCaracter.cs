using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Util
{
    class RemocaoDeCaracter
    {
        public static string RemoverCaracter(string cpf)
        {
            return cpf.Replace(".", "").Replace("-", "");
        }
    }
}
