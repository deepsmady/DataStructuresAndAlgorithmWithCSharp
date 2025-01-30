using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.BasicRecursion
{
    public class BasicRecursion
    {
        private static int _counter = 0;
        public static void Print()
        {
            if (_counter == 3)
            {
                return;
            }
            Console.WriteLine(_counter);
            _counter++;
            Print();
        }

        public static void Print_N_Times(int i, int n)
        {
            if (i > n)
            {
                return;
            }
            Console.WriteLine("Deeps");
            Print_N_Times(i + 1, n);
        }

        public static void Print_1ToN(int i, int n)
        {
            if (i > n)
            {
                return;
            }
            Console.WriteLine(i + " ");
            Print_1ToN(i + 1, n);
        }

        public static void Print_1ToN_Backtracking(int i, int n)
        {
            if (i < 1)
            {
                return;
            }
            Print_1ToN_Backtracking(i - 1, n);
            Console.WriteLine(i + " ");
        }

        public static void Print_NTo1(int i, int n)
        {
            if (i < 1)
            {
                return;
            }
            Console.WriteLine(i);
            Print_NTo1(i - 1, n);
        }

        public static void Print_NTo1_Backtracking(int i, int n)
        {
            if (i > n)
            {
                return;
            }
            Print_NTo1_Backtracking(i + 1, n);
            Console.WriteLine(i);
        }

        public static void SumOfN_Parameterized(int i, int sum)
        {
            if (i < 1)
            {
                Console.WriteLine("Sum : " + sum);
                return ;
            }
            SumOfN_Parameterized(i - 1, sum + i);
        }

        public static int SumOfN_Functional(int i)
        {
            if(i == 0) return 0;
            return i + SumOfN_Functional(i - 1);
        }

        public static int Factorial_Functional(int i)
        {
            if (i == 0) return 1;
            return i * Factorial_Functional(i - 1);
        }

        public static void ReverseArray_Recursion(int i, int n, int[] array)
        {
            if(i >= n / 2)
            {
                return;
            }
            var temp = array[i];
            array[i] = array[n-i-1];
            array[n-i- 1] = temp;
                        
            ReverseArray_Recursion(i + 1, n , array);
        }

        public static bool IsStringPalindrome_Recursion(int i, string str)
        {
            if (i >= str.Length / 2) return true;
            if (str[i] != str[str.Length - i - 1]) return false;
            return IsStringPalindrome_Recursion(i + 1, str);
        }

        public static int Fibonacci_Recursion(int n)
        {
            if (n <= 1) return n;
            //f(n) = f(n-1) + f(n-2) => (last + secondlast)
            int last = Fibonacci_Recursion(n - 1);
            int secondlast = Fibonacci_Recursion(n - 2);
            return last + secondlast;
        }

    }
}
