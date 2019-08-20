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
        public static Produto produto = new Produto();
        public static Cliente cliente = new Cliente();
        public static Vendedor vendedor = new Vendedor();
        public static List<Produto> produtos = new List<Produto>();


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
