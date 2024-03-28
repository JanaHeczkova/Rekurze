using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurze
{
    internal class CifernySoucet
    {
        public int SpocitejCifernySoucet(int n)
        {
            int zbytek = n % 10;
            if (n%10 == 0)
            {
                return n;
            }
            else
            {
                return zbytek + SpocitejCifernySoucet(n / 10);
            }
        }

    }
}
