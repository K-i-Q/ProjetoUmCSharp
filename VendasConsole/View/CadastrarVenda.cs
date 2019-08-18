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

            Venda venda = new Venda();
            Cliente cliente = new Cliente();
            Vendedor vendedor = new Vendedor();
            Produto produto = new Produto();
            List<Produto> produtos = new List<Produto>();
            int quantidade = 0;
            bool temEstoque = false;
            int continuar = 0;
            int confirmar = 0;


            Console.WriteLine("Registrar Venda");

            Console.WriteLine("Digite o cpf do cliente");
            cliente.Cpf = Console.ReadLine();
            cliente = VendaDAO.PesquisarCliente(cliente.Cpf);

            Console.WriteLine("Digite o cpf do vendedor");
            vendedor.Cpf = Console.ReadLine();
            vendedor = VendaDAO.PesquisarVendedor(vendedor.Cpf);

            do
            {
                Console.WriteLine("Digite o produto");
                produto.Nome = Console.ReadLine();
                produto = VendaDAO.PesquisarProduto(produto.Nome);

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

            } while (continuar != 0);

            Console.WriteLine("Confirmar venda? Pressione 1 para SIM e 0 para CANCELAR");
            confirmar = Convert.ToInt32(Console.ReadLine());

            if (confirmar == 1)
            {
                Venda.RegistrarItensVenda(cliente, vendedor, produtos, quantidade);
                Console.WriteLine(VendaDAO.AdicionarVenda(venda));
            }
            else if (confirmar == 0)
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("outra coisa...");

            }
            Console.WriteLine("pressione para sair");
            Console.ReadKey();

        }
    }
}
