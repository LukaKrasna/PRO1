using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki
{
    internal class Kvader:Pravokotnik
    {
        int višina;
        public Kvader(int x1p,int y1p,int x2p,int y2p,int vK):base(x1p,y1p,x2p,y2p)
        {
            višina = vK;
        }
        public int Prostornina()
        {
            return Ploščina() * višina;
        }
        public int Površina()
        {
            return 2 * base.Ploščina() +
                2 * base.StranicaA() * višina +
                2 * base.StranicaB() * višina;
        }
    }
}
