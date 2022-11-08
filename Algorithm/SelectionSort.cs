using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            // loop through the array
            for (int i = 0; i < array.Length; i++)
            {
                // set the minimum index to the current index
                int minIndex = i;
                // loop through the array starting at the current index + 1
                for (int j = i + 1; j < array.Length; j++)
                {
                    // if the value at the current index is less than the value at the minimum index, set the minimum index to the current index
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // swap the value at the current index with the value at the minimum index
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            // return the sorted array
            return array;
        }
        
    }
}
