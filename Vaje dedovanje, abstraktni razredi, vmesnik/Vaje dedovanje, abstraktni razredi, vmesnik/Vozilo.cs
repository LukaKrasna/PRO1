using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik
{
    internal abstract class Vozilo
    {
        //imajo proizvajalca, model, leto izdelave in barvo.
        protected string proizvajalec;
        protected string model;
        protected int letoIzdelave;
        protected string barva;

        public string Proizvajalec { get => proizvajalec; set => proizvajalec = value; }
        public string Model { get => model; set => model = value; }
        public int LetoIzdelave { get => letoIzdelave; set => letoIzdelave = value; }
        public string Barva { get => barva; set => barva = value; }
    }
}
