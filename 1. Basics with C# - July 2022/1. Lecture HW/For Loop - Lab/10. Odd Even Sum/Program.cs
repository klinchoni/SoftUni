using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRows=int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= numOfRows; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            if(evenSum == oddSum)
            {
                Console.WriteLine($"Yes\r\nSum = {evenSum}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(evenSum-oddSum)}");
            }
            
        }
    }
}
