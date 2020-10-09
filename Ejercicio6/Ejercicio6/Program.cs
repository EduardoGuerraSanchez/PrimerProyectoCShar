using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int contador = 0;
            char siete = '7';
            Console.WriteLine("Introduce tu numero y a ver cuantos 7 tiene dicho numero");

            string numero = Console.ReadLine();

            foreach(char letra in numero)
            {
                Console.WriteLine(letra);
                if( letra == siete){
                    contador++;
                }               
            }
            Console.WriteLine("Hay : " + contador + " sietes");
            Console.ReadLine();
        }
    }
}
