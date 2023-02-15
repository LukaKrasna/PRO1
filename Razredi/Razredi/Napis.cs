using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    internal class Napis
    {
        public string najljubšiProgram; //vezano na objekt
        public static int štIzvodov; // vezano na razred
        public void izpiši()
        {
            Console.WriteLine("Rad imam " + najljubšiProgram);
        }
        public Napis() //to je konstruktor. Ustvariš ga s napisom ctor (tab 2x).
        {
            najljubšiProgram = "Neznano";
            Console.WriteLine("Konstruktor brez parametra");
            štIzvodov++;
        }
        public Napis(string n)
        {
            najljubšiProgram = n;
            Console.WriteLine("Konstruktor s parametri");
            štIzvodov++;
        }
        public static void Koliko()
        {
            Console.WriteLine("Število objektov tipa Napis je " + štIzvodov);
        }
        /*~Napis() //destruktor (ni treba znat)
        {
            Console.WriteLine("Sem v destruktorju.");
        }*/
    }
}
