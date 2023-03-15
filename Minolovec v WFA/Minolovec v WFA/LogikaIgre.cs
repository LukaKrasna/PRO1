using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minolovec_v_WFA
{
    internal class LogikaIgre
    {
        public bool[,] mine = new bool[10 + 2, 10 + 2];
        //generiraj naključno mine s 25% verjetnostjo
        //igra bo v vrsticah od 1 do 10, zgoraj je vrstica 0, spodaj 11
        public int[,] rešitev = new int[10 + 2, 10 + 2];
        Random r = new Random();
        public LogikaIgre()
        {

            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    mine[k, j] = r.NextDouble() < 0.25;
                }
            }
            //izračunaj rešitev

            for (int k = 1; k <= 10; k++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    for (int x = k - 1; x <= k + 1; x++)
                    {
                        for (int y = j - 1; y <= j + 1; y++)
                        {
                            if (mine[x, y] == true)
                                rešitev[k, j]++;
                        }
                    }
                }
            }
        }
    }
}

