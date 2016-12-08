using System;

namespace ProjectEuler
{
    internal class Problem004
    {
        internal static int Solve()
        {
            int largest = 0;
            int temp;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    temp = i * j;
                    if (temp > largest && Helpers.IsPalindrome(temp))
                    {
                        largest = temp;
                    }
                }
            }
            return largest;
        }
    }
}