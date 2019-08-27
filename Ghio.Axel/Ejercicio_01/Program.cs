using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            /*Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hola C#");

            string nombre = "Axel";

            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("{0} - {1}", nombre, apellido);
            Console.ReadLine();*/

            int numero = 0;
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    minimo = numero;
                    maximo = numero;
                }
                else if(numero < minimo)
                {
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                suma = suma + numero;
            }
            promedio = (float)suma / 5;
            Console.WriteLine("El minimo es: {0}, el maximo es: {1}, el promedio es: {2}", minimo, maximo, promedio);
            Console.ReadLine();
        }
    }
}
