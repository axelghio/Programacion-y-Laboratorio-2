using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";

            int numero;
            int ano1;
            int ano2;

            Console.Write("Ingrese desde que año quiere iniciar a calcular: ");
            ano1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese hasta que año quiere calcular: ");
            ano2 = int.Parse(Console.ReadLine());

            for (numero = ano1; numero <= ano2; numero++)
            {
                if (numero % 4 == 0 && numero % 100 != 0 || numero % 400 == 0)
                {
                    Console.WriteLine("El año " + numero + " es bisiesto.\n");
                }
                else
                {
                    Console.WriteLine("El año " + numero + " no es bisiesto..\n");
                }
            }
            Console.ReadKey();
        }
    }
}
