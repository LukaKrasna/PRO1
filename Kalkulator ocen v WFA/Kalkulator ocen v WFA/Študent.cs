using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_ocen_v_WFA
{
    abstract class Študent
    {
        //delne ocene od 0 do 100
        int delni1;
        public int Delni1
        {
            get { return delni1; }
            set {
                if (value < 0 || value > 100)
                    throw new Exception("Napačen vnos");
                else
                    delni1 = value;
            }
        }
        int delni2;
        public int Delni2
        {
            get { return delni2; }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Napačen vnos");
                else
                    delni2 = value;
            }
        }
        int seminar;
        public int Seminar
        {
            get { return seminar; }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Napačen vnos");
                else
                    seminar = value;
            }
        }
        int ustna;
        public int Ustna
        {
            get { return ustna; }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Napačen vnos");
                else
                    ustna = value;
            }
        }
        public abstract string Izpis(); //vsak ima izpis, ampak so različni
        public abstract double KončnaOcena();
        public abstract string Črka();
    }
}
