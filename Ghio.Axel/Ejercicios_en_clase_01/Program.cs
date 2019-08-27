using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
using Clase02.Entidades;

namespace Ejercicios_en_clase_01
{
    class Program
    {
        static void Main(string[] args)
        {/*
            MiClase.nombre = "Axel";
            //MiClase.MostrarEdad();
            Console.WriteLine(MiClase.RetornarNombre());
            Console.WriteLine(MiClase.CompararNombres("Axel"));
            Console.ReadLine();*/


            Sello.Mensaje = "gato de mier";
            Sello.Imprimir();
            Console.ForegroundColor = Sello.ImprimirEnColor();
            Sello.Imprimir();
            Sello.Borrar();
            Console.ReadLine();
        }
    }
}
