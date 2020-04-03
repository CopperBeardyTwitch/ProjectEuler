using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?   
    /// </summary>
   public class Problem3_LargestPrimeFactor
    {
       const long input = 600851475143;
        long LargestFactor = input;
       
        long n = 2;
        public void Solve() 
        {
            
            while (n * n <= LargestFactor)
            {
                if (LargestFactor % n == 0)
                {
                    LargestFactor /= n;
                }
                else
                {
                    ++n;
                }
            }

            Console.WriteLine($"Largest prime factor of {input} = {LargestFactor}");
        }
    }
}
