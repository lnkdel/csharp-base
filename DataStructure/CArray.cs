using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
                arr[i] = 0;
            numElements = 0;
        }

        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                this.DisplayElements();
            }
        }

        public void SelectionSort()
        {
            int min, temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[inner] < arr[min])
                        min = inner;
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                this.DisplayElements();
            }
        }

        public void InsertionSort()
        {
            int inner, temp;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
                this.DisplayElements();
            }
        }

        public int BinarySearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                    return mid;
                else
                    if (value < arr[mid])
                        upperBound = mid - 1;
                    else
                        lowerBound = mid + 1;
            }
            return -1;
        }

        public int BSearch(int value)
        {
            return Array.BinarySearch(arr, value);
        }

        public static void Output()
        {
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
                nums.Insert(rnd.Next(0, 100));

            Console.WriteLine("Before Sorting: ");
            nums.DisplayElements();
            Console.WriteLine("During Sorting:");
            //nums.BubbleSort();
            nums.SelectionSort();
            Console.WriteLine("After Sorting: ");
            nums.DisplayElements();

            Console.WriteLine("Search 71: ");
            int pos = nums.BinarySearch(71);
            if (pos != -1)
            {
                Console.WriteLine("found item");
                nums.DisplayElements();
            }
            else
                Console.WriteLine("Not in the array");
        }
    }
}
