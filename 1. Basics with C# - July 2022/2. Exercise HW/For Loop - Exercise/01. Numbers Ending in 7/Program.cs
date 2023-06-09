using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
