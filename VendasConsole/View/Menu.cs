using System;

namespace VendasConsole.View
{
    class Menu
    {
        public static bool Renderizar(bool continuar)
        {
            int opcaoMenu = 0;

            TextoOpcoesMenu.Renderizar();
            opcaoMenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcaoMenu)
            {
                case 0:
                    continuar = SairPrograma.Renderizar(continuar);
                    break;
                case 1:
                    CadastrarCliente.Renderizar();
                    continuar = true;
                    break;
                case 2:
                    ListarClientes.Renderizar();
                    continuar = true;
                    break;
                case 3:
                    CadastrarVendedor.Renderizar();
                    continuar = true;
                    break;
                case 4:
                    ListarVendedores.Renderizar();
                    continuar = true;
                    break;
                case 5:
                    CadastrarProduto.Renderizar();
                    continuar = true;
                    break;
                case 6:
                    ListarProduto.Renderizar();
                    continuar = true;
                    break;
                case 7:
                    CadastrarVenda.Renderizar();
                    continuar = true;
                    break;
                case 8:
                    ListarVendas.Renderizar();
                    continuar = true;
                    break;

                default:
                    Console.WriteLine("Erro...");
                    continuar = true;
                    break;
            }
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            return continuar;
        }
    }
}
