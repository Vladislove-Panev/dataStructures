using System;

namespace dataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList L = new LinkedList();
            L.Add(2);
            int[] arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            L.Add(new int[] { 0, 2, 4, 7});
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            L.Add(2, 100);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            L.Add(3, new int[] { 9, 9, 9 });
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            L.AddToBeggining(12);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            L.AddToBeggining(new int[] { -1, -2, -3 });
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.WriteLine(L.Max());
            Console.WriteLine(L.Min());

            L.Remove();
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            L.Remove(2);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            L.Remove(4, 2);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.RemoveElement(4);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.RemoveFirstElement();
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");


            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.RemoveFirstElement(2);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.RemoveLastElement(2);
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.Reverse();
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
            Console.Write("-----------------------");
            Console.WriteLine();
            L.SortArrayInc();
            arr = L.Return();
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
