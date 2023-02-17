using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaTočke
{
    internal class Točka
    {
        double x;
        double y;
        double r;
        int kot; //kot je s topinjah

        public double X { get => x; set => x = value; } //to so lastnosti
        public double Y { get => y; set => y = value; } //to tudi
        public double R { get => r; set => r = value; } // to tudi

        public void PretvoriVPolarne()
        {
            //x in y poznam, računam r on kot
            r = Math.Sqrt(x * x + y * y);
            kot = (int)(Math.Atan(y / x) * 180 / Math.PI);
        }
        public void PretvoriVKarteziče()
        {
            //r kot poznam, x in y računam
            x = Math.Round(r * Math.Cos(kot * Math.PI / 100), 2);
            y = Math.Round(r * Math.Cos(kot * Math.PI / 100), 2);
        }
        public Točka()
        {
            x = 0;y = 0;
            PretvoriVPolarne();
        }
        public Točka(double x1, double y1)
        {
            x = x1; y = y1;
            PretvoriVPolarne();
        }
        public Točka(double r1,int kot1)
        {
            r = r1;kot = kot1;
            PretvoriVKarteziče();
        }
        public void Izpis()
        {
            Console.WriteLine("*************TOČKA*************");
            Console.WriteLine("Karteziče: (" + x + "," + y + ")");
            Console.WriteLine("Polarne:   (" + r + "," + kot + "°)");
        }
    }
}
