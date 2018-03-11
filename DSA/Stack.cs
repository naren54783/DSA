using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
 public   class Stack
    {
        //Balanced Brackets
    public string isBalanced(string s)
        {

            Stack<char> CharStack = new Stack<char>();


            foreach (char ch in s)
            {
                if (ch == '{' || ch == '(' || ch == '[')
                {
                    CharStack.Push(ch);
                }
                else if(ch=='}' || ch==')' || ch==']')
                {
                    if (CharStack.Count()==0)
                    {
                        return "NO";
                    }
                    char openBracket = CharStack.Pop();

                    if (ch == '}' && openBracket != '{')
                    {
                        return "NO";
                    }
                    if (ch == ']' && openBracket != '[')
                    {
                        return "NO";
                    }
                    if (ch == ')' && openBracket != '(')
                    {
                        return "NO";
                    }
                }
            }



            if (CharStack.Count() > 0) return "NO";

            return "YES";
        }

        public void MaximumElement()
        {

            int iCount = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < iCount; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    int inputVal = Convert.ToInt32(Console.ReadLine());
                    stack.Push(inputVal);
                }
                else if (input == 2)
                {
                    stack.Pop();
                }
                else if (input == 3)
                {
                   int item= stack.Peek();
                    Console.WriteLine(item);
                }

            }

        }
    }
}
