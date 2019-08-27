using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string decimalBinario(double numero)
        {
            string enBinario = "";
            int miNum = 0;
            int parseado;

            parseado = (int)numero;

            if (parseado > 0)
            {
                while (parseado > 0)
                {
                    miNum = parseado % 2;
                    if (miNum == 0)
                    {
                        enBinario = 0 + enBinario;
                    }
                    else
                    {
                        enBinario = 1 + enBinario;
                    }
                    parseado = parseado / 2;
                }
            }
            return enBinario;
        }

        public static double binarioDecimal(string numero)
        {
            int resultado = 0;
            int i = 0;
            int j = 0;
            string binario;
            for (i = numero.Length - 1; i > -1; i++)
            {
                //binario[j] = numero[i];
                j++;
            }
            return resultado;
        }
    }
}
