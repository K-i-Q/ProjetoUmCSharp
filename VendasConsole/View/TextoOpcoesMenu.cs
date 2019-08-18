using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.View
{
    class TextoOpcoesMenu
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção do menu: ");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("0 - Sair");
        }
    }
}
