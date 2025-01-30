using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_TUF.CommonPatterns
{
    public class Patterns
    {
        public static void print7(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void print8(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * n - (2 * i + 1); j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void print9(int n)
        {
            for (int i = 0; i < 2 * n - 1; i++)
            {
                int stars;
                if (i < n)
                {
                    stars = i + 1;
                }
                else
                {
                    stars = 2 * n - (i + 1);
                }
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void print10(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int start;
                if (i % 2 == 0)
                {
                    start = 1;
                }
                else
                {
                    start = 0;
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }

                Console.WriteLine();
            }
        }

        public static void print11(int n)
        {
            int space = 2 * n - 2;
            for (int i = 0; i < n; i++)
            {
                //Number
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }
                //Space
                for (int j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                //Number
                for (int j = i + 1; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
                space = space - 2;
            }
        }

        public static void print12(int n)
        {
            int numberToPrint = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(numberToPrint + " ");
                    numberToPrint++;
                }
                Console.WriteLine();
            }
        }

        public static void print13(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (char j = 'A'; j <= 'A' + i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }


        public static void print14(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (char j = 'A'; j <= (n - i - 1 + 'A'); j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }
        }

    }
}
