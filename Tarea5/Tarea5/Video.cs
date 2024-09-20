using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class Video
    {
        public int codigo { get; set; }
        public String nombreVideo { get; set; }
        public double duracion { get; set; }
        public double precioSoles { get; set; }
        public double tipoCambio { get; set; }

        public Video(int codigo, string nombreVideo, double duracion, double precioSoles, double tipoCambio)
        {
            this.codigo = codigo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSoles = precioSoles;
            this.tipoCambio = tipoCambio;
        }

        public double precioDolares()
        {
            return Math.Round(precioSoles / tipoCambio, 2);
        }

    }
}