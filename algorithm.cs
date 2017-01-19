using System;

namespace Algorithms
{
    public abstract class Search
    {
        public static void LinearSearch(int[] arr, int searchElement)
        {
            int numberOfIterations = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                numberOfIterations++;
                if (arr[i] == searchElement)
                {
                    Console.WriteLine("Element " + searchElement + " found at " + i + " index.");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element " + searchElement + " not in array");
            }
            Console.WriteLine("Linear Search Number Of Interations :" + numberOfIterations);
        }

///recursive implementation of binary search
        public static void BinarySearch(int[] arr, int searchElement, int startIndex, int endIndex, int numberOfIterations = 1)
        {
            if (endIndex - startIndex >= 1)
            {
                int midNum = startIndex + (endIndex - startIndex) / 2;
                numberOfIterations++;

                if (searchElement == arr[midNum])
                {
                    numberOfIterations++;
                    Console.WriteLine("element " + searchElement + " found at index " + midNum);
                    Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
                    return;
                }
                else if (searchElement > arr[midNum])
                {
                    numberOfIterations++;
                    BinarySearch(arr, searchElement, midNum + 1, endIndex, numberOfIterations);
                }
                else //if (searchElement < arr[midNum])
                {
                    numberOfIterations++;
                    BinarySearch(arr, searchElement, startIndex, midNum - 1, numberOfIterations);

                }
            }
            else
            {
                Console.WriteLine("BinarySearch Element Not Found");
                Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
            }
        }
        ///InsertionSort





        public static void BinarySearchIterative(int[] arr, int searchElement)
        {

            int startIndex = 0, endIndex = arr.Length;
            int numberOfIterations = 0;
            numberOfIterations++;


            while (endIndex - startIndex >= 1)
            {
                int midNum = startIndex + (endIndex - startIndex) / 2;

                if (searchElement == arr[midNum])
                {
                    numberOfIterations++;
                    Console.WriteLine("element " + searchElement + " found at index " + midNum);
                    Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
                    break;
                }
                else if (searchElement > arr[midNum])
                {
                    numberOfIterations++;
                    startIndex = midNum + 1;
                }
                else //if (searchElement < arr[midNum])
                {
                    numberOfIterations++;
                    endIndex = midNum - 1;

                }
            }
            //   else
            {
                Console.WriteLine("BinarySearch Element Not Found");
                Console.WriteLine("BinarySearchIterative Number Of Iterations : " + numberOfIterations);
            }
        }

    }

    public static class sort
    {
        public static int[] InsertionSort(int[] arr)
        {
            int numberOfIterations = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                numberOfIterations++;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                    numberOfIterations++;
                }
            }
            Console.Write("\n\nInsertionSort Display Sorted Array(y/n) : ");
            if (Convert.ToChar(Console.ReadLine()) == 'y')
            {
                misc.Displayarr(arr);
            }

            Console.WriteLine("\n\nInsertionSort Number Of Iterations : " + numberOfIterations);
            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            int numberOfIterations = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                numberOfIterations++;

                for (int j = i; j < arr.Length; j++)
                {
                    numberOfIterations++;

                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                        numberOfIterations++;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            Console.Write("\n\nSelectionSort Display Sorted Array(y/n) : ");
            if (Convert.ToChar(Console.ReadLine()) == 'y')
            {
                misc.Displayarr(arr);
            }
            Console.WriteLine("\n\nSelectionSort Number Of Iterations : " + numberOfIterations);
            return arr;
        }
    }

    public static class misc
    {
        public static int[] randomArr(int arrsize)
        {
            int[] arr = new int[arrsize];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 50);
            }
            Console.Write("Display Array(enter y)? : ");
            char disp = Convert.ToChar(Console.ReadLine());
            if (disp == 'y')
            {
                Displayarr(arr);
            }
            return arr;
        }
        //not usefull anymore
        public static int[] fillsortedarr(int arrsize)
        {
            int[] arr = new int[arrsize];
            Random r = new Random();
            int startpoint = r.Next(1, 50);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = startpoint++;
            }
            Console.Write("Display Array(enter y)? : ");
            char disp = Convert.ToChar(Console.ReadLine());
            if (disp == 'y')
            {
                Displayarr(arr);
            }
            return arr;
        }

        public static void Displayarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
