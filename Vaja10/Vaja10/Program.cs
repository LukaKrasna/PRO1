using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi število za a stranico.");
            string aa = Console.ReadLine();
            int a = int.Parse(aa);
            Console.WriteLine("Vnesi število za b stranico.");
            string bb = Console.ReadLine();
            int b = int.Parse(bb);
            Console.WriteLine("Vnesi število za c stranico.");
            string cc = Console.ReadLine();
            int c = int.Parse(cc);
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("So stranice trikotnika.");
            }
            else
            {
                Console.WriteLine("Niso straice trikotnika.");
            }
            Console.ReadLine();
        }
    }
}
