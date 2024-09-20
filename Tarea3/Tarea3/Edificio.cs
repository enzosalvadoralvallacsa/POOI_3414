using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    internal class Edificio
    {
        public int codigo { get; set; }

        public int numeroDepartamentos { get; set; }

        public int cantidadPisos { get; set; }

        public double precioDepartamentoDolares { get; set; }

        public Edificio(int codigo, int numeroDepartamentos, int cantidadPisos, double precioDepartamentoDolares)
        {
            this.codigo = codigo;
            this.numeroDepartamentos = numeroDepartamentos;
            this.cantidadPisos = cantidadPisos;
            this.precioDepartamentoDolares = precioDepartamentoDolares;
        }

        public double precioDolaresEdificio()
        {
            return numeroDepartamentos * precioDepartamentoDolares;
        }
    }
}