using System;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddNodeAtTheEnd(5);
            linkedList.AddNodeAtTheEnd(10);
            linkedList.AddNodeAtTheEnd(45);
            linkedList.AddNodeAtTheStart(25);

            LinkedList<string> linkedList2 = new LinkedList<string>();
            linkedList2.AddNodeAtTheEnd("Ali");
            linkedList2.AddNodeAtTheEnd("Ashraf");
            linkedList2.AddNodeAtTheEnd("Quba"); 
            linkedList2.AddNodeAtTheStart("Name");

            Console.WriteLine(linkedList.Head.Data + " - " + linkedList.Tail.Data);
            Console.WriteLine(linkedList2.Head.Data + " - " + linkedList2.Tail.Data);
            linkedList2.Display();

            linkedList.Search(10);

            linkedList.Display();
            linkedList.Remove(25);
            linkedList.Display();

            Console.WriteLine("-----------------------");

            linkedList2.InsertNode("is", 0);
            linkedList2.Display();

            Console.WriteLine("--------------");

            LinkedList<int> l = new LinkedList<int>();
            l.AddNodeAtTheEnd(20);
            l.AddNodeAtTheEnd(30);
            l.AddNodeAtTheEnd(40);
            l.AddNodeAtTheEnd(50);
            l.AddNodeAtTheStart(10);

            l.Reverse();
            l.Display();
            Console.WriteLine("--------");

            Console.WriteLine(l.count+ " - " + l.Count());
            l.Remove(40);
            l.Display();
            Console.WriteLine(l.count + " - " + l.Count());

            

            l.Clear();
            Console.WriteLine(l.count + " - " + l.Count());

            Console.WriteLine("-----------------");
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddNodeAtTheStart(45);
            ls.AddNodeAtTheStart(55);
            ls.AddNodeAtTheStart(50);
            ls.Display();
            Console.WriteLine("-----------------");
            ls.Reverse();
            ls.Display();
            Console.WriteLine("-----------------");
            Node<int> c = new Node<int>(20);
            Node<int> c1 = new Node<int>(20);
            Console.WriteLine(c.CompareTo(c1.Data));

            Console.WriteLine("-----------------");
            ls.Sort();
            ls.Display();


        }
    }
}
