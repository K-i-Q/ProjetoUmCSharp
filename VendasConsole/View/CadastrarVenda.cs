using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;
using VendasConsole.Util;

namespace VendasConsole.View
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            int continuar = 0;


            do
            {
                Venda venda = new Venda();
                Cliente cliente = new Cliente();
                Vendedor vendedor = new Vendedor();
                Produto produto = new Produto();
                List<Produto> produtos = new List<Produto>();
                int quantidade = 0;
                bool temEstoque = false;
               
                Console.WriteLine("Registrar Venda");
                Console.WriteLine("Digite o cpf do cliente");
                cliente.Cpf = Console.ReadLine();
                Venda.cliente = VendaDAO.PesquisarCliente(cliente.Cpf);

                Console.WriteLine("Digite o cpf do vendedor");
                vendedor.Cpf = Console.ReadLine();
                Venda.vendedor = VendaDAO.PesquisarVendedor(vendedor.Cpf);

                Console.WriteLine("Digite o produto");
                produto.Nome = Console.ReadLine();
                Venda.produto = VendaDAO.PesquisarProduto(produto.Nome);

                Console.WriteLine("Digite a quantidade");
                quantidade = Convert.ToInt32(Console.ReadLine());

                temEstoque = VendaDAO.PesquisarEstoquePorProduto(quantidade);
                if (!temEstoque)
                {
                    Mensagens.SemEstoque();

                }
                else
                {
                   produtos.Add(produto);
                }
                Console.WriteLine("Registrar mais produtos para esta venda? Pressione 1 para continuar ou 0 para sair ");
                continuar = Convert.ToInt32(Console.ReadLine());
                if(continuar == 0)
                {
                    VendaDAO.RegistrarItensVenda(cliente, vendedor, produtos, quantidade, venda);
                }
            } while (continuar != 0);
            
        }
    }
}
