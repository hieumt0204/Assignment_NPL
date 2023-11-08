using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public class MyStack<T>
    {
        private T[] array;

        private int top;

        private const int INITIAL_SIZE = 10;

        public MyStack()
        {
            array = new T[INITIAL_SIZE];
            top = -1;
        }


        public bool IsEmpty()
        {
            return top == -1;
        }


        public int Size()
        {
            return top + 1;
        }

        public void Push(T item)
        {
            if (top == array.Length - 1)
            {
                Array.Resize(ref array, array.Length * 2);
            }

            top++;
            array[top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = array[top];
            top--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return array[top];
        }

    }
}

