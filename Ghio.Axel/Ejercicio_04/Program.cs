using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";

            int b; int s; int a; int num; int j;

            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                b = 0;
                s = i / 2;

                for (j = 1; j <= s; j++)
                {

                    a = i % j;

                    if (a == 0)
                        b = b + j;
                }
                if (b == i)
                    Console.WriteLine("El " + i + " es un numero perfecto.");

            }
            Console.ReadKey();
        }
    }
}
