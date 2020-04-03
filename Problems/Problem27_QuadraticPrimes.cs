using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome
    /// made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Problem27_QuadraticPrimes
    {
       
        int mostConsecutivePrimes = 0;
        double conA = 0.0;
        double conB = 0.0;
        public void Solve()
        {
            //n^2 + an + b

            int currentConsecutivePrime = 0;
            for (double i = 1.0; i <= 1000; i++)
            {
                for (double j = 0.0; j < 1000; j++)
                {
                    for(double k = 1000; k >=0; k--)
                    {
                        var x = (Math.Pow(i, 2) + (j * i) + k);
                        var y = x % 2;
                        bool isPrime = y  != 0;
                        if(isPrime) 
                        {
                            currentConsecutivePrime++;
                          
                            Console.WriteLine($"{currentConsecutivePrime}");
                        }
                        else
                        {
                            if (currentConsecutivePrime > mostConsecutivePrimes)
                            {
                                mostConsecutivePrimes = currentConsecutivePrime; 
                                conA = j;
                                conB = k++;
                            }
                            currentConsecutivePrime = 0;
                        }
                    }
                }
            }

            Console.WriteLine($"{conA} * {conB} = {conA * conB}");
        }
    }
}
