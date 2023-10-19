using System;


namespace CollectionsAndSortingAlgorithms
{
    internal class SelectionSortDemo
    {
         static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minimun_index = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minimun_index])
                    {
                        minimun_index = j;
                    }
                }
                int temp= arr[minimun_index];
                arr[minimun_index] = arr[i];
                arr[i] = temp;
            }
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10] { 30, 40, 20, 90, 10, 50, 60, 70, 80, 100 };
            Console.WriteLine("Original Array is :");
            PrintArray(arr);
            Console.WriteLine("--------------------");
            SelectionSort(arr);
            Console.WriteLine("Sorted Array is :");
            PrintArray(arr);
            Console.ReadLine();
        }

      
    }
}
