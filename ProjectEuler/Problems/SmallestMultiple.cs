using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
   public class SmallestMultiple
   {
      public long largestMultiple = 20;
      public List<long> multipleList;
      public bool debugMode = true;

      public SmallestMultiple()
      {
         multipleList = new List<long>();
         for (int i = 1; i <= largestMultiple; i++)
         {
               multipleList.Add(i);
         }
         if (debugMode)
            Console.WriteLine(string.Join(" ", multipleList.ToArray()));
      }

      /// <summary>
      /// Find the smallest number that has the numbers between 1 & 20 as multiples
      /// </summary>
      /// <returns>Accepted answer 232792560</returns>
      public long Answer()
      {
         bool stop = false;
         var currNum = largestMultiple;  // start at the largest multiple as it can't be smaller than that
         while (!stop)
         {
            if (containsMultiples(currNum))
               return currNum;
            currNum = currNum+2;  // odd numbers wont be divisible by any of the even numbers

            if (currNum > long.MaxValue)
               stop = true ;
         }
         return 0;
      }

      public bool containsMultiples(long currentNum)
      {
         foreach (var multiple in multipleList)
         {
            if (currentNum % multiple != 0)
            {
               if (debugMode && currentNum % 1000 == 0)
                  Console.WriteLine(currentNum);
 //              if (debugMode)
 //                 Console.WriteLine("{0} doesn't have multiple {1}", currentNum, multiple);
               return false;
            }
         }
         return true;
      }
   }
}
