using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;

namespace VendasConsole.Model
{
    class Venda
    {
        public List<Vendedor> vendedores = null;
        public static List<Produto> produtos = null;
        public List<Cliente> clientes = null;

        public static Produto produto = null;
        public static Cliente cliente = null;
        public static Vendedor vendedor = null;
        public static int quantidade;
        public long Id { get; private set; }
        public DateTime CriadoEm { get; set; }

        public Venda()
        {
            Id++;
            CriadoEm = DateTime.Now;
            clientes = new List<Cliente>();
            vendedores = new List<Vendedor>();
            produtos = new List<Produto>();

            clientes = ClienteDAO.ListarClientes();
            vendedores = VendedorDAO.ListarVendedores();
        }
        
        public static void RegistrarItensVenda(Cliente c, Vendedor v, List<Produto> p, int q)
        {
            cliente = c;
            vendedor = v;
            produtos = p;
            quantidade = q;

        }

        //ToString()
        public override string ToString()
        {
            StringBuilder comprovante = new StringBuilder();

            comprovante.Append("Venda: " + Id);
            comprovante.Append("\nCliente: " + cliente.Nome);
            comprovante.Append("\nVendedor: " + vendedor.Nome);
            comprovante.Append("\nData e Hora da Venda: " + CriadoEm);
            comprovante.Append("\nProdutos:");

            foreach (Produto produto in produtos)
            {
                comprovante.Append("\n" + produto);
            }


            return comprovante.ToString();
        }

        //Equals
        public override bool Equals(object obj)
        {
            Venda v = (Venda)obj;
            return Id == v.Id;
        }
    }
}
