using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarVendasPorCliente
    {
        public static void Renderizar()
        {
            string cpf;
            Console.WriteLine("Listar Vendas Por Cliente");
            Console.WriteLine("Digite o CPF do cliente: ");
            cpf = Console.ReadLine();

            foreach (Venda v in VendaDAO.ListarVendasPorCliente(cpf))
            {
                Console.WriteLine(v);
            }
        }
    }
}
