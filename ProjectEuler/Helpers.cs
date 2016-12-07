using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Helpers
    {
        public static int fib(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("No negative numbers");
            }
            if (n == 0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return n;
            }
            else
            {
                return (fib(n - 1) + fib(n - 2));
            }
        }
    }
}
