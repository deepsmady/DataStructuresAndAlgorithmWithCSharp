// See https://aka.ms/new-console-template for more information
using DSA_TUF_Sorting;

Console.WriteLine("Sorting world!");

Console.WriteLine("Selection Sort");
int[] arr = { 9, 3, 7, 18, 2 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Console.WriteLine($"Sorted Array : {string.Join(',', Sorting.SelectionSort(arr))}");

Console.WriteLine("Bubble Sort");
arr = new int[] { 9, 3, 7, 18, 2 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Console.WriteLine($"Sorted Array : {string.Join(',', Sorting.BubbleSort(arr))}");

Console.WriteLine("Insertion Sort");
arr = new int[] { 9, 3, 7, 18, 2 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Console.WriteLine($"Sorted Array : {string.Join(',', Sorting.InsertionSort(arr))}");

Console.WriteLine("Merge Sort");
arr = new int[] { 9, 3, 7, 18, 2 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Sorting.MergeSort(arr,0,arr.Length-1);
Console.WriteLine($"Sorted Array : {string.Join(',', arr)}");

Console.WriteLine("Quick Sort");
arr = new int[] { 9, 3, 7, 18, 2 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Sorting.QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Sorted Array : {string.Join(',', arr)}");




Console.ReadKey();
