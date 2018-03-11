using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   public class MyStack<T>
    {        
        private StackNode<T> top;
              
       public void push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);
            t.next = top;
            top = t;
        }

        public T pop()
        {
            if (top == null) throw new Exception("Empty stack");
            T item = top.data;
            top = top.next;
            return item;

        }

        public T peek()
        {
            if (top == null) throw new Exception("Empty stack");

            return top.data;

        }
    }

    public  class StackNode<T>
    {
        public T data;
        public StackNode<T> next;
        public StackNode(T item)
        {
            this.data = item;
        }

    }
}
