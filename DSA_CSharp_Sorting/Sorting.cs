using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_TUF_Sorting
{
    internal class Sorting
    {
        /// <summary>
        /// Select Minimum and Swap
        /// So, I => 0  to n-2
        /// 	j => I  to n-1
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i <= n - 2; i++)
            {
                int minIndex = i;
                for (int j = i; j <= n - 1; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }

        /// <summary>
        /// Push the max to last by adjacent swaps
        /// I goes from (n-1) to 0
        /// J goes from 0 to I
        /// But as the inner loop compares j with j+1, J has to go till(i-1)
        /// Otherwise, it will throw out of index exception.
        /// Time Complexity Worst & Average case = O(N^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BubbleSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Time Complexity Best case = O(N)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] BubbleSortOptimized(int[] arr)
        {
            var n = arr.Length;
            for (int i = n - 1; i >= 1; i--)
            {
                bool didSwap = false;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        didSwap = true;
                    }
                }
                if (didSwap == false) break;
            }
            return arr;
        }

        public static int[] InsertionSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i <= n - 1; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    var temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }

            return arr;
        }

        public static void MergeSort(int[] arr, int low, int high)
        {
            //if low=high, then it has reached single element, so can be returned
            if (low >= high) return;
            int mid = (low + high) / 2;
            //For left section
            MergeSort(arr, low, mid);
            //For right section
            MergeSort(arr, mid + 1, high);
            //Once the left and right section is done, merge both section elements in a sorted way
            Merge(arr, low, mid, high);
        }

        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            List<int> temp = new List<int>();

            //Checking in left and right section adding to a temporary list in sorted order.
            while (left <= mid && right <= high)
            {
                if (arr[left] < arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            //If something is left in left section, add to temp entirely
            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }

            //If something is left in right section, add to temp entirely
            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            //Add back to original arr from temp
            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                //Get the partition index
                int pIndex = Partition(arr, low, high);
                //Sort the array left of PI
                QuickSort(arr, low, pIndex - 1);
                //Sort the array right of PI
                QuickSort(arr, pIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low;
            int j = high;
            //untill j crosses i
            while (i < j)
            {
                //untill any element in left is greater than pivot
                //and left index less than or equal to last index-1
                while (arr[i] <= pivot && i <= high - 1)
                {
                    i++;
                }
                //untill any element in right is lesser than pivot
                //and right index is greater than or equal to first index-1
                while (arr[j] > pivot && j >= low + 1)
                {
                    j--;
                }
                //if i and j is not yet crossed, swap elements in i & j
                if (i < j)
                {
                    var t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                }
            }
            //if i and j are crossed, swap elements in j & low
            var temp = arr[low];
            arr[low] = arr[j];
            arr[j] = temp;

            return j;

        }
    }
}
