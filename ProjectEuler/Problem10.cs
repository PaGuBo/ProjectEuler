using System;
using System.Diagnostics;

namespace ProjectEuler
{
    internal class Problem10
    {
        internal static long  Solve()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            long sum = 0;
            for(int i = 2; i < 2000000; i++)
            {
                if (Helpers.IsPrime(i))
                {
                    sum += i;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            return sum;
        }
    }
}