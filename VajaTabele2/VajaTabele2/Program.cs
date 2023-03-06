using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VajaTabele2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Napišite program, v katerem boste imeli deklarirano dvodimenzionalno tabelo
(10X10) celih števil z imenom b.
a. Napolnite tabelo z naključnimi števili od 0 do 100. Naključna števila
 generiramo s pomočjo razreda Random. Deklariramo si spremenljivko
 (z imenom na primer r) tipa Random kot nov izvod razreda Random :
 Random r = new Random();
 Naključna števila dobimo tako, da poljubni spremenljivki tipa int
 priredimo vrednost
int i = r.Next(100),
 kjer je vrednost v oklepaju največja vrednost, ki jo želimo izbrati
b. Izpišite tabelo na zaslon v obliki desetih vrstic in desetih stolpcev.
 Uporabite decimalni format, vsako število naj zasede 5 mest.
c. Napišite del kode, ki poišče in izpiše največji element v tabeli
d. Napišite del kode, ki izračuna vsoto vseh elementov v tabeli
e. Napišite del kode, ki izpiše diagonalne elemente tabele  */
            Random r = new Random();
            int[,] b = new int[10, 10];
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    b[k, j] = r.Next(100);

                }
            }
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(b[k, j] + " ");
                }
                Console.WriteLine();
            }
            //Napišite del kode, ki poišče in izpiše največji element v tabeli
            int max = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (b[k, j] > max)
                        max = b[k, j];
                }
                
            }
            //Napišite del kode, ki izračuna vsoto vseh elementov v tabeli
            int vsota = 0;
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    vsota += b[k, j];
                }

            }
            Console.WriteLine();
            Console.WriteLine("Največji element v tabeli je " + max);
            Console.WriteLine("Vsota vseh elementov je " + vsota);
            //Napišite del kode, ki izpiše diagonalne elemente tabele
            for (int k = 0; k < 10; k++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(k == j)
                        Console.WriteLine(b[k, j] + " ");
                }

            }
            Console.ReadLine();
        }
    }
}
