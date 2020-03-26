using System;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(new int[] { 0, 1, 2, 4 });
            int[] a = new int[] { 7, 8, 9 };
            arr.Remove(1, 2);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]);
        }
    }
}
