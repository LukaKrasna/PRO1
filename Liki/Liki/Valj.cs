﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki
{
    internal class Valj : Krog
    {
        double višina;
        public Valj(int xK, int yK, double rK, double vV):base(xK,yK,rK)
        {
            višina = vV;
        }
        public double Višina { get => višina; set => višina = value; }
        public double Površina()
        {
            return 2 * Math.PI * Radij * (Radij + Višina);
        }
        public double Volumen()
        {
            return Math.PI * (Radij * Radij) * Višina;
        }
    }
}
