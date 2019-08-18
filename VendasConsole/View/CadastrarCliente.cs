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
    class CadastrarCliente
    {

        
        public static void Renderizar()
        {
            
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastrar cliente");
            Console.WriteLine("Digite o nome");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Digite o cpf");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine(ClienteDAO.AdicionarClientes(cliente));

        }
        


    }
}
