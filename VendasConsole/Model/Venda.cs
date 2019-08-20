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
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }

        public int Quantidade { get; set; }

        public List<Produto> ListaDeProdutosDaVenda = new List<Produto>();


        public long Id { get; private set; }
        public static long GlobalId;

        public DateTime CriadoEm { get; set; }

        public Venda()
        {
            Id = Interlocked.Increment(ref GlobalId);
            CriadoEm = DateTime.Now;
        }


        //ToString()
        public override string ToString()
        {
            StringBuilder comprovante = new StringBuilder();


            comprovante.Append("Venda: " + Id);
            comprovante.Append("\nCliente: " + Cliente.Nome);
            comprovante.Append("\nVendedor: " + Vendedor.Nome);
            comprovante.Append("\nData e Hora da Venda: " + CriadoEm);
            comprovante.Append("\nProdutos:");

            foreach (Produto produto in ListaDeProdutosDaVenda)
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
