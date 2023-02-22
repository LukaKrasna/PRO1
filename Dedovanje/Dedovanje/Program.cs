using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delavec d = new Delavec("123", "Janez Novak", 10, 160);
            d.Izpis();
            LDelavec a = new LDelavec();
            a.DelID = "5678";
            a.Ime = "Miha Potrč";
            a.LetnaPlača = 12000;
            a.Izpis();
            LetniDelavec b = new LetniDelavec();
            b.DelID = "5678";
            b.Ime = "Miha Potrč";
            b.LetnaPlača = 12000;
            b.Izpis();
            b.Geslo
            Console.ReadLine();
        }
    }
}
