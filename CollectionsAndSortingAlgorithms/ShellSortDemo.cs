using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndSortingAlgorithms
{
    internal class ShellSortDemo
    {
        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                 for (int i = gap; i < n; i += 1)
                {
                    int temp = arr[i];
                    int j;
                    for ( j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
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
            int[] arr = new int[10] { 30, 40, 20, 90, 50, 70, 60, 80, 100, 10 };
            Console.WriteLine("Original Array is :");
            PrintArray(arr);
            Console.WriteLine("--------------------");
            ShellSort(arr);
            Console.WriteLine("Sorted Array is :");
            PrintArray(arr);
        }

    }
}
