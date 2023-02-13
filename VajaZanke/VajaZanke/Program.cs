using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VajaZanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //1. naloga: Napišite program s pomočjo katerega uporabnik vnese 10 števil, nato pa izpišite 
            //najmanjšega med njimi.

            int min = 100000;
            for(int k=0; k<10; k++) //10x ponovi
            {
                Console.WriteLine(k+". Vnesi zadnje število ");
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                {
                    min = x;
                }//konec if
            }//konec for
            Console.WriteLine("Najmanjše je " + min);
            Console.ReadLine();
            */

            /* //2. naloga: Napišite program v katerem generirate 100 naključnih števil med 0 in 99, nato pa
//izpišete vsoto teh sto števil. Naključna števila v C# generiramo s pomočjo razredaRandom.

            int x = 0;
            double d = 0;
            Random r = new Random();
            for (int k=0; k<=99; k++)
            {
                int št = r.Next(100);
                x = x + št;
            }
            d = x / 100;
            Console.WriteLine("Vsota je " + d);
             */

            /*//3. naloga: Napišite program v katerem generirate 1.000 naljučnih števil med 0 in 999, izpišite
//povprečno vrednost naključno generiranih števil.

            int v = 0;
            double d = 0;
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int št = r.Next(1000);
                v = v + št;
            }
            d = v / 1000;
            Console.WriteLine("Povprečno število " + d);
            */

            /* //4. naloga: V programu generirajte 100.000 naključnih števil med o in 1.000.000. Denimo, da ta
//števila predstavljajo zneske, ki jih imajo posamezniki na banki. Nato izračunajte vsoto
//teh zneskov . Banka bi rada obračunala obresti ( letne 2,3%) na vsak posamezen
//znesek, zanima jih pa tudi koliko bodo obresti obremenile banko. V ta namen
//izračunajte koliko je 2,3% od vsote vseh zneskov in koliko je vsota obresti ( vsak
//znesek pomnožite s 2,3% in jih nato seštejte). Izpišite oba rezultata. Kaj opazite?

            float vsotaZneskov = 0;
            float vsotaObresti = 0;
            Random r = new Random();
            //
            for(int k = 0; k < 100000; k++)
            {
                float znesek = r.Next(100000);
                vsotaZneskov = vsotaZneskov + znesek;
                float obresti = znesek * 0.023f;
                vsotaObresti = vsotaObresti + obresti;
            }
            Console.WriteLine("Vsota zneskov * 0,023 {0,15:f2}", vsotaZneskov * 0.023f);
            Console.WriteLine("Vsota obresti         {0,15:n2}") vsotaObresti);
            Console.ReadLine();
             */

            //5 naloga: Napišite prvi program z uporabo while in z uporabo do….while zanke. 


            //6 naloga: Napiši program, ki izpiše vse črke (velike in male) in njihove ASCII kode. V vsaki vrstici naj bo po 10 črk.
            /* for (int k = 'A'; k <= 'z'; k++)
             {
                 Console.WriteLine((char)k);
             }
            */

            //7 naloga: Napiši program, ki izračuna in izpiše vsoto S= sin(π/1)+ sin(π/2)+ sin(π/3)+ ….+sin(π/100)


            //8 naloga: Izračunaj vrednost izraza 1+ x/1 + x2/(1*2) + x3/(1*2*3) + x4/(1*2*3*4)*…. na 5 decimalnih
            //mest natančno. X je podatek, ki ga bereš prek tipkovnice.;
            double člen = 1;
            double vsota = 1;
            Console.WriteLine("Vnesi vrednost x");
            double x = double.Parse(Console.ReadLine());
            //ponajvljaj 100x
            //for (int k = 1; k <= 100; k++)
            int k = 1;
            while (Math.Abs(vsota-Math.Exp(x))>0.000001)
            {
                člen = člen * x / k;
                vsota = vsota + člen;
                k++;
            }
            Console.WriteLine("Vsota je " + vsota);
            Console.WriteLine("e na x je " + Math.Exp(x));
            Console.ReadLine();

            //9 naloga: Napiši program, ki prebere število v šestnajstiški obliki in ga pretvori in izpiše v desetiški
            //obliki.Vhodno število beri kot zaporedje znakov. (cifre so 0,1,….9,A,B,….,F)

        }
    }
}
