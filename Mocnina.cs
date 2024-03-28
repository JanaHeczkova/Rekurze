using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurze
{
    internal class Mocnina
    {
        public int SpocitejMocninu(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return x * SpocitejMocninu(x, n - 1);
            }
        }
}
}
