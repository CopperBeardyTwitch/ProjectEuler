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
   public class Problem4_LargestPalindromeProduct
    {
       const int LargestThreeDigitNumber = 999;
       
        public void Solve() 
        {
            int largestPalidrome = 0;
           
                for(var i = LargestThreeDigitNumber; i > 0; i--)
                {
                    for (int j = LargestThreeDigitNumber ; j > 0; j--)
                    {
                        int product = i * j;
                        bool result = CheckIfPalidrome(product);
                        if(result)
                        {
                            if(product > largestPalidrome)
                            {
                                largestPalidrome = product;
                                break;
                            }
                        }
                    }
                } 

            Console.WriteLine($"{largestPalidrome}");
        }
        bool CheckIfPalidrome(int product)
        {
            string prod = product.ToString();
            char[] p = prod.ToCharArray();
            Array.Reverse(p);
            string prodReversed = new string(p);

            if (prod.Equals(prodReversed)) {
                return true;
            }
            return false;
        }
    }
}
