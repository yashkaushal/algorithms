using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.Write("enter sise of array: ");
                int arraysize = Convert.ToInt16(Console.ReadLine());
                Console.Write("enter element to search: ");
                int searchelement = Convert.ToInt16(Console.ReadLine());


                Console.WriteLine("Sorted array in InsertionSort");
                InsertionSort(fillsortedarr(arraysize));

                BinarySearch(SelectionSort(fillarr(arraysize)), searchelement, 0, arraysize);
                BinarySearchIterative(SelectionSort(fillarr(arraysize)), searchelement);

                LinearSearch(InsertionSort(fillarr(arraysize)), searchelement);

                Console.Write("\nPress Any key : ");
                Console.ReadKey();
            }
        }




        static int[] fillarr(int arrsize)
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
        static int[] fillsortedarr(int arrsize)
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

       
        static void LinearSearch(int[] arr, int searchthis)
        {
            int numberOfIterations = 0;
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                numberOfIterations++;
                if (arr[i] == searchthis)
                {
                    Console.WriteLine("Element " + searchthis + " found at " + i + " index.");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element " + searchthis + " not in array");
            }
            Console.WriteLine("Linear Search Number Of Interations :" + numberOfIterations);
        }
        static void Displayarr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void BinarySearch(int[] arr, int searchthis, int startIndex, int endIndex, int numberOfIterations = 1)
        {
            if (endIndex - startIndex >= 1)
            {
                int midNum = startIndex + (endIndex - startIndex) / 2;
                numberOfIterations++;

                if (searchthis == arr[midNum])
                {
                    numberOfIterations++;
                    Console.WriteLine("element " + searchthis + " found at index " + midNum);
                    Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
                    return;
                }
                else if (searchthis > arr[midNum])
                {
                    numberOfIterations++;
                    BinarySearch(arr, searchthis, midNum + 1, endIndex, numberOfIterations);
                }
                else //if (searchthis < arr[midNum])
                {
                    numberOfIterations++;
                    BinarySearch(arr, searchthis, startIndex, midNum - 1, numberOfIterations);

                }
            }
            else
            {
                Console.WriteLine("BinarySearch Element Not Found");
                Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
            }
        }

        static int[] InsertionSort(int[] arr)
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
                Displayarr(arr);
            }

            Console.WriteLine("\n\nInsertionSort Number Of Iterations : " + numberOfIterations);
            return arr;
        }

        static int[] SelectionSort(int[] arr)
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
                Displayarr(arr);
            }
            Console.WriteLine("\n\nSelectionSort Number Of Iterations : " + numberOfIterations);
            return arr;
        }

        static void BinarySearchIterative(int[] arr, int searchthis)
        {

            int startIndex = 0, endIndex = arr.Length;
            int numberOfIterations = 0;
            numberOfIterations++;


            while (endIndex - startIndex >= 1)
            {
                int midNum = startIndex + (endIndex - startIndex) / 2;

                if (searchthis == arr[midNum])
                {
                    numberOfIterations++;
                    Console.WriteLine("element " + searchthis + " found at index " + midNum);
                    Console.WriteLine("BinarySearch Number Of Iterations : " + numberOfIterations);
                    break;
                }
                else if (searchthis > arr[midNum])
                {
                    numberOfIterations++;
                    startIndex = midNum + 1;
                }
                else //if (searchthis < arr[midNum])
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
}
