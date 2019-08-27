using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";

            int numeroIngresado;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            if(numeroIngresado <= 0)
            {
                Console.WriteLine("El numero ingresado no puede ser '0' o menor a '0'");
                Console.ReadKey();
            }
            else
            {

            }            
        }
    }
}
