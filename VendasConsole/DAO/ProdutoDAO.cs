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

        public static string AdicionarProduto(Produto produto)
        {
            if (listaProdutos.Contains(produto))
            {
                return Mensagens.ProdutoExistente();
            }
            else
            {
                listaProdutos.Add(produto);
                Produto p = new Produto("nescau", 7, 40);
                listaProdutos.Add(p);
                return Mensagens.CadastradoComSucesso();
                
            }
        }
    }
}
