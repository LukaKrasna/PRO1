using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vnesi deljenca med 0 in 100.");
                int deljenec = int.Parse(Console.ReadLine());
                if (deljenec < 0 || deljenec > 100)
                    throw new ApplicationException("Deljenec naj bo med 0 in 100.");
                Console.WriteLine("Vnesi delitelja med 1 in 10.");
                int delitelj = int.Parse(Console.ReadLine());
                if (delitelj < 1 || delitelj > 10)
                    throw new Exception("Delitelj ni med 1 in 10");
                double količnik = (double)deljenec / delitelj;
                Console.WriteLine(deljenec + " : " + delitelj + " = " + količnik);
                Console.WriteLine("Količnik je " + količnik + ".");
            }
            catch (FormatException)
            {
                Console.WriteLine("Napaka pri vnosu podatkov.");//To je samo prevod errora messagea v slovenščino.
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Deljenje z 0 ni dovoljeno.");//Isto tu.
            }
            catch(Exception ex)
            {
                Console.WriteLine("Prišlo je do napake: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Sem v finally.");
            }
            Console.WriteLine("Konec.");
            Console.ReadLine();
        }
    }
}
