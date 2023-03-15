using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_ocen_v_WFA
{
    internal class ŠtudentNar : Študent
    {
        public override string Izpis()
        {
            string r = "";
            r += "*************ŠTUDENT NARAVOSLOVJA*************";
            r += Environment.NewLine + "Delni 1:  " + Delni1;
            r += Environment.NewLine + "Delni 2:  " + Delni2;
            r += Environment.NewLine + "Seminar:  " + Seminar;
            r += Environment.NewLine + "Končna ocena:  " + KončnaOcena();
            r += Environment.NewLine + "Črka:  " + Črka();
            r += Environment.NewLine + "*******************************";
            return r;
        }
        public override double KončnaOcena()
        {
            return 0.4 * Delni1 + 0.4 * Delni2 + 0.2 * Seminar;
        }

        public override string Črka()
        {
            double x = KončnaOcena();
            if (x >= 90)
                return "A";
            if (x >= 80)
                return "B";
            if (x >= 70)
                return "C";
            if (x >= 60)
                return "D";
            return "F";
        }
    }
}
