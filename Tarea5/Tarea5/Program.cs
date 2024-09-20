using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Video myvideo = new Video(23, "Avengers", 150, 15, 3.65);


            visualizarDatos(myvideo);

            myvideo.precioSoles += 5.50;

            visualizarDatos(myvideo);

        }

        static void visualizarDatos(Video myvideo)
        {
            Console.WriteLine("Código           : " + myvideo.codigo);
            Console.WriteLine("Nombre           : " + myvideo.nombreVideo);
            Console.WriteLine("Duración         : " + myvideo.duracion);
            Console.WriteLine("Precio Soles     : " + myvideo.precioSoles.ToString("F2"));
            Console.WriteLine("Tipo de Cambio   : " + myvideo.tipoCambio.ToString("F2"));
            Console.WriteLine("Precio Dólares   : " + myvideo.precioDolares().ToString("F2"));
            Console.WriteLine();
            Console.ReadKey();
        }

    }

}