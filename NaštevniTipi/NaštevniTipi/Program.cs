using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaštevniTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet p = Planet.Zemlja;
            Console.WriteLine("Izrbal sem " + p);
            int odd = (int)p;
            Console.WriteLine("Po oddaljenosti od sonca je " + p);
            PeriodaPlanet pp = PeriodaPlanet.Jupiter;
            if (pp <= PeriodaPlanet.Mars)
            {
                Console.WriteLine("Odhodni čas je " + (int)pp);
            }
            else
            {
                Console.WriteLine("Odhodni čas ni znan za " + pp);
            }
            //branje iz tipkovnice
            Console.WriteLine("Vnesi zaporedno število tretjega meseca ");
            string odg = Console.ReadLine();
            int mojPlanet = int.Parse(odg);
            Planet moj = (Planet)mojPlanet;
            Console.WriteLine("Tvoj planet je " + moj);

            //Console.ReadLine();
        }
    }
}
