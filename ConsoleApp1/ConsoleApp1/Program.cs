using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double d = 0;
            Random r = new Random();
            for (int k=0; k<=99; k++)
            {
                int št = r.Next(100);
                x = x + št;
            }
            d = x / 100;
            Console.WriteLine("Vsota je " + d);
        }
    }
}
