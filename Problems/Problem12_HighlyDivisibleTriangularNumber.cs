﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// The sequence of triangle numbers is generated by adding the natural numbers.
    /// So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28.
    /// The first ten terms would be:
    /// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// Let us list the factors of the first seven triangle numbers:
    /// 1: 1
    /// 3: 1,3
    /// 6: 1,2,3,6
    /// 10: 1,2,5,10
    /// 15: 1,3,5,15
    /// 21: 1,3,7,21
    /// 28: 1,2,4,7,14,28
    /// We can see that 28 is the first triangle number to have over five divisors.
    /// 
    /// What is the value of the first triangle number to have over five hundred divisors?    /// 
    /// 
    /// </summary>
    public class Problem12_HighlyDivisibleTriangularNumber
    {
        
        
        public void Solve()
        {
            bool underFiveHundered = true;
             long number = 3;
            int count = 0;
            while(underFiveHundered)
            {
                count = 0;

                long toFactor = GenerateNaturalNumber(number);
                long temp = toFactor;
                count = Factors(toFactor);
                if(count >= 500)
                {
                    underFiveHundered = false;

                }
                Console.WriteLine($"Start number = {toFactor},TotalFactors { count} ");
                number++; 
            }
            Console.WriteLine($"Start number = {number-1},TotalFactors { count} ");
            Console.ReadLine();
        }

        public long GenerateNaturalNumber(long num)
        {
            long value = 0;
            for (long i = 1; i <=num;  i++)
            {
                value += i;
            } 
           return value;
        }

        public int Factors(long num)
        {
            long tempNum = long.Parse( Math.Ceiling(num/2.0).ToString()) ;

            var fList = new List<long>() {1,num };

            for (long i = 2; i < tempNum; i++)
            {
                if(num % i == 0)
                {
                    if(!fList.Contains(i))
                    {
                        fList.Add(i);
                        if (!fList.Contains(num / i))
                        {
                            tempNum = num / i;
                            fList.Add(num / i);
                        }

                       
                    }
                    
                }
            }
            return fList.Count;



        }

    }
}
