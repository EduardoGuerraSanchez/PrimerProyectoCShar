using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            Console.WriteLine("Introduce tu primer numero");
            primerNumero = System.Convert.ToInt32( System.Console.ReadLine());
            Console.WriteLine("Introduce tu segundo numero");
            segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("El primer numero es mayor:");
                Console.WriteLine(primerNumero);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El segundo numero es mayor:");
                Console.WriteLine(segundoNumero);
                Console.ReadLine();
            }
        }
    }
}
