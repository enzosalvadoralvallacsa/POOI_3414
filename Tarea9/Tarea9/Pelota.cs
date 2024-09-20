using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    internal class Pelota
    {
        public String marca { get; set; }
        public double pesoGramos { get; set; }
        public double presionLibras { get; set; }
        public double diametroCentimetros { get; set; }
        public double precio { get; set; }

        public Pelota(string marca, double pesoGramos, double presionLibras, double diametroCentimetros, double precio)
        {
            this.marca = marca;
            this.pesoGramos = pesoGramos;
            this.presionLibras = presionLibras;
            this.diametroCentimetros = diametroCentimetros;
            this.precio = precio;
        }

        public double radio()
        {
            return diametroCentimetros / 2;
        }

        public double volumenBalon()
        {
            return Math.Round(4 * 3.1416 * radio() * radio() * radio() / 3, 2);
        }
        public double descuento()
        {
            return precio * 0.10;
        }

        public double importePagar()
        {

            return precio - descuento();

        }
    }
}