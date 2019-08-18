using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VendasConsole.DAO;

namespace VendasConsole.Model
{
    class Venda
    {
        public static List<Produto> produtos;
        public static List<Venda> vendas;

        public static Produto produto;
        public static Cliente cliente;
        public static Vendedor vendedor;

        public static int quantidade;
        public long Id { get; private set; }
        public static long GlobalId;

        public DateTime CriadoEm { get; set; }

        public Venda()
        {

            Id = Interlocked.Increment(ref GlobalId);
            CriadoEm = DateTime.Now;

            produtos = new List<Produto>();
            vendas = new List<Venda>();

            vendedor = new Vendedor();
            produto = new Produto();
            cliente = new Cliente();
        }
        
        public static void RegistrarItensVenda(Cliente c, Vendedor v, List<Produto> p, int q, Venda venda)
        {
            cliente = c;
            vendedor = v;
            produtos = p;
            quantidade = q;
            vendas.Add(venda);

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
