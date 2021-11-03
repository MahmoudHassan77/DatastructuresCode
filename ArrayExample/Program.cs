using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr; // refrenece doen't specified yet.
            arr = new int[3]; // arr ref will stored in stack and will take three cells in heap each cell 4 byte (int space) with 0 default value.
            // we can also initialize arr with values arr = new int[3]{1,2,3};

            // assign data to arr
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            // size of array arr.length * size of data type
            Console.WriteLine(arr.Length +" - "+ sizeof(int) + " - " +arr.Length * sizeof(int) + " Byte");
        }
    }
}
