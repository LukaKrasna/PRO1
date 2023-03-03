using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprehod_po_hiši
{
    internal class Soba:Lokacija
    {
        string dekoracija;
        public Soba(string i,string d):base(i)
        {
            dekoracija = d;
        }
        public new string Opis()
        {
            string r = base.Opis();
            r += Environment.NewLine;
            r += "Vidiš " + dekoracija + Environment.NewLine;
            return r;
        }
    }
}
