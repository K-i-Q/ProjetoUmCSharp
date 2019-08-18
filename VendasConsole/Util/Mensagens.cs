
namespace VendasConsole.Util
{
    class Mensagens
    {
        public static string CpfExistente()
        {
            return "CPF já está cadastrado!";
        }
        public static string CpfInvalido()
        {
            return "CPF inválido, por favor digite um CPF válido";
        }
        public static string ProdutoExistente()
        {
            return "Produto já existe em nossa base de dados";
        }
        public static string VendaExistente()
        {
            return "Esta venda já foi cadastrada";
        }
        public static string SemEstoque()
        {
            return "Não temos esta quantia em estoque";
        }
        public static string CadastradoComSucesso()
        {
            return "Cadastrado com Sucesso!";
        }
    }
}
