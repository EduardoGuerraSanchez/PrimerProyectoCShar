using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Introduce el primer numero");
            a = System.Convert.ToInt32(
            System.Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            b = System.Convert.ToInt32(
            System.Console.ReadLine());

            if( (a % 2 == 0) && (b % 2 == 0))
            {
                Console.WriteLine("Son pares");
                Console.ReadLine();
            }

        }
    }
}
