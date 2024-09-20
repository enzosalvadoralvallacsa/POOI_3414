using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Computadora
    {
        public int codigo { get; set; }
        public String marca { get; set; }
        public String color { get; set; }

        public double dolares { get; set; }

        public Computadora(int codigo, string marca, string color, double dolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.dolares = dolares;
        }

        public double precioSoles()
        {
            return dolares * 3.35;
        }

        public double precioEuros()
        {
            return 1.20 * dolares;
        }
    }
}