using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatne_vaje_razredi___lahke_2.naloga
{
    internal class Pravokotnik
    {
        /*Ustvarite razred Pravokotnik, ki predstavlja pravokotnik z dolžino in širino.Razred
Pravokotnik mora biti enkapsuliran, tako da dolžine in širine ni mogoče spremeniti, ko ju
nastavite s konstruktorjem.Razred mora zagotoviti tudi naslednje metode:
GetArea: vrne površino pravokotnika.
GetPerimeter: vrne obseg pravokotnika.
IsSquare: vrne true, če je pravokotnik kvadrat (tj.dolžina = širina), in false v nasprotnem
primeru.
Dodajte metodo Main in testirajte delovanje.*/
        int dolžina;
        int širina;

        public int Dolžina { get => dolžina; }
        public int Širina { get => širina; }
        public Pravokotnik(int d, int s)
        {
            dolžina = d;
            širina = s;
        }
        public double GetArea()
        {
            return dolžina * širina;
        }
        public double GetPerimeter()
        {
            return dolžina + dolžina + širina + širina;
        }
        public bool IsSquare()
        {
            if (dolžina == širina)
            {
                return true;
            }
            return false;
        }
    }
}