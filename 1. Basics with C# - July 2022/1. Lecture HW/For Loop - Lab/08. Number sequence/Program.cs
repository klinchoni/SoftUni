using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            int numOfRows=int.Parse(Console.ReadLine());

            for(int i = 0; i < numOfRows; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if(currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }

                if(currentNum < minNumber)
                {
                    minNumber = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
