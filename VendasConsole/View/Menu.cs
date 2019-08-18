using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.View
{
    class Menu
    {
        public static void Renderizar(bool continuar)
        {
            int opcaoMenu = 0;

            TextoOpcoesMenu.Renderizar();
            opcaoMenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcaoMenu)
            {
                case 0:
                    SairPrograma.Renderizar(continuar);
                    break;
                case 1:
                    CadastrarCliente.Renderizar();
                    break;
                case 2:
                    ListarClientes.Renderizar();
                    break;
                default:
                    Console.WriteLine("Erro...");
                    break;
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
