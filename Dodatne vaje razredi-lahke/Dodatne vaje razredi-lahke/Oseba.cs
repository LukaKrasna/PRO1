using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatne_vaje_razredi_lahke
{
    internal class Oseba
    {
        string ime;
        int starost;
        public string Ime { get => ime; set => ime = value; }
        public int Starost { get => starost; set => starost = value; }
        public Oseba(string i, int s)
        {
            ime = i;
            starost = s;
        }
        public int GetAgeInMonths()
        {
            return starost * 12;
        }
        public bool IsAdult()
        {
            if (starost <= 18)
                return false;
            return true;
        }
        public bool IsEqual(Oseba x)
        {
            if (this.ime == x.ime && this.starost == x.starost)
                return true;
            return false;
        }
    }
}
