using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Razredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Napis x = new Napis();
            x.najljubšiProgram = "C#";
            x.izpiši();
            Napis.Koliko();
            Napis y = new Napis();
            y.najljubšiProgram = "python";
            y.izpiši();
            Napis.Koliko();
            Napis.Koliko();
            Napis.štIzvodov = 5;
            /*Console.WriteLine("Kateri je tvoj najboljši p. j.?");
            string moj = Console.ReadLine();
            Napis z = new Napis(moj);
            z.izpiši(); */
            Console.ReadLine();
        }
    }
}
