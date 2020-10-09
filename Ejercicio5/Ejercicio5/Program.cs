using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {


    
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            bool acertar = false;
            Console.WriteLine("Introduce tu numero a adivinar");
            a = System.Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Introduce un numero a ver si lo adivinas:");
            b = System.Convert.ToInt32(System.Console.ReadLine());
            

            if ( a == b)
            {
                Console.WriteLine("Felicidades, has acertado");
                System.Console.ReadLine();
                acertar = true;
            }
            if (a != b)
            {
                Console.WriteLine("Lo siento, has fallado, pero te dire una pista");

                if (a % 2 == 0)
                {
                    Console.WriteLine("El numero a adivinar es par");
                    b = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El numero a adivinar es impar");
                    b = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.ReadLine();
                }

                if( a >= 0 && a <= 10)
                {
                    Console.WriteLine("El numero a adivinar esta entre el 0 y el 10");
                    b = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El numero a adivinar esta entre el 11 y el 20");
                    b = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.ReadLine();
                }


                if( a / 5 == 0)
                {
                    Console.WriteLine("Tu numero es multiplo de 5");
                    b = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.ReadLine();
                }
            }

        }
    }
}
