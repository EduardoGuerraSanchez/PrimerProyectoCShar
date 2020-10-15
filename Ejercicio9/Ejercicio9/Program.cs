using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int res = 0;

            try
            {
                Console.WriteLine("Introduce tu primer numero");
                a = System.Convert.ToInt32(System.Console.ReadLine());

                Console.WriteLine("Introduce tu segundo numero");
                b = System.Convert.ToInt32(System.Console.ReadLine());

                res = a / b;
                Console.WriteLine("Tu resultado es: " + res);
                Console.ReadLine();

            }catch(Exception ex)
            {
                Console.WriteLine("Pa mi que no");
                Console.ReadLine();
            }
        }
    }
}
