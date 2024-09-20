using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pelota ball = new Pelota("Adidas", 30, 12, 45, 143);


            visualizarDatos(ball);

            ball.precio *= 0.75;
            ball.diametroCentimetros += 1;

            visualizarDatos(ball);
        }

        static void visualizarDatos(Pelota ball)
        {

            Console.WriteLine("Marca             : " + ball.marca);
            Console.WriteLine("Peso en Gramos    : " + ball.pesoGramos);
            Console.WriteLine("Presión en Libras : " + ball.presionLibras);
            Console.WriteLine("Diámetro en cm    : " + ball.diametroCentimetros);
            Console.WriteLine("Precio            : " + ball.precio);
            Console.WriteLine("Radio             : " + ball.radio());
            Console.WriteLine("Volúmen balón     : " + ball.volumenBalon().ToString("F2"));
            Console.WriteLine("Descuento         : " + ball.descuento());
            Console.WriteLine("Importe Pagar     : " + ball.importePagar());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}