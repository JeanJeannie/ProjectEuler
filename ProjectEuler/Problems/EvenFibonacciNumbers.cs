using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
   public class EvenFibonacciNumbers
   {
      public List<long> fiboNumbers = new List<long>();
      public List<long> evenFiboNumbers = new List<long>();
      public bool DebugMode = true;
      /// <summary>
      /// For each even fibonacci num under 4 million find the sum
      /// fibo sequence = 1,2,3,5,8,13,21 etc (sum of each pair of numbers);
      /// </summary>
      /// <returns>The sum of the even fibo nums -- Accepted Answer: 4613732</returns>
      public long Answer()
      {
         long limitNum = 4000000;
         Console.WriteLine("limit {0}", limitNum);
         long x = 1;
         long y = 2;

         AddFibo(x);
         AddFibo(y);
         fiboNumbers.Add(x);
         fiboNumbers.Add(y);
         long fiboNum = Utilities.FindFibonacci(x, y);

         while (fiboNum < limitNum)
         {
            AddFibo(fiboNum);
            x = y;
            y = fiboNum;
            fiboNum = Utilities.FindFibonacci(x, y);
         }
         Console.WriteLine("end");
         return evenFiboNumbers.Sum();
      }

      public void AddFibo(long num)
      {
         fiboNumbers.Add(num);
         if (num % 2 == 0)
            evenFiboNumbers.Add(num);

         if (DebugMode)
            Console.WriteLine("{0} {1}", num, num % 2 == 0 ? "*" : "");      
      }

   }
}
