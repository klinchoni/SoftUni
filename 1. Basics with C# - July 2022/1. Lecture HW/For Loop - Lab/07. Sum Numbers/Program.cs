using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows=int.Parse(Console.ReadLine());
            int totalSum = 0;
            for(int i = 0;i < numberOfRows; i++)
            {
                int currentNum=int.Parse(Console.ReadLine());
                totalSum += currentNum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
