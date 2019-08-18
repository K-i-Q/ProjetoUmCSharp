using System;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class ListarProduto
    {
        public static void Renderizar()
        {
            Console.WriteLine("Listar produtos");
            foreach (Produto p in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(p);
            }
        }
    }
}
