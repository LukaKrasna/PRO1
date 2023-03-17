using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortni_graf
{
    internal class Element
    {
        public string ime;
        public double prodaja;
        public Element(string i, double p)
        {
            ime = i;
            prodaja = p;
        }
    }
}
