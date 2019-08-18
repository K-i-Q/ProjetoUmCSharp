using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Model
{
    class RegistraVenda
    {
        static Venda Venda = new Venda();
        static List<Venda> Vendas = new List<Venda>();

        public static void CadastrarVenda(Venda v)
        {
            Venda = v;
            Vendas.Add(v);
        }
        public static List<Venda> ListarVendas()
        {
            return Vendas;
        }
    }
}
