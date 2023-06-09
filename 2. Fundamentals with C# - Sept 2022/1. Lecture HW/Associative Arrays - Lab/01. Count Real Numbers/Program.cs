using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double,int>counts=
                new SortedDictionary<double,int>();

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach(var currentNum in numbers)
            {
                if (!counts.ContainsKey(currentNum))
                {
                    counts.Add(currentNum, 0);
                }

                counts[currentNum]+=1;
            }

            foreach(var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
