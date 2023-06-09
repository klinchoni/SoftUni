using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                         .Split('|')
                                         .Reverse()
                                         .ToList();
            List<int> nums = new List<int>();

            foreach (string str in numbers)
            {
                nums.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                               .Select(int.Parse)
                                                               .ToList());
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
