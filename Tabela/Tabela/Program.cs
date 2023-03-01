using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] ocene = { 82, 98, 64, 80, 95, 75 };
            //izračunaj povprečno oceno
            int vsota = 0;
            for (int k = 0; k < ocene.Length; k++)
            {
                vsota += ocene[k];
            }
            Console.WriteLine("Povprečje je " + (double)vsota / ocene.Length);
            Console.ReadLine();*/

            //int[] a = { 80, 3, 7, 8, 1, 5, 6, 84, 15 };
            //Console.WriteLine("Neurejena tabela");
            //Izpis(a);
            ////Izbiranje(a);
            //Vstavljanje(a);
            int[] a = new int[500000];
            Random r = new Random();
            for (int k = 0; k < args.Length;k++)
            {
                a[k] = r.Next(100000);
            }
            DateTime dt1 = DateTime.Now;
            Izbiranje(a);
            DateTime dt2 = DateTime.Now;
            double ts = (dt2 - dt1).TotalMilliseconds;
            Console.WriteLine("Za izbiranje " + ts +" ms");
            Console.ReadLine();
        }
        static void Izpis(int[] t)
        {
            for (int k=0; k <t.Length; k++)
            {
                Console.Write(t[k]+"\t");
            }
            Console.WriteLine();
        }
        static void Izbiranje(int[] t)
        {
            //uredi tabelo z imenom t po postopku izbiranja - selection sort
            for (int k = 0; k < t.Length - 1; k++)
            {
                //poišči minimum od k do konca tabele
                int min = t[k];
                int minIndeks = k;
                for(int j=k+1;j<t.Length; j++)
                {
                    if (t[j] < min)
                    {
                        min = t[j];
                        minIndeks = j;
                    }
                }//konec iskanja mini
                //zamenjaj element na mestu k z elemenotm na mestu minIndeks
                int c = t[k];
                t[k] = t[minIndeks];
                t[minIndeks] = c;
                //Izpis(t);
            }//konec for
        }
        static void Vstavljanje(int[] t)
        {
            for (int k = 1; k < t.Length; k++)
            {
                //pogrezni element t[k]
                int j = k;
                int temp = t[k];
                while(j>0 && t[j - 1] > temp)
                {
                    t[j] = t[j - 1];
                    j--;
                }//ali smo dobili manjšega od temp ali je konec tabele
                t[j] = temp;
                //Izpis(t);
            }
        }
    }
}
