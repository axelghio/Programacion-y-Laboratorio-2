using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            int dia;
            int mes;
            int anio;
            int anio2;
            int cantDias = 0;
            int contadorBis = 0;
            int contadorNat = 0;
            int numero;

            anio2 = int.Parse(DateTime.Now.ToString("yyyy"));

            Console.WriteLine("Ingrese su fecha de nacimiento.");

            Console.Write("Ingrese dia: ");
            dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese anio: ");
            anio = int.Parse(Console.ReadLine());

            for (numero = anio; numero <= anio2; numero++)
            {
                if (numero % 4 == 0 && numero % 100 != 0 || numero % 400 == 0)
                {
                    contadorBis++;
                }
                else
                {
                    contadorNat = contadorNat + 365;
                }
            }

            cantDias = contadorNat + contadorBis;

            Console.WriteLine("Usted ha vivido hasta el dia de hoy( " + DateTime.Now.ToString("dd/MM/yyyy") + " ), " + cantDias + " dias.");
            Console.ReadKey();
        }
    }
}
