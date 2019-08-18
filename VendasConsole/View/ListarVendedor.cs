using System;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar vendedores");
            foreach (Vendedor v in VendedorDAO.ListarVendedores())
            {
                Console.WriteLine(v);
            }
        }
    }
}
