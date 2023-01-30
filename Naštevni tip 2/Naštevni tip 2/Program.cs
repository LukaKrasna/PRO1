using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naštevni_tip_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int Karta = ran.Next(4);
            int Stevilo = ran.Next(10);

            Barva brv = (Barva)Karta;
            Vrednost vrd = (Vrednost)Stevilo;
            Console.Write("Karta je " + brv);
            Console.WriteLine(" z vrednostjo " + vrd + ".");
            Console.ReadLine();
        }
    }
}
