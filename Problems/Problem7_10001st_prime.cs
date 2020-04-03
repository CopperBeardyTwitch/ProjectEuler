using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// By listing the first six prime numbers: 
    /// 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

///What is the 10 001st prime number?  /// </summary>
    public class Problem7_10001st_prime
    {
       

        public void Solve()
        {

            List<int> primes = new List<int>() { 2,3,5,7};

            var currentNumber = 7;
            
            var count = 4;
            while(count != 10001)
            {
                currentNumber += 2;
                var isPrime = true;
                foreach(var item in primes)
                {
                    if(Math.Sqrt(currentNumber) < item)
                    {
                        break;
                    }
                    if(currentNumber % item == 0)
                    {
                        isPrime = false;
                    }
                }


                if(isPrime)
                {                
                primes.Add(currentNumber);
                    count++;
                }
            }            



            Console.WriteLine($"{primes[10000]}");
            Console.ReadLine();
        }

    }
}
