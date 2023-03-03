using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_tabele
{
    internal class Program
    {
        static void Main(string[] args)
        {/*1. Napišite program, v katerem imate deklarirano spremenljivko a, ki je tabela
cela števil. Vsebuje naj 10 elementov.
a. napišite kodo s pomočjo katere bo uporabnik vnesel 10 števil. Števila
shranite v tabelo a. Program naj uporabnika vpraša : "Vnesi število 1 ",
nato počaka na vnos, nato "Vnesi število 2 " itd.
b. napišite del kode, kjer boste poiskali in izpisali najmanjši in največji
element tabele
c. napišite kodo, kjer boste izračunali in izpisali vsoto in povprečno
vrednost elementov tabele. */
            int[] a = new int[10];
            Console.WriteLine("Vnesi 10 števil.");
            for(int b = 0;b <= 10; b++)
            {
                Console.WriteLine();
            }
        }
    }
}
