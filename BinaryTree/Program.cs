using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Root = new Node<int>(8);
            Node<int> Left = new Node<int>(3);
            Node<int> Right = new Node<int>(10);
            Root.Left = Left;
            Root.Right = Right;


        }
    }
}
