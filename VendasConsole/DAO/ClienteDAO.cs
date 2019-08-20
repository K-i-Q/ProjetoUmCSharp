using System.Collections.Generic;
using VendasConsole.Model;
using VendasConsole.Util;

namespace VendasConsole.DAO
{
    class ClienteDAO
    {
        private ClienteDAO()
        {

        }
        private static List<Cliente> ListaDeClientes = new List<Cliente>();
        private static List<Venda> ListaCompras = new List<Venda>();
        private static Cliente Cliente = new Cliente();

        public static List<Cliente> ListarClientes()
        {
            return ListaDeClientes;
        }

        public static List<Venda> ListarCompras(Cliente cliente)
        {
            
            return cliente.ListaCompras;
        }


        //public static void AdicionarCompra(Venda venda)
        //{
        //    cliente.ListaCompras.Add(venda);
        //}
        public static string AdicionarClientes(Cliente cliente)
        {
            if (!Validacao.ValidarCpf(cliente.Cpf))
            {

                return Mensagens.CpfInvalido();
            }
            if (!(ListaDeClientes.Contains(cliente)))
            {
                cliente.Cpf = RemocaoDeCaracter.RemoverCaracter(cliente.Cpf);
                ListaDeClientes.Add(cliente);
                Cliente c = new Cliente("João", "64417641056");
                ListaDeClientes.Add(c);
                //Retorna true quando o CPF inserido para cadastro não existe na lista
                return Mensagens.CadastradoComSucesso();
            }
            else
            {
                return Mensagens.CpfExistente();
            }
        }

        //public static bool CadastrarCliente(Cliente c)
        //{
        //    if (BuscarCliente(c) != null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
            
        //}
        //public static Cliente BuscarCliente(Cliente c)
        //{
        //    foreach (Cliente clienteCadastrado in ListaDeClientes)
        //    {
        //        if (clienteCadastrado.Cpf.Equals(c.Cpf))
        //        {
        //            return clienteCadastrado;
        //        }
        //    }
        //    return null;
        //}


    }
}
