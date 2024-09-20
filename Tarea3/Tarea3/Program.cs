using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Edificio building = new Edificio(32, 250, 6, 123423);

            visualizarDatos(building);

            building.precioDepartamentoDolares *= 1.20;


            visualizarDatos(building);
        }

        static void visualizarDatos(Edificio building)
        {

            Console.WriteLine("Código                   : " + building.codigo);
            Console.WriteLine("Número de departamentos  : " + building.numeroDepartamentos);
            Console.WriteLine("Cantidad de Pisos        : " + building.cantidadPisos);
            Console.WriteLine("Precio en dolares        : " + building.precioDepartamentoDolares);
            Console.WriteLine("Precio del edificio      : " + building.precioDolaresEdificio());
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}