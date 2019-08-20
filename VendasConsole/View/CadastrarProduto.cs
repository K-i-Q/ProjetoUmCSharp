using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {

            Produto produto = new Produto();
            //Console.WriteLine("Cadastrar Produto");
            //Console.WriteLine("Digite o nome");
            //produto.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o preço");
            //produto.Preco = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade");
            //Produto.Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ProdutoDAO.adicionarProduto(produto));

        }
    }
}
