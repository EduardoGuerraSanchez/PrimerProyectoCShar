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
            Console.WriteLine("Este es tu tablero, introduce la posicion de tu alfil");

            for (int f = 0; f < 8; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("N ");
                    Console.Write("B ");
                }
                Console.WriteLine();
            }

            fila = System.Convert.ToInt32(System.Console.ReadLine());
            columna = System.Convert.ToInt32(System.Console.ReadLine());


            Console.WriteLine("La posicion de tu alfil se encuentra aqui");

            for( int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if ((i - j == fila - columna) || (i + j == fila + columna))
                        Console.WriteLine("* ");
                    else if ((i + j) % 2 == 0)
                        Console.WriteLine("N ");
                    else
                        Console.WriteLine("B ");
                }
                Console.WriteLine();
            }
             Console.ReadLine();
        }
    }
}
