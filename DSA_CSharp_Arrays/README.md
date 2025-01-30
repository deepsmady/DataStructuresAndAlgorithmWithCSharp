# DSA C# Arrays - Algorithm Implementations

This repository contains various **Data Structures and Algorithms (DSA) implementations** using **C#**, specifically focused on **array problems**.

## 🚀 Features & Implemented Algorithms

1. **Two Sum Problem (HashMap & Two-Pointers)**
2. **Maximum Profit from Stock Prices**
3. **Check for Duplicate Elements**
4. **Product of Array Except Self**
5. **Kadane’s Algorithm for Maximum Subarray Sum**
6. **Maximum Subarray Product**
7. **Next Permutation of an Array**
8. **Three Sum Problem**
9. **Majority Element (N/2 Condition)**

---

## 📝 Implementations

### 1️⃣ **Two Sum Problem**
Finds two indices whose elements sum up to a given target.

- **Using HashMap (O(n) time complexity)**
- **Using Two Pointers (O(n log n) due to sorting)**

```csharp
public static int[] TwoSumProblemUsingHashMap(int[] arr, int target)
```

```csharp
public static int[] TwoSumProblemUsing2Pointers(int[] arr, int target)
```

---

### 2️⃣ **Best Time to Buy and Sell Stock**
Finds the maximum profit that can be earned by buying and selling a stock once.

```csharp
public int MaxProfit(int[] prices)
```

---

### 3️⃣ **Checking for Duplicates**
Returns `true` if there is any duplicate element in the array.

```csharp
public bool ContainsDuplicate1(int[] nums)
public bool ContainsDuplicate2(int[] nums)
```

---

### 4️⃣ **Product of Array Except Self**
Computes an output array where `output[i]` is the product of all elements except `nums[i]`.

```csharp
public int[] ProductExceptSelf(int[] nums)
```

---

### 5️⃣ **Kadane's Algorithm (Maximum Subarray Sum)**
Finds the largest sum of a contiguous subarray.

```csharp
public int SubarrayWithMaximumSum_KadanesAlgorithm(int[] arr)
```

---

### 6️⃣ **Maximum Subarray Product**
Finds the subarray with the maximum product.

```csharp
public int SubarrayWithMaximumProduct(int[] arr)
```

---

### 7️⃣ **Next Permutation**
Finds the next lexicographical permutation of an array.

```csharp
public void NextPermutation(int[] arr)
```

---

### 8️⃣ **Three Sum Problem**
Finds all unique triplets in an array that sum to zero.

```csharp
public static IList<IList<int>> ThreeSum(int[] arr)
```

---

### 9️⃣ **Majority Element (N/2 Condition)**
Finds the element that appears more than `n/2` times using **Moore’s Voting Algorithm**.

```csharp
public static int MajorityElement_NBy2(int[] arr)
```

---

## 🛠️ How to Run the Code

1. **Clone the Repository**
   ```sh
   git clone https://github.com/your-username/DSA_CSharp_Arrays.git
   cd DSA_CSharp_Arrays
   ```

2. **Open in Visual Studio**
   - Open the `.sln` file in **Visual Studio**.
   - Build and run the project.

3. **Run a Specific Function**
   ```csharp
   int[] result = Problems.TwoSumProblemUsingHashMap(new int[] {2, 6, 5, 8, 11}, 14);
   Console.WriteLine($"Indices: {result[0]}, {result[1]}");
   ```

---

## 🏆 Complexity Analysis

| Algorithm | Time Complexity | Space Complexity |
|-----------|----------------|------------------|
| **Two Sum (HashMap)** | O(n) | O(n) |
| **Two Sum (Two-Pointers)** | O(n log n) | O(1) |
| **Max Profit (Stocks)** | O(n) | O(1) |
| **Contains Duplicate** | O(n) | O(n) |
| **Product Except Self** | O(n) | O(n) |
| **Kadane's Algorithm** | O(n) | O(1) |
| **Maximum Subarray Product** | O(n) | O(1) |
| **Next Permutation** | O(n) | O(1) |
| **Three Sum** | O(n²) | O(n) |
| **Majority Element (Moore's Algorithm)** | O(n) | O(1) |

---

## 📌 Contributing
Feel free to fork this repository and submit pull requests for improvements.

---

## 📜 License
This project is licensed under the MIT License.
