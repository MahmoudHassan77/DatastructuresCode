using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LinkedListExample
{
    public class Node<T>: IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            Data = val;
        }

        public int CompareTo(T other)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            switch (comparer.Compare(Data,other))
            {
                case 1 : // Data > other
                    return 1;
                case -1: // Data < other
                    return -1;
                default: // Data = other
                    return 0;
            }
           
        }
    }
}
