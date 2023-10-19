using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndSortingAlgorithms
{
    internal class InsertionSortDemo
    {
        public static void InsertionSort(int[] arr)
        {
            int key,j;
            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while(j>=0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = key;
            }
        }

        public static void PrintArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10] {30,40,20,90,10,50,60,70,80,100};
            Console.WriteLine("Original Array is :");
            PrintArray(arr);
            Console.WriteLine("--------------------");
            InsertionSort(arr);
            Console.WriteLine("Sorted Array is :");
            PrintArray(arr);

            Console.ReadLine();
        }
    }
}
