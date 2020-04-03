using ProjectEuler.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// Find the sum of all the primes below two million.
    /// </summary>
   public class Problem10_SummationOfPrimes
    {
       long below = 2000000;
       
        public void Solve() 
        {

           var x =  PrimeTo.PrimeArray(below);
            var t = x.Sum();
            Console.WriteLine($"Total == {t}");
            Console.ReadLine();
        }
       
    }
}
