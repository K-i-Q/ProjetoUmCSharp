using System;

namespace VendasConsole.Model
{
    class Vendedor
    {
        

        //Construtor SEM parâmetro
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
            Cpf = "06159287060";
            Nome = "Maria";
        }
        //Construtor COM parâmetro
        public Vendedor(string cpf, string nome)
        {
            CriadoEm = DateTime.Now;
            Cpf = cpf;
            Nome = nome;
        }

        //Declarãção de propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }



        //ToString()
        public override string ToString()
        {
            return "Vendedor: " + Nome + "|| CPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente v = (Cliente)obj;
            return Cpf == v.Cpf;
        }
    }
}
