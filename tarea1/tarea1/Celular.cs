using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Celular
    {
        public int numero { get; set; }

        public String usuario { get; set; }

        public int segundosConsumidos { get; set; }

        public double precioPorSegundos { get; set; }

        public Celular(int numero, string usuario, int segundosConsumidos, double precioPorSegundos)
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioPorSegundos = precioPorSegundos;
        }

        public double costoPorConsumo()
        {
            return segundosConsumidos * precioPorSegundos;
        }

        public double calcularImpuestoIGV()
        {
            return costoPorConsumo() * 0.18;
        }

        public double totalPagar()
        {
            return costoPorConsumo() + calcularImpuestoIGV();
        }



    }

}
