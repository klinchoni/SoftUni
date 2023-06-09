using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurances =
                 new Dictionary<char, int>();

            string text = Console.ReadLine();
            foreach (char ch in text)
            {
                if (ch != ' ')
                {
                    if (!occurances.ContainsKey(ch))
                    {
                        occurances[ch] = 0;
                    }

                    occurances[ch]++;
                }
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
