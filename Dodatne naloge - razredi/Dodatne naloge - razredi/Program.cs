using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatne_naloge___razredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Izdelajte program, s pomočjo katerega bosta dva igralca igrala igro Palčke. Pravila igre: Na
začetku imamo na mizi 7 (ali več palčk). Vsak igralec lahko vzame iz mize eno , dve ali tri palčke.
Igralca se izmenjujeta. Igro izgubi tisti, ki pobere zadnjo palčko. Postopek igranja bi lahko opisali
s psevdokodo:
2.1. Izberi začetno število palčk
2.2. Dokler ni konec igre, ponavljaj
2.2.1.poročaj o stanju (število palčk na mizi, kateri igralec je na vrsti)
2.2.2.naredi naslednjo potezo
2.3. poročaj o zmagovalcu
Navodila: Izdelajte razred Palčke.
V njem deklarirajte izvodovo spremenljivko štPalčk (trenutno stanje palčk na mizi) in
spremenljivko igralec (1=če je na vrsti prvi igralec, 2=če je na vrsti drugi igralec).
Izdelajte konstruktor razreda s katerim nastavite število palčk na 7 in igralca na 1.
Izdelajte metodo VzemiPalčke. metoda sprejme en celoštevilski parameter , ki predstavlja število
palčk, ki jih igralec želi vzeti. Metoda vrne vrednost true, če je vzetek uspel in vrednost false, če
vzetek ni uspel. Vzetek uspe, če je število palčk, ki jih želimo vzeti med 1 in 3. Če je vzetek uspel
se tudi spremeni igralec.
V razredu imamo tudi lastnost ŠtPalčk , ki omogoča samo bralni dostop do spremenljivke štPalčk.
Dodajte še metodo KonecIgre(), ki vrne vrednost true, če je število palčk na mizi manjše ali enako
0.
Nato dodajte še metodo DobiZmagovalca, ki vrne vrednost spremenljivke igralec, če je število
palčk na mizi manj od 1.
Na koncu dodajte metodo Izpis, ki v konzolno okno izpiše stanje igre. Na primer:
Na mizi je še 5 palčk. Na vrsti je igralec 2.
V metodo Main() prevedite psevdokodo napisano na začetku naloge. Nato lahko poskusite igrati
igrico s sosedom.*/
            //2.1.Izberi začetno število palčk
            Palčke p = new Palčke(20);
            //2.2.Dokler ni konec igre, ponavljaj
            while (!p.JeKonec())
            {
                //2.2.1.poročaj o stanju(število palčk na mizi, kateri igralec je na vrsti)
                p.IzpisStanja();
                //2.2.2.naredi naslednjo potezo
                Console.WriteLine("Koiko palčk vzameš?");
                int x = int.Parse(Console.ReadLine());
                p.VzemiPalčke(x);
            }
            //2.3.poročaj o zmagovalcu
            Console.WriteLine("Zmagal je igralec " + p.DobiZmagovalca());
            Console.ReadLine();
        }
    }
}
