using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";

            int numero;
            double cuadrado;
            double cubo;

            do
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    Console.WriteLine("Error, Reingresar número!");
                }
            } while (numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado de {0} es: {1}, y el cubo es: {2}", numero, cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
