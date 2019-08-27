using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            int numero;
            int intentos = 0;
            int valorMinimo;
            int valorMaximo;
            int promedio;
            bool estado;

            Console.Write("Ingresa un numero dentro del rango -100 y 100");
            numero = int.Parse(Console.ReadLine());
            while(intentos <= 10)
            {
                estado = validar(numero, -100, 100);
            }
            

            bool validar(int valor, int min, int max)
            {
                bool retorno = false;
                if(numero >= min && numero <= max)
                {
                    retorno = true;
                }
                return retorno;
            }
            Console.WriteLine("");
        }
    }
}
