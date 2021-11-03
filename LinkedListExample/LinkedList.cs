using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListExample
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int count = 0;

        public LinkedList()
        {
            Head = Tail = null;
        }
        public void AddNodeAtTheEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if(Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            count++;
        }

        public void Display()
        {
            if(Head == null)
            {
                Console.WriteLine("Linked list is empty.");
            }
            else
            {
                Node<T> item = Head;
                while (item != null)
                {
                    Console.WriteLine(item.Data);
                    item = item.Next;
                }
            }
        }

        public void AddNodeAtTheStart(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            count++;
        }

        public void Search(T val)
        {
            Node<T> current = Head;
            int pos = 1;
            while(current != null)
            {
                if (current.Data.Equals(val))
                {
                    Console.WriteLine($"item {val} found at position {pos}");
                    break;
                }
                current = current.Next;
                pos++;
            }
            if (current == null) Console.WriteLine("item not found!");
        }

        public void Remove(T val)
        {
            if(Head == null)
            {
                Console.WriteLine("List is empty!");
            }
            else if (Head.Data.Equals(val))
            {
                Head = Head.Next;
            }
            else
            {
                Node<T> current = Head.Next;
                Node<T> prev = Head;
                while(current != null)
                {
                    if (current.Data.Equals(val))
                    {
                        prev.Next = current.Next;
                        if(current == Tail)
                        {
                            Tail = prev;
                        }
                        count--;
                        break;
                    }
                    current = current.Next;
                    prev = prev.Next;
                }
                if (current == null) Console.WriteLine("This item not found!");
            }
        }
        public void InsertNode(T val, int pos)
        {
            Node<T> current = Head;
            for (int i = 0; i < pos; i++)
            {
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("Position you selected bigger than list length.");
                    return;
                }
            }
            Node<T> node = new Node<T>(val);
            node.Next = current.Next;
            current.Next = node;
            count++;

        }
        public int Count()
        {
            int listCount = 0;
            Node<T> current = Head;
            while(current != null)
            {
                current = current.Next;
                listCount++;
            }
            return listCount;
        }
        public void Clear()
        {
            Head = Tail = null;
            count = 0;
        }

        // Sort, Reverse
        public void Reverse()
        {
            if (count == 0 || count == 1) return;
            Node<T> swap = Head.Next;
            Node<T> prev = Head;
            while (swap.Next != null)
            {
                if (prev == Head) Head.Next = null;
                Node<T> node = new Node<T>(swap.Data);
                node.Next = swap.Next;
                swap.Next = prev;
                prev = swap;
                swap = node.Next;
            }
            Tail= Head;
            swap.Next = prev;
            Head = swap;
        }
        public void Sort()
        {
            if (count == 0 || count == 1) return;
            Node<T> current = Head;
            Node<T> swap;
            while (current.Next != null)
            {
                swap = current.Next;
                while(swap != null)
                {
                    if (swap.CompareTo(current.Data) < 0)
                    {
                        T val = swap.Data;
                        swap.Data = current.Data;
                        current.Data = val;
                    }
                    swap = swap.Next;
                }
                current = current.Next;
            }
        }
    }
}
