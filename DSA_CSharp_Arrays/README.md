# DSA_CSharp_Arrays

This repository contains a collection of common array-related problems implemented in C#. Each problem is solved using efficient algorithms and data structures to ensure optimal performance. Below is a detailed explanation of each function, its logic, and the algorithm used.

---

## Table of Contents
1. [Two Sum Problem](#1-two-sum-problem)
2. [Max Profit](#2-max-profit)
3. [Contains Duplicate](#3-contains-duplicate)
4. [Product Except Self](#4-product-except-self)
5. [Subarray with Maximum Sum (Kadane's Algorithm)](#5-subarray-with-maximum-sum-kadanes-algorithm)
6. [Subarray with Maximum Product](#6-subarray-with-maximum-product)
7. [Next Permutation](#7-next-permutation)
8. [Three Sum](#8-three-sum)
9. [Majority Element (N/2)](#9-majority-element-n2)
10. [Longest Subarray with Sum K - Explanation & Implementations](#10-longest-subarray-with-sum-k---explanation--implementations)

---

## 1. Two Sum Problem

### **TwoSumProblemUsingHashMap**
- **Description**: Finds two numbers in an array that add up to a target using a hash map.
- **Logic**: Uses a dictionary to store elements and their indices. For each element, it calculates the complement (`target - arr[i]`) and checks if the complement exists in the dictionary.
- **Time Complexity**: O(N).
- **Space Complexity**: O(N).

### **TwoSumProblemUsing2Pointers**
- **Description**: Finds two numbers in a sorted array that add up to a target using two pointers.
- **Logic**: Sorts the array and uses two pointers to find the pair of elements that sum up to the target.
- **Time Complexity**: O(N log N).
- **Space Complexity**: O(N).

---

## 2. Max Profit
- **Description**: Calculates the maximum profit from buying and selling stocks.
- **Logic**: Iterates through the array, keeping track of the minimum price and the maximum profit.
- **Time Complexity**: O(N).
- **Space Complexity**: O(1).

---

## 3. Contains Duplicate

### **ContainsDuplicate1**
- **Description**: Checks if an array contains duplicate elements using a dictionary.
- **Logic**: Uses a dictionary to check for duplicates. If an element already exists in the dictionary, it returns `true`.
- **Time Complexity**: O(N).
- **Space Complexity**: O(N).

### **ContainsDuplicate2**
- **Description**: Checks if an array contains duplicate elements using a HashSet.
- **Logic**: Uses a HashSet to store elements. If the size of the HashSet is less than the size of the array, it means there are duplicates.
- **Time Complexity**: O(N).
- **Space Complexity**: O(N).

---

## 4. Product Except Self
- **Description**: Computes the product of all elements in the array except the current element.
- **Logic**: Uses prefix and suffix products to calculate the result.
- **Time Complexity**: O(N).
- **Space Complexity**: O(N).

---

## 5. Subarray with Maximum Sum (Kadane's Algorithm)
- **Description**: Finds the contiguous subarray with the maximum sum.
- **Logic**: Implements Kadane's Algorithm to find the maximum sum of a contiguous subarray.
- **Time Complexity**: O(N).
- **Space Complexity**: O(1).

---

## 6. Subarray with Maximum Product
- **Description**: Finds the contiguous subarray with the maximum product.
- **Logic**: Uses prefix and suffix products to find the maximum product.
- **Time Complexity**: O(N).
- **Space Complexity**: O(1).

---

## 7. Next Permutation
- **Description**: Finds the next lexicographical permutation of the array.
- **Logic**: Identifies the first decreasing element, swaps it with the smallest element greater than it to the right, and reverses the suffix.
- **Time Complexity**: O(N).
- **Space Complexity**: O(1).

---

## 8. Three Sum
- **Description**: Finds all unique triplets in the array that sum up to zero.
- **Logic**: Sorts the array and uses two pointers to find the triplets.
- **Time Complexity**: O(N^2).
- **Space Complexity**: O(1), excluding the space required for the output.

---

## 9. Majority Element (N/2)
- **Description**: Finds the majority element in an array (appears more than `n/2` times).
- **Logic**: Uses the Boyer-Moore Voting Algorithm to find the majority element.
- **Time Complexity**: O(N).
- **Space Complexity**: O(1).

---

# **Longest Subarray with Sum K - Explanation & Implementations**

This document explains various approaches to solving the problem of finding the **longest contiguous subarray** with a given sum `k`. The methods range from brute-force to optimal solutions.

---

## **1. Brute Force Approach - O(N³)**
### **Explanation**
- Iterate over all possible subarrays using three nested loops.
- Compute the sum for each subarray and check if it equals `k`.
- If a valid subarray is found, update the maximum length.

### **Code**
```csharp
/// <summary>
/// Brute Force with O(N^3) Time Complexity
/// </summary>
public static int LongestSubarrayWithSum_K_N3(int[] arr, int k)
{
    int len = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            int sum = 0;
            for (int m = i; m <= j; m++)
            {
                sum += arr[m];
                if (sum == k)
                {
                    len = Math.Max(len, j - i + 1);
                }
            }
        }
    }
    return len;
}
```
### **Complexity Analysis**
- Since there are **three nested loops**, the time complexity is **O(N³)**, making this approach inefficient for large inputs.

---

## **2. Improved Brute Force - O(N²)**
### **Explanation**
- Instead of recalculating the sum in the innermost loop, we maintain a running sum.
- This eliminates the need for the third loop, reducing time complexity to **O(N²)**.

### **Code**
```csharp
/// <summary>
/// Brute Force with O(N^2) Time Complexity
/// </summary>
public static int LongestSubarrayWithSum_K_N2(int[] arr, int k)
{
    int len = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int sum = 0;
        for (int j = i; j < arr.Length; j++)
        {
            sum += arr[j];
            if (sum == k)
            {
                len = Math.Max(len, j - i + 1);
            }
        }
    }
    return len;
}
```
### **Complexity Analysis**
- Since there are **two nested loops**, the time complexity is **O(N²)**, which is an improvement over the previous approach.

---

## **3. Better Approach - O(N log N)**
### **Explanation**
- Uses a **prefix sum and a hash map** to store the first occurrence of a sum.
- If `(sum - k)` exists in the map, we calculate the subarray length.
- This reduces the time complexity to **O(N log N)** due to dictionary operations.

### **Code**
```csharp
/// <summary>
/// Better Solution with O(N Log N) Time Complexity
/// </summary>
public static int LongestSubarrayWithSum_K_Better(int[] arr, int k)
{
    int maxLen = 0;
    int sum = 0;
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];

        if (sum == k)
        {
            maxLen = Math.Max(maxLen, i + 1);
        }

        int rem = sum - k;
        if (map.ContainsKey(rem))
        {
            maxLen = Math.Max(maxLen, i - map[rem]);
        }

        if (!map.ContainsKey(sum))
        {
            map.Add(sum, i);
        }
    }
    return maxLen;
}
```
### **Complexity Analysis**
- **O(N log N)** due to dictionary operations, but in most cases, it approaches **O(N)**.

---

## **4. Optimal Approach - O(N)**
### **Explanation**
- Uses the **Sliding Window (Two Pointers) technique**.
- Expands `right` pointer until sum exceeds `k`, then shrinks `left`.
- Achieves an optimal time complexity of **O(N)**.

### **Code**
```csharp
/// <summary>
/// Optimal Solution using Sliding Window - O(N) Time Complexity
/// </summary>
public static int LongestSubarrayWithSum_K_Optimal(int[] arr, int k)
{
    int maxLen = 0;
    int left = 0, right = 0;
    int n = arr.Length;
    int sum = arr[0];

    while (right < n)
    {
        while (sum > k && left <= right)
        {
            sum -= arr[left];
            left++;
        }

        if (sum == k)
        {
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        right++;
        if (right < n)
        {
            sum += arr[right];
        }
    }

    return maxLen;
}
```
### **Complexity Analysis**
- **O(N)** since each element is processed at most **twice** (once when expanding and once when contracting).

---

## **Comparison Table**

| Approach | Time Complexity | Space Complexity | Suitable for Large Inputs? |
|----------|---------------|------------------|----------------------------|
| **Brute Force (O(N³))** | O(N³) | O(1) | ❌ No |
| **Improved Brute Force (O(N²))** | O(N²) | O(1) | ❌ No |
| **Better Approach (O(N log N))** | O(N log N) | O(N) | ✅ Yes |
| **Optimal Sliding Window (O(N))** | O(N) | O(1) | ✅✅ Best |

---

## **Final Thoughts**
- **For positive numbers only**, the **Sliding Window approach (O(N))** is the best.
- If the array contains **negative numbers**, the **Hash Map approach (O(N log N))** should be used instead.
- **Brute force methods are not practical** for large inputs but serve as a baseline for understanding.

---

Would you like any modifications or additional explanations? 😊



