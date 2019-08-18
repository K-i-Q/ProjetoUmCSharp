using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static List<Cliente> ListarClientes()
        {
            return listaClientes;
        }

        public static string adicionarClientes(Cliente cliente)
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
