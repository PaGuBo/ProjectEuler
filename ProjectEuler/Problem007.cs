using System;

namespace ProjectEuler
{
    internal class Problem007
    {
        internal static int Solve()
        {
            int currentPrimeIndex = 1;
            var currentPrime = 2;
            var desiredPrimeIndex = 10001;
            while(currentPrimeIndex < desiredPrimeIndex)
            {
                var currentNumber = currentPrime+1;
                while(!Helpers.IsPrime(currentNumber))
                {
                    currentNumber++;
                }
                currentPrime = currentNumber;
                currentPrimeIndex++;
            }
            return currentPrime;
        }
    }
}