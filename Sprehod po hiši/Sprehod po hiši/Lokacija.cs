using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprehod_po_hiši
{
    internal class Lokacija
    {
        public string ime;//dnevna soba, vrt...
        public Lokacija[] izhodi;
        public Lokacija(string i)
        {
            ime = i;
        }
        //trnutno si v dnevni sobi, od tu lahko greš v jedilnico, sprednje dvorišče; vračamo string
        public string Opis()
        {
            string r = "";
            r += "Trenutno si v " + ime;
            r += Environment.NewLine;//gre v novo vrstico
            r += "Od tu lahko greš";
            r += Environment.NewLine;
            for(int k =0;k<izhodi.Length; k++)
            {
                r += k + " - " + izhodi[k].ime;
                r += Environment.NewLine;
            }
            return r;
        }
    }
}
