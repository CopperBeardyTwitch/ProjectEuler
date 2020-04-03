﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    ///2520 is the smallest number that can be divided by each of the
    ///numbers from 1 to 10 without any remainder.
    ///What is the smallest positive number that is evenly divisible 
    ///by all of the numbers from 1 to 20?
    /// </summary>
   public class Problem5_SmallestMultiple
    {
       
       
       
        public void Solve() 
        {
            long[] range = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

           long result = 1;
            for (int i = 1; i < range.Length; i++)
            {
                 result = LCM(result,range[i]);
            }
             



            Console.WriteLine($"{result}");
            Console.ReadLine();
        }

        private long LCM (long a,long b)
        {
            return a * b / GCD(a, b);
        }

        private long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
       
    }
}
