using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddle(input);
        }

        public static void PrintMiddle(string input)
        {
            if (input.Length == 1 || input.Length == 2)
            {
                Console.WriteLine(input);
                return;
            }

            int mid = input.Length / 2;
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[mid]);
            }
            else
            {
                Console.WriteLine($"{input[mid - 1]}{input[mid]}");
            }
        }
    }
}
