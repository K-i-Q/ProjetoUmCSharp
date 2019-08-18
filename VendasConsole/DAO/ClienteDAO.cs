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
        private static List<Cliente> listaClientes = new List<Cliente>();
        private static List<Venda> listaCompras = new List<Venda>();
        private static Cliente cliente = new Cliente();

        public static List<Cliente> ListarClientes()
        {
            return listaClientes;
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
            if (!(listaClientes.Contains(cliente)))
            {
                cliente.Cpf = RemocaoDeCaracter.RemoverCaracter(cliente.Cpf);
                listaClientes.Add(cliente);
                //Retorna true quando o CPF inserido para cadastro não existe na lista
                return Mensagens.CadastradoComSucesso();
            }
            else
            {
                return Mensagens.CpfExistente();
            }
        }


    }
}
