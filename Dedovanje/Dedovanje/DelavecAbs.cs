﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal abstract class DelavecAbs
    {
        protected string delID;
        protected string ime;
        protected double brutoPlača;

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public abstract double BrutoPlača 
        { 
            get; 
        }
        public abstract void Izpis();
    }
}
