using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAO;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {

            Vendedor vendedor = new Vendedor();
            //Console.WriteLine("Cadastrar Vendedor");
            //Console.WriteLine("Digite o nome");
            //vendedor.Nome = Console.ReadLine();
            //Console.WriteLine("Digite o cpf");
            //vendedor.Cpf = Console.ReadLine();

            Console.WriteLine(VendedorDAO.adicionarVendedor(vendedor));

        }
    }
}
