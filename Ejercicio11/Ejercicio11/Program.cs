using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcula la letra del DNI, pediremos el DNI por teclado y se devolverá el DNI completo. Para calcular la letra, 
            //cogemos el resto de dividir el DNI entre 23 y ese número corresponderá a una letra con la siguiente relacion. 
            //0=T,1=R,2=W,3=A,4=G,5=M,6=Y,7=F,8=P,9=D,10=X,11=B,12=N,13=J,14=Z,15=S,16=Q,17=V,18=H,19=L,20=C,21=K,22=E}

            double dni = 0;
            double letra = 0;
            char letraDNI;

            Console.WriteLine("Calcula la letra del DNI, pediremos el DNI por teclado y se devolverá el DNI completo. Para calcular la letra,");
            Console.WriteLine("cogemos el resto de dividir el DNI entre 23 y ese número corresponderá a una letra con la siguiente relacion.");
            Console.WriteLine("0=T,1=R,2=W,3=A,4=G,5=M,6=Y,7=F,8=P,9=D,10=X,11=B,12=N,13=J,14=Z,15=S,16=Q,17=V,18=H,19=L,20=C,21=K,22=E}");
            Console.WriteLine("Introduce tu DNI");

            dni = System.Convert.ToInt32(System.Console.ReadLine());

            letra = dni % 23;

            if( letra == 0)
            {
                letraDNI = 'T';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }

            if (letra == 1)
            {
                letraDNI = 'R';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 2)
            {
                letraDNI = 'W';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 3)
            {
                letraDNI = 'A';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 4)
            {
                letraDNI = 'G';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 5)
            {
                letraDNI = 'M';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 6)
            {
                letraDNI = 'Y';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 7)
            {
                letraDNI = 'F';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 8)
            {
                letraDNI = 'P';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 9 )
            {
                letraDNI = 'D';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 10)
            {
                letraDNI = 'X';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 11)
            {
                letraDNI = 'B';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 12)
            {
                letraDNI = 'N';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 13)
            {
                letraDNI = 'J';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 14)
            {
                letraDNI = 'Z';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 15)
            {
                letraDNI = 'S';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 16)
            {
                letraDNI = 'Q';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 17)
            {
                letraDNI = 'V';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 18)
            {
                letraDNI = 'H';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 19)
            {
                letraDNI = 'L';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 20)
            {
                letraDNI = 'C';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }
            if (letra == 21)
            {
                letraDNI = 'K';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }

            if (letra == 22)
            {
                letraDNI = 'E';
                Console.WriteLine("Tu letra del DNI es: " + letraDNI);
            }

            Console.ReadLine();

        }
    }
}
