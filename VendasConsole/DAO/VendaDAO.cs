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
        private static List<Produto> produtos = new List<Produto>();
        private static List<Venda> ListaDeTodasAsVendas = new List<Venda>();
        private static List<Venda> listaVendasPorCliente = new List<Venda>();
        private static List<Cliente> listaClientes;
        private static List<Vendedor> listaVendedores;
        private static List<Produto> listaProdutos;

        private static Produto produto = new Produto();
        private static Cliente cliente = new Cliente();
        private static Vendedor vendedor= new Vendedor();

        public static int quantidade;

        private VendaDAO()
        {
            
        }
        




        public static List<Venda> ListarVendasPorCliente(string cpf)
        {
            Cliente cliente;

            var encontrado = listaClientes.Where(c => c.ToString().Contains(cpf)).ToList();
            cliente = encontrado.ElementAt(0);

            listaVendasPorCliente = ClienteDAO.ListarCompras(cliente);
            return listaVendasPorCliente;
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

        public static void RegistrarItensVenda(Cliente c, Vendedor v, List<Produto> p, int q, Venda ve)
        {
            cliente = c;
            vendedor = v;
            produtos = p;
            quantidade = q;
            ListaDeTodasAsVendas.Add(ve);
        }

        public static List<Venda> ListarTodasAsVendas()
        {
            return ListaDeTodasAsVendas;
        }

       

    }
}
