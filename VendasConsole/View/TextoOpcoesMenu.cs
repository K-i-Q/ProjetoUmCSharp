﻿using System;

namespace VendasConsole.View
{
    class TextoOpcoesMenu
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção do menu: ");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Cadastrar Vendedor");
            Console.WriteLine("4 - Listar Vendedores");
            Console.WriteLine("5 - Cadastrar Produto");
            Console.WriteLine("6 - Listar Produtos");
            Console.WriteLine("7 - Registrar Venda");
            Console.WriteLine("8 - Listar Vendas");
            Console.WriteLine("0 - Sair");
        }
    }
}
