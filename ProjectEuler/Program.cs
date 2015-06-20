using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems;

namespace ProjectEuler
{
   class Program
   {
      static void Main(string[] args)
      {
         Problem6();
         Console.ReadLine();
      }

      public static void Problem7()
      {
         Console.WriteLine(new Prime10001().Answer());
      }

      public static void Problem6()
      {
         Console.WriteLine(new SumSquareDifference().Answer());
      }      

      public static void Problem5()
      {
         Console.WriteLine(new SmallestMultiple().Answer());
      }      


      public static void Problem4()
      {
         Console.WriteLine(new LargestPalindromicProduct().Answer());
      }      

      public static void Problem3()
      {
         Console.WriteLine(new LargestPrimeFactor().Answer());
      }

      public static void Problem2()
      {
         Console.WriteLine(new EvenFibonacciNumbers().Answer());
      }

      public static void Problem1()
      {
         Console.WriteLine(new MultiplesOfThreeAndFive().Answer());
      }


   }
}
