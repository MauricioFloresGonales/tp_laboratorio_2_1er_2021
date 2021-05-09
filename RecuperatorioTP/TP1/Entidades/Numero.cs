using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(string strNumero) : this()
        {
            this.SetNumero = strNumero;
        }
        public Numero(double numero):this(numero.ToString())
        {
        }
        
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero == 0)
                return double.MinValue;
            return (double)num1.numero / num2.numero;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;

            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }
            return retorno;
        }
        private static bool EsBinario(string numeroBinario)
        {
            char caracterCero = '0';
            char caracterUno = '1';
            char caracterComa = ',';
            char caracterPunto = '.';

            for (int i = 0; i < numeroBinario.Length; i++)
            {
                if (numeroBinario[i] != caracterCero && numeroBinario[i] != caracterUno)
                {
                    if (numeroBinario[i] != caracterComa && numeroBinario[i] != caracterPunto)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static string DecimalBinario(string numero)
        {
            ulong aux;
            if (ulong.TryParse(numero, out aux))
            {
                return DecimalBinario(aux);
            }
            return "Valor invalido";
        }
        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    numero = (int)(numero / 2);
                }
                return numeroBinario;
            }
            else
            {
                if (numero == 0)
                {
                    numeroBinario = "0";
                }
                else
                {
                    numeroBinario = "Valor invalido";
                }
            }
            return numeroBinario;
        }
        public static string BinarioDecimal(string palabra)
        {
            if (EsBinario(palabra))
            {
                char[] array = palabra.ToCharArray();
                Array.Reverse(array);
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
                return sum.ToString();
            }
            return "Valor invalido";
        }
    }
}
