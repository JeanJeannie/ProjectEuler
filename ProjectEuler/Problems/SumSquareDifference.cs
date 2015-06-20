using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
   public class SumSquareDifference
   {
      public long upperLimit = 100;

      /// <summary>
      /// Return the difference of the square of the sum of numbers from 1 - 100 and the sum of the square of the same numbers;  eg. (1*1 + 2*2 +3*3) - ((1+2+3)*(1+2+3))
      /// </summary>
      /// <returns>Accepted answer 25164150</returns>
      public long Answer() 
      {
         long sumNum = 0;
         long sumSqNum = 0;
         for (long i = 1; i <= upperLimit; i++)
         {
            sumNum = sumNum + i;
            sumSqNum = sumSqNum + (i * i);
         }
         return Math.Abs((sumNum*sumNum)-sumSqNum);
      }
   }
}
