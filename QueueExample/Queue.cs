using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Queue<T>
    {
        public int Front { get; set; }
        public int Back { get; set; }
        public int Count { get; set; }
        public T[] Arr { get; set; }

        public Queue(int size)
        {
            Arr = new T[size];
            Front = Back = Count = 0;
        }

        public void enqueue(T value)
        {
            if(Back == Arr.Length)
            {
                Console.WriteLine("Queue is overflow.");
            }
            else
            {
                Arr[Back] = value;
                Back++;
                Count++;
            }
        }

        public T dequeue()
        {
            if (Back == Front) {
                Console.WriteLine("Queue is empty.");
                return default(T);
            }
            else
            {
                Front++;
                Count--;
                return Arr[Front-1];
            }
        }
        public bool isEmpty()
        {
            if (Count == 0) return true;
            else return false;
        }
    }
}
