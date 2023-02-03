using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_AL
{
    public class Mojr
    {
        private string mojniz;
        public Mojr(string niz)
        {
            mojniz = niz;
        }
        public void Izpis()
        {
            Console.WriteLine(mojniz);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mojr prvi;
            prvi = new Mojr("Moj prvi objekt v C#");
            prvi.Izpis(); 
        }
    }
}
