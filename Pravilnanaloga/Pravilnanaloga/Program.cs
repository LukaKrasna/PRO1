using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pravilnanaloga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi tip klica 1- mobilno, 2- stacionarno.");
            //string odg = Console.ReadLine();
            TipiKlica tip = (TipiKlica)int.Parse(Console.ReadLine());
            //na enak način vnesi minute
            Console.WriteLine("Vnesi število minut.");
            int min = int.Parse(Console.ReadLine());

            double z = 0;
            if (tip == TipiKlica.KlicMobilno)
            {
                z = min * 0.03;
            }
            else 
            {
                z = min + 0.02;
            }
            Console.WriteLine("Dolguješ " + z + " evrov.");
            Console.ReadLine();
        }
    }
}
