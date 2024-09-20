using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computadora miPC = new Computadora(23, "Asus", "Black", 120);

            visualizarDatos(miPC);

            miPC.dolares *= 0.90;


            visualizarDatos(miPC);
        }

        static void visualizarDatos(Computadora miPC)
        {

            Console.WriteLine("Código: " + miPC.codigo);
            Console.WriteLine("Marca : " + miPC.marca);
            Console.WriteLine("Color : " + miPC.color);
            Console.WriteLine("Precio en dolares : " + miPC.dolares);
            Console.WriteLine("Precio en soles   : " + miPC.precioSoles());
            Console.WriteLine("Precio en euros   : " + miPC.precioEuros());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}