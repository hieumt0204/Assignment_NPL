using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
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

    public class MyQueue1<T>
    {
        private Node<T> front;

        private Node<T> rear;

        private int count;

        public MyQueue1()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public int Size()
        {
            return count;
        }

        public void Enqueue(T item)
        {
            Node<T> node = new Node<T>(item);

            if (IsEmpty())
            {
                front = node;
                rear = node;
            }
            else
            {
                rear.Next = node;
                rear = node;
            }
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T item = front.Value;

            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            count--;

            return item;
        }
    }
}
