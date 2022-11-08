using System.Diagnostics;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new[] { 234987,34,2354,1,4352,42,5 };
            Stopwatch timer = new();

            timer.Restart();
            Console.WriteLine(string.Join(",", QuickSortAlg.QuickSort(data, 0, data.Length - 1)));
            timer.Stop();
            Console.WriteLine("Analytics]: " + timer.Elapsed);

            timer.Restart();
            Console.WriteLine(string.Join(",", SelectionSort.Sort(data)));
            timer.Stop();
            Console.WriteLine("Analytics]: " + timer.Elapsed);

            timer.Restart();
            Console.WriteLine(string.Join(",", MergeSortAlg.MergeSort(data)));
            timer.Stop();
            Console.WriteLine("Analytics]: " + timer.Elapsed);
        }

        static int BinarySearch(int[] data, int target)
        {
            // set the left and right index
            int left = 0;
            int right = data.Length - 1;
            // loop until the left index is greater than the right index
            while (left <= right)
            {
                if (left <= right)
                {
                    // find the middle index
                    int mid = (left + right) / 2;
                    if (data[mid] == target) // if the middle index is the target, return the middle index
                    {
                        return mid;
                    }
                    else if (data[mid] < target) // if the middle index is less than the target, set the left index to the middle index + 1
                    {
                        left = mid + 1;
                    }
                    else // if the middle index is greater than the target, set the right index to the middle index - 1
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1; // if the target is not found, return -1
        }

        static int LinearSearch(int[] array, int value)
        {
            // inc through the array.
            for (int i = 0; i < array.Length; i++) // start iteration
            {
                if (array[i] == value) // compare value 
                {
                    return i; // return index
                }
            }
            return -1; // -1 means not found
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // start iteration
            {
                for (int j = 0; j < array.Length - 1; j++) // start iteration
                {
                    if (array[j] > array[j + 1]) // compare value 
                    {
                        int temp = array[j]; // store value
                        array[j] = array[j + 1]; // swap value
                        array[j + 1] = temp; // swap value
                    }
                }
            }
            return array;
        }
    }
}