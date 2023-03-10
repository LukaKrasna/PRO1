using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropskoPrvenstvo
{
    internal class NogometnaLiga
    {
        Ekipa[] liga = new Ekipa[10];
        int[,] pari = new int[10, 10];//pari[0,2] = 5 pomeni, da se ekipi 0 in 2 srečata v 5 kolu
        public NogometnaLiga()
        {
            liga[0] = new Ekipa("Slovenija");
            liga[1] = new Ekipa("Islandija");
            liga[2] = new Ekipa("Poljska  ");
            liga[3] = new Ekipa("Švica    ");
            liga[4] = new Ekipa("Srbija   ");
            liga[5] = new Ekipa("Nemčija  ");
            liga[6] = new Ekipa("Španija  ");
            liga[7] = new Ekipa("Grčija   ");
            liga[8] = new Ekipa("Italija  ");
            liga[9] = new Ekipa("Hrvaška  ");
            IzdelajTurnir();
        }
        //izpiši kdo se sreča po kolih
        public void IzpišiTurnir()
        {
            //za vsako kolo
            for(int kolo = 1; kolo <= 9; kolo++)
            {
                Console.WriteLine("\n"+kolo+". kolo");
                for(int j = 0; j< 10; j++)
                {
                    for(int z = 0; z < 10; z++)
                    {
                        if (pari[j,z]==kolo)
                        {
                            Ekipa prva = liga[j];
                            Ekipa druga = liga[z];
                            Console.WriteLine(prva.Ime+" : "+druga.Ime);
                        }
                    }
                }
            }
        }
        int x = 0;
        int y = 1;
        int[] zgoraj = { 2, 3, 4, 5 };
        int[] spodaj = { 9, 8, 7, 6 };
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            pari[zgoraj[0], spodaj[0]] = kolo;
            pari[zgoraj[1], spodaj[1]] = kolo;
            pari[zgoraj[2], spodaj[2]] = kolo;
            pari[zgoraj[3], spodaj[3]] = kolo;
            int temp = y;
            y = spodaj[0];
            spodaj[0] = spodaj[1];
            spodaj[1] = spodaj[2];
            spodaj[2] = spodaj[3];
            spodaj[3] = zgoraj[3];
            zgoraj[3] = zgoraj[2];
            zgoraj[2] = zgoraj[1];
            zgoraj[1] = zgoraj[0];
            zgoraj[0] = temp;
        }
        public void IzdelajTurnir()
        {
            for(int k=1; k<=9;k++)
            {
                NapolniPare(k);
            }
        }
        public void ObdelajKolo()//za prvo kolo
        {
            //preglej tabelo pari, kjer je vrednost 1
            for(int k = 0; k < 10; k++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (pari[k,j]==1)
                    {
                        Ekipa prva = liga[k];
                        Ekipa druga = liga[j];
                        Console.WriteLine(prva.Ime+" : "+druga.Ime);
                        //uporabnik vnese na primer 3:2
                        string odg = Console.ReadLine();
                        string[] r = odg.Split(':');
                        int goli1 = int.Parse(r[0]);
                        int goli2 = int.Parse(r[1]);
                        liga[k].vnesiRezultat(goli1, goli2);
                        liga[j].vnesiRezultat(goli2, goli1);
                    }
                }
            }
        }
        public void IzpisVseh()
        {
            //izpiši tabelo liga
            for(int k = 0; k < 10; k++)
            {
                liga[k].Izpis();
            }
        }
        //uredi tabelo
        public void urediTabelo()
        {
            Ekipa[] urejena = new Ekipa[10];
            for(int k = 0; k < 10; k++)
            {
                urejena[k] = liga[k];
            }
            //uredi po poljubnem algoritmu
            for(int k=0; k<9; k++)
            {
                Ekipa max = urejena[k];
                int maxIndex = k;
                for(int j=k+1;j<10;j++)
                {
                    if (urejena[j].BoljšaEkipa(max))
                    {
                        max = urejena[j];
                        maxIndex = j;
                    }//konec if
                }//konecj
                Ekipa temp = liga[maxIndex];
                liga[maxIndex] = liga[k];
                liga[k] = temp;
            }//konec k
            for (int k = 0; k < 10; k++)
            {
                urejena[k].Izpis();
            }
        }//konec uredi
        //1. izdelja seznam kol
        //1. kolo se sreča slo:isl
        //                 pol:švi
        //                 srb:nem
        //...
        //2. vnesi relutat enega kola
        //slo:isl  1:2
        //pol:švi  0:0
        //3. izpiši lestvico
        //4. za ta pridne izpiši urejeno lestvico
    }
}
