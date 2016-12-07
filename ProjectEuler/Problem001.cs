using System;
using System.Linq;

namespace ProjectEuler
{
    internal class Problem001
    {
        internal static int Solve()
        {
            return Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}