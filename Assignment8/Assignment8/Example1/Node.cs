using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
   

    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    public class MyStack1<T>
    {
        private Node<T> top;

        private int count;

        public MyStack1()
        {
            top = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size()
        {
            return count;
        }

        public void Push(T item)
        {
            Node<T> node = new Node<T>(item);

            node.Next = top;

            top = node;

            count++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = top.Value;

            top = top.Next;

            count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return top.Value;
        }
    }
}
