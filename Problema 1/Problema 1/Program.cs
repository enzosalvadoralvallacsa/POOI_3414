using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Docente docente = new Docente(5, "Equisde", 4, 20);

            Console.WriteLine("Código            : " + docente.codigo);
            Console.WriteLine("Nombre            : " + docente.nombre);
            Console.WriteLine("Horas Trabajadas  : " + docente.horasTrabajadas);
            Console.WriteLine("Tarifa Horaria    : " + docente.tarifaHoraria);
            Console.WriteLine("Sueldo Bruto      : " + docente.sueldoBruto());
            Console.WriteLine("Descuento         : " + docente.descuento());
            Console.WriteLine("Sueldo Neto       : " + docente.sueldoNeto());
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}