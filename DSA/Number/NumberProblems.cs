using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Number
{
   public static class NumberProblems
    {
        public static void isAmgStrongNumber(int num)
        {
            int sum = 0;
            int InputNumber = num;
            while (InputNumber > 0)
            {
                int remainder = InputNumber % 10;
                sum += (remainder * remainder * remainder);
                InputNumber = InputNumber / 10;
            }

            if (sum == num)
            {
                Console.WriteLine("ArmgStrong number");
            }
            else
            {
                Console.WriteLine("Not ArmgStrong number");
            }
        }

        public static void reverseNumber(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                rev = rev * 10 + remainder;
                num = num / 10;
            }

            Console.WriteLine(rev);
        }
        public static void SwapTwoNumberWithoutTemp()
        {
            int a = 100;
            int b = 200;

            a = a + b; //a=300
            b = a - b; //b=100;
            a = a - b;


            Console.WriteLine("a:" + a + " and b :" + b);
        }

        public static int Fibonacci(int n)
        {
            // Console.WriteLine("call for " + n);
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
