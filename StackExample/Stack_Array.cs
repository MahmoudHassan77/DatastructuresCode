using System;
using System.Collections.Generic;
using System.Text;

namespace StackExample
{
    public class Stack_Array<T>
    {
        public T[] Arr { get; set; }
        public int Top { get; set; }
        public Stack_Array(int size)
        {
            Arr = new T[size];
            Top = -1;
        }
        public void Push(T val)
        {
            if (Top == Arr.Length - 1) Console.WriteLine("Stack Overflows.");
            else
            {
                Top++;
                Arr[Top] = val;
            }
        }
        public T Pop()
        {
            if (Top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return default(T);
            }
            else
            {
                T elem = Arr[Top];
                Top--;
                return elem;
            }
        }
        public bool IsEmpty()
        {
            if (Top == -1) return true;
            else return false;
        }

        public int Peek()
        {
            if (Top == -1) 
            {
                Console.WriteLine("Stack is empty.");
                return Top;
            }
            else return Top;
        }
    }
}
