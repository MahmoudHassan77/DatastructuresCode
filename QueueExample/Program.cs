using System;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(5);
            queue.enqueue(3);
            queue.enqueue(10);
            queue.enqueue(8);
            queue.enqueue(9);
            queue.enqueue(7);
            queue.enqueue(8);

            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());

        }
    }
}
