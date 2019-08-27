using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    { 
        static void Main(string[] args)

        {
            Console.Title = "Ejercicio_13";
            double numDecimal;
            string miNumBinario;

            string numBinario;
            double miNumDecimal;

            Console.Write("Ingrese un numero decimal: ");
            numDecimal = double.Parse(Console.ReadLine());
            miNumBinario = Conversor.decimalBinario(numDecimal);

            //numBinario = Console.ReadLine();
            //miNumDecimal = Conversor.binarioDecimal(numBinario);
            Console.WriteLine("El numero en decimal " + numDecimal + " En binario es: " + miNumBinario);
            Console.ReadKey();
        }
    }
}
