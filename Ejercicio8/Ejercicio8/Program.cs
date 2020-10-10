using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {

        public static bool mes31( int mes )
        {
            bool treintaYUno = false;

            if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                treintaYUno = true;

            }

            return treintaYUno;

        }

        public static bool mes30(int mes)
        {

            bool treinta = false;

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                treinta = true;

            }

            return treinta;

        }

        public static bool bisiesto(int mes, int anio)
        {
            bool bis = false;

            if(mes == 2)
            {
                if( anio % 4 == 0 && anio % 100 == 0 && anio % 400 == 0)
                {
                    bis = true;
                }
            }
            return bis;       
        }


        static void Main(string[] args)
        {
            int mes = 0;
            int anio = 0;
            bool treintaYUno = false;
            bool treinta = false;
            bool bis = false;

            Console.WriteLine("Introduce el mes de tu fecha");
            mes = System.Convert.ToInt32(System.Console.ReadLine());

            Console.WriteLine("Introduce el año de tu fecha");
            anio = System.Convert.ToInt32(System.Console.ReadLine());

            treintaYUno = mes31(mes);

            treinta = mes30(mes);

            bis = bisiesto(mes,anio);


            

            switch (mes)
            {
                case 1: Console.WriteLine("Enero");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 2: Console.WriteLine("Febrero");
                    if (bis == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 28 dias");

                    }
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    if (treinta == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 30 dias");
                    }
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    if (treinta == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 30 dias");
                    }
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    if (treinta == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 30 dias");
                    }
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    if (treinta == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 30 dias");
                    }
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    if (treintaYUno == true)
                    {
                        Console.WriteLine("El mes: " + mes + " del año: " + anio + " tiene 31 dias");
                    }
                    break;
                default: Console.WriteLine("Este mes no corresponde a ninguno");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}
