using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
   public class LargestPrimeFactor
   {
      public const long numToFindFactorsOf = 600851475143;

      /// <summary>
      /// Find largest prime factor of 600851475143
      /// Prime factors are the prime numbers that can be multiplied together to give the number
      /// </summary>
      /// <returns>Accepted answer 6857</returns>
      public long Answer()
      {
         var primeFactors = Utilities.PrimeFactors(numToFindFactorsOf);
         Console.WriteLine(string.Join(",", primeFactors.ToArray()));
         return primeFactors.Max();
      }


   }
}
