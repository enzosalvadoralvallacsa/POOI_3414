using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01_01
{
    internal class Docente
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifaHoraria { get; set; }

        public Docente(int codigo, string nombre, int horasTrabajadas, double tarifaHoraria)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaHoraria = tarifaHoraria;
        }

        public double sueldoBruto()
        {
            return horasTrabajadas * tarifaHoraria;
        }
        public double descuento()
        {
            if (sueldoBruto() < 4500)
            {
                return sueldoBruto() * 0.12;
            }
            else if (sueldoBruto() >= 45000 && sueldoBruto() < 6500)
            {
                return sueldoBruto() * 0.14;
            }
            else
            {
                return sueldoBruto() * 0.16;
            }
        }

        public double sueldoNeto()
        {
            return sueldoBruto() - descuento();
        }

    }
}