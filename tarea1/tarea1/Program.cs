using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular myFono = new Celular(933645649, "Enzo", 30, 5);

            visualizarDatos(myFono);

            myFono.segundosConsumidos += 20;
            myFono.precioPorSegundos *= 0.95;

            visualizarDatos(myFono);


        }

        static void visualizarDatos(Celular myFono)
        {
            Console.WriteLine("Número: " + myFono.numero);
            Console.WriteLine("Usuario: " + myFono.usuario);
            Console.WriteLine("Segundos Consumidos: " + myFono.segundosConsumidos);
            Console.WriteLine("Precio por Segundo: " + myFono.precioPorSegundos);
            Console.WriteLine("Costo por Consumo: " + myFono.costoPorConsumo());
            Console.WriteLine("Impuesto IGV: " + myFono.calcularImpuestoIGV());
            Console.WriteLine("Total a Pagar: " + myFono.totalPagar());
            Console.WriteLine();
            Console.ReadKey();
        }


    }
}