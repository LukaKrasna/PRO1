﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik_2
{
    internal interface Iproduct
    {
        double GetID(int ID);
        string GetName(string Name);
        double GetPrice(int Price);
    }
}
