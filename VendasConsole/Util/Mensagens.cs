using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Util
{
    class Mensagens
    {
        public static void CpfExistente()
        {
            Console.WriteLine("CPF já está cadastrado!");
        }
        public static void CadastradoComSucesso()
        {
            Console.WriteLine("Cliente foi cadastrado!");
        }
    }
}
