using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
   public class MultiplesOfThreeAndFive
   {
      /// <summary>
      /// Given all natural numbers below 1000 find the sum of all multiples of 3 and 5
      /// Approach:
      ///   Find the sum of 3 and the sum of 5 and subtract the duplicates (sum of 15)
      ///   For 3, 5 and 15:
      ///      Find the number of multiples under 1000
      ///      Find the sum - this will be the highest (multiple + lowest)* (number of multiples/2)
      /// </summary>
      /// <returns>The sum of all multiples of 3 and 5 below 1000  -- Accepted Answer: 233168</returns>
      public long Answer()
      {
         var belowNumber = 1000;
         var three = new Number(3, belowNumber);
         Console.WriteLine( three);

         var five = new Number(5, belowNumber);
         Console.WriteLine(five);

         var commonMultiples = new Number(3 * 5, belowNumber);
         Console.WriteLine(commonMultiples);
         
         return five.SumOfMultiples + three.SumOfMultiples - commonMultiples.SumOfMultiples;  
      }

      public class Number
      {
         public int ThisNumber { get; set; }
         public int BelowThisNumber { get; set; }
         public long Multiples {get; set;}
         public long HighestMultiple { get; set; }
         public long SumOfMultiples { get; set; }

         public Number(int naturalNumber, int belowThisNumber)
         {
            ThisNumber = naturalNumber;
            BelowThisNumber = belowThisNumber;
            Multiples = (long)Math.Floor((double)(BelowThisNumber-1)/(double)ThisNumber);
            HighestMultiple = Multiples * ThisNumber;

            SumOfMultiples =(long)((double)(HighestMultiple + ThisNumber) * ((double)Multiples / 2));
         }

         public override string ToString()
         {
            return string.Format("Num {0} Below {1} Multiples {2} HighestMultiple {3} Sum {4}", ThisNumber, BelowThisNumber, Multiples, HighestMultiple, SumOfMultiples);
         }
      }
   }
}
