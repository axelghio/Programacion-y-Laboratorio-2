using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_en_clase_01
{
    public class MiClase
    {
        public static string nombre;
        public static int edad;

        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
            Console.ReadLine();
        }
        public static string RetornarNombre()
        {
            Console.Write("Ingrese nombre: ");
            MiClase.nombre = Console.ReadLine();
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            bool comparacion = false;
            if (nombre == MiClase.nombre)
            {
                comparacion = true;
            }
            return comparacion;
        }
    }
}
