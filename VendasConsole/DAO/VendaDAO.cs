using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Model;
using VendasConsole.Util;

namespace VendasConsole.DAO
{
    class VendaDAO
    {
        private VendaDAO()
        {

        }

        private static List<Venda> listaVendas = new List<Venda>();
        private static List<Cliente> listaClientes = new List<Cliente>();
        private static List<Vendedor> listaVendedores = new List<Vendedor>();
        private static List<Produto> listaProdutos = new List<Produto>();

        public static List<Venda> ListarVendas()
        {
            return listaVendas;
        }

        public static Cliente PesquisarCliente(string cpf)
        {
            listaClientes = ClienteDAO.ListarClientes();
            Cliente cliente;

            var encontrados = listaClientes.Where(c => c.ToString().Contains(cpf)).ToList();
            cliente = encontrados.ElementAt(0);
            if (encontrados != null)
            {
                return cliente;
            }
            return null;
        }
        public static Vendedor PesquisarVendedor(string cpf)
        {
            listaVendedores = VendedorDAO.ListarVendedores();
            Vendedor vendedor;

            var encontrados = listaVendedores.Where(c => c.ToString().Contains(cpf)).ToList();
            vendedor = encontrados.ElementAt(0);
            if (encontrados != null)
            {
                return vendedor;
            }
            return null;
        }

        public static Produto PesquisarProduto(string nome)
        {
            listaProdutos = ProdutoDAO.ListarProdutos();
            Produto produto;

            var encontrados = listaProdutos.Where(c => c.ToString().Contains(nome)).ToList();
            produto = encontrados.ElementAt(0);
            if (encontrados != null)
            {
                return produto;
            }
            return null;
        }

        public static bool PesquisarEstoquePorProduto(int quantidade)
        {
            if (quantidade <= Produto.Quantidade)
            {
                return true;
            }            
            return false;
        }

        public static string AdicionarVenda(Venda venda)
        {
            if (listaVendas.Contains(venda))
            {
                return Mensagens.VendaExistente();
            }
            else
            {
                listaVendas.Add(venda);
                return Mensagens.CadastradoComSucesso();
            }



        }
    }
}
