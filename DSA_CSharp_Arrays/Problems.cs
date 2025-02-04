using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp_Arrays
{
    internal class Problems
    {
        /// <summary>
        /// eg : { 2, 6, 5, 8, 11 } => Target = 14
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumProblemUsingHashMap(int[] arr, int target)
        {
            //Dict to store element(key) and index(value)
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { i, map[complement] };
                }
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], i);
                }

            }
            return new int[] { -1, -1 };
        }

        /// <summary>
        /// eg : { 2, 6, 5, 8, 11 } => Target = 14
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumProblemUsing2Pointers(int[] arr, int target)
        {
            //store the initial index to a temp dictionary
            var arrayIndexMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                arrayIndexMap.Add(arr[i], i);
            }
            int left = 0;
            int right = arr.Length - 1;
            //Sort the array
            arr = arr.OrderBy(x => x).ToArray();

            //Move the left and right pointers towards right and left respectively and check the sum
            //If the sum is less than target, move left p else move right p.
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int sum = (arr[left] + arr[right]);
                if (sum == target) return new int[] { arrayIndexMap[arr[left]], arrayIndexMap[arr[right]] };
                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[] { -1, -1 };
        }

        public int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int maxProfit = 0;
            for (int i = 1; i <= prices.Length - 1; i++)
            {
                int proOrLoss = prices[i] - min;
                maxProfit = Math.Max(maxProfit, proOrLoss);
                min = Math.Min(min, prices[i]);
            }
            return maxProfit;
        }

        /// <summary>
        /// TC = O(N)
        /// SC = O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate1(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }
            return false;
        }

        /// <summary>
        /// TC = O(N)
        /// SC = O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate2(int[] nums)
        {
            HashSet<int> tempList = new HashSet<int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                tempList.Add(nums[i]);
            }
            return tempList.Count < nums.Length;
        }

        /// <summary>
        /// TC = O(n)+O(n)+O(n)=O(n)
        /// SC = 3*O(N) = O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] output = new int[n];
            int[] prefix = new int[n];
            int[] suffix = new int[n];

            prefix[0] = 1;
            for (int i = 1; i < n; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1];
            }

            suffix[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                output[i] = prefix[i] * suffix[i];
            }

            return output;
        }

        public int SubarrayWithMaximumSum_KidanesAlgorithm(int[] arr)
        {
            int sum = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                sum = sum + arr[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }
            return maxSum < 0 ? maxSum : 0;
        }

        /// <summary>
        /// Most intuitive method
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SubarrayWithMaximumProduct(int[] arr)
        {
            int maxProduct = int.MinValue;
            int preffixProduct = 1;
            int suffixProduct = 1;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (preffixProduct == 0)
                {
                    preffixProduct = 1;
                }
                if (suffixProduct == 0)
                {
                    suffixProduct = 1;
                }

                preffixProduct = preffixProduct * arr[i];
                suffixProduct = suffixProduct * arr[arr.Length - i - 1];
                maxProduct = Math.Max(maxProduct, Math.Max(preffixProduct, suffixProduct));
            }
            return maxProduct;
        }

        public void NextPermutation(int[] arr)
        {
            int n = arr.Length;
            int dipIndex = -1;

            // Step 1: Find the first decreasing element (dipIndex)
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    dipIndex = i;
                    break;
                }
            }

            // If no dipIndex is found, reverse the entire array to get the smallest permutation
            if (dipIndex == -1)
            {
                Array.Reverse(arr);
                return;
            }

            // Step 2: Find the smallest element greater than arr[dipIndex] to the right
            for (int i = n - 1; i > dipIndex; i--)
            {
                if (arr[i] > arr[dipIndex])
                {
                    // Swap arr[dipIndex] and arr[i]
                    (arr[dipIndex], arr[i]) = (arr[i], arr[dipIndex]);
                    break;
                }
            }

            // Step 3: Reverse the suffix starting from dipIndex + 1
            Array.Reverse(arr, dipIndex + 1, n - dipIndex - 1);
        }

        public static IList<IList<int>> ThreeSum(int[] arr)
        {
            List<IList<int>> ans = new List<IList<int>>();
            Array.Sort(arr);  // Sort the array first

            for (int i = 0; i < arr.Length - 2; i++)  // Run till arr.Length - 2
            {
                if (i > 0 && arr[i] == arr[i - 1]) continue; // Skip duplicate values for `i`

                int j = i + 1, k = arr.Length - 1;

                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (sum < 0)
                    {
                        j++;
                    }
                    else if (sum > 0)
                    {
                        k--;
                    }
                    else
                    {
                        ans.Add(new List<int> { arr[i], arr[j], arr[k] });

                        // Move pointers to avoid duplicate values
                        while (j < k && arr[j] == arr[j + 1]) j++;
                        while (j < k && arr[k] == arr[k - 1]) k--;

                        j++;
                        k--;
                    }
                }
            }

            return ans;
        }


        public static int MajorityElement_NBy2(int[] arr)
        {
            int ctr = 0;  // Counter to track the candidate element's occurrence
            int n = arr.Length;  // Length of the array
            int ele = arr[0];  // Candidate for the majority element

            // Phase 1: Find the potential majority element using Moore's Voting Algorithm
            for (int i = 0; i <= n - 1; i++)
            {
                if (ctr == 0)  // If counter is 0, set the current element as the candidate
                {
                    ele = arr[i];
                    ctr = 1;
                }
                else if (arr[i] == ele)  // If the same element appears, increase counter
                {
                    ctr++;
                }
                else  // If a different element appears, decrease counter
                {
                    ctr--;
                }
            }

            // Phase 2: Verify if the candidate appears more than n/2 times
            int ctr2 = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if (arr[i] == ele)
                {
                    ctr2++;  // Count occurrences of the candidate element
                }
            }

            // If the candidate element occurs more than n/2 times, return it; otherwise, return -1
            if (ctr2 > n / 2) return ele;
            return -1;
        }
        
        public static IList<int> MajorityElement_NBy3(int[] arr)
        {
            int ctr1 = 0, ctr2 = 0;  // Counter to track the candidate element's occurrence
            int n = arr.Length;  // Length of the array
            int ele1 = int.MinValue, ele2 = int.MinValue;  // Candidate for the majority element

            IList<int> listMajorityElements = new List<int>();

            // Phase 1: Find the potential majority element using Moore's Voting Algorithm
            for (int i = 0; i <= n - 1; i++)
            {
                if (ctr1 == 0 && arr[i] != ele2)  // If counter is 0, set the current element as the candidate
                {
                    ele1 = arr[i];
                    ctr1 = 1;
                }
                else if (ctr2 == 0 && arr[i] != ele1)  // If counter is 0, set the current element as the candidate
                {
                    ele2 = arr[i];
                    ctr2 = 1;
                }
                else if (arr[i] == ele1) ctr1++; // If the same element appears, increase counter
                else if (arr[i] == ele2) ctr2++; // If the same element appears, increase counter                
                else  // If a different element appears, decrease counter
                {
                    ctr1--;
                    ctr2--;
                }
            }

            // Phase 2: Verify if the candidate appears more than n/3 times
            ctr1 = 0; ctr2 = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if (arr[i] == ele1)
                {
                    ctr1++;  // Count occurrences of the candidate element
                } 
                else if (arr[i] == ele2)
                {
                    ctr2++;  // Count occurrences of the candidate element
                }
            }

            // If the candidate element occurs more than n/3 times, return it; otherwise, return -1
            if (ctr1 > n / 3) listMajorityElements.Add(ele1);
            if (ctr2 > n / 3) listMajorityElements.Add(ele2);
            return listMajorityElements;
        }



    }
}
