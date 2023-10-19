using System;

namespace CollectionsAndSortingAlgorithms
{
    internal class BubbleSortDemo
    {
       static void BubbbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }   
        }

        static public void PrintArray(int[] array)
        {
            for(int i=0; i<array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 55,56,86,96,358,48,5 };
            Console.WriteLine("Original Array is :");
            PrintArray(arr);
            Console.WriteLine("--------------------");
            BubbbleSort(arr);
            Console.WriteLine("Sorted Array is :");
            PrintArray(arr);
            Console.ReadLine();
        }
    }
}
