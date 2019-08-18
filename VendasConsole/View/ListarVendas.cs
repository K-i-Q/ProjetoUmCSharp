using System;
using System.Collections.Generic;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarVendas
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar Vendas");
            foreach (Venda v in VendaDAO.ListarVendas())
            {
                Console.WriteLine(v);
            }
        }
    }
}
