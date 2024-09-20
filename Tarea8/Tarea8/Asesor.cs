using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    internal class Asesor
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int horasTrabajadas { get; set; }
        public double tarifaPorHora { get; set; }

        public Asesor(int codigo, string nombre, int horasTrabajadas, double tarifaPorHora)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaPorHora = tarifaPorHora;
        }

        public double sueldoBruto()
        {
            return horasTrabajadas * tarifaPorHora;
        }

        public double descuento()
        {
            return sueldoBruto() * 0.15;
        }

        public double sueldoNeto()
        {
            return sueldoBruto() - descuento();
        }
    }
}