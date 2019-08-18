using System;

namespace VendasConsole.Model
{
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
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
