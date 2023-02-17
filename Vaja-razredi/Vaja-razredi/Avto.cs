using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja_razredi
{
    internal class Avto
    {
        int najevčjaHitrost;
        int povprečnaPoraba;
        int količinaGorivaVRezervoarju;
        int številoPrevoženihKm;
        string registerskaŠtevilka;
        public Avto (int nH, int pP,string rŠ)
        {
            najevčjaHitrost = nH;
            povprečnaPoraba = pP;
            registerskaŠtevilka = rŠ;
        }
        public Avto (int kGVR, int šPK)
        {
            količinaGorivaVRezervoarju = kGVR;
            številoPrevoženihKm = šPK;
        }
        public double Doseg()
        {
            return 100 * 7.61 / 7.61;
        }
    }
}
