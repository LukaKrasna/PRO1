using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedovanje
{
    internal abstract class LetniDelavec : DelavecAbs, IVarnost
    {
        double letnaPlača;
        public override double BrutoPlača
        {
            get { return letnaPlača / 12; }
        }
        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public override void Izpis()
        {
            Console.WriteLine("*************DELAVEC*************");
            Console.WriteLine("ID              " + delID);
            Console.WriteLine("Ime             " + ime);
            Console.WriteLine("Letna plača     " + letnaPlača);
            Console.WriteLine("Bruto plača     " + brutoPlača);
            Console.WriteLine("*********************************");
        public void Geslo()
        {
            Console.WriteLine("Preverjanje gelsa.");
        }

        public void UgotoviUporabnika()
        {
            Console.WriteLine("Uprašaj za uporabniško ime.");
        }

        public void ZapišiDogodek()
        {
            Console.WriteLine("Zapiši dogodek.");
        }
    }
}
}
