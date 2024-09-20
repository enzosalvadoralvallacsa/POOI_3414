using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado employee = new Empleado(34, "Enzo", 933645649, 2350);

            visualizarDatos(employee);

            employee.numeroCelular = 999888777;
            employee.sueldoSoles += 200;

            visualizarDatos(employee);
        }

        static void visualizarDatos(Empleado employee)
        {
            Console.WriteLine("Código               : " + employee.codigo);
            Console.WriteLine("Nombre               : " + employee.nombre);
            Console.WriteLine("Número ed celular    : " + employee.numeroCelular);
            Console.WriteLine("Sueldo               : " + employee.sueldoSoles);
            Console.WriteLine("El sueldo es         : " + employee.elSueldoEs());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}