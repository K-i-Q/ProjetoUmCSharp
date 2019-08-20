using System;

namespace VendasConsole.Model
{
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
            Nome = "arroz";
            Preco = 5;
            Quantidade = 50;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            CriadoEm = DateTime.Now;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Declarãção de propriedades
        public string Nome { get; set; }
        public double Preco { get; set; }
        public static int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public static int QuantiaEmEstoque()
        {
            return Quantidade;
        }

        //ToString()
        public override string ToString()
        {
            return "Produto: " + Nome + "|| Preco Un.: " + Preco;
        }

        public override bool Equals(object obj)
        {
            Produto p = (Produto)obj;
            return Nome == p.Nome;
        }
    }
}
