using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //naloga: https://ucilnice.scng.si/pluginfile.php/34073/mod_resource/content/0/Ruleta.pdf
            Random r = new Random();
            Console.WriteLine("Vnesi začetni denarni vložek.");
            int stanje = int.Parse(Console.ReadLine());
            int začStanje = stanje;
            Console.WriteLine("Vnesi začetno višino stave.");
            int stava = int.Parse(Console.ReadLine());
            int začStava = stava;
            int min = 0;
            int max = 9999999;
            string barva = "";
            for (int k = 1; k <= 10; k++)
            {
                int metKocke = r.Next(36);
                if(metKocke % 2 == 0)
                {
                    stanje = stanje + stava;
                    stava = začStava;
                    barva = "rdeča";
                }
                else
                {
                    stanje = stanje - stava;
                    stava = začStava;
                    barva = "črna";
                }
                Console.WriteLine("met: ")
            }

        }
    }
}
