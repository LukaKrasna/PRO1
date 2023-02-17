using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VajaTočke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // naloga: https://ucilnice.scng.si/pluginfile.php/18681/mod_resource/content/1/VajeRazredi.pdf (od "premakni (dx,dy)" naprej)
            Točka t1 = new Točka(1.0, 1.0);
            t1.Izpis();
            Točka t2 = new Točka(1.0, 180);
            t2.Izpis();
            Console.ReadLine();
        }
    }
}
