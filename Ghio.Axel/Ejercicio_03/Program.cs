using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_03";
            int numero;
            int i;
            int contador = 0;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            for(i = 2; i<= numero; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if(contador == 2)
                {
                    Console.WriteLine(i);
                }
                contador = 0;
            }
            Console.ReadKey();
        }
    }
}
