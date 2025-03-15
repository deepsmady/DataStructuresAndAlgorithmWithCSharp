// See https://aka.ms/new-console-template for more information
using DSA_CSharp_BinarySearch;

Console.WriteLine("Binary Search!!!");
Console.WriteLine("----------------");

Console.WriteLine("--- Find Minimum In Rotated Sorted Array ---");
int[] arr = new int[] { 4,5,6,7,8,1,2,3 };
Console.WriteLine($"Minimum In Rotated Sorted Array = {Problems.MinimumInRotatedSortedArray(arr)}");

Console.ReadKey();
