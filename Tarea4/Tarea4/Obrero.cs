using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4    
{
    internal class Obrero
    {
        public int codigo { get; set; }

        public String nombre { get; set; }

        public int horasTrabajadas { get; set; }

        public double tarifaHora { get; set; }

        public Obrero(int codigo, string nombre, int horasTrabajadas, double tarifaHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHora = tarifaHora;
        }

        public double sueldoBruto()
        {
            return horasTrabajadas * tarifaHora;
        }

        public double dAfp()
        {
            return sueldoBruto() * 0.10;
        }

        public double dEps()
        {
            return sueldoBruto() * 0.05;

        }

        public double sueldoNeto()
        {
            return sueldoBruto() - dAfp() - dEps();
        }


    }
}