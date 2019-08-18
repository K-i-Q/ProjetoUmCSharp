using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            bool continuar = true;

            do
            {
                Menu.Renderizar(continuar);
            } while (continuar);
        }
    }
}
