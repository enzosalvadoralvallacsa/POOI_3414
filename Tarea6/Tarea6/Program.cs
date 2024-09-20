using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente patient = new Paciente("Enzo", "Alva", 25, 1.68, 106);

            visualizarDatos(patient);
            patient.edad = 14;
            visualizarDatos(patient);

        }

        static void visualizarDatos(Paciente patient)
        {
            Console.WriteLine("Nombre           : " + patient.nombre);
            Console.WriteLine("Apellido         : " + patient.apellido);
            Console.WriteLine("Edad             : " + patient.edad);
            Console.WriteLine("Talla            : " + patient.talla);
            Console.WriteLine("Peso             : " + patient.peso);
            Console.WriteLine("Estado           : " + patient.Edad());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}