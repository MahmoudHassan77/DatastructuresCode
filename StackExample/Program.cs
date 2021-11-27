using System;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation & push data

            //Stack_Array<int> stack = new Stack_Array<int>(3);
            //stack.Push(5);
            //stack.Push(5);
            //stack.Push(5);
            //stack.Push(5);

            //// pop
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //// Is empty
            //Console.WriteLine(stack.IsEmpty());

            ////
            //string name = Console.ReadLine();
            //Console.WriteLine(Reverse(name));

            //Console.WriteLine(Balanced("({[]})"));
            //Console.WriteLine(Balanced("({[])"));
            //Console.WriteLine(Balanced("({[]}[])"));


            Console.WriteLine(infixToPostfix("5+2/2"));

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

        static bool Balanced(string pattern)
        {
            Stack_Array<char> stack = new Stack_Array<char>(pattern.Length);
            foreach (var item in pattern)
            {
                if (item == 40 || item == 91 || item == 123) stack.Push(item);
                else
                {
                    char ch = stack.Pop();
                    if (ch == item - 2 || ch == item - 1) continue;
                    else return false;
                }
            }

            return true;
        }

        static string infixToPostfix(string infix)
        {
            string postfix = "";

            int precedence;
            Stack_Array<char> arr = new Stack_Array<char>(infix.Length);
            for (int i = 0; i < infix.Length; i++)
            {
                char ch = infix[i];
                int x =0;
                if(ch =='*' || ch == '/' || ch == '+' || ch == '-')
                {
                    x = 1;
                    if (arr.IsEmpty())
                    {
                        arr.Push(ch);
                    }
                    else
                    {
                        if(arr.Arr[arr.Peek()] == '*' || arr.Arr[arr.Peek()] == '/')
                        {
                            precedence = 1;
                        }
                        else
                        {
                            precedence = 0;
                        }

                        if(precedence == 1)
                        {
                            postfix += arr.Arr[arr.Pop()];
                            i--;
                        }
                        else
                        {
                            if(ch=='+' || ch == '-')
                            {
                                postfix += arr.Arr[arr.Pop()];
                                i--;
                            }
                            else
                            {
                                arr.Push(ch);
                            }
                        }
                    }
                }
                else
                {
                    if (x == 1)
                    {
                        postfix += " ";
                        x = 0;
                    }
                    postfix += ch;
                }
            }
            int top = arr.Top;
            for (int i = 0; i <= top; i++)
            {
                postfix += " "+ arr.Pop();
            }

            return postfix;
        }
    }
}
