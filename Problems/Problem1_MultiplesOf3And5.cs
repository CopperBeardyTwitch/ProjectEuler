using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class Problem1_MultiplesOf3And5
    {
        const int input = 1000;
        public void Solve()
        {
            int count = 0;
            for (int i = 1; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    count += i;
            }
            Console.WriteLine($"Sum of all multiples of 3 and 5 below {input} = {count}");

        }
    }
}
