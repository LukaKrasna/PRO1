using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izpiši temperaturo vode od 5 do 100.");
            string odg = Console.ReadLine();
            int t = int.Parse(odg);
            if (t <= 10)
            {
                Console.WriteLine("Zelo mrzla.");
            }
            else if (t>10 && t<=20)
            {
                Console.WriteLine("Hladna.");
            }
            else if (t>20 && t<=30)
            {
                Console.WriteLine("Topla.");
            }
            else if (t>30 && t<=50)
            {
                Console.WriteLine("Vroča.");
            }
            else if (t>50)
            {
                Console.WriteLine("Zelo vroča.");
            }
        }
    }
}
