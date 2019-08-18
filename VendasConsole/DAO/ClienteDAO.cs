using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Model;

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

        public static bool adicionarClientes(Cliente cliente)
        {
            if (!(listaClientes.Contains(cliente)))
            {
                listaClientes.Add(cliente);
                //Retorna true quando o CPF inserido para cadastro não existe na lista
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
