using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem003
    {

        public static int Solve(long input)
        {
            var retVal = Convert.ToInt32(Math.Floor(Math.Sqrt(input)));
            while (!(Helpers.IsAFactorOfB(retVal, input) && Helpers.IsPrime(retVal)))
            {
                retVal--;
            }
            return retVal;
        }
    }
}
