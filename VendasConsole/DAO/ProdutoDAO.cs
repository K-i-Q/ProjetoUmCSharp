using System.Collections.Generic;
using VendasConsole.Model;
using VendasConsole.Util;

namespace VendasConsole.DAO
{
    class ProdutoDAO
    {
        private ProdutoDAO()
        {

        }
        private static List<Produto> listaProdutos = new List<Produto>();

        public static List<Produto> ListarProdutos()
        {
            return listaProdutos;
        }

        public static string adicionarProduto(Produto produto)
        {
            if (listaProdutos.Contains(produto))
            {
                return Mensagens.ProdutoExistente();
            }
            else
            {
                listaProdutos.Add(produto);
                return Mensagens.CadastradoComSucesso();
            }
        }
    }
}
