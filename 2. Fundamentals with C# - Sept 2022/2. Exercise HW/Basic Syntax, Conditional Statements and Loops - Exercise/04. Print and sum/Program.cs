﻿using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum=int.Parse(Console.ReadLine());
            int endNum=int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i=startNum; i<=endNum; i++)
            {
                sum +=i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
