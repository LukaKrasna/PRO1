using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_ocen_v_WFA
{
    internal class ŠtudentAng : Študent
    {
        public override string Izpis()
        {
            string r = "*****ŠTUDENT ANGLEŠČINE******";
            r += Environment.NewLine + "Delni 1:  " + Delni1;
            r += Environment.NewLine + "Delni 2:  " + Delni2;
            r += Environment.NewLine + "Ustni:  " + Ustna;
            r += Environment.NewLine + "Seminar:  " + Seminar;
            r += Environment.NewLine + "Končna ocena:  " + KončnaOcena();
            r += Environment.NewLine + "Črka:     " + Črka();
            r += Environment.NewLine + "*******************************";
            return r;
        }
        public override double KončnaOcena()
        {
            return 0.25 * Delni1 + 0.25 * Delni2 + 0.3 * Seminar + 0.2 * Ustna;
        }

        public override string Črka()
        {
            double x = KončnaOcena();
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
