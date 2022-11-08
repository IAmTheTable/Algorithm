using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class QuickSortAlg
    {
        public static int[] QuickSort(int[] array, int left, int right)
        {
            // set the left and right index
            int i = left;
            int j = right;
            // set the pivot to the middle index
            int pivot = array[(left + right) / 2];
            // loop until the left index is greater than the right index
            while (i <= j)
            {
                // loop until the value at the left index is greater than the pivot
                while (array[i] < pivot)
                {
                    i++;
                }
                // loop until the value at the right index is less than the pivot
                while (array[j] > pivot)
                {
                    j--;
                }
                // if the left index is less than or equal to the right index
                if (i <= j)
                {
                    // swap the value at the left index with the value at the right index
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    // increment the left index
                    i++;
                    // decrement the right index
                    j--;
                }
            }
            // if the left index is less than the right index
            if (left < j)
            {
                // call the quick sort function recursively
                QuickSort(array, left, j);
            }
            // if the right index is greater than the left index
            if (i < right)
            {
                // call the quick sort function recursively
                QuickSort(array, i, right);
            }
            // return the sorted array
            return array;
        }
    }
}
