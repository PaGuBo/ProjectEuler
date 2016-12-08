using System;

namespace ProjectEuler
{
    internal class Problem005
    {
        internal static int Solve()
        {
            int n = 1;
            
            while(true)
            {
                var isValid = true;
                for (int i = 2; i <= 20; i++)
                {
                    if (n%i != 0)
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    return n;
                }
                n++;
            }
        }
    }
}