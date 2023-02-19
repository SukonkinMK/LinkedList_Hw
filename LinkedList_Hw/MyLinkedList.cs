using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Hw
{
    public class MyLinkedList<T>
    {
        private Node head;
        private Node tail;

        public Node Head => head;
        public Node Tail => tail;

        public class Node
        {
            public T Value { get; set; }

            public Node Next { get; set; }

            public Node Prev { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        public void addFirst(T value)
        {
            Node node = new Node(value);
            if (head != null)
            {
                node.Next = head;
                head.Prev = node;
            }
            else
            {
                tail = node;
            }
            head = node;
        }

        public void addLast(T value)
        {
            Node node = new Node(value);
            if (tail != null)
            {
                node.Prev = tail;
                tail.Next = node;
            }
            else
            {
                head = node;
            }
            tail = node;
        }

        public void removeFirst()
        {
            if (head != null && head.Next != null)
            {
                head.Next.Prev = null;
                head = head.Next;
            }
            else
            {
                head = null;
                tail = null;
            }
        }
        public void removeLast()
        {
            if (tail != null && tail.Prev != null)
            {
                tail.Prev.Next = null;
                tail = tail.Prev;
            }
            else
            {
                head = null;
                tail = null;
            }
        }

        public void printList()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Value.ToString() + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }

        public void reverseList()
        {
            Node node = head;
            Node tmp;
            while (node != null)
            {
                tmp = node.Next;
                node.Next = node.Prev;
                node.Prev = tmp;
                node  = tmp;
            }
            tmp = head;
            head = tail;
            tail = tmp;
        }
    }
}
