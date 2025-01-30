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

Console.ReadKey();
