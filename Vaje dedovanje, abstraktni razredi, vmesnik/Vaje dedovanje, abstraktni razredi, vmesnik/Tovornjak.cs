using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik
{
    internal class Tovornjak:Vozilo,IDriveable
    {
        //Tovornjaki imajo nosilnost in vlečno zmogljivost.
        int nosilnost;
        int zmogljivost;
        public int Nosilnost { get => nosilnost; set => nosilnost = value; }
        public int Zmogljivost { get => zmogljivost; set => zmogljivost = value; }

        public double Drive(int štKilometrov)
        {
            //porabi 10l na 100km
            return štKilometrov * 10 / 100.0;
        }
    }
}
