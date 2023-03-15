using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_ocen_v_WFA
{
    class ŠtudentMat : Študent
    {
        public override string Izpis()
        {
            string r = "*****ŠTUDENT MATEMATIKE******";
            r += Environment.NewLine + "Delni 1 " + Delni1;
            r += Environment.NewLine + "Delni 2 " + Delni2;
            r += Environment.NewLine + "Končna ocena " + KončnaOcena();
            r += Environment.NewLine + "Črka    " + Črka();
            r += Environment.NewLine + "*******************************";
            return r;
        }

        public override double KončnaOcena()
        {
            return 0.5 * Delni1 + 0.5 * Delni2;
        }

        public override string Črka()
        {
            double x = KončnaOcena();
            if (x >= 90)
                return "A";
            if (x >= 83)
                return "B";
            if (x >= 76)
                return "C";
            if (x >= 65)
                return "D";
            return "F";
        }
    }
}
