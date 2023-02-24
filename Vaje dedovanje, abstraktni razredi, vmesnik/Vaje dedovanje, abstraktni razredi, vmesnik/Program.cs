using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. naloga.Ustvarite program, v katerem boste opisovali več vozil. Obstajajo tri vrste vozil: avtomobili,
tovornjaki in motorna kolesa. Vsa vozila imajo proizvajalca, model, leto izdelave in barvo.
Vendar ima vsaka vrsta vozila svoj edinstven niz lastnosti:
            Avtomobili imajo več vrat in prostornino prtljažnika.
Tovornjaki imajo nosilnost in vlečno zmogljivost.
Motocikli imajo več koles in največjo hitrost.
Ustvarite abstraktni razred Vozilo, ki vsebuje skupne lastnosti vseh vozil.Po potrebi dodajte
lastnosti in metode razredu Vozilo za uveljavitev enkapsulacije.
Ustvarite vmesnik IDrivable, ki definira obnašanje voznih vozil.Vmesnik IDrivable bi moral
vključevati metodo Drive, ki meri razdaljo v kilometrih in vrne količino porabljenega goriva.
Ustvarite konkretne razrede Car, Truck in Motorcycle, ki podedujejo razred Vozilo in
implementirajte vmesnik IDrivable.Vsakemu razredu po potrebi dodajte lastnosti in metode,
da uveljavite enkapsulacijo in izpolnite zahteve problema.
V metodi Main testirajte delovanje.*/
            Avto a = new Avto();
            a.ŠtVrat = 5;
            a.Barva = "rdeča";
            a.Proizvajalec = "Alfa romeo";
            a.Model = "Đulijeta";
            a.LetoIzdelave = 2023;
            Console.WriteLine("Avto*****");
            Console.WriteLine("Proizvajalec     " + a.Proizvajalec);
            Console.WriteLine("Model            " + a.Model);
            Console.WriteLine("Leto izdelave    " + a.LetoIzdelave);
            Console.WriteLine("Za 30 km porabiš " + a.Drive(30) + " litrov.");
            Console.WriteLine();

            Tovornjak b = new Tovornjak();
            b.Barva = "modra";
            b.Proizvajalec = "Barka";
            b.Model = "Dubej";
            b.LetoIzdelave = 2019;
            b.Nosilnost = 2000;
            b.Zmogljivost = 5000;
            Console.WriteLine("Tovornjak*****");
            Console.WriteLine("Proizvajalec     " + b.Proizvajalec);
            Console.WriteLine("Model            " + b.Model);
            Console.WriteLine("Leto izdelave    " + b.LetoIzdelave);
            Console.WriteLine("Za 30 km porabiš " + b.Drive(30) + " litrov.");
            Console.WriteLine("Nosilnost        " + b.Nosilnost);
            Console.WriteLine("Zmogljivost      " + b.Zmogljivost);
            Console.WriteLine();

            Motocikel c = new Motocikel();
            c.Barva = "rumena";
            c.Proizvajalec = "Lisjak";
            c.Model = "Žvižgač";
            c.LetoIzdelave = 2022;
            c.ŠtKoles = 2;
            c.NajvečjaHitrost = "120km/h";
            Console.WriteLine("Motocikel*****");
            Console.WriteLine("Proizvajalec     " + c.Proizvajalec);
            Console.WriteLine("Model            " + c.Model);
            Console.WriteLine("Leto izdelave    " + c.LetoIzdelave);
            Console.WriteLine("Za 30 km porabiš " + c.Drive(30) + " litrov.");
            Console.WriteLine("Število koles " + c.ŠtKoles);
            Console.WriteLine("Največja hitrost " + c.NajvečjaHitrost);
            Console.ReadLine();
        }
    }
}
