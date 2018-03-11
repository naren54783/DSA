using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Misc.FizzBuzz();

            // int[] arr = new int[8] { -2, -3, 4, -1, -2, 1, 5, -3 };
            //Console.WriteLine(Misc.LargestSumContiguousSubArray(arr));

            // Misc.FindFirstnonRepeatingCharacter("finding");

            // Misc.reverseNumber(371);
            //LinkedList linkedList = new LinkedList();
            //linkedList.Print();
            //Console.WriteLine();
            //linkedList.AddNodeAtFirstToLinkedList(3);
            //linkedList.AddNodeAtFirstToLinkedList(4);
            //linkedList.AddNodeAtLastToLinkedList(1);
            //linkedList.AddNodeAfterKthNode(5, 3);

            //linkedList.Print();

            MyStack<int> stack = new MyStack<int>();
            stack.push(5);
            stack.push(3);
            stack.push(2);
            stack.push(1);

          Console.WriteLine( "peek--" + stack.peek());
            Console.WriteLine("pop--"+stack.pop());
            Console.WriteLine("peek--" + stack.peek());
            Console.WriteLine("pop--" + stack.pop());

            Console.WriteLine("peek--" + stack.peek());
            Console.WriteLine("pop--" + stack.pop());
            Console.ReadLine();
        }
    }
}
