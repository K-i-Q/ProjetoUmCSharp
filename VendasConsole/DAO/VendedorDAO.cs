using System.Collections.Generic;
using VendasConsole.Model;
using VendasConsole.Util;

namespace VendasConsole.DAO
{
    class VendedorDAO
    {
        private VendedorDAO()
        {

        }
        private static List<Vendedor> listaVendedores = new List<Vendedor>();

        public static List<Vendedor> ListarVendedores()
        {
            return listaVendedores;
        }

        public static string adicionarVendedor(Vendedor vendedor)
        {
            if (!Validacao.ValidarCpf(vendedor.Cpf))
            {

                return Mensagens.CpfInvalido();
            }
            if (!(listaVendedores.Contains(vendedor)))
            {
                vendedor.Cpf = RemocaoDeCaracter.RemoverCaracter(vendedor.Cpf);
                listaVendedores.Add(vendedor);
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
