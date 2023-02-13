using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaZanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 100000;
            for(int k=0; k<10; k++) //10x ponovi
            {
                Console.WriteLine(k+". Vnesi zadnje število ");
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                {
                    min = x;
                }//konec if
            }//konec for
            Console.WriteLine("Najmanjše je " + min);
            Console.ReadLine(); 
        }
    }
}
