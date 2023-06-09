using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                names.Add(Console.ReadLine());
            }

            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
