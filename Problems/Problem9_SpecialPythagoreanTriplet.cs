using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    ///A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    ///a2 + b2 = c2
    ///For example, 32 + 42 = 9 + 16 = 25 = 52.
    ///There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    ///Find the product abc.
    /// </summary>
    public class Problem9_SpecialPythagoreanTriplet
    {
        const long n = 10000;

        public void Solve()
        {
            long prod = 0;
            long a = 0;
            long b = 0;
            long c = 0;
            for (long i = 1; i < n-2; i++)
            {
                for (long j = i + 1; j < n-1; j++)
                {
                    for (long k = i + 2; k < n; k++)
                    {
                        if ((i * i + j * j).Equals(k * k) && (i + j+ k).Equals(n))
                        {
                            a = i;
                            b = j;
                            c = k;

                            prod = a * b * c;
                            break;
                        }

                    }
                }







            }

            Console.WriteLine($"{a} * {b} * {c} = {prod}");
            Console.ReadLine();
        }

    }
}
