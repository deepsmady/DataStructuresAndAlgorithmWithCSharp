using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_TUF.BasicHashing
{
    public class BasicHashing
    {
        public static void HashingDemo()
        {
            int n;
            Console.WriteLine("Enter array size : ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                //Pre-store
                if (map.ContainsKey(a[i]))
                {
                    map[a[i]]++; // Increment frequency if the key exists
                }
                else
                {
                    map[a[i]] = 1; // Initialize the frequency to 1 if the key does not exist
                }
            }

            Console.WriteLine("Dictionary Items");
            foreach (var item in map)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            int q;
            Console.WriteLine("Enter the number of values to be checked in array for fetching : ");
            q = int.Parse(Console.ReadLine());

            while (q != 0)
            {
                Console.WriteLine("Enter the number : ");
                int num = int.Parse(Console.ReadLine());
                //fetch
                if (num == 0)
                {
                    q = 0; // Exit the loop
                }
                else if (map.ContainsKey(num))
                {
                    Console.WriteLine($"Frequency of {num} = {map[num]}");
                }
                else
                {
                    Console.WriteLine($"The number {num} does not exist in the array.");
                }
            }
        }

        /// <summary>
        /// Find the highest/lowest frequency element
        /// </summary>
        public static void HighestAndLowestFrequencyElement()
        {
            int[] arr = { 10, 5, 10, 15, 10, 5 };
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            int maxFreq = 0, minFreq = int.MaxValue;
            int maxEle = 0, minEle = 0;

            // Count frequencies
            foreach (int num in arr)
            {
                if (freqMap.ContainsKey(num))
                    freqMap[num]++;
                else
                    freqMap[num] = 1;
            }

            // Find max and min frequency elements
            foreach (var pair in freqMap)
            {
                if (pair.Value > maxFreq)
                {
                    maxFreq = pair.Value;
                    maxEle = pair.Key;
                }
                if (pair.Value < minFreq)
                {
                    minFreq = pair.Value;
                    minEle = pair.Key;
                }
            }

            Console.WriteLine($"The highest frequency element is: {maxEle} with frequency {maxFreq}");
            Console.WriteLine($"The lowest frequency element is: {minEle} with frequency {minFreq}");
        }
    }
}
