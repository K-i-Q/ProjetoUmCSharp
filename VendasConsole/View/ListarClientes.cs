using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar clientes");
            foreach (Cliente c in ClienteDAO.ListarClientes())
            {
                Console.WriteLine(c);
            }
        }
    }
}
