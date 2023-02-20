using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatne_naloge___razredi
{
    internal class Palčke
    {
        int štPalčke; //koliko je trenutno palčk na mizi
        int igralec; // 1 ali 2 - kdo je na vrsti

        public int ŠtPalčke { get => štPalčke;}
        public int Igralec { get => igralec;}
        public Palčke()
        {
            igralec = 1;
            štPalčke = 11;
        }
        public Palčke(int š)
        {
            štPalčke = š;
            igralec = 1;
        }
        public Palčke(int š, int i)
        {
            štPalčke = š;
            igralec = 1;
        }
        public void IzpisStanja()
        {
            Console.WriteLine("Na mizi je " + ŠtPalčke + " palčk.");
            Console.WriteLine("na vrsti je " + igralec);
        }
        //vzemi n palčk iz mize in zamenjaj igralca
        public void VzemiPalčke(int n)
        {
            if (n < 1 || n > 3)
            {
                Console.WriteLine("Ne slepari.");
                return;
            }
            štPalčke = štPalčke - n;
            igralec = 3 - igralec;
        }
        public bool JeKonec()
        {
            return štPalčke <= 0;
        }
        public int DobiZmagovalca()
        {
            return igralec;
        }
    }
}
