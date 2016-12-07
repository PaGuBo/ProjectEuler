using System;

namespace ProjectEuler
{
    internal class Problem002
    {
        internal static int Solve()
        {
            var sum = 0;
            foreach(var fibNumber in Helpers.FibonaciNumbers(1000000))
            {
                if(fibNumber > 4000000)
                {
                    break;
                }
                else if(fibNumber % 2 == 0)
                {
                    sum += fibNumber;
                }
            }
            return sum;
        }

        
    }
}