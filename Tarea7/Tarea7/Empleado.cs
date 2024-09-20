using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7
{
    internal class Empleado
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int numeroCelular { get; set; }
        public double sueldoSoles { get; set; }

        public Empleado(int codigo, string nombre, int numeroCelular, double sueldoSoles)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.numeroCelular = numeroCelular;
            this.sueldoSoles = sueldoSoles;
        }

        public String elSueldoEs()
        {
            if (sueldoSoles > 3500)
                return "Mayor a 3500";
            else if (sueldoSoles > 3500)
                return "Menos a 3500";
            else
                return "Es igual a 3500";
        }
    }
}