using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Misc
{/*Write a short program that prints each number from 1 to 100 on a new line. 

For each multiple of 3, print "Fizz" instead of the number. 

For each multiple of 5, print "Buzz" instead of the number. 

For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.*/
  public  static class FizzBuzz
    {
        public static void Print()
        {

            for (int i = 1; i <= 100; i++)
            {
                string outPut = "";
                if (i % 3 == 0)
                {
                    outPut = "Fizz";
                }
                if (i % 5 == 0)
                {
                    outPut += "Buzz";
                }

                Console.WriteLine(outPut == "" ? i.ToString() : outPut);
            }
        }
    }
}
