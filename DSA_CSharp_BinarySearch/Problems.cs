
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp_BinarySearch
{
    public class Problems
    {
        public int BinarySearch_Iterative(int[] arr, int target)
        {
            // Initialize search boundaries
            int low = 0, high = arr.Length - 1;

            // Continue searching while the search space is valid
            while (low <= high)
            {
                // Compute the middle index safely to avoid integer overflow
                int mid = low + (high - low) / 2;

                // If the middle element matches the target, return its index
                if (arr[mid] == target)
                    return mid;

                // If the target is greater, search the right half
                else if (target > arr[mid])
                    low = mid + 1;

                // Otherwise, search the left half
                else
                    high = mid - 1;
            }

            // Target not found, return -1
            return -1;
        }

        public int BinarySearch_Recursive(int[] arr, int target)
        {
            // Start the recursive binary search
            return BinarySearch(arr, 0, arr.Length - 1, target);
        }

        private int BinarySearch(int[] arr, int low, int high, int target)
        {
            // Base case: if the search space is invalid, return -1 (not found)
            if (low > high) return -1;

            // Calculate the middle index safely to prevent overflow
            int mid = low + (high - low) / 2;

            // If the middle element is the target, return its index
            if (target == arr[mid])
                return mid;

            // If the target is greater, search the right half
            else if (target > arr[mid])
                return BinarySearch(arr, mid + 1, high, target);

            // Otherwise, search the left half
            else
                return BinarySearch(arr, low, mid - 1, target);
        }

    }
}
