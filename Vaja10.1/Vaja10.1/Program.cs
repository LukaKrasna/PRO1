using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi poljubno trimestno število.");
            string odg = Console.ReadLine();
            int a = int.Parse(odg);
            int b =  a % 10;
            int b1 = a / 10;
            int c =  b1 % 10;
            int c1 = b1 / 10;
            int d = c1 % 10;
            if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0)
            {
                Console.WriteLine("Številke so lihe.");
            }
            else if(a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                Console.WriteLine("Številke so sode.");
            }
            else
            {
                Console.WriteLine("Številke so sode in lihe.");
            }
        }
    }
}
