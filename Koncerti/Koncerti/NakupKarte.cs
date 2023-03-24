using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koncerti
{
    enum PrivilegeLevel {Standard, Premium, Executive, PremiumExecutive}
    internal class NakupKarte
    {
        string imeDogodka;
        string štKupca;
        int štVstopnic;
        PrivilegeLevel privilegij;
        public string ŠtKupca { get => štKupca;
        set
            { if (String.IsNullOrEmpty(value))
                    throw new Exception("Ni kupca");
                else
                    štKupca = value;
            } 
        }

    }
}
