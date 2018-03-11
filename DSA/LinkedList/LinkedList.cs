using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
  public  class LinkedList
    {
        LinkedNode head = null;
        LinkedNode current ;
        int count;

        public LinkedList()
        {
            head = new LinkedNode();
            current = head;
        }

        public void AddNodeAtLastToLinkedList(int num)
        {
            var newNode= new LinkedNode() { data = num, next = null };
           
            var node = head;

            while (node.next != null)
            {
                node = node.next;
            }

            node.next = newNode;
            
        }

        public void AddNodeAtFirstToLinkedList(int num)
        {
            var newNode = new LinkedNode() { data = num, next = null };

            var node = head;

            newNode.next = head.next;
            head.next = newNode; 

        }

        public void AddNodeAfterKthNode(int num, int k)
        {
            var newNode = new LinkedNode() { data = num, next = null };
            var node = head.next;

            while (node.next != null)
            {
                if (node.data.Equals(k))
                {
                    break;
                }
            }

            newNode.next = node.next;
            node.next = newNode;

        }

        public void Print()
        {
            var node = head.next;
            Console.Write("Head-->");
            while (node != null)
            {
                Console.Write(node.data + "->");
                node = node.next;
            }
            Console.Write("NULL");
        }
    }
}
