using System;

namespace ProjectEuler
{
    internal class Problem009
    {
        internal static int Solve()
        {
            //terrible approach, there must be a better way
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (a + b + c == 1000 && 
                            a < b && b < c &&
                            a*a + b*b == c*c)
                        {
                            return a * b * c;
                        }
                    }
                }
            }
            return -1;
        }
    }
}