using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje_dedovanje__abstraktni_razredi__vmesnik_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Gradite aplikacijo za upravljanje zalog v trgovini. Na voljo sta dve vrsti izdelkov: knjige in igrače.
Obe vrsti izdelkov morata imeti edinstven ID, ime in ceno.Razred Book in razred Toy morata
dedovati od abstraktnega razreda AbstractProduct, ki implementira vmesnik IProduct.
Vmesnik IProduct mora definirati naslednje metode:
GetID(): vrne ID izdelka.
GetName(): vrne ime izdelka.
GetPrice(): vrne ceno izdelka.
Abstraktni razred AbstractProduct bi moral implementirati vmesnik IProduct in definirati naslednje
abstraktne metode:
GetDescription(): vrne opis izdelka.
GetDiscountedPrice(): vrne ceno izdelka po uporabi morebitnih popustov.
Razreda Book in Toy morata izvajati metodi GetDescription() in GetDiscountedPrice(), medtem ko
mora razred AbstractProduct definirati metodo GetCategory(), ki vrne kategorijo izdelka(bodisi
"knjiga" ali "igrača").
V metodi Main testirajte delovanje.*/
        }
    }
}
