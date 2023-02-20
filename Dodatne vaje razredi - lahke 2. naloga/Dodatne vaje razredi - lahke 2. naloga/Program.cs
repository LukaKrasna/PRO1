using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatne_vaje_razredi___lahke_2.naloga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pravokotnik a = new Pravokotnik(14, 12);
            Console.WriteLine("Kakšna je ploščina? " + a.GetArea() + "cm");
            Console.WriteLine("Kakšen je obseg? " + a.GetPerimeter() + "cm");
            Console.WriteLine("Ali je to kvadrat? " + a.IsSquare());
            Console.ReadLine();
        }
    }
}
