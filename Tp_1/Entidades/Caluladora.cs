﻿using System;
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
            if (operador == "" || operador.Length > 1)
                operador = "+";
            switch (Caluladora.ValidarOperador(char.Parse(operador)))
            {
                case "-":
                        return num1 - num2;
                case "/":
                        return num1 / num2;
                case "*":
                        return num1 * num2;
                default:
                        return num1 + num2;
            }
        }
    }
}
