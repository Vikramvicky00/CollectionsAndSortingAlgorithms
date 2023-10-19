using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndSortingAlgorithms
{
    internal class QuickSortDemocs
    {
        static int partition(int[] arr, int low, int high)
        {
             
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;
                    Console.WriteLine(i);
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i+1);
        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                Console.WriteLine(pi);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
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
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Array is :");
            PrintArray(arr);

            Console.ReadLine();
        }

       
    }
}
