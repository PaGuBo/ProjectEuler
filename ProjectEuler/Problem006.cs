using System;
using System.Linq;

namespace ProjectEuler
{
    internal class Problem006
    {
        internal static double Solve()
        {
            var sumOfSquares = Enumerable.Range(1, 100).Select(x => x * x).Sum();
            var squareOfSums = Math.Pow(Enumerable.Range(1, 100).Select(x => x).Sum(), 2);
            return squareOfSums - sumOfSquares;
        }
    }
}