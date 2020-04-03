using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Helpers
{
    public static class PrimeTo
    {
        public static long[] PrimeArray(long upperLimit)
        {
            bool[] initlized = new bool[upperLimit];
            for (long i = 2; i < upperLimit; i++)
            {
                initlized[i] = true;
            }

            for (long i = 2; i <= Math.Sqrt(upperLimit) ; i++)
            {
                if(initlized[i] == true)
                {
                    for (long j = (long)Math.Pow(i*1.0,2); j < upperLimit; j += i)
                    {
                        initlized[j] = false;
                    }
                }
            }

            List<long> vals = new List<long>();
            for (long i = 0; i < initlized.Length; i++)
            {
                if(initlized[i])
                {
                    vals.Add(i);
                }
            }

            
           // long[] values = primes.ToArray();
       
            return  vals.ToArray();
        }
    }
}
