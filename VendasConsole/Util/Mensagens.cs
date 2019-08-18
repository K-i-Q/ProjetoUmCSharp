using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Util
{
    class Mensagens
    {
        public static string CpfExistente()
        {
            return "CPF já está cadastrado!";
        }
        public static string CpfInvalido()
        {
            return "CPF inválido, por favor digite um CPF válido";
        }
        public static string CadastradoComSucesso()
        {
            return "Cliente foi cadastrado!";
        }
    }
}
