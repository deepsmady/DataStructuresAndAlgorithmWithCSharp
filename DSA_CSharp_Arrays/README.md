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
10. [Usage](#usage)
11. [Contributing](#contributing)
12. [License](#license)

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

## Usage
To use these functions, simply call the appropriate method with the required parameters. For example:

```csharp
int[] arr = { 2, 6, 5, 8, 11 };
int target = 14;
int[] result = Problems.TwoSumProblemUsingHashMap(arr, target);
Console.WriteLine($"Indices: {result[0]}, {result[1]}");