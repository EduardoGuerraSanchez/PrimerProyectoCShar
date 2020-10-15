using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        class Jugador
        {
            private int edad;

            public void setEdad(int edad)
            {
                this.edad = edad;
            }
            public int getEdad()
            {
                return this.edad;
            }
        }

        static void Main(string[] args)
        {
            //Realiza un ejercicio en clasificar a los jugadores de futbol por sus categorias
            //Cadete 14/15
            //Juvenil 16/17/18
            //Senior +18

            ArrayList cadete = new ArrayList();
            ArrayList juvenil = new ArrayList();
            ArrayList senior = new ArrayList();
            

            Console.WriteLine("Tengo a 5 jugadores, asignales sus categorias respectivas");

            Console.WriteLine("Introduce al primer jugador");
            Jugador jugador = new Jugador();
            jugador.setEdad(System.Convert.ToInt32(System.Console.ReadLine()));
            if (jugador.getEdad() == 14 || jugador.getEdad() == 15)
                cadete.Add(jugador);

            else if (jugador.getEdad() == 16 || jugador.getEdad() == 17 || jugador.getEdad() == 18)
                juvenil.Add(jugador);

            else if (jugador.getEdad() > 18)
                senior.Add(jugador);

            Console.WriteLine("Introduce al segundo jugador");

            jugador = new Jugador();
            jugador.setEdad(System.Convert.ToInt32(System.Console.ReadLine()));
            if (jugador.getEdad() == 14 || jugador.getEdad() == 15)
                cadete.Add(jugador);

            else if (jugador.getEdad() == 16 || jugador.getEdad() == 17 || jugador.getEdad() == 18)
                juvenil.Add(jugador);

            else if (jugador.getEdad() > 18)
                senior.Add(jugador);

            Console.WriteLine("Introduce al tercer jugador");

            jugador = new Jugador();
            jugador.setEdad(System.Convert.ToInt32(System.Console.ReadLine()));
            if (jugador.getEdad() == 14 || jugador.getEdad() == 15)
                cadete.Add(jugador);

            else if (jugador.getEdad() == 16 || jugador.getEdad() == 17 || jugador.getEdad() == 18)
                juvenil.Add(jugador);

            else if (jugador.getEdad() > 18)
                senior.Add(jugador);

            Console.WriteLine("Introduce al cuarto jugador");

            jugador = new Jugador();
            jugador.setEdad(System.Convert.ToInt32(System.Console.ReadLine()));
            if (jugador.getEdad() == 14 || jugador.getEdad() == 15)
                cadete.Add(jugador);

            else if (jugador.getEdad() == 16 || jugador.getEdad() == 17 || jugador.getEdad() == 18)
                juvenil.Add(jugador);

            else if (jugador.getEdad() > 18)
                senior.Add(jugador);

            Console.WriteLine("Introduce al quinto jugador");

            jugador = new Jugador();
            jugador.setEdad(System.Convert.ToInt32(System.Console.ReadLine()));
            if (jugador.getEdad() == 14 || jugador.getEdad() == 15)
                cadete.Add(jugador);

            else if (jugador.getEdad() == 16 || jugador.getEdad() == 17 || jugador.getEdad() == 18)
                juvenil.Add(jugador);

            else if (jugador.getEdad() > 18)
                senior.Add(jugador);


            foreach (Jugador jug in cadete)
                Console.WriteLine("Las edades de tus cadetes son: " + jug.getEdad());

            foreach (Jugador jug in juvenil)
                Console.WriteLine("Las edades de tus juveniles son: " + jug.getEdad());

            foreach (Jugador jug in senior)
                Console.WriteLine("Las edades de tus senior son: " + jug.getEdad());

            Console.ReadLine();
        }
    }
}
