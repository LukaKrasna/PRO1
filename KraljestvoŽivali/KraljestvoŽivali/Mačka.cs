using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KraljestvoŽivali
{
    internal class Mačka:Žival, IGovor
    {
        public Mačka()
        {
            opis = "mačka";
            ime = "Srečko";

        }

        public string Govor()
        {
            return "mijav, mijav, mijav.";
        }
    }
}
