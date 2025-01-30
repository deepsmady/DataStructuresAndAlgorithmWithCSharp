using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_TUF.BasicMathsConcepts
{
    public class BasicMathsConcepts
    {
        public static void DigitsExtraction(int n)
        {
            while (n > 0)
            {
                var digit = n % 10;
                Console.WriteLine(digit);
                n = n / 10;
            }
        }
        public static int CountDigits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }
            return count;
        }
        public static int CountDigitsWithLog(int n)
        {
            int count = (int)(Math.Log10(n) + 1);
            return count;
        }

        public static int ReverseDigits(int n)
        {
            int reverseNum = 0;
            while (n > 0)
            {
                var lastdigit = n % 10;
                reverseNum = reverseNum * 10 + lastdigit;
                n = n / 10;
            }
            return reverseNum;
        }

        public static bool IsPalindrome(int n)
        {
            int nCopy = n;

            //ReverseDigits Code
            int reverseNum = 0;
            while (n > 0)
            {
                var lastdigit = n % 10;
                reverseNum = reverseNum * 10 + lastdigit;
                n = n / 10;
            }

            return (reverseNum == nCopy);
        }

        public static bool IsArmStrongNumber(int n)
        {
            int nCopy = n;

            //ReverseDigits Code
            int digitsCubeSum = 0;
            while (n > 0)
            {
                var lastdigit = n % 10;
                digitsCubeSum = digitsCubeSum + (int)(Math.Pow(lastdigit, 3));
                n = n / 10;
            }

            return (digitsCubeSum == nCopy);
        }

        public static void PrintDivisors(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void PrintDivisorsOptimized(int n)
        {
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    if (i != n / i)
                    {
                        Console.Write((n / i) + " ");
                    }
                }

            }
        }

        public static bool IsPrime(int n)
        {
            var counter = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    counter++;

                    if (n / i != i)
                    {
                        counter++;
                    }
                }
            }
            return counter == 2;
        }

        /// <summary>
        /// GCD using Brute Force Approach 
        /// Eg: (9 and 12 => 3)
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int GCDorHCF_BF(int n1, int n2)
        {
            var gcd = 1;
            for (int i = Math.Min(n1, n2); i >= 1; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    gcd = i;
                    break;
                }
            }
            return gcd;
        }

        /// <summary>
        /// GCD using Equilateral Algo
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int GCDorHCF_Equilateral(int n1, int n2)
        {
            while (n1 > 0 && n2 > 0)
            {
                if (n1 > n2)
                {
                    n1 = n1 % n2;
                }
                else
                {
                    n2 = n2 % n1;
                }
            }
            int gcd;
            if (n1 == 0)
                gcd = n2;
            else
                gcd = n1;

            return gcd;
        }

    }
}
