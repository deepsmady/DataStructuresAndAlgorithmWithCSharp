// See https://aka.ms/new-console-template for more information
using DSA_CSharp_Arrays;

Console.WriteLine("ARRAYS!!!!!!!!!!!");
Console.WriteLine("2 Sum Problem - Get the index values for which the value sum equals target - Hashmap");
int[] arr = { 2, 6, 5, 8, 11 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
var indices = Problems.TwoSumProblemUsingHashMap(arr, target: 14);
Console.WriteLine($"Indices : {string.Join(',', indices)}");

Console.WriteLine("2 Sum Problem - Get the index values for which the value sum equals target - 2 pointer");
arr = new int[]{ 2, 6, 5, 8, 11 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
indices = Problems.TwoSumProblemUsing2Pointers(arr, target: 14);
Console.WriteLine($"Indices : {string.Join(',', indices)}");

Console.WriteLine("--- Next Permutation ---");
arr = new int[] { 2, 1, 5, 4, 3, 0, 0 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
Problems.NextPermutation(arr);
Console.WriteLine($"Next Permutation : {string.Join(',', arr)}");

Console.WriteLine("--- Find All Sub Arrays With Given Sum ---");
arr = new int[] { 3,1,2,4 };
var count = Problems.FindAllSubArraysWithGivenSum(arr,6);
Console.WriteLine($"Count of Sub Arrays With Given Sum : {count}");

Console.WriteLine("--- Find All Sub Arrays With XOR : K ---");
arr = new int[] { 4,2,2,6,4 };
count = Problems.SubArraysWithXOR_K(arr, 6);
Console.WriteLine($"Count of Sub Arrays With With XOR : K = {count}");

Console.WriteLine("--- Find Missing And Repeating Numbers ---");
arr = new int[] { 4, 3, 6, 2, 1, 1 };
Console.WriteLine($"Array : {string.Join(',', arr)}");
List<int> missingRepeating = Problems.FindMissingAndRepeatingNumbers(arr);
Console.WriteLine($"Repeating = {missingRepeating[0]}, Missing = {missingRepeating[1]}");

Console.ReadKey();
