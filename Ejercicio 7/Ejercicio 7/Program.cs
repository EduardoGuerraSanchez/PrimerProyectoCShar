using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila = 0;
            int columna = 0;
            string N = "N";
            string B = "B";
            int salto = 0;
            int i = 0;

            Console.WriteLine("Introduce la primera posicion de tu alfil");
            fila = System.Convert.ToInt32(System.Console.ReadLine());
            columna = System.Convert.ToInt32(System.Console.ReadLine());


            for(int contador=0; contador < 8; contador++)
            {
                Console.WriteLine(N+" "+B+" "+N+" "+B+" "+N+" "+B+" "+N+" "+B);
                               
            }
            Console.ReadLine();

            Console.WriteLine("La posicion de tu alfil se encuentra aqui");

            

            Console.ReadLine();





        }
    }
}
