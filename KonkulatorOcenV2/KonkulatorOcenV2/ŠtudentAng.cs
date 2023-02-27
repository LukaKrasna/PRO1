using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonkulatorOcenV2
{
    internal class ŠtudentAng : ŠtudentAbs
    {
        public override string Izpis()
        {
            string p = "";
            p += "*************Študent Angleščine*************";
            p += Environment.NewLine + "Delni 1 " + delni1;
            p += Environment.NewLine + "Delni 2 " + delni2;
            p += Environment.NewLine + "Seminar " + seminar;
            p += Environment.NewLine + "Ustna ocena " + ustnaOcena;
            p += Environment.NewLine + "Končna " + Ocena();
            p += Environment.NewLine + "Črka " + Črka();
            return p;
        }

        public override double Ocena()
        {
            return 0.25 * delni1 + 0.25 * delni2 + 0.3 * seminar + 0.2 * ustnaOcena;
        }

        public override string Črka()
        {
            double x = Ocena();
            if (x >= 93)
                return "A";
            if (x >= 85)
                return "B";
            if (x >= 78)
                return "C";
            if (x >= 70)
                return "D";
            return "F";
        }
    }
}
