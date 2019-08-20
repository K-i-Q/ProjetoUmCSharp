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
            
            VendaDAO.ListarTodasAsVendas().ForEach(Console.WriteLine);

        }
    }
}
