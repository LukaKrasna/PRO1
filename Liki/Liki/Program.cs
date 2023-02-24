using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. naloga Krog:
            Krog k = new Krog(37, 45, 2.5f);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            k.X = 2;
            k.Y = 2;
            k.Radij = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            Console.ReadLine();

            //2. naloga Pravokotnik:

            Pravokotnik p = new Pravokotnik(0, 1, 1, 0);
            Console.WriteLine("Koordinati kota levo zgoraj = " + p.X1 + "," + p.Y1 +
            "\nKoordinati kota desno spodaj = " + p.X2 + "," + p.Y2);
            Console.WriteLine("Stranica a " + p.StranicaA());
            Console.WriteLine("Stranica b " + p.StranicaB());
            Console.WriteLine("Ploščina " + p.Ploščina());
            Console.ReadLine(); 

            //3. naloga Valj:
          
                Valj v = new Valj(37, 45, 2.5f, 1f);
                Console.WriteLine("X koordinata = " + v.X +
                "\nY koordinata = " + v.Y +
                "\nRadij =" + v.Radij +
                "\nVišina =" + v.Višina);
                Console.WriteLine("Površina = " + v.Površina());
                Console.WriteLine("Volumen =" + v.Volumen());
                Console.ReadLine();
            

            //4. naloga Kvader:

            Kvader kv = new Kvader(0, 1, 1, 0, 1);
            Console.WriteLine("Prostornina kvadra je " +kv.Prostornina());
            Console.WriteLine("Površina kvadra je " + kv.Površina());

            Console.ReadLine();
        }
    }
}
