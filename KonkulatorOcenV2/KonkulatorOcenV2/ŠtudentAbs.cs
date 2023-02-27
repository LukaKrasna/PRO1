using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonkulatorOcenV2
{
    internal abstract class ŠtudentAbs //namenjen samo delovanju!!
    {
        protected int delni1; //ocene od 0 do 100
        protected int delni2;
        protected int seminar;
        protected int ustnaOcena;
        public int Delni1
        {
            get => delni1;
            set
            {
                if (value >= 0 && value <= 100)
                    delni1 = value;
                else
                    throw new Exception("Neveljavna ocena");
            }
        }
        public int Delni2
        { get => delni2;
            set
            {
                if (value >= 0 && value <= 100)
                    delni2 = value;
                else
                    throw new Exception("Neveljavna ocena");
            }
        }
        public int Seminar 
        { get => seminar;
            set
            {
                if (value >= 0 && value <= 100)
                    seminar = value;
                else
                    throw new Exception("Neveljavna ocena");
            }
        }
        public int UstnaOcena 
        { get => ustnaOcena;
            set
            {
                if (value >= 0 && value <= 100)
                     ustnaOcena = value;
                else
                    throw new Exception("Neveljavna ocena");
            }
        }
        public abstract double Ocena();//vsak študent ima svoj izračun
        public abstract string Črka();//vsakem študentu drugače pretvori
        public abstract string Izpis();
    }
}
