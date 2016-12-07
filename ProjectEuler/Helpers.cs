using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Helpers
    {
        public static IEnumerable<int> FibonaciNumbers(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Positive number only");
            }
            int n1 = 0;
            int n2 = 1;
            int fib = 1;

            for (int i = 0; i < number; i++)
            {
                yield return fib;
                n1 = n2;
                n2 = fib;
                fib = n1 + n2;
            }
        }

        public static int FibonacciIterative(int n)
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
                int n1 = 1;
                int n2 = 2;
                int fib = 3;
                for(int i = 3; i < n; i++)
                {
                    n1 = n2;
                    n2 = fib;
                    fib = n1 + n2;
                }
                return fib;
            }
        }

        public static int FibonacciRecursive(int n)
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
                return (FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2));
            }
        }
    }
}
