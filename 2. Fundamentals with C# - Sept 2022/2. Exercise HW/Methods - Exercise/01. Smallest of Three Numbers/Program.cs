using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintSmallestNumber(a, b, c);
        }

        public static void PrintSmallestNumber(int a, int b, int c)
        {
            int smallestNumber = 0;

            if (a <= b && a <= c)
            {
                smallestNumber = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNumber = b;
            }
            else
            {
                smallestNumber = c;
            }

            Console.WriteLine(smallestNumber);
        }
    }
}

