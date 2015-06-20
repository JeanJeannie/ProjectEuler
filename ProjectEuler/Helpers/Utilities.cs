using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Helpers
{
   public static class Utilities
   {

      public static List<long> PrimeList(long? upLimit = null, long? countLimit = null)
      {
         var primeList = new List<long>();
         var upperLimit = long.MaxValue;
         if (upLimit != null)
         {
            upperLimit = (long)upLimit;
         }
         bool stop = false;

         long i = 2;
         while (!stop)
         {
            if (IsPrime(i))
               primeList.Add(i);

            i++;
            if (i > upperLimit)
               stop = true;

            if (countLimit != null)
            {
               if ((long)primeList.Count >= (long)countLimit)
                  stop = true;
            }
         }

         return primeList;      
      }

      public static bool IsPrime(long n)
      {
         if (n <= 3)
         {
            return n > 1;
         }
         else if (n % 2 == 0 || n % 3 == 0)
         {
            return false;
         }
         for (long i = 5; i * i <= n; i += 6)
         {
            if (n % i == 0 || n % (i + 2) == 0)
            {
               return false;
            }
         }
         return true;
      }

      public static List<long> PrimeFactors(long num)
      {
         var primeFactorList = new List<long>();
         while (num % 2 == 0)
         {
            primeFactorList.Add(2);
            num = num / 2;
         }

         for (long i = 3; i < Math.Ceiling(Math.Sqrt(num)); i++)
         {
            while (num % i == 0)
            {
               primeFactorList.Add(i);
               num = num / i;
            }
         }

         if (num > 2)
            primeFactorList.Add(num);

         return primeFactorList;
      }

      public static bool IsPalindromic(long x)
      {
         var stringRep = x.ToString().ToCharArray();
         for (int i = 0; i < stringRep.Length / 2; i++)
         {
            if (stringRep[i] != stringRep[stringRep.Length - i - 1])
               return false;
         }
         return true;
      }


      public static long FindFibonacci(long x = 1, long y = 2)
      {
         return x + y;
      }


   }
}
