using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropskoPrvenstvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Naloga:https://ucilnice.scng.si/pluginfile.php/34397/mod_resource/content/1/Tabela_objektov.pdf */
            /*Ekipa a = new Ekipa("Slovenija");
            Ekipa b = new Ekipa("Italija  ");
            //slo:Ita=2:1
            a.vnesiRezultat(2, 3);
            b.vnesiRezultat(3, 2);
            a.Izpis();
            b.Izpis();
            if(a.BoljšaEkipa(b))
                Console.WriteLine("Slovenija je boljša.");
                else
                    Console.WriteLine("Italija je boljša.");
                Console.ReadLine();*/

            /*NogometnaLiga n = new NogometnaLiga();
            n.IzpišiTurnir();
            Console.ReadLine();*/

            NogometnaLiga n = new NogometnaLiga();
            n.ObdelajKolo();
            n.IzpisVseh();
            Console.ReadLine();


        }
    }
}
