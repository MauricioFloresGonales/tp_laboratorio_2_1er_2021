using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Caluladora
    {
        private static string ValidarOperador(char operador)
        {
            if (operador == null)
                return "+";
            switch (operador)
            {
                case '-':
                    return "-";
                case '/':
                    return "/";
                case '*':
                    return "*";
                default:
                    return "+"; 
            }
        }
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;
            switch (Caluladora.ValidarOperador(operador[0]))
            {
                case "-":
                    retorno = num1 - num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                default:
                    retorno = num1 + num2;
                    break;
            }
            return retorno;
        }
    }
}
