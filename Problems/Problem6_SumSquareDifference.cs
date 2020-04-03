using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// find the difference between the sum on n range and the sum off nSquare range
    //</summary>
   public class Problem6_SumSquareDifference
    {
       const int LastN = 100;
       int n = 1;
       
        public void Solve() 
        {

            double sumNSquare = 0;
            double countSquared = 0;


            for (int i = 1; i <= LastN; i++)
            {
                sumNSquare += Math.Pow(i * 1.0, 2.0);
                countSquared += i;
            }

            countSquared = Math.Pow(countSquared * 1.0, 2.0);

            Console.WriteLine($"Sum of the squares from 1 to {LastN} is:  {sumNSquare}");
            Console.WriteLine($"Sum of the from 1 to {LastN} squared is:  {countSquared}");
            Console.WriteLine($"The differnce between {countSquared}  and {sumNSquare} is:   {countSquared - sumNSquare}");
            Console.ReadLine();

        }
       
    }
}
