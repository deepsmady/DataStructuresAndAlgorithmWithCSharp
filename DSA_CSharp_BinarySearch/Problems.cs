
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

        /// <summary>
        /// Search Element In a Rotated Sorted Array 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private int SearchElementInRotatedSortedArray1(int[] arr, int k)
        {
            int n = arr.Length;
            int low = 0, high = n - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // Calculate the middle index to avoid overflow

                if (arr[mid] == k) return mid; // If the middle element is the target, return its index

                // Check if the left half is sorted
                if (arr[low] <= arr[mid])
                {
                    // If the target lies within the sorted left half
                    if (k >= arr[low] && k <= arr[mid])
                    {
                        high = mid - 1; // Narrow search to the left half
                    }
                    else
                    {
                        low = mid + 1; // Search in the right half
                    }
                }
                else
                {
                    // If the target lies within the sorted right half
                    if (k >= arr[mid] && k <= arr[high])
                    {
                        low = mid + 1; // Narrow search to the right half
                    }
                    else
                    {
                        high = mid - 1; // Search in the left half
                    }
                }
            }

            return -1; // Target not found
        }

        /// <summary>
        /// Search Element In RotatedSortedArray if there are duplicate entries       
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        private bool SearchElementInRotatedSortedArray2(int[] arr, int k)
        {
            int n = arr.Length;
            int low = 0, high = n - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // Calculate the middle index to avoid overflow

                if (arr[mid] == k) return true; // If the middle element is the target, return its index

                if(arr[low] == arr[mid] && arr[mid] == arr[high])
                {
                    low++;
                    high--;
                    continue;
                }
                // Check if the left half is sorted
                if (arr[low] <= arr[mid])
                {
                    // If the target lies within the sorted left half
                    if (k >= arr[low] && k <= arr[mid])
                    {
                        high = mid - 1; // Narrow search to the left half
                    }
                    else
                    {
                        low = mid + 1; // Search in the right half
                    }
                }
                else
                {
                    // If the target lies within the sorted right half
                    if (k >= arr[mid] && k <= arr[high])
                    {
                        low = mid + 1; // Narrow search to the right half
                    }
                    else
                    {
                        high = mid - 1; // Search in the left half
                    }
                }
            }

            return false; // Target not found
        }

        public static int MinimumInRotatedSortedArray(int[] arr)
        {
            int low = 0, high = arr.Length - 1; // Initialize pointers to the start and end of the array
            int min = int.MaxValue; // Initialize min value to the largest possible integer

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // Calculate mid index to prevent overflow

                // If the left half is sorted
                if (arr[low] <= arr[mid])
                {
                    min = Math.Min(min, arr[low]); // Update min with the smallest element in the left half
                    low = mid + 1; // Move to the right half since left half is sorted
                }
                else
                {
                    min = Math.Min(min, arr[mid]); // Update min with the smallest element in the right half
                    high = mid - 1; // Move to the left half
                }
            }

            return min; // Return the minimum element found
        }


    }
}
