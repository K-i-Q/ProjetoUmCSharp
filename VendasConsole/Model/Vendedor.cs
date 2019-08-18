using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Model
{
    class Vendedor
    {

        //Construtor SEM parâmetro
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }
        //Construtor COM parâmetro
        public Vendedor(string cpf)
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
            return "Vendedor: " + Nome + "\nCPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Vendedor c = (Vendedor)obj;
            return Nome == c.Nome & Cpf == c.Cpf;
        }
    }
}
