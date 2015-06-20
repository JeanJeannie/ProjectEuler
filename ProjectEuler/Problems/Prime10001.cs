using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
   public class Prime10001
   {
      /// <summary>
      /// Returns the 10,001st prime number
      /// </summary>
      /// <returns>Accepted answer 104743</returns>
      public long Answer()
      {
         var primeList = Utilities.PrimeList(null, 10001);
         Console.WriteLine(string.Join(" ", primeList.ToArray()));
         return primeList.Max();
      }
   }
}
