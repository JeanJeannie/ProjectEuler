using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
   public class LargestPalindromicProduct
   {
      public const int maxNum = 999;
      public bool debugMode = true;
      public List<long> palinProducts = new List<long>();
      /// <summary>
      /// Find the largest palindromic number that is a product of 2 3-digit numbers
      /// </summary>
      /// <returns>Accepted answer 906609</returns>
      public long Answer()
      {
         var count = 0;

         for (int x = maxNum; x > 0; x--)
         {
            for (int y = maxNum; y > 0; y--)
            {
               count++;
               long product;
               if (IsPalindromicProduct(x, y, out product))
               {
                  palinProducts.Add(product);
               }               
            }
         }
         return palinProducts.Max();
      }
      
      public bool IsPalindromicProduct(long x, long y, out long product)
      {
         product = x * y;

         if (Utilities.IsPalindromic(product))
         {
            palinProducts.Add(product);
            if (debugMode)
               Console.WriteLine("x:{0} y:{1} product:{2} **", x, y, product);
            return true;
         }
         return false;      
      }

   }
}
