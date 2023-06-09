using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }

        public static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool isOdd = false;

                foreach (char symbol in i.ToString())
                {
                    int digit = symbol - '0';
                    sum += digit;
                    if (digit % 2 != 0)
                    {
                        isOdd = true;
                    }
                }

                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
