using System;

namespace Clase02.Entidades
{
    public class Sello
    {
        public static string Mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            Sello.Recuadro();
            return Sello.Mensaje;
        }

        public static void Borrar()
        {
            Sello.Mensaje = "";
        }

        public static ConsoleColor ImprimirEnColor()
        {
            Sello.color = ConsoleColor.DarkRed;            
            return Sello.color;
        }

        static string Recuadro()
        {
            int largo;
            string forma = "*";
            int i;
            largo = Sello.Mensaje.Length;

            for(i=0;i<largo+2;i++)
            {
                Console.Write(forma);
            }
            Console.Write("\n*" + Sello.Mensaje + "*\n");
            for (i = 0; i < largo + 2; i++)
            {
                Console.Write(forma);
            }
            Console.WriteLine("");
            return forma;
        }
    }
}
