using System;

namespace VendasConsole.Model
{
    class Cliente
    {
        #region C#

        //Construtor SEM parâmetro
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //Construtor COM parâmetro
        public Cliente(string cpf)
        {
            CriadoEm = DateTime.Now;
            Cpf = cpf;
        }

        //Declarãção de propriedades
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        //ToString()
        public override string ToString()
        {
            return "Cliente: "+ Nome+ " | | CPF: "+Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente c = (Cliente) obj;
            return Cpf == c.Cpf;
            //Cliente c1 = new Cliente();
            //Cliente c2 = new Cliente();

            //c1.Nome = "Carlos";
            //c1.Cpf = "123";

            //c2.Nome = "Carlos";
            //c2.Cpf = "123";
            //if (c1.Equals(c2))
            //{
            //    Console.WriteLine("Iguais");
            //}
            //else
            //{
            //    Console.WriteLine("Diferentes");
            //}
        }
        #endregion


        #region Java
        //Declarãção de propriedades
        //private string nome = "";
        //private string cpf = "";


        //public string getNome()
        //{

        //    return nome;
        //}
        //public void setNome(string nome)
        //{
        //    this.nome = nome;
        //}

        //public string getCpf()
        //{

        //    return cpf;
        //}
        //public void setCpf(string cpf)
        //{
        //    this.cpf = cpf;
        //} 
        #endregion



    }
}
