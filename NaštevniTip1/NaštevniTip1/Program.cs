using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaštevniTip1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Če uporabljate Mobilni tip klica pritisnite 1, če pa Stacionarni pritinsite 2.");
            string odg = Console.ReadLine();
            int tip = int.Parse(odg);
            Console.WriteLine("Koliko minut?");
            int min = Convert.ToInt32(Console.ReadLine());
            if (tip==(1))
            {
                double Sum = min * 0.02;
                Console.WriteLine("Znesek je " + Sum + " evrov.");
            }
            if (tip==(2))
            {
                double Sum = min + 0.03;
                Console.WriteLine("Znesek je " + Sum + " evrov.");
            }
            Console.ReadLine();

        }
    }
}
