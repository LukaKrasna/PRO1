using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaZaIzpit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metalec m = new Metalec(1, "Kozmus", "Primož", "Ilirija", "met klavida");
            m.vnesiRezultat();
            m.Izpis();
            Console.WriteLine("Najdaljši met "+m.NajboljšiMet());
            Console.ReadLine();

        }
    }
}
