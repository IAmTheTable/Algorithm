using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class MergeSortAlg
    {
        public static int[] MergeSort(int[] data)
        {
            // if the array is empty or has a length of 1, return the array
            if (data.Length <= 1)
            {
                return data;
            }
            // create a new array for the left side of the array
            int[] left = new int[data.Length / 2];
            // create a new array for the right side of the array
            int[] right = new int[data.Length - left.Length];
            // loop through the left side of the array
            for (int i = 0; i < left.Length; i++)
            {
                // set the left side of the array to the data array
                left[i] = data[i];
            }
            // loop through the right side of the array
            for (int i = 0; i < right.Length; i++)
            {
                // set the right side of the array to the data array
                right[i] = data[left.Length + i];
            }
            // set the left side of the array to the merge sort method
            left = MergeSort(left);
            // set the right side of the array to the merge sort method
            right = MergeSort(right);
            // return the merge method
            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            // create a new array for the result
            int[] result = new int[left.Length + right.Length];
            // create a variable for the left index
            int leftIndex = 0;
            // create a variable for the right index
            int rightIndex = 0;
            // create a variable for the result index
            int resultIndex = 0;
            // loop until the left index is greater than the left length
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                // if the left index is less than the right index
                if (left[leftIndex] <= right[rightIndex])
                {
                    // set the result index to the left index
                    result[resultIndex] = left[leftIndex];
                    // increment the left index
                    leftIndex++;
                }
                else
                {
                    // set the result index to the right index
                    result[resultIndex] = right[rightIndex];
                    // increment the right index
                    rightIndex++;
                }
                // increment the result index
                resultIndex++;
            }
            // loop until the left index is less than the left length
            while (leftIndex < left.Length)
            {
                // set the result index to the left index
                result[resultIndex] = left[leftIndex];
                // increment the left index
                leftIndex++;
                // increment the result index
                resultIndex++;
            }
            // loop until the right index is less than the right length
            while (rightIndex < right.Length)
            {
                // set the result index to the right index
                result[resultIndex] = right[rightIndex];
                // increment the right index
                rightIndex++;
                // increment the result index
                resultIndex++;
            }
            // return the result
            return result;
        }
    }
}
