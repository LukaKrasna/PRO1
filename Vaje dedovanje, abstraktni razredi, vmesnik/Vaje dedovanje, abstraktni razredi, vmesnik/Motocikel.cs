using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik
{
    internal class Motocikel:Vozilo,IDriveable
    {
        //Motocikli imajo več koles in največjo hitrost.
        int štKoles;
        string največjaHitrost;
        public int ŠtKoles { get => štKoles; set => štKoles = value; }
        public string NajvečjaHitrost { get => največjaHitrost; set => največjaHitrost = value; }

        public double Drive(int štKilometrov)
        {
            //porabi 3l na 100km
            return štKilometrov * 3 / 100.0;
        }
    }
}
