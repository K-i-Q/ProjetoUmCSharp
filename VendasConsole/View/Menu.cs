using System;

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
                    continuar = SairPrograma.Renderizar();
                    break;
                case 1:
                    CadastrarCliente.Renderizar();
                    break;
                case 2:
                    ListarClientes.Renderizar();
                    break;
                case 3:
                    CadastrarVendedor.Renderizar();
                    break;
                case 4:
                    ListarVendedores.Renderizar();
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
