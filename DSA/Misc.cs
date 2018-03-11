using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DSA
{
    public static class Misc
    {

        public static void FizzBuzz()
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

        //Largest Sum Contiguous Subarray
        public static int LargestSumContiguousSubArray(int[] arr)
        {
            int max_so_far = 0;
            int max_end_here = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max_end_here += arr[i];

                if (max_end_here < 0)
                    max_end_here = 0;
                //if (max_so_far < max_end_here)
                //{
                //    max_so_far = max_end_here;
                //}

                max_so_far = Math.Max(max_so_far, max_end_here);
            }

            return max_so_far;
        }


        public static void FindDuplicateCharacters(string str)
        {

            Dictionary<string, int> dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (char ch in str)
            {
                if (dic.ContainsKey(ch.ToString()))
                {
                    dic[ch.ToString()] += 1;
                }
                else
                {
                    dic.Add(ch.ToString(), 1);
                }

            }

            //print all duplicate characters
            foreach (var item in dic)
            {
                if (item.Value > 1)
                {

                    Console.WriteLine(item.Key);
                }
            }

            KeyValuePair<string, int> Maxkey = new KeyValuePair<string, int>();
            //print charcter whose occurence is more
            foreach (var item in dic)
            {
                if (item.Value > Maxkey.Value)
                {
                    Maxkey = item;
                }
            }
            Console.WriteLine(Maxkey.Key);
        }

        public static void FindFirstnonRepeatingCharacter(string inputStr)
        {
            //   OrderedDictionary dictionary = new OrderedDictionary();


            Dictionary<string, int> dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            //  Hashtable<string, int> hashtable = new SortedDictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            string result = "";
            foreach (char ch in inputStr)
            {
                if (dic.ContainsKey(ch.ToString()))
                {
                    dic[ch.ToString()]  += 1;
                }
                else
                {
                    dic.Add(ch.ToString(), 1);
                }
            }
            

            foreach (var item in dic)
            {
                if (item.Value>1)
                {
                    result = item.Key;
                    break;
                }
            }

            Console.WriteLine(result);

        }

        public static void RemoveAllDuplicateCharacters(string inputStr)
        {
            HashSet<string> ht = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (char ch in inputStr)
            {
                if (!ht.Contains(ch.ToString()))
                {
                    ht.Add(ch.ToString());
                }
            }

            foreach (var item in ht)
            {
                Console.WriteLine(item.ToString());
            }
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

        public static int isPalindrome(string A)
        {

            if (A == "") return 0;
            int startIndex = 0;
            int endIndex = A.Length-1;

            while (startIndex < endIndex)
            {

                if (!checkIfAlphanumeric(A[startIndex]))
                {
                    startIndex++;
                }
                else if (!checkIfAlphanumeric(A[endIndex]))
                {
                    endIndex--;
                }
                else
                {

                    if (A[startIndex].ToString().ToUpper() != A[endIndex].ToString().ToUpper())
                    {
                        return 0;
                    }
                    startIndex++;
                    endIndex--;
                }
              

            }

            return 1;

        }

        static bool  checkIfAlphanumeric(char ch)
        {
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
                {
                return true;
            }
            return false;
        }

        public static void isAmgStrongNumber(int num)
        {
            int sum = 0;
            int InputNumber = num;
           while(InputNumber > 0)
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

    }
}
