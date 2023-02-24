using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik
{
    internal interface IDriveable
    {
        /*Vmesnik IDrivable bi moral
vključevati metodo Drive, ki meri razdaljo v kilometrih in vrne količino porabljenega goriva.*/
        double Drive(int štKilometrov);
    }
}
