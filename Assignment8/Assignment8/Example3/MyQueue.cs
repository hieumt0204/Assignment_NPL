using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class MyQueue<T>
    {
        private T[] array;

        private int front;

        private int rear;

        private const int INITIAL_SIZE = 10;

        public MyQueue()
        {
            array = new T[INITIAL_SIZE];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                return rear - front + 1;
            }
        }

        public void Enqueue(T item)
        {
            if (rear == array.Length - 1)
            {
                Array.Resize(ref array, array.Length * 2);
            }

            rear++;
            array[rear] = item;

            if (front == -1)
            {
                front = 0;
            }
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            T item = array[front];
            front++;

            if (front > rear)
            {
                front = -1;
                rear = -1;
            }

            return item;
        }
    }
}

