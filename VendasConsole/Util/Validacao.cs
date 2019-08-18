using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Util
{
    class Validacao
    {
        public static bool ValidarCpf(String cpf)
        {
            cpf = RemocaoDeCaracter.RemoverCaracter(cpf);

            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
                case "00000000000":
                    return false;

                default:
                    int soma = 0;
                    int resto = 0;
                    int primeiroDigito = 0;
                    int segundoDigito = 0;
                    int peso = 10;
                    for (int i = 0; i < 9; i++)
                    {
                        soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                        peso--;
                    }
                    resto = soma % 11;
                    if (resto < 2)
                    {
                        primeiroDigito = 0;
                    }
                    else
                    {
                        primeiroDigito = 11 - resto;
                    }
                    if (primeiroDigito != Convert.ToInt32(cpf[9].ToString()))
                    {
                        return false;
                    }

                    soma = 0;
                    segundoDigito = 0;
                    peso = 11;
                    for (int i = 0; i < 10; i++)
                    {
                        soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                        peso--;
                    }
                    resto = soma % 11;
                    if (resto < 2)
                    {
                        segundoDigito = 0;
                    }
                    else
                    {
                        segundoDigito = 11 - resto;
                    }
                    if (segundoDigito != Convert.ToInt32(cpf[10].ToString()))
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}
