using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaizpis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 5678;
            Console.WriteLine("a=" + a + " b=" + b);
            //formatiranje izpisa
            Console.WriteLine("a={0} b={1}", a, b);
            Console.ReadLine();
        }
    }
}
