using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obrero worker = new Obrero(54, "Enzo", 5, 950);



            visualizarDatos(worker);

            worker.horasTrabajadas += 8;
            worker.tarifaHora *= 0.985;


            visualizarDatos(worker);
        }
        static void visualizarDatos(Obrero worker)
        {
            Console.WriteLine("Código           : " + worker.codigo);
            Console.WriteLine("Nombre           : " + worker.nombre);
            Console.WriteLine("Horas Trabajadas : " + worker.horasTrabajadas);
            Console.WriteLine("Sueldo Bruto     : " + worker.sueldoBruto());
            Console.WriteLine("Descuento AFP    : " + worker.dAfp());
            Console.WriteLine("Descuento EPS    : " + worker.dEps());
            Console.WriteLine("Sueldo Neto      : " + worker.sueldoNeto());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}