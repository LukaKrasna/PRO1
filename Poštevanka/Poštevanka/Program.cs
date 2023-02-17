using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poštevanka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool c = false;
            int i = 0;
            do
            {
                Console.WriteLine("Vnesi številko za poštevanko.");
                int x = int.Parse(Console.ReadLine());
                for (int k = 1; k <= 5; k++)
                {
                    int y = r.Next(10);
                    Console.WriteLine(y + " * " + x + " = ?");
                    int a = int.Parse(Console.ReadLine());
                    if (a == x * y)
                    {
                       // Console.WriteLine("Da. " + a + " je pravilen odgovor.");
                       i++;
                    }
                }
              
                Console.WriteLine("Imel/a si jih " + i + " pravilnih");
                Console.WriteLine("Ali želiš ponovno vnesti število?(Da/Ne)");
                string c1 = (Console.ReadLine());
                if (c1.ToUpper()=="DA") //(c1.Equals("Da")  tudi to lahko, deluje sam da pri ToUpper je bolje.
                {
                    c = true;
                    Console.WriteLine("V redu.");
                }
                else if (c1.ToUpper()=="NE")
                {
                    c = false;
                    Console.WriteLine("V redu. Adijo.");
                }


            } while (c == true);
        }
    }
}
