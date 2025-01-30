// See https://aka.ms/new-console-template for more information
using DSA_CSharp.BasicHashing;
using DSA_CSharp.BasicMathsConcepts;
using DSA_CSharp.BasicRecursion;
using DSA_CSharp.CommonPatterns;

Console.WriteLine("Enter the input value : ");
int n = int.Parse(Console.ReadLine());
//Patterns.print14(n);

Console.WriteLine("Digits Extraction");
BasicMathsConcepts.DigitsExtraction(n);

var digitsCount = BasicMathsConcepts.CountDigits(n);
Console.WriteLine($"DigitsCount : {digitsCount}");
digitsCount = BasicMathsConcepts.CountDigitsWithLog(n);
Console.WriteLine($"DigitsCountWithLogFn : {digitsCount}");

var reverseNum = BasicMathsConcepts.ReverseDigits(n);
Console.WriteLine($"ReverseNumber : {reverseNum}");

Console.WriteLine($"Is the Number Palindrome? : {BasicMathsConcepts.IsPalindrome(n)}");
Console.WriteLine($"Is the Number Armstrong? : {BasicMathsConcepts.IsArmStrongNumber(n)}");

var numToFindDivisors = 32;
Console.WriteLine($"Print Divisors of {numToFindDivisors}");
BasicMathsConcepts.PrintDivisors(numToFindDivisors);

Console.WriteLine();
Console.WriteLine($"Print Divisors of {numToFindDivisors} optimized");
BasicMathsConcepts.PrintDivisorsOptimized(numToFindDivisors);

Console.WriteLine();
var num = 7;
Console.WriteLine($"Is the Number {num} PrimeNumber? : {BasicMathsConcepts.IsPrime(num)}");

Console.WriteLine();
int n1 = 9, n2 = 12;
Console.WriteLine($"HCF/GCD of {n1} & {n2} :  {BasicMathsConcepts.GCDorHCF_BF(n1, n2)}");

Console.WriteLine();
n1 = 52; n2 = 10;
Console.WriteLine($"HCF/GCD of {n1} & {n2} :  {BasicMathsConcepts.GCDorHCF_Equilateral(n1, n2)}");

Console.WriteLine();
Console.WriteLine($"Basic Recursion Demo");
BasicRecursion.Print();

Console.WriteLine();
n = 4;
Console.WriteLine($"Print Name '{n}' Times using Recursion");
BasicRecursion.Print_N_Times(1,n);

Console.WriteLine($"Print from 1 to {n} using Recursion");
BasicRecursion.Print_1ToN(1, n);
Console.WriteLine($"Print from 1 to {n} using Recursion Backtracking");
BasicRecursion.Print_1ToN_Backtracking(n, n);

Console.WriteLine($"Print from {n} to 1 using Recursion");
BasicRecursion.Print_NTo1(n,n);
Console.WriteLine($"Print from {n} to 1 using Recursion Backtracking");
BasicRecursion.Print_NTo1_Backtracking(1, n);

Console.WriteLine($"Sum of N numbers Parameterized");
BasicRecursion.SumOfN_Parameterized(n, 0);
 
Console.WriteLine($"Sum of N numbers Functional : {BasicRecursion.SumOfN_Functional(n)}");
Console.WriteLine($"Factorial of {n} Functional : {BasicRecursion.Factorial_Functional(n)}");

Console.WriteLine($"Reverse array using Recursion");
var array = new[] { 2, 9, 4, 5, 7 };
Console.WriteLine($"Array : {string.Join(',',array)}");
BasicRecursion.ReverseArray_Recursion(0, array.Length, array);
Console.WriteLine($"Reversed Array : {string.Join(',', array)}");

var str = "MADAM";
Console.WriteLine($"Is String {str} Palindrome? : {BasicRecursion.IsStringPalindrome_Recursion(0,str)}");

n = 6;
Console.WriteLine($"Fibonacci of {n} using Recursion : {BasicRecursion.Fibonacci_Recursion(n)}");

Console.WriteLine($"Hash Table / Dictionary Demo:");
BasicHashing.HashingDemo();

Console.ReadKey();

