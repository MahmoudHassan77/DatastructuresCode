using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation & push data

            Stack_Array<int> stack = new Stack_Array<int>(3);
            stack.Push(5);
            stack.Push(5);
            stack.Push(5);
            stack.Push(5);

            // pop
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            // Is empty
            Console.WriteLine(stack.IsEmpty());

            //
            string name = Console.ReadLine();
            Console.WriteLine(Reverse(name));


        }

        static string Reverse(string name)
        {
            string rename = "";
            Stack_Array<char> array = new Stack_Array<char>(name.Length);

            foreach (var item in name)
            {
                array.Push(item);
            }
            while (!array.IsEmpty())
            {
                rename += array.Pop();
            }

            return rename;
        }
    }
}
