using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea8;

namespace Problema08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Asesor assessor = new Asesor(23, "Enzo", 8, 45);


            visualizarDatos(assessor);

            assessor.horasTrabajadas += 10;
            assessor.tarifaPorHora *= 0.85;

            visualizarDatos(assessor);
        }

        static void visualizarDatos(Asesor assessor)
        {
            Console.WriteLine("Código               : " + assessor.codigo);
            Console.WriteLine("Nombre               : " + assessor.nombre);
            Console.WriteLine("Horas Trabajadas     : " + assessor.horasTrabajadas);
            Console.WriteLine("Tarifa               : " + assessor.tarifaPorHora);
            Console.WriteLine("Sueldo Bruto         : " + assessor.sueldoBruto());
            Console.WriteLine("Descuento            : " + assessor.descuento());
            Console.WriteLine("Sueldo Neto          : " + assessor.sueldoNeto());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}